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
using static SI_Units.UnitSystem.Entities.D9Units;

namespace SI_Units.UnitSystem.Relations
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
