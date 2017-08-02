using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mathematics;
using static Mathematics.BaseUnits;
using static Mathematics.Functions.Entities;
using static Mathematics.Constants;
using static Mathematics.Constants.Quantifier;

namespace SI_Units.UnitSystem.Entities
{
    public class D6Units
    {
        //Power
        //D6;  M^1 * D^2 * T^-3
        //Base Unit: Watt
        public struct Power
        {
            public decimal val;
            public int exponent;

            public Power(decimal Val, Quantifier Q, PowerUnit U)
            {
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public Power(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Power d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator Power(decimal d)
            {
                return new Power(d, Base, PowerUnit.Watt);
            }

            //explicit operators
            public static Power operator +(Power A, Power B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new Power(Val, Exponent);
            }
            public static Power operator -(Power A, Power B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new Power(Val, Exponent);
            }

            public static Power SetExponent(Power M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new Power(v, e);
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
