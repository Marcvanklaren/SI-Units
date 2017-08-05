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

namespace Physics.Mechanics.Entities
{
    public class Newtonian
    {
        public static decimal v;
        public static int e;
        public static string s;
        
        //Momentum
        //D4;   M^1 * L^1 * T^1
        //Base Unit: NewtonSecond
        public struct Momentum
        {
            public decimal val;
            public int exponent;

            public Momentum(decimal Val, Quantifier Q, MomentumUnit U)
            {
                switch (U)
                {
                    case MomentumUnit.NewtonSecond:
                        v = Val;
                        e = (int)Q;
                        break;
                }
                val = v;
                exponent = e;
            }
            public Momentum(decimal NewtonSecond, int Exponent)
            {
                val = NewtonSecond;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Momentum NewtonSecond)
            {
                return NewtonSecond.val * (10 ^ NewtonSecond.exponent);
            }
            public static explicit operator Momentum(decimal NewtonSecond)
            {
                return new Momentum(NewtonSecond, Base, MomentumUnit.NewtonSecond);
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

            public string ToString(Quantifier Q, MomentumUnit U)
            {
                switch (U)
                {
                    case MomentumUnit.NewtonSecond:
                        s = Entity2String(this.val, this.exponent, Q) + " Newton*Second";
                        break;
                }
                return s;
            }

            public void Print()
            {
                string s = ToString(Base, MomentumUnit.NewtonSecond);
                Console.WriteLine(s);
            }
        }

        //AngularMomentum
        //D1;   M^1 * T^-1
        //Base Unit: NewtonMeterSecond
        public struct AngularMomentum
        {
            public decimal val;
            public int exponent;

            public AngularMomentum(decimal Val, Quantifier Q, AngularMomentumUnit U)
            {
                switch (U)
                {
                    case AngularMomentumUnit.NewtonMeterSecond:
                        v = Val;
                        e = (int)Q;
                        break;
                }
                val = v;
                exponent = e;
            }
            public AngularMomentum(decimal NewtonMeterSecond, int Exponent)
            {
                val = NewtonMeterSecond;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(AngularMomentum NewtonMeterSecond)
            {
                return NewtonMeterSecond.val * (10 ^ NewtonMeterSecond.exponent);
            }
            public static explicit operator AngularMomentum(decimal NewtonMeterSecond)
            {
                return new AngularMomentum(NewtonMeterSecond, Base, AngularMomentumUnit.NewtonMeterSecond);
            }

            //explicit operators
            public static AngularMomentum operator +(AngularMomentum A, AngularMomentum B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new AngularMomentum(Val, Exponent);
            }
            public static AngularMomentum operator -(AngularMomentum A, AngularMomentum B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new AngularMomentum(Val, Exponent);
            }

            public static AngularMomentum SetExponent(AngularMomentum M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new AngularMomentum(v, e);
            }

            public string ToString(Quantifier Q, AngularMomentumUnit U)
            {
                switch (U)
                {
                    case AngularMomentumUnit.NewtonMeterSecond:
                        s = Entity2String(this.val, this.exponent, Q) + " Newton*Meter*Second";
                        break;
                }
                return s;
            }

            public void Print()
            {
                string s = ToString(Base, AngularMomentumUnit.NewtonMeterSecond);
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
                switch (U)
                {
                    case ImpulseUnit.NewtonSecond:
                        v = Val;
                        e = (int)Q;
                        break;
                }
                val = v;
                exponent = e;
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

            public string ToString(Quantifier Q, ImpulseUnit U)
            {
                switch (U)
                {
                    case ImpulseUnit.NewtonSecond:
                        s = Entity2String(this.val, this.exponent, Q) + " Newton*Second";
                        break;
                }
                return s;
            }

            public void Print()
            {
                string s = ToString(Base, ImpulseUnit.NewtonSecond);
                Console.WriteLine(s);
            }
        }
    }
}
