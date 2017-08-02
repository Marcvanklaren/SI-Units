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
    public class Newtonian
    {
        //Momentum
        //D4;   M^1 * L^1 * T^1
        //Base Unit: NewtonSecond
        public struct Momentum
        {
            public decimal val;
            public int exponent;

            public Momentum(decimal Val, Quantifier Q, MomentumUnit U)
            {
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public Momentum(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Momentum d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator Momentum(decimal d)
            {
                return new Momentum(d, Base, MomentumUnit.NewtonSecond);
            }

            //explicit operators
            public static Momentum operator +(Momentum A, Momentum B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new Momentum(Val, Exponent);
            }
            public static Momentum operator -(Momentum A, Momentum B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new Momentum(Val, Exponent);
            }

            public static Momentum SetExponent(Momentum M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new Momentum(v, e);
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

        //Impulse
        //D1;   M^1
        //Base Unit: NewtonSecond
        public struct Impulse
        {
            public decimal val;
            public int exponent;

            public Impulse(decimal Val, Quantifier Q, ImpulseUnit U)
            {
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public Impulse(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Impulse d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator Impulse(decimal d)
            {
                return new Impulse(d, Base, ImpulseUnit.NewtonSecond);
            }

            //explicit operators
            public static Impulse operator +(Impulse A, Impulse B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new Impulse(Val, Exponent);
            }
            public static Impulse operator -(Impulse A, Impulse B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new Impulse(Val, Exponent);
            }

            public static Impulse SetExponent(Impulse M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new Impulse(v, e);
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
