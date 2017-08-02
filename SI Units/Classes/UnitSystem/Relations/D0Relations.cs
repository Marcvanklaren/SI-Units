using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Mathematics.Constants;
using static Mathematics.Functions.Entities;
using static Mathematics.BaseUnits;

using static SI_Units.UnitSystem.Entities.D0Units;

namespace SI_Units.UnitSystem.Relations
{
    public class Relations0
    {
        decimal v;
        int e;
        //SolidAngle, Angle
        public SolidAngle SolidAngle(Angle A, Angle B)
        {
            Multiplication(A.val, A.exponent, B.val, B.exponent, out v, out e);
            return new SolidAngle(v, e);
        }
        public Angle Angle(SolidAngle A, Angle B)
        {
            Division(A.val, A.exponent, B.val, B.exponent, out v, out e);
            return new Angle(v, e);
        }
    }
}
