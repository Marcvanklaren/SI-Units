using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Physics.Mathematics.Functions.Entities;

namespace Physics.Mathematics.Constants
{
    public class MathematicalConstants
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

        public static Constant PI = new Constant((decimal)3.1415926535897932384, 0);
        public static Constant Avogadro = new Constant((decimal)6.023, 23);
    }
}

