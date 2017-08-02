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
using static SI_Units.UnitSystem.Entities.D5Units;

namespace SI_Units.UnitSystem.Relations
{
    class Relations5
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
    }
}
