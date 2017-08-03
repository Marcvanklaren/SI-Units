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

        //MagneticFlux, Potential, Time
        #region M=P*T
        public Potential Potential(MagneticFlux M, Time T)
        {
            Division(M.val, M.exponent, T.val, T.exponent, out v, out e);
            return new Potential(v, e);
        }
        public Time Time(MagneticFlux M, Potential P)
        {
            Division(M.val, M.exponent, P.val, P.exponent, out v, out e);
            return new Time(v, e);
        }
        public MagneticFlux MagneticFlux(Potential P, Time T)
        {
            Multiplication(P.val, P.exponent, T.val, T.exponent, out v, out e);
            return new MagneticFlux(v, e);
        }
        #endregion
    }
}
