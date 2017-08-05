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
    /// <summary>
    ///Base Quantities    -    Symbol for quantity    -    Symbol for dimension    -    Base Unit
    ///- Distance              l                           L                            meter
    ///- Mass                  m                           M                            gram
    ///- Time                  t                           T                            second
    ///- Electric Current      i                           I                            ampere
    ///- Temperature           o                           O                            kelvin
    ///- Amount of Substance   n                           N                            mole
    ///- Luminous Intensity    j                           J                            candela
    ///
    ///DIMENSIONS
    ///Dimension of a quantity is defined by (L^a)*(M*b)*(T^c)*(I^d)*(O^e)*(N^f)*(J*g)
    ///a,b,c,d,e,f,g ϵ ℤ
    ///
    ///Dimension of a quantity denoted by "D" + (|a| + |b| + |c| + |d| + |e| + |f| + |g|)
    ///(Base units are D1, AKA "dimensionless". They only relate to 1 quantity: themselves)
    ///
    ///Units are organised in 1 class per D-value
    /// </summary>
    public class D3Units
    {
        public static decimal v;
        public static int e;
        
        //Volume
        //D3;   L^3
        //Base Unit: Meter3
        //Volume
        public struct Volume
        {
            public decimal val;
            public int exponent;

            public Volume(decimal Val, Quantifier Q, VolumeUnit U)
            {
                switch (U)
                {
                    case VolumeUnit.Meter3:
                        v = Val;
                        e = (int)Q * 3;
                        break;
                    case VolumeUnit.Liter:
                        v = Val;
                        e = ((int)Q -1) * 3;        //1000L = 1 M3
                        break;
                }
                val = v;
                exponent = e;
            }
            public Volume(decimal Meter3, int Exponent)
            {
                val = Meter3;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Volume Meter3)
            {
                return Meter3.val * (10 ^ Meter3.exponent);
            }
            public static explicit operator Volume(decimal Meter3)
            {
                return new Volume(Meter3, Base, VolumeUnit.Meter3);
            }

            //explicit operators
            public static Volume operator +(Volume A, Volume B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new Volume(Val, Exponent);
            }
            public static Volume operator -(Volume A, Volume B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new Volume(Val, Exponent);
            }

            public static Volume SetExponent(Volume M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new Volume(v, e);
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

        //Acceleration
        //D3;   L^1 * T^-2
        //Base Unit: MeterPSecond2
        //Acceleration
        public struct LinearAcceleration
        {
            public decimal val;
            public int exponent;

            public LinearAcceleration(decimal Val, Quantifier Q, LinearAccelerationUnit U)
            {
                switch (U)
                {
                    case LinearAccelerationUnit.MeterPSecond2:
                        v = Val;
                        e = (int)Q;
                        break;
                    case LinearAccelerationUnit.KMeterPHourPSecond:
                        Multiplication(Val, (int)Q, KMeterPHourPSecond.val, KMeterPHourPSecond.exponent, out v, out e);
                        break;
                }
                val = v;
                exponent = e;
            }
            public LinearAcceleration(decimal MeterPSecondPSecond, int Exponent)
            {
                val = MeterPSecondPSecond;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(LinearAcceleration MeterPSecondPSecond)
            {
                return MeterPSecondPSecond.val * (10 ^ MeterPSecondPSecond.exponent);
            }
            public static explicit operator LinearAcceleration(decimal MeterPSecondPSecond)
            {
                return new LinearAcceleration(MeterPSecondPSecond, Base, LinearAccelerationUnit.MeterPSecond2);
            }

            //explicit operators
            public static LinearAcceleration operator +(LinearAcceleration A, LinearAcceleration B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new LinearAcceleration(Val, Exponent);
            }
            public static LinearAcceleration operator -(LinearAcceleration A, LinearAcceleration B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new LinearAcceleration(Val, Exponent);
            }

            public static LinearAcceleration SetExponent(LinearAcceleration M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new LinearAcceleration(v, e);
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

        //Illuminance
        //D3;   J^1 * L^-2
        //Base Unit: Lux
        //Illuminance
        public struct Illuminance
        {
            public decimal val;
            public int exponent;

            public Illuminance(decimal Val, Quantifier Q, IlluminanceUnit U)
            {
                switch (U)
                {
                    case IlluminanceUnit.Lux:
                        v = Val;
                        e = (int)Q;
                        break;
                }
                val = v;
                exponent = e;
            }
            public Illuminance(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Illuminance d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator Illuminance(decimal d)
            {
                return new Illuminance(d, Base, IlluminanceUnit.Lux);
            }

            //explicit operators
            public static Illuminance operator +(Illuminance A, Illuminance B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new Illuminance(Val, Exponent);
            }
            public static Illuminance operator -(Illuminance A, Illuminance B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new Illuminance(Val, Exponent);
            }

            public static Illuminance SetExponent(Illuminance M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new Illuminance(v, e);
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
