using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Physics.Mathematics.Constants.MathematicalConstants;
using static Physics.Mathematics.Functions.Entities;
using static Physics.Mathematics.BaseUnits;

using static Physics.UnitSystem.SIUnits.Entities.D0Units;

namespace Physics.UnitSystem.SIUnits.Relations
{
    public class D0Relations
    {
        decimal v;
        int e;

        //SolidAngle, Angle
        #region S=A*A
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
        #endregion
    }
}
