﻿using System;
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
    class D7Units
    {
        //Potential
        //D7;   M^1 * L^2 * T^-3 * I^-1
        //Base Unit: Volt
        public struct Potential
        {
            public decimal val;
            public int exponent;

            public Potential(decimal Val, Quantifier Q, ElectricPotentialUnit U)
            {
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public Potential(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Potential d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator Potential(decimal d)
            {
                return new Potential(d, Base, ElectricPotentialUnit.Volt);
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
    }
}
