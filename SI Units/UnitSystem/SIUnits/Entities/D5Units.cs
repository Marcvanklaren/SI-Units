using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Physics.Mathematics;
using static Physics.Mathematics.BaseUnits;
using static Physics.Mathematics.Functions.Entities;
using static Physics.Mathematics.Constants;
using static Physics.Mathematics.Constants.Quantifier;

namespace Physics.UnitSystem.SIUnits.Entities
{
    public class D5Units
    {
        //Energy
        //D5;   M^1 * L^2 * T^-2
        //Base Unit: Joule
        public struct Energy
        {
            public decimal val;
            public int exponent;

            public Energy(decimal Val, Quantifier Q, EnergyUnit U)
            {
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public Energy(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Energy d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator Energy(decimal d)
            {
                return new Energy(d, Base, EnergyUnit.Joule);
            }

            //explicit operators
            public static Energy operator +(Energy A, Energy B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new Energy(Val, Exponent);
            }
            public static Energy operator -(Energy A, Energy B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new Energy(Val, Exponent);
            }

            public static Energy SetExponent(Energy M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new Energy(v, e);
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
