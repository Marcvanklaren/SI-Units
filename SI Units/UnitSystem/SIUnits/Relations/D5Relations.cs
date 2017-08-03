using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Physics.Mathematics.Constants;
using static Physics.Mathematics.Functions.Entities;
using static Physics.Mathematics.BaseUnits;

using static Physics.UnitSystem.SIUnits.Entities.D0Units;
using static Physics.UnitSystem.SIUnits.Entities.D1Units;
using static Physics.UnitSystem.SIUnits.Entities.D2Units;
using static Physics.UnitSystem.SIUnits.Entities.D3Units;
using static Physics.UnitSystem.SIUnits.Entities.D4Units;
using static Physics.UnitSystem.SIUnits.Entities.D5Units;

namespace Physics.UnitSystem.SIUnits.Relations
{
    class D5Relations
    {
        decimal v;
        int e;
        //Energy, Force, Distance
        #region E=F*D
        public Energy Energy(Force F, Distance D)
        {
            Multiplication(F.val, F.exponent, D.val, D.exponent, out v, out e);
            return new Energy(v, e);
        }
        public Energy Energy(Distance D, Force F)
        {
            Multiplication(F.val, F.exponent, D.val, D.exponent, out v, out e);
            return new Energy(v, e);
        }
        public Force Force(Energy E, Distance D)
        {
            Division(E.val, E.exponent, D.val, D.exponent, out v, out e);
            return new Force(v, e);
        }
        public Distance Distance(Energy E, Force F)
        {
            Division(E.val, E.exponent, F.val, F.exponent, out v, out e);
            return new Distance(v, e);
        }
        #endregion

        //AbsorbedDose, Energy, Mass
        #region D=E/M
        public AbsorbedDose AbsorbedDose(Energy E, Mass M)
        {
            Division(E.val, E.exponent, M.val, M.exponent - 3, out v, out e);
            return new AbsorbedDose(v, e);
        }
        public Energy Energy(AbsorbedDose D, Mass M)
        {
            Multiplication(D.val, D.exponent, M.val, M.exponent - 3, out v, out e);
            return new Energy(v, e);
        }
        public Energy Energy(Mass M, AbsorbedDose D)
        {
            Multiplication(D.val, D.exponent, M.val, M.exponent - 3, out v, out e);
            return new Energy(v, e);
        }
        public Mass Mass(Energy E, AbsorbedDose D)
        {
            Multiplication(E.val, E.exponent, D.val, D.exponent, out v, out e);
            return new Mass(v, e + 3);
        }
        #endregion
    }
}
