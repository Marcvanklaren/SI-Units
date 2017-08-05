using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Physics.Mathematics;
using static Physics.Mathematics.BaseUnits;
using static Physics.Mathematics.Functions.Entities;
using static Physics.Mathematics.Constants.MathematicalConstants;
using static Physics.Mathematics.Constants.MathematicalConstants.Quantifier;

namespace Physics.UnitSystem.SIUnits.Entities
{
    class D7Units
    {
        public static decimal v;
        public static int e;
        
        //Potential
        //D7;   M^1 * L^2 * T^-3 * I^-1
        //Base Unit: Volt
        public struct Potential
        {
            public decimal val;
            public int exponent;

            public Potential(decimal Val, Quantifier Q, PotentialUnit U)
            {
                switch (U)
                {
                    case PotentialUnit.Volt:
                        v = Val;
                        e = (int)Q;
                        break;
                }
                val = v;
                exponent = e;
            }
            public Potential(decimal Volt, int Exponent)
            {
                val = Volt;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Potential Volt)
            {
                return Volt.val * (10 ^ Volt.exponent);
            }
            public static explicit operator Potential(decimal Volt)
            {
                return new Potential(Volt, Base, PotentialUnit.Volt);
            }

            //explicit operators
            public static Potential operator +(Potential A, Potential B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new Potential(Val, Exponent);
            }
            public static Potential operator -(Potential A, Potential B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new Potential(Val, Exponent);
            }

            public static Potential SetExponent(Potential M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new Potential(v, e);
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

        //Inductance
        //D7;   M^1 * D^2 * T^-2 * I^-2
        //Base Unit: Henry
        public struct Inductance
        {
            public decimal val;
            public int exponent;

            public Inductance(decimal Val, Quantifier Q, InductanceUnit U)
            {
                switch (U)
                {
                    case InductanceUnit.Henry:
                        v = Val;
                        e = (int)Q;
                        break;
                }
                val = v;
                exponent = e;
            }
            public Inductance(decimal Henry, int Exponent)
            {
                val = Henry;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Inductance Henry)
            {
                return Henry.val * (10 ^ Henry.exponent);
            }
            public static explicit operator Inductance(decimal Henry)
            {
                return new Inductance(Henry, Base, InductanceUnit.Henry);
            }

            //explicit operators
            public static Inductance operator +(Inductance A, Inductance B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new Inductance(Val, Exponent);
            }
            public static Inductance operator -(Inductance A, Inductance B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new Inductance(Val, Exponent);
            }

            public static Inductance SetExponent(Inductance M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new Inductance(v, e);
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
