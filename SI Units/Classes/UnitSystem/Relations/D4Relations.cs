using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Mathematics.Constants;
using static Mathematics.Functions.Entities;
using static Mathematics.BaseUnits;

using static SI_Units.UnitSystem.Entities.D1Units;
using static SI_Units.UnitSystem.Entities.D2Units;
using static SI_Units.UnitSystem.Entities.D3Units;
using static SI_Units.UnitSystem.Entities.D4Units;

namespace SI_Units.UnitSystem.Relations
{
    class Relations4
    {
        decimal v;
        int e;

        //Density, Mass, Volume
        #region D=M/V
        public Mass Mass(Density D, Volume V)
        {
            Multiplication(D.val, D.exponent, V.val, V.exponent + 4, out v, out e);
            return new Mass(v, e);
        }
        public Mass Mass(Volume V, Density D)
        {
            Multiplication(D.val, D.exponent, V.val, V.exponent + 4, out v, out e);
            return new Mass(v, e);
        }
        public Density Density(Mass M, Volume V)
        {
            Division(M.val, M.exponent, V.val, V.exponent + 4, out v, out e);
            return new Density(v, e);
        }
        public Volume Volume(Mass M, Density D)
        {
            Division(M.val, M.exponent, D.val, D.exponent, out v, out e);
            return new Volume(v, e - 4);
        }
        #endregion

        //Force, Mass, Acceleration
        #region F=M*A
        public Force Force(Mass M, LinearAcceleration A)
        {
            Multiplication(M.val, M.exponent - 3, A.val, A.exponent, out v, out e);
            return new Force(v, e);
        }
        public Force Force(LinearAcceleration A, Mass M)
        {
            Multiplication(M.val, M.exponent - 3, A.val, A.exponent, out v, out e);
            return new Force(v, e);
        }
        public LinearAcceleration Acceleration(Force F, Mass M)
        {
            Division(F.val, F.exponent, M.val, M.exponent, out v, out e);
            return new LinearAcceleration(v, e);
        }
        public Mass Mass(Force F, LinearAcceleration A)
        {
            Division(F.val, F.exponent, A.val, A.exponent, out v, out e);
            return new Mass(v, e + 3);
        }

        //lower-D compositions
        public Force Force(Mass M, LinearVelocity V, Time T)
        {
            Division(V.val, V.exponent, T.val, T.exponent, out v, out e);
            Multiplication(M.val, M.exponent - 3, v, e, out v, out e);
            return new Force(v, e);
        }
        public Force Force(Mass M, Distance D, Time T1, Time T2)
        {
            Multiplication(T1.val, T1.exponent, T2.val, T2.exponent, out v, out e);
            Division(D.val, D.exponent, v, e, out v, out e);
            Multiplication(M.val, M.exponent - 3, v, e, out v, out e);
            return new Force(v, e);
        }
        public Force Force(LinearVelocity V, Time T, Mass M)
        {
            Division(V.val, V.exponent, T.val, T.exponent, out v, out e);
            Multiplication(M.val, M.exponent - 3, v, e, out v, out e);
            return new Force(v, e);
        }
        public Force Force(Distance D, Time T1, Time T2, Mass M)
        {
            Multiplication(T1.val, T1.exponent, T2.val, T2.exponent, out v, out e);
            Division(D.val, D.exponent, v, e, out v, out e);
            Multiplication(M.val, M.exponent - 3, v, e, out v, out e);
            return new Force(v, e);
        }
        #endregion
    }
}
