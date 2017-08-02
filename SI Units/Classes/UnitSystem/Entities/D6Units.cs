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
        //Pressure
        //D1;   M^-2 * D^2 * T^-2
        //Base Unit: Pascal
        public struct Pressure
        {
            public decimal val;
            public int exponent;

            public Pressure(decimal Val, Quantifier Q, PressureUnit U)
            {
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public Pressure(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Pressure d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator Pressure(decimal d)
            {
                return new Pressure(d, Base, PressureUnit.Pascal);
            }

            //explicit operators
            public static Pressure operator +(Pressure A, Pressure B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new Pressure(Val, Exponent);
            }
            public static Pressure operator -(Pressure A, Pressure B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new Pressure(Val, Exponent);
            }

            public static Pressure SetExponent(Pressure M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new Pressure(v, e);
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
