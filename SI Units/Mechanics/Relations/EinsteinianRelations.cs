using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Physics.Mathematics.Constants.MathematicalConstants;
using static Physics.Mathematics.Constants.PhysicalConstants;
using static Physics.Mathematics.Functions.Entities;
using static Physics.Mathematics.BaseUnits;

using static Physics.UnitSystem.SIUnits.Entities.D0Units;
using static Physics.UnitSystem.SIUnits.Entities.D1Units;
using static Physics.UnitSystem.SIUnits.Entities.D2Units;
using static Physics.UnitSystem.SIUnits.Entities.D3Units;
using static Physics.UnitSystem.SIUnits.Entities.D4Units;
using static Physics.UnitSystem.SIUnits.Entities.D5Units;
using static Physics.UnitSystem.SIUnits.Entities.D6Units;
using static Physics.UnitSystem.SIUnits.Entities.D7Units;
using static Physics.UnitSystem.SIUnits.Entities.D8Units;
using static Physics.UnitSystem.SIUnits.Entities.D9Units;
using static Physics.Mechanics.Entities.Newtonian;

namespace Physics.Mechanics.Relations
{
    class EinsteinianRelations
    {
        decimal v;
        int e;
        
        //Energy, Mass
        #region E=M*c^2
        public Energy Energy(Mass M)
        {
            Multiplication(c.val, c.exponent, c.val, c.exponent, out v, out e);
            Multiplication(M.val, M.exponent, v, e, out v, out e);
            return new Energy(v, e);
        }
        public Mass Mass(Energy E)
        {
            Multiplication(c.val, c.exponent, c.val, c.exponent, out v, out e);
            Division(E.val, E.exponent, v, e, out v, out e);
            return new Mass(v, e);
        }
        #endregion
    }
}
