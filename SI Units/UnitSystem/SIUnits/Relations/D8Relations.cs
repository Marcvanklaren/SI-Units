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
using static Physics.UnitSystem.SIUnits.Entities.D6Units;
using static Physics.UnitSystem.SIUnits.Entities.D7Units;
using static Physics.UnitSystem.SIUnits.Entities.D8Units;

namespace Physics.UnitSystem.SIUnits.Relations
{
    class D8Relations
    {
        decimal v;
        int e;
        
        //Resistance, Potential, ElectricCurrent
        #region R=P/A
        public Resistance Resistance(Potential P, ElectricCurrent A)
        {
            Division(P.val, P.exponent, A.val, A.exponent, out v, out e);
            return new Resistance(v, e);
        }
        public ElectricCurrent ElectricCurrent(Potential P, Resistance R)
        {
            Division(P.val, P.exponent, R.val, R.exponent, out v, out e);
            return new ElectricCurrent(v, e);
        }
        public Potential Potential(ElectricCurrent A, Resistance R)
        {
            Multiplication(A.val, A.exponent, R.val, R.exponent, out v, out e);
            return new Potential(v, e);
        }
        public Potential Potential(Resistance R, ElectricCurrent A)
        {
            Multiplication(A.val, A.exponent, R.val, R.exponent, out v, out e);
            return new Potential(v, e);
        }
        #endregion

        //Resistance, Conductance
        #region R=1/C
        public Resistance Resistance(Conductance C)
        {
            Division(1, 0, c.val, C.exponent, out v, out e);
            return new Resistance(v, e);
        }
        public Conductance Conductance(Resistance R)
        {
            Division(1, 0, R.val, R.exponent, out v, out e);
            return new Conductance(v, e);
        }
        #endregion
    }
}
