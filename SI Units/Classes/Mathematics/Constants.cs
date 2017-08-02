using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SI_Units.UnitSystem.Entities;

using static Mathematics.Functions.Entities;

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
        public static Constant PI = new Constant((decimal)3.14159265358979323846264338327950288419716939937510582097494459230781640628620899, 0);


        //Physical constants
        public static Constant c = new Constant((decimal)299792458, 0);

        public static Constant G = new Constant((decimal)6.674, -11);


        public struct Constant
        {
            public decimal val;
            public int exponent;

            public Constant(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Constant d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator Constant(decimal d)
            {
                return new Constant(d, 0);
            }

            //explicit operators
            public static Constant operator +(Constant A, Constant B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new Constant(Val, Exponent);
            }
            public static Constant operator -(Constant A, Constant B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new Constant(Val, Exponent);
            }

            public static Constant SetExponent(Constant M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new Constant(v, e);
            }

            public override string ToString()
            {
                string s = Entity2String(this.val, this.exponent);

                return s;
            }

            public void Print()
            {
                string s = ToString();
                Console.WriteLine(s);
            }
        }
    }
}

