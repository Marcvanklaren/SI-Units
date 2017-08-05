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
    public class D0Units
    {
        public static decimal v;
        public static int e;
        public static string s;

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
                switch (U)
                {
                    case AngleUnit.Radian:
                        v = Val;
                        e = (int)Q;
                        break;
                    case AngleUnit.Degree:
                        Multiplication(Val, (int)Q, Degree.val, Degree.exponent, out v, out e);
                        break;
                }
                val = v;
                exponent = e;
            }
            public Angle(decimal Radian, int Exponent)
            {
                val = Radian;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Angle Radian)
            {
                return Radian.val * (10 ^ Radian.exponent);
            }
            public static explicit operator Angle(decimal Radian)
            {
                return new Angle(Radian, Quantifier.Base, AngleUnit.Radian);
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

            public string ToString(Quantifier Q, AngleUnit U)
            {
                switch (U)
                {
                    case AngleUnit.Radian:
                        s = Entity2String(this.val, this.exponent, Q) + " Radian";
                        break;
                    case AngleUnit.Degree:
                        Division(this.val, this.exponent, Degree.val, Degree.exponent, out v, out e);
                        s = Entity2String(v, e, Q) + " Degree";
                        break;
                }
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
                switch (U)
                {
                    case SolidAngleUnit.Steradian:
                        v = Val;
                        e = (int)Q;
                        break;
                    case SolidAngleUnit.Degree2:
                        Multiplication(Val * 4, (int)Q, Degree2.val, Degree2.exponent, out v, out e);
                        break;
                }
                val = v;
                exponent = e;
            }
            public SolidAngle(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(SolidAngle Steradian)
            {
                return Steradian.val * (10 ^ Steradian.exponent);
            }
            public static explicit operator SolidAngle(decimal Steradian)
            {
                return new SolidAngle(Steradian, Base, SolidAngleUnit.Steradian);
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

            public string ToString(Quantifier Q, SolidAngleUnit U)
            {
                switch (U)
                {
                    case SolidAngleUnit.Steradian:
                        s = Entity2String(this.val, this.exponent, Q) + " Steradian";
                        break;
                    case SolidAngleUnit.Degree2:
                        Division(this.val, this.exponent, Degree2.val, Degree2.exponent, out v, out e);
                        s = Entity2String(v, e, Q) + " Degree";
                        break;
                }
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
