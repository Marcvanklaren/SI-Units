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

namespace Physics.UnitSystem.SIUnits.Relations
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
    }
}
