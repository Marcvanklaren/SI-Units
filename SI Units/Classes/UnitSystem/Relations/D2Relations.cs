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

namespace SI_Units.UnitSystem.Relations
{
    public class Relations2
    {
        decimal v;
        int e;
        //Area, Distance
        #region A=D*D
        public Area Area(Distance A, Distance B)
        {
            Multiplication(A.val, A.exponent, B.val, B.exponent, out v, out e);
            return new Area(v, e);
        }
        public Distance Distance(Area A, Distance B)
        {
            Division(A.val, A.exponent, B.val, B.exponent, out v, out e);
            return new Distance(v, e);
        }
        #endregion

        //Velocity, Distance, Time
        #region V=D/T
        public Distance Distance(LinearVelocity V, Time T)
        {
            Multiplication(V.val, V.exponent, T.val, T.exponent, out v, out e);
            return new Distance(v, e);
        }
        public Distance Distance(Time T, LinearVelocity V)
        {
            Multiplication(T.val, T.exponent, V.val, V.exponent, out v, out e);
            return new Distance(v, e);
        }
        public LinearVelocity LinearVelocity(Distance D, Time T)
        {
            Division(D.val, D.exponent, T.val, T.exponent, out v, out e);
            return new LinearVelocity(v, e);
        }
        public Time Time(Distance D, LinearVelocity V)
        {
            Division(D.val, D.exponent, V.val, V.exponent, out v, out e);
            return new Time();
        }
        #endregion

        //ElectricCharge, ElectricCurrent, Time
        #region C=A*T
        public ElectricCharge ElectricCharge(ElectricCurrent A, Time T)
        {
            Multiplication(A.val, A.exponent, T.val, T.exponent, out v, out e);
            return new ElectricCharge(v, e);
        }
        public ElectricCharge ElectricCharge(Time T, ElectricCurrent A)
        {
            Multiplication(A.val, A.exponent, T.val, T.exponent, out v, out e);
            return new ElectricCharge(v, e);
        }
        public ElectricCurrent ElectricCurrent(ElectricCharge C, Time T)
        {
            Division(C.val, C.exponent, T.val, T.exponent, out v, out e);
            return new ElectricCurrent(v, e);
        }
        public Time Time(ElectricCharge C, ElectricCurrent A)
        {
            Division(C.val, C.exponent, C.val, C.exponent, out v, out e);
            return new Time(v, e);
        }
        #endregion

        //CatalyticActivity, AoSubstance, Time
        #region K=A/T
        public CatalyticActivity CatalyticActivity(AoSubstance A, Time T)
        {
            Division(A.val, A.exponent, T.val, T.exponent, out v, out e);
            return new CatalyticActivity(v, e);
        }
        public Time Time(AoSubstance A, CatalyticActivity K)
        {
            Division(A.val, A.exponent, K.val, K.exponent, out v, out e);
            return new Time(v, e);
        }
        public AoSubstance AoSubstance(CatalyticActivity K, Time T)
        {
            Multiplication(K.val, K.exponent, T.val, T.exponent, out v, out e);
            return new AoSubstance(v, e);
        }
        public AoSubstance AoSubstance(Time T, CatalyticActivity K)
        {
            Multiplication(K.val, K.exponent, T.val, T.exponent, out v, out e);
            return new AoSubstance(v, e);
        }
        #endregion
    }
}
