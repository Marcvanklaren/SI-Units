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
using static SI_Units.UnitSystem.Entities.D8Units;

namespace SI_Units.UnitSystem.Relations
{
    class D8Relations
    {
        decimal v;
        int e;
        
        //Inductance, MagneticFlux, Potential
        #region I=M/P
        public Inductance Inductance(MagneticFlux M, Potential P)
        {
            Division(M.val, M.exponent, P.val, P.exponent, out v, out e);
            return new Inductance(v, e);
        }
        public Potential Potential(MagneticFlux M, Inductance I)
        {
            Division(M.val, M.exponent, I.val, I.exponent, out v, out e);
            return new Potential(v, e);
        }
        public MagneticFlux MagneticFlux(Inductance I, Potential P)
        {
            Multiplication(I.val, I.exponent, P.val, P.exponent, out v, out e);
            return new MagneticFlux(v, e);
        }
        public MagneticFlux MagneticFlux(Potential P, Inductance I)
        {
            Multiplication(I.val, I.exponent, P.val, P.exponent, out v, out e);
            return new MagneticFlux(v, e);
        }
        #endregion

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
