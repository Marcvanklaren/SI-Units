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
    class D8Units
    {
        //Inductance
        //D8;   M^1 * D^2 * T^-3 * I^-2
        //Base Unit: Henry
        public struct Inductance
        {
            public decimal val;
            public int exponent;

            public Inductance(decimal Val, Quantifier Q, InductanceUnit U)
            {
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public Inductance(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Inductance d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator Inductance(decimal d)
            {
                return new Inductance(d, Base, InductanceUnit.Henry);
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

        //Resistance
        //D8;   M^1 * D^2 * T^-3 * I^-2
        //Base Unit: Ohm
        public struct Resistance
        {
            public decimal val;
            public int exponent;

            public Resistance(decimal Val, Quantifier Q, ResistanceUnit U)
            {
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public Resistance(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Resistance d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator Resistance(decimal d)
            {
                return new Resistance(d, Base, ResistanceUnit.Ohm);
            }

            //explicit operators
            public static Resistance operator +(Resistance A, Resistance B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new Resistance(Val, Exponent);
            }
            public static Resistance operator -(Resistance A, Resistance B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new Resistance(Val, Exponent);
            }

            public static Resistance SetExponent(Resistance M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new Resistance(v, e);
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

        //Conductance
        //D1;   M^-1 * D^-2 * T^3 * I^2
        //Base Unit: Siemens
        public struct Conductance
        {
            public decimal val;
            public int exponent;

            public Conductance(decimal Val, Quantifier Q, ConductanceUnit U)
            {
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public Conductance(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Conductance d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator Conductance(decimal d)
            {
                return new Conductance(d, Base, ConductanceUnit.Siemens);
            }

            //explicit operators
            public static Conductance operator +(Conductance A, Conductance B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new Conductance(Val, Exponent);
            }
            public static Conductance operator -(Conductance A, Conductance B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new Conductance(Val, Exponent);
            }

            public static Conductance SetExponent(Conductance M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new Conductance(v, e);
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
