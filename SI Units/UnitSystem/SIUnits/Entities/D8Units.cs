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
    class D8Units
    {
        public static decimal v;
        public static int e;
        public static string s;
        
        //Resistance
        //D8;   M^1 * L^2 * T^-3 * I^-2
        //Base Unit: Ohm
        public struct Resistance
        {
            public decimal val;
            public int exponent;

            public Resistance(decimal Val, Quantifier Q, ResistanceUnit U)
            {
                switch (U)
                {
                    case ResistanceUnit.Ohm:
                        v = Val;
                        e = (int)Q;
                        break;
                }
                val = v;
                exponent = e;
            }
            public Resistance(decimal Ohm, int Exponent)
            {
                val = Ohm;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Resistance Ohm)
            {
                return Ohm.val * (10 ^ Ohm.exponent);
            }
            public static explicit operator Resistance(decimal Ohm)
            {
                return new Resistance(Ohm, Base, ResistanceUnit.Ohm);
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

            public string ToString(Quantifier Q, ResistanceUnit U)
            {
                switch (U)
                {
                    case ResistanceUnit.Ohm:
                        s = Entity2String(this.val, this.exponent, Q) + " Ohm";
                        break;
                }
                return s;
            }

            public void Print()
            {
                string s = ToString(Base, ResistanceUnit.Ohm);
                Console.WriteLine(s);
            }
        }

        //Conductance
        //D8;   M^-1 * L^-2 * T^3 * I^2
        //Base Unit: Siemens
        public struct Conductance
        {
            public decimal val;
            public int exponent;

            public Conductance(decimal Val, Quantifier Q, ConductanceUnit U)
            {
                switch (U)
                {
                    case ConductanceUnit.Siemens:
                        v = Val;
                        e = (int)Q;
                        break;
                }
                val = v;
                exponent = e;
            }
            public Conductance(decimal Siemens, int Exponent)
            {
                val = Siemens;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Conductance Siemens)
            {
                return Siemens.val * (10 ^ Siemens.exponent);
            }
            public static explicit operator Conductance(decimal Siemens)
            {
                return new Conductance(Siemens, Base, ConductanceUnit.Siemens);
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

            public string ToString(Quantifier Q, ConductanceUnit U)
            {
                switch (U)
                {
                    case ConductanceUnit.Siemens:
                        s = Entity2String(this.val, this.exponent, Q) + " Siemens";
                        break;
                }
                return s;
            }

            public void Print()
            {
                string s = ToString(Base, ConductanceUnit.Siemens);
                Console.WriteLine(s);
            }
        }
    }
}
