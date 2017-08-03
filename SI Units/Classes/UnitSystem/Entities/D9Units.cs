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
    class D9Units
    {
        //Capacitance
        //D9;   M^-1 * D^-2 * T^4 * I^2
        //Base Unit: Farad
        public struct Capacitance
        {
            public decimal val;
            public int exponent;

            public Capacitance(decimal Val, Quantifier Q, CapacitanceUnit U)
            {
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public Capacitance(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Capacitance d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator Capacitance(decimal d)
            {
                return new Capacitance(d, Base, CapacitanceUnit.Farad);
            }

            //explicit operators
            public static Capacitance operator +(Capacitance A, Capacitance B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new Capacitance(Val, Exponent);
            }
            public static Capacitance operator -(Capacitance A, Capacitance B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new Capacitance(Val, Exponent);
            }

            public static Capacitance SetExponent(Capacitance M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new Capacitance(v, e);
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
