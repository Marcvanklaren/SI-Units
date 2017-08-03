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

namespace SI_Units.UnitSystem.Relations
{
    public class D2Relations
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

        //AngularVelocity, Angle, Time
        #region AV=A/T
        public AngularVelocity AngularVelocity(Angle A, Time T)
        {
            Division(A.val, A.exponent, T.val, T.exponent, out v, out e);
            return new AngularVelocity(v, e);
        }
        public Time Time(Angle A, AngularVelocity AV)
        {
            Division(A.val, A.exponent, AV.val, AV.exponent, out v, out e);
            return new Time(v, e);
        }
        public Angle Angle(AngularVelocity A, Time T)
        {
            Multiplication(A.val, A.exponent, T.val, T.exponent, out v, out e);
            return new Angle(v, e);
        }
        public Angle Angle(Time T, AngularVelocity A)
        {
            Multiplication(A.val, A.exponent, T.val, T.exponent, out v, out e);
            return new Angle(v, e);
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

        //SolidAngle, Area, distance
        #region A=

        #endregion

        //AngularAcceleration, AngularVelocity, Time
        #region A=V/T
        public AngularAcceleration AngularAcceleration(AngularVelocity V, Time T)
        {
            Division(V.val, V.exponent, T.val, T.exponent, out v, out e);
            return new AngularAcceleration(v, e);
        }
        public Time Time(AngularVelocity V, AngularAcceleration A)
        {
            Division(V.val, V.exponent, A.val, A.exponent, out v, out e);
            return new Time(v, e);
        }
        public AngularVelocity AngularVelocity(AngularAcceleration A, Time T)
        {
            Multiplication(A.val, A.exponent, T.val, T.exponent, out v, out e);
            return new AngularVelocity(v, e);
        }
        public AngularVelocity AngularVelocity(Time T, AngularAcceleration A)
        {
            Multiplication(A.val, A.exponent, T.val, T.exponent, out v, out e);
            return new AngularVelocity(v, e);
        }

        public AngularAcceleration AngularAcceleration(Angle A, Time T1, Time T2)
        {
            Multiplication(T1.val, T1.exponent, T2.val, T2.exponent, out v, out e);
            Division(A.val, A.exponent, v, e, out v, out e);
            return new AngularAcceleration(v, e);
        }
        #endregion
    }
}
