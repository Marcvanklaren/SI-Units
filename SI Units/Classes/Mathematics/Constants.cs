using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SI_Units.UnitSystem.Entities;

using static SI_Units.UnitSystem.Entities.D1Units;
using static SI_Units.UnitSystem.Entities.D2Units;
using static SI_Units.UnitSystem.Entities.D3Units;
using static SI_Units.UnitSystem.Entities.D4Units;

namespace Mathematics
{
    public class Constants
    {
        public enum Quantifier
        {
            yotto = -10,
            zepto = -9,
            atto = -8,
            femto = -7,
            pico = -6,
            nano = -5,
            micro = -4,
            milli = -3,
            centi = -2,
            deci = -1,

            Base = 0,

            Deca = 1,
            Hecto = 2,
            Kilo = 3,
            Mega = 4,
            Giga = 5,
            Terra = 6,
            Penta = 7,
            Exa = 8,
            Zeta = 9,
            Yotta = 10
        }

        //Mathematical constants
        public static decimal PI = (decimal)3.14159265358979323846264338327950288419716939937510582097494459230781640628620899;


        //Physical constants
        public static decimal c = 299792458;
    }
}

