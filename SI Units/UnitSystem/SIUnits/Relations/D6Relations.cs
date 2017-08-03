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

namespace Physics.UnitSystem.SIUnits.Relations
{
    class D6Relations
    {
        decimal v;
        int e;

        //Power, Energy, Time
        #region P=E/T
        public Power Power(Energy E, Time T)
        {
            Division(E.val, E.exponent, T.val, T.exponent, out v, out e);
            return new Power(v, e);
        }
        public Time Time(Energy E, Power P)
        {
            Division(E.val, E.exponent, P.val, P.exponent, out v, out e);
            return new Time(v, e);
        }
        public Energy Energy(Power P, Time T)
        {
            Multiplication(P.val, P.exponent, T.val, T.exponent, out v, out e);
            return new Energy(v, e);
        }
        public Energy Energy(Time T, Power P)
        {
            Multiplication(P.val, P.exponent, T.val, T.exponent, out v, out e);
            return new Energy(v, e);
        }
        #endregion

        //MagneticFluxDensity, MagneticFlux, Area
        #region D=M/A
        public MagneticFluxDensity MagneticFluxDensity(MagneticFlux M, Area A)
        {
            Division(M.val, M.exponent, A.val, A.exponent, out v, out e);
            return new MagneticFluxDensity(v, e);
        }
        public Area Area(MagneticFlux M, MagneticFluxDensity D)
        {
            Division(M.val, M.exponent, D.val, D.exponent, out v, out e);
            return new Area(v, e);
        }
        public MagneticFlux MagneticFlux(MagneticFluxDensity D, Area A)
        {
            Multiplication(D.val, D.exponent, A.val, A.exponent, out v, out e);
            return new MagneticFlux(v, e);
        }
        public MagneticFlux MagneticFlux(Area A, MagneticFluxDensity D)
        {
            Multiplication(D.val, D.exponent, A.val, A.exponent, out v, out e);
            return new MagneticFlux(v, e);
        }
        #endregion
    }
}
