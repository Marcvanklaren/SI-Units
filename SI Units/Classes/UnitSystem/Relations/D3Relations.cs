using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Mathematics.Functions.Entities;

using static SI_Units.UnitSystem.Entities.D1Units;
using static SI_Units.UnitSystem.Entities.D2Units;
using static SI_Units.UnitSystem.Entities.D3Units;

namespace SI_Units.UnitSystem.Relations
{
    public class Relations3
    {
        decimal v;
        int e;
        //Volume, Area, Distance
        #region V=A*D
        public Volume Volume(Area A, Distance D)
        {
            Multiplication(A.val, A.exponent, D.val, D.exponent, out v, out e);
            return new Volume(v, e);
        }
        public Volume Volume(Distance D, Area A)
        {
            Multiplication(A.val, A.exponent, D.val, D.exponent, out v, out e);
            return new Volume(v, e);
        }
        public Distance Distance(Volume V, Area A)
        {
            Division(V.val, V.exponent, A.val, A.exponent, out v, out e);
            return new Distance(v, e);
        }

        //lower-D compositions
        public Volume Volume(Distance A, Distance B, Distance C)
        {
            Multiplication(A.val, A.exponent, B.val, B.exponent, out v, out e);
            Multiplication(v, e, C.val, C.exponent, out v, out e);
            return new Volume(v, e);
        }
        #endregion

        //Acceleration, Velocity, Time
        #region A=V/T
        public LinearVelocity Velocity(LinearAcceleration A, Time T)
        {
            Multiplication(A.val, A.exponent, T.val, T.exponent, out v, out e);
            return new LinearVelocity(v, e);
        }
        public LinearVelocity Velocity(Time T, LinearAcceleration A)
        {
            Multiplication(A.val, A.exponent, T.val, T.exponent, out v, out e);
            return new LinearVelocity(v, e);
        }
        public Time Time(LinearVelocity V, LinearAcceleration A)
        {
            Division(V.val, V.exponent, A.val, A.exponent, out v, out e);
            return new Time(v, e);
        }
        public LinearAcceleration Acceleration(LinearVelocity V, Time T)
        {
            Division(V.val, V.exponent, T.val, T.exponent, out v, out e);
            return new LinearAcceleration(v, e);
        }
        public LinearAcceleration Acceleration(Distance D, Time A, Time B)
        {
            Multiplication(A.val, A.exponent, B.val, B.exponent, out v, out e);
            Division(D.val, D.exponent, v, e, out v, out e);
            return new LinearAcceleration(v, e);
        }
        #endregion

        //Illuminance, LuminousFlux, Area
        #region I=L/A
        public Illuminance Illuminance(LuminousFlux L, Area A)
        {
            Division(L.val, L.exponent, A.val, A.exponent, out v, out e);
            return new Illuminance(v, e);
        }
        public Area Area(LuminousFlux L, Illuminance I)
        {
            Division(L.val, L.exponent, I.val, I.exponent, out v, out e);
            return new Area(v, e);
        }
        public LuminousFlux LuminousFlux(Illuminance I, Area A)
        {
            Multiplication(I.val, I.exponent, A.val, A.exponent, out v, out e);
            return new LuminousFlux(v, e);
        }
        public LuminousFlux LuminousFlux(Area A, Illuminance I)
        {
            Multiplication(I.val, I.exponent, A.val, A.exponent, out v, out e);
            return new LuminousFlux(v, e);
        }
        #endregion
    }
}
