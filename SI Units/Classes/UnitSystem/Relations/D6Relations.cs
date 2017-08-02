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

namespace SI_Units.Classes.UnitSystem.Relations
{
    class D6Relations
    {
        decimal v;
        int e;
        
        //Pressure, Force, Area
        #region P = F/A
        public Pressure Pressure(Force F, Area A)
        {
            Division(F.val, F.exponent, A.val, A.exponent, out v, out e);
            return new Pressure(v, e);
        }

        public Force Force(Pressure P, Area A)
        {
            Multiplication(P.val, P.exponent, A.val, A.exponent, out v, out e);
            return new Force(v, e);
        }
        public Force Force(Area A, Pressure P)
        {
            Multiplication(P.val, P.exponent, A.val, A.exponent, out v, out e);
            return new Force(v, e);
        }
        #endregion
    }
}
