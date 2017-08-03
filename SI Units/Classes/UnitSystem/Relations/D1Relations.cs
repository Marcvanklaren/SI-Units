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

namespace SI_Units.UnitSystem.Relations
{
    public class D1Relations
    {
        decimal v;
        int e;
        //Frequency, Time
        #region F=1/T
            public Frequency Frequency(Time T)
            {
                v = 1 / T.val;
                e = -T.exponent;
                SetExponent(ref v, ref e);
                return new Frequency(v, e);
            }
            public Time Time(Frequency F)
            {
                v = 1 / F.val;
                e = -F.exponent;
                SetExponent(ref v, ref e);
                return new Time(v, e);
            }
            #endregion

        //Activity, Time
        #region A=1/T
        public Activity Activity(Time T)
        {
            v = 1 / T.val;
            e = -T.exponent;
            SetExponent(ref v, ref e);
            return new Activity(v, e);
        }
        public Time Time(Activity F)
        {
            v = 1 / F.val;
            e = -F.exponent;
            SetExponent(ref v, ref e);
            return new Time(v, e);
        }
        #endregion

        //LuminousFlux, LuminousIntensity, SolidAngle
        #region L=I*A
        public LuminousFlux LuminousFlux(LuminousIntensity I, SolidAngle A)
        {
            Multiplication(I.val, I.exponent, A.val, A.exponent, out v, out e);
            return new LuminousFlux(v, e);
        }
        public LuminousFlux LuminousFlux(SolidAngle A, LuminousIntensity I)
        {
            Multiplication(I.val, I.exponent, A.val, A.exponent, out v, out e);
            return new LuminousFlux(v, e);
        }
        public LuminousIntensity LuminousIntensity(LuminousFlux L, SolidAngle A)
        {
            Division(L.val, L.exponent, A.val, A.exponent, out v, out e);
            return new LuminousIntensity(v, e);
        }
        public SolidAngle SolidAngle(LuminousFlux L, LuminousIntensity I)
        {
            Division(L.val, L.exponent, I.val, I.exponent, out v, out e);
            return new SolidAngle(v, e);
        }
        #endregion

        //Angle, Distance
        #region D=A*R
        public Angle Angle(Distance D, Distance Radius)
        {
            Division(D.val, D.exponent, Radius.val, Radius.exponent, out v, out e);
            return new Angle(v, e);
        }
        public Distance Radius(Distance D, Angle A)
        {
            Division(D.val, D.exponent, A.val, A.exponent, out v, out e);
            return new Distance(v, e);
        }
        public Distance Distance(Distance Radius, Angle A)
        {
            Multiplication(Radius.val, Radius.exponent, A.val, A.exponent, out v, out e);
            return new Distance(v, e);
        }
        public Distance Distance(Angle A, Distance Radius)
        {
            Multiplication(Radius.val, Radius.exponent, A.val, A.exponent, out v, out e);
            return new Distance(v, e);
        }
        #endregion
    }
}
