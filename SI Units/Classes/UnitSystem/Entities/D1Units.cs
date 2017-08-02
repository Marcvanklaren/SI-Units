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

namespace SI_Units.UnitSystem
{
    namespace Entities
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
        public class D1Units
        {
            public decimal val;
            public int exponent = 0;

            //Base Units
            #region BaseUnits
            //Distance
            //D1;   L^1
            //Base Unit: Meter
            //Distance
            public struct Distance
            {
                public decimal val;
                public int exponent;

                public Distance(decimal Val, Quantifier Q, DistanceUnit U)
                {
                    val = Val;
                    exponent = (int)Q + (int)U;
                }
                public Distance(decimal Val, int Exponent)
                {
                    val = Val;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(Distance d)
                {
                    return d.val * (10 ^ d.exponent);
                }
                public static explicit operator Distance(decimal d)
                {
                    return new Distance(d, Base, DistanceUnit.Meter);
                }

                //explicit operators
                public static Distance operator +(Distance A, Distance B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (A.val * Factor) + B.val;
                    return new Distance(Val, Exponent);
                }
                public static Distance operator -(Distance A, Distance B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (-A.val * Factor) + B.val;
                    return new Distance(Val, Exponent);
                }

                public static Distance SetExponent(Distance M)
                {
                    decimal v = M.val;
                    int e = M.exponent;
                    Functions.Entities.SetExponent(ref v, ref e);
                    return new Distance(v, e);
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

            //Time
            //D1;   T^1
            //Base Unit: Second
            //Time
            public struct Time
            {
                public decimal val;
                public int exponent;

                public Time(decimal Val, Quantifier Q, TimeUnit U)
                {
                    val = Val;
                    exponent = (int)Q + (int)U;
                }
                public Time(decimal Val, int Exponent)
                {
                    val = Val;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(Time d)
                {
                    return d.val * (10 ^ d.exponent);
                }
                public static explicit operator Time(decimal d)
                {
                    return new Time(d, Base, TimeUnit.Second);
                }

                //explicit operators
                public static Time operator +(Time A, Time B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (A.val * Factor) + B.val;
                    return new Time(Val, Exponent);
                }
                public static Time operator -(Time A, Time B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (-A.val * Factor) + B.val;
                    return new Time(Val, Exponent);
                }

                public static Time SetExponent(Time M)
                {
                    decimal v = M.val;
                    int e = M.exponent;
                    Functions.Entities.SetExponent(ref v, ref e);
                    return new Time(v, e);
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

            //Mass
            //D1;   M^1
            //Base Unit: Gram
            //Mass
            public struct Mass
            {
                public decimal val;
                public int exponent;

                public Mass(decimal Val, Quantifier Q, MassUnit U)
                {
                    val = Val;
                    exponent = (int)Q + (int)U;
                }
                public Mass(decimal Val, int Exponent)
                {
                    val = Val;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(Mass d)
                {
                    return d.val * (10 ^ d.exponent);
                }
                public static explicit operator Mass(decimal d)
                {
                    return new Mass(d, Base, MassUnit.Gram);
                }

                //explicit operators
                public static Mass operator +(Mass A, Mass B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (A.val * Factor) + B.val;
                    return new Mass(Val, Exponent);
                }
                public static Mass operator -(Mass A, Mass B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (-A.val * Factor) + B.val;
                    return new Mass(Val, Exponent);
                }

                public static Mass SetExponent(Mass M)
                {
                    decimal v = M.val;
                    int e = M.exponent;
                    Functions.Entities.SetExponent(ref v, ref e);
                    return new Mass(v, e);
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

            //AoSubstance
            //D1;   N^1
            //Base Unit: Mole
            //AoSubstance
            public struct AoSubstance
            {
                public decimal val;
                public int exponent;

                public AoSubstance(decimal Val, Quantifier Q, AoSubstanceUnit U)
                {
                    val = Val;
                    exponent = (int)Q + (int)U;
                }
                public AoSubstance(decimal Val, int Exponent)
                {
                    val = Val;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(AoSubstance d)
                {
                    return d.val * (10 ^ d.exponent);
                }
                public static explicit operator AoSubstance(decimal d)
                {
                    return new AoSubstance(d, Base, AoSubstanceUnit.Mole);
                }

                //explicit operators
                public static AoSubstance operator +(AoSubstance A, AoSubstance B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (A.val * Factor) + B.val;
                    return new AoSubstance(Val, Exponent);
                }
                public static AoSubstance operator -(AoSubstance A, AoSubstance B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (-A.val * Factor) + B.val;
                    return new AoSubstance(Val, Exponent);
                }

                public static AoSubstance SetExponent(AoSubstance M)
                {
                    decimal v = M.val;
                    int e = M.exponent;
                    Functions.Entities.SetExponent(ref v, ref e);
                    return new AoSubstance(v, e);
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

            //ElectricCurrent
            //D1;   I^1
            //Base Unit: Ampere
            //ElectricCurrent
            public struct ElectricCurrent
            {
                public decimal val;
                public int exponent;

                public ElectricCurrent(decimal Val, Quantifier Q, ElectricCurrentUnit U)
                {
                    val = Val;
                    exponent = (int)Q + (int)U;
                }
                public ElectricCurrent(decimal Val, int Exponent)
                {
                    val = Val;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(ElectricCurrent d)
                {
                    return d.val * (10 ^ d.exponent);
                }
                public static explicit operator ElectricCurrent(decimal d)
                {
                    return new ElectricCurrent(d, Base, ElectricCurrentUnit.Ampere);
                }

                //explicit operators
                public static ElectricCurrent operator +(ElectricCurrent A, ElectricCurrent B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (A.val * Factor) + B.val;
                    return new ElectricCurrent(Val, Exponent);
                }
                public static ElectricCurrent operator -(ElectricCurrent A, ElectricCurrent B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (-A.val * Factor) + B.val;
                    return new ElectricCurrent(Val, Exponent);
                }

                public static ElectricCurrent SetExponent(ElectricCurrent M)
                {
                    decimal v = M.val;
                    int e = M.exponent;
                    Functions.Entities.SetExponent(ref v, ref e);
                    return new ElectricCurrent(v, e);
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

            //ThermoDynaTemp
            //D1;   O^1
            //Base Unit: Kelvin
            //ThermoDynaTemp
            public struct ThermoDynaTemp
            {
                public decimal val;
                public int exponent;

                public ThermoDynaTemp(decimal Val, Quantifier Q, ThermoDynaTempUnit U)
                {
                    val = Val;
                    exponent = (int)Q + (int)U;
                }
                public ThermoDynaTemp(decimal Val, int Exponent)
                {
                    val = Val;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(ThermoDynaTemp d)
                {
                    return d.val * (10 ^ d.exponent);
                }
                public static explicit operator ThermoDynaTemp(decimal d)
                {
                    return new ThermoDynaTemp(d, Base, ThermoDynaTempUnit.Kelvin);
                }

                //explicit operators
                public static ThermoDynaTemp operator +(ThermoDynaTemp A, ThermoDynaTemp B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (A.val * Factor) + B.val;
                    return new ThermoDynaTemp(Val, Exponent);
                }
                public static ThermoDynaTemp operator -(ThermoDynaTemp A, ThermoDynaTemp B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (-A.val * Factor) + B.val;
                    return new ThermoDynaTemp(Val, Exponent);
                }

                public static ThermoDynaTemp SetExponent(ThermoDynaTemp M)
                {
                    decimal v = M.val;
                    int e = M.exponent;
                    Functions.Entities.SetExponent(ref v, ref e);
                    return new ThermoDynaTemp(v, e);
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

            //LuminousIntensity
            //D1;   J^1
            //Base Unit: Candela
            //LuminousIntensity
            public struct LuminousIntensity
            {
                public decimal val;
                public int exponent;

                public LuminousIntensity(decimal Val, Quantifier Q, LuminousIntensityUnit U)
                {
                    val = Val;
                    exponent = (int)Q + (int)U;
                }
                public LuminousIntensity(decimal Val, int Exponent)
                {
                    val = Val;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(LuminousIntensity d)
                {
                    return d.val * (10 ^ d.exponent);
                }
                public static explicit operator LuminousIntensity(decimal d)
                {
                    return new LuminousIntensity(d, Base, LuminousIntensityUnit.Candela);
                }

                //explicit operators
                public static LuminousIntensity operator +(LuminousIntensity A, LuminousIntensity B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (A.val * Factor) + B.val;
                    return new LuminousIntensity(Val, Exponent);
                }
                public static LuminousIntensity operator -(LuminousIntensity A, LuminousIntensity B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (-A.val * Factor) + B.val;
                    return new LuminousIntensity(Val, Exponent);
                }

                public static LuminousIntensity SetExponent(LuminousIntensity M)
                {
                    decimal v = M.val;
                    int e = M.exponent;
                    Functions.Entities.SetExponent(ref v, ref e);
                    return new LuminousIntensity(v, e);
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
            #endregion

            //Derived Units
            #region DerivedUnits
            //Frequency
            //D1;   T^-1
            //Base Unit: Hertz
            //Frequency
            public struct Frequency
            {
                public decimal val;
                public int exponent;

                public Frequency(decimal Val, Quantifier Q, FrequencyUnit U)
                {
                    val = Val;
                    exponent = (int)Q + (int)U;
                }
                public Frequency(decimal Val, int Exponent)
                {
                    val = Val;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(Frequency d)
                {
                    return d.val * (10 ^ d.exponent);
                }
                public static explicit operator Frequency(decimal d)
                {
                    return new Frequency(d, Base, FrequencyUnit.Hertz);
                }

                //explicit operators
                public static Frequency operator +(Frequency A, Frequency B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (A.val * Factor) + B.val;
                    return new Frequency(Val, Exponent);
                }
                public static Frequency operator -(Frequency A, Frequency B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (-A.val * Factor) + B.val;
                    return new Frequency(Val, Exponent);
                }

                public static Frequency SetExponent(Frequency M)
                {
                    decimal v = M.val;
                    int e = M.exponent;
                    Functions.Entities.SetExponent(ref v, ref e);
                    return new Frequency(v, e);
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

            //Activity
            //D1;   T^-1
            //Base Unit: Becquerel
            //Activity
            public struct Activity
            {
                public decimal val;
                public int exponent;

                public Activity(decimal Val, Quantifier Q, ActivityUnit U)
                {
                    val = Val;
                    exponent = (int)Q + (int)U;
                }
                public Activity(decimal Val, int Exponent)
                {
                    val = Val;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(Activity d)
                {
                    return d.val * (10 ^ d.exponent);
                }
                public static explicit operator Activity(decimal d)
                {
                    return new Activity(d, Base, ActivityUnit.Becquerel);
                }

                //explicit operators
                public static Activity operator +(Activity A, Activity B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (A.val * Factor) + B.val;
                    return new Activity(Val, Exponent);
                }
                public static Activity operator -(Activity A, Activity B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (-A.val * Factor) + B.val;
                    return new Activity(Val, Exponent);
                }

                public static Activity SetExponent(Activity M)
                {
                    decimal v = M.val;
                    int e = M.exponent;
                    Functions.Entities.SetExponent(ref v, ref e);
                    return new Activity(v, e);
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
            #endregion

            //LuminousFlux
            //D1;   J^1
            //Base Unit: Lumen
            //LuminousFlux
            public struct LuminousFlux
            {
                public decimal val;
                public int exponent;

                public LuminousFlux(decimal Val, Quantifier Q, LuminousFluxUnit U)
                {
                    val = Val;
                    exponent = (int)Q + (int)U;
                }
                public LuminousFlux(decimal Val, int Exponent)
                {
                    val = Val;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(LuminousFlux d)
                {
                    return d.val * (10 ^ d.exponent);
                }
                public static explicit operator LuminousFlux(decimal d)
                {
                    return new LuminousFlux(d, Base, LuminousFluxUnit.Lumen);
                }

                //explicit operators
                public static LuminousFlux operator +(LuminousFlux A, LuminousFlux B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (A.val * Factor) + B.val;
                    return new LuminousFlux(Val, Exponent);
                }
                public static LuminousFlux operator -(LuminousFlux A, LuminousFlux B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (-A.val * Factor) + B.val;
                    return new LuminousFlux(Val, Exponent);
                }

                public static LuminousFlux SetExponent(LuminousFlux M)
                {
                    decimal v = M.val;
                    int e = M.exponent;
                    Functions.Entities.SetExponent(ref v, ref e);
                    return new LuminousFlux(v, e);
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
}
