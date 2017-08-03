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
    public class D0Units
    {
        //Angle
        //D0;   (L^1 * L^-1)
        //Base Unit: Radian
        //Angle
        public struct Angle
        {
            public decimal val;
            public int exponent;

            public Angle(decimal Val, Quantifier Q, AngleUnit U)
            {
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public Angle(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Angle d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator Angle(decimal d)
            {
                return new Angle(d, Base, AngleUnit.Radian);
            }

            //explicit operators
            public static Angle operator +(Angle A, Angle B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new Angle(Val, Exponent);
            }
            public static Angle operator -(Angle A, Angle B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new Angle(Val, Exponent);
            }

            public static Angle SetExponent(Angle M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new Angle(v, e);
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

        //SolidAngle
        //D0;   (L^2 * L^-2)
        //Base Unit: Steradian
        //SolidAngle
        public struct SolidAngle
        {
            public decimal val;
            public int exponent;

            public SolidAngle(decimal Val, Quantifier Q, SolidAngleUnit U)
            {
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public SolidAngle(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(SolidAngle d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator SolidAngle(decimal d)
            {
                return new SolidAngle(d, Base, SolidAngleUnit.Steradian);
            }

            //explicit operators
            public static SolidAngle operator +(SolidAngle A, SolidAngle B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new SolidAngle(Val, Exponent);
            }
            public static SolidAngle operator -(SolidAngle A, SolidAngle B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new SolidAngle(Val, Exponent);
            }

            public static SolidAngle SetExponent(SolidAngle M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new SolidAngle(v, e);
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
