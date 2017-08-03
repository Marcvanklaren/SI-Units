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
using static SI_Units.UnitSystem.Entities.D7Units;

namespace SI_Units.Classes.UnitSystem.Relations
{
    class D7Relations
    {
        decimal v;
        int e;

        //Potential, Power, ElectricCurrent
        #region EP=P/EC
        public Potential Potential(Power P, ElectricCurrent C)
        {
            Division(P.val, P.exponent, C.val, C.exponent, out v, out e);
            return new Potential(v, e);
        }
        public ElectricCurrent ElectricCurrent(Power P, Potential EP)
        {
            Division(P.val, P.exponent, EP.val, EP.exponent, out v, out e);
            return new ElectricCurrent(v, e);
        }
        public Power Power(ElectricCurrent C, Potential P)
        {
            Multiplication(c.val, C.exponent, P.val, P.exponent, out v, out e);
            return new Power(v, e);
        }
        public Power Power(Potential P, ElectricCurrent C)
        {
            Multiplication(c.val, C.exponent, P.val, P.exponent, out v, out e);
            return new Power(v, e);
        }
        #endregion
    }
}
