using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Mathematics.Constants;
using static Mathematics.Functions.Entities;
using static Mathematics.BaseUnits;

using static SI_Units.UnitSystem.Entities.D0Units;
using static SI_Units.UnitSystem.Entities.D1Units;
using static SI_Units.UnitSystem.Entities.D2Units;
using static SI_Units.UnitSystem.Entities.D3Units;
using static SI_Units.UnitSystem.Entities.D4Units;
using static SI_Units.UnitSystem.Entities.D5Units;
using static SI_Units.UnitSystem.Entities.D6Units;
using static SI_Units.UnitSystem.Entities.Newtonian;

namespace SI_Units.UnitSystem.Relations
{
    class NewtonianRelations
    {
        decimal v;
        int e;
        decimal v2;
        int e2;

        //Momentum, Mass, Distance
        #region Mo = M*D
        public Momentum Momentum(Mass M, Distance D)
        {
            Multiplication(M.val, M.exponent - 3, D.val, D.exponent, out v, out e);
            return new Momentum(v, e);
        }
        public Momentum Momentum(Distance D, Mass M)
        {
            Multiplication(M.val, M.exponent - 3, D.val, D.exponent, out v, out e);
            return new Momentum(v, e);
        }
        public Mass Mass(Momentum M, Distance D)
        {
            Division(M.val, M.exponent, D.val, D.exponent, out v, out e);
            return new Mass(v, e + 3);
        }
        public Distance Distance(Momentum Mo, Mass M)
        {
            Division(Mo.val, Mo.exponent, M.val, M.exponent - 3, out v, out e);
            return new Distance(v, e);
        }
        #endregion

        //AngularMomentum, AngularVelocity, Mass
        #region AM=A*M
        public AngularMomentum AngularMomentum(AngularVelocity V, Mass M)
        {
            Multiplication(V.val, V.exponent, M.val, M.exponent - 3, out v, out e);
            return new AngularMomentum(v, e);
        }
        public AngularMomentum AngularMomentum(Mass M, AngularVelocity V)
        {
            Multiplication(V.val, V.exponent, M.val, M.exponent - 3, out v, out e);
            return new AngularMomentum(v, e);
        }
        public AngularVelocity AngularVelocity(AngularMomentum A, Mass M)
        {
            Division(A.val, A.exponent, M.val, M.exponent - 3, out v, out e);
            return new AngularVelocity(v, e);
        }
        public Mass Mass(AngularMomentum M, AngularVelocity V)
        {
            Division(M.val, M.exponent, V.val, V.exponent, out v, out e);
            return new Mass(v, e + 3);
        }
        #endregion

        //Momentum, AngularMomentum, Distance
        #region M=AM*D
        public Momentum Momentum(AngularMomentum A, Distance Radius)
        {
            Multiplication(A.val, A.exponent, Radius.val, Radius.exponent, out v, out e);
            return new Momentum(v, e);
        }
        public Momentum Momentum(Distance Radius, AngularMomentum A)
        {
            Multiplication(A.val, A.exponent, Radius.val, Radius.exponent, out v, out e);
            return new Momentum(v, e);
        }
        public Distance Radius(Momentum M, AngularMomentum A)
        {
            Division(M.val, M.exponent, A.val, A.exponent, out v, out e);
            return new Distance(v, e);
        }
        public AngularMomentum AngularMomentum(Momentum M, Distance Radius)
        {
            Division(M.val, M.exponent, Radius.val, Radius.exponent, out v, out e);
            return new AngularMomentum(v, e);
        }
        #endregion

        //Momentum, Impulse
        #region M=I
        public Momentum Momentum(Impulse I)
        {
            return new Momentum(I.val, I.exponent);
        }
        public Impulse Impulse(Momentum M)
        {
            return new Impulse(M.val, M.exponent);
        }
        #endregion

        //Impulse, Force, Time
        #region M=F*T
        public Impulse Impulse(Force F, Time T)
        {
            Multiplication(F.val, F.exponent, T.val, T.exponent, out v, out e);
            return new Impulse(v, e);
        }
        public Impulse Impulse(Time T, Force F)
        {
            Multiplication(F.val, F.exponent, T.val, T.exponent, out v, out e);
            return new Impulse(v, e);
        }
        public Force Force(Impulse M, Time T)
        {
            Division(M.val, M.exponent, T.val, T.exponent, out v, out e);
            return new Force(v, e);
        }
        public Time Time(Momentum M, Force F)
        {
            Division(M.val, M.exponent, F.val, F.exponent, out v, out e);
            return new Time(v, e);
        }
        #endregion

        //Gravity, Mass, Distance
        #region F=G*M*M*D^-2
        public Force Gravity(Mass M1, Mass M2, Distance R)
        {
            Multiplication(M1.val, M1.exponent - 3, M2.val, M2.exponent - 3, out v, out e);
            Power2(R.val, R.exponent, out v2, out e2);
            Division(v, e, v2, e2, out v, out e);
            Multiplication(v, e, G.val, G.exponent, out v, out e);
            return new Force(v, e);
        }
        public Distance Distance(Mass M1, Mass M2, Force Gravity)
        {
            Multiplication(M1.val, M1.exponent - 3, M2.val, M2.exponent - 3, out v, out e);
            Multiplication(G.val, G.exponent, v, e, out v, out e);
            Division(v, e, Gravity.val, Gravity.exponent, out v, out e);
            SquareRoot(v, e, out v, out e);
            return new Distance(v, e);
        }
        public Mass Mass(Force Gravity, Distance D, Mass M)
        {
            Power2(D.val, D.exponent, out v, out e);
            Multiplication(v, e, Gravity.val, Gravity.exponent, out v, out e);
            Multiplication(M.val, M.exponent - 3, G.val, G.exponent, out v2, out e2);
            Division(v, e, v2, e2, out v, out e);
            return new Mass(v, e + 3);
        }
        public Mass Mass(Distance D, Force Gravity, Mass M)
        {
            Power2(D.val, D.exponent, out v, out e);
            Multiplication(v, e, Gravity.val, Gravity.exponent, out v, out e);
            Multiplication(M.val, M.exponent - 3, G.val, G.exponent, out v2, out e2);
            Division(v, e, v2, e2, out v, out e);
            return new Mass(v, e + 3);
        }
        #endregion
    }
}
