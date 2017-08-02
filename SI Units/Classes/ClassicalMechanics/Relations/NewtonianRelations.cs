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
        decimal v1;
        int e1;
        decimal v2;
        int e2;

        //Momentum, Mass, Distance
        #region Mo = M*D
        public Momentum Momentum(Mass M, Distance D)
        {
            Multiplication(M.val, M.exponent - 3, D.val, D.exponent, out v1, out e1);
            return new Momentum(v1, e1);
        }
        public Momentum Momentum(Distance D, Mass M)
        {
            Multiplication(M.val, M.exponent - 3, D.val, D.exponent, out v1, out e1);
            return new Momentum(v1, e1);
        }
        public Mass Mass(Momentum M, Distance D)
        {
            Division(M.val, M.exponent, D.val, D.exponent, out v1, out e1);
            return new Mass(v1, e1 + 3);
        }
        public Distance Distance(Momentum Mo, Mass M)
        {
            Division(Mo.val, Mo.exponent, M.val, M.exponent - 3, out v1, out e1);
            return new Distance(v1, e1);
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
            Multiplication(F.val, F.exponent, T.val, T.exponent, out v1, out e1);
            return new Impulse(v1, e1);
        }
        public Impulse Impulse(Time T, Force F)
        {
            Multiplication(F.val, F.exponent, T.val, T.exponent, out v1, out e1);
            return new Impulse(v1, e1);
        }
        public Force Force(Impulse M, Time T)
        {
            Division(M.val, M.exponent, T.val, T.exponent, out v1, out e1);
            return new Force(v1, e1);
        }
        public Time Time(Momentum M, Force F)
        {
            Division(M.val, M.exponent, F.val, F.exponent, out v1, out e1);
            return new Time(v1, e1);
        }
        #endregion

        //Gravity, Mass, Distance
        #region F=G*M*M*D^-2
        public Force Gravity(Mass M1, Mass M2, Distance R)
        {
            Multiplication(M1.val, M1.exponent, M2.val, M2.exponent, out v1, out e1);
            Power2(R.val, R.exponent, out v2, out e2);
            Division(v1, e1, v2, e2, out v1, out e1);
            Multiplication(v1, e1, G.val, G.exponent, out v1, out e1);
            return new Force(v1, e1);
        }
        public Distance Distance(Mass M1, Mass M2, Force Gravity)
        {
            Multiplication(M1.val, M1.exponent, M2.val, M2.exponent, out v1, out e1);
            Multiplication(G.val, G.exponent, v1, e1, out v1, out e1);
            Division(v1, e1, Gravity.val, Gravity.exponent, out v1, out e1);
            SquareRoot(v1, e1, out v1, out e1);
            return new Distance(v1, e1);
        }
        public Mass Mass(Force F, Distance D, Mass M)
        {
            Power2(D.val, D.exponent, out v1, out e1);
            Multiplication(v1, e1, F.val, F.exponent, out v1, out e1);
            Multiplication(M.val, M.exponent, G.val, G.exponent, out v2, out e2);
            Division(v1, e1, v2, e2, out v1, out e1);
            return new Mass(v1, e1);
        }
        public Mass Mass(Distance D, Force F, Mass M)
        {
            Power2(D.val, D.exponent, out v1, out e1);
            Multiplication(v1, e1, F.val, F.exponent, out v1, out e1);
            Multiplication(M.val, M.exponent, G.val, G.exponent, out v2, out e2);
            Division(v1, e1, v2, e2, out v1, out e1);
            return new Mass(v1, e1);
        }
        #endregion
    }
}
