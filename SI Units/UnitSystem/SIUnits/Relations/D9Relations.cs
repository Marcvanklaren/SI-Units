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
using static Physics.UnitSystem.SIUnits.Entities.D9Units;

namespace Physics.UnitSystem.SIUnits.Relations
{
    class D9Relations
    {
        decimal v;
        int e;

        //Capacitance, ElectricCharge, Potential
        #region C=A/P
        public Capacitance Capacitance(ElectricCharge A, Potential P)
        {
            Division(A.val, A.exponent, P.val, P.exponent, out v, out e);
            return new Capacitance(v, e);
        }
        public Potential Potential(ElectricCharge A, Capacitance C)
        {
            Division(A.val, A.exponent, C.val, C.exponent, out v, out e);
            return new Potential(v, e);
        }
        public ElectricCharge ElectricCharge(Potential P, Capacitance C)
        {
            Multiplication(P.val, P.exponent, C.val, C.exponent, out v, out e);
            return new ElectricCharge(v, e);
        }
        public ElectricCharge ElectricCharge(Capacitance C, Potential P)
        {
            Multiplication(P.val, P.exponent, C.val, C.exponent, out v, out e);
            return new ElectricCharge(v, e);
        }
        #endregion
    }
}
