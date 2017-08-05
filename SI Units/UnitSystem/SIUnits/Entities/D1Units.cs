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

namespace Physics.UnitSystem.SIUnits
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
            public static decimal v;
            public static int e;

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
                    switch (U)
                    {
                        case DistanceUnit.Meter:
                            v = Val;
                            e = (int)Q;
                            break;
                        case DistanceUnit.Yard:
                            Multiplication(Val, (int)Q, Degree.val, Degree.exponent, out v, out e);
                            break;
                    }
                    val = v;
                    exponent = e;
                }
                public Distance(decimal Meter, int Exponent)
                {
                    val = Meter;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(Distance Meter)
                {
                    return Meter.val * (10 ^ Meter.exponent);
                }
                public static explicit operator Distance(decimal Mater)
                {
                    return new Distance(Mater, Base, DistanceUnit.Meter);
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
                    switch (U)
                    {
                        case TimeUnit.Second:
                            v = Val;
                            e = (int)Q;
                            break;
                        case TimeUnit.Minute:
                            Multiplication(Val, (int)Q, Minute.val, Minute.exponent, out v, out e);
                            break;
                        case TimeUnit.Hour:
                            Multiplication(Val, (int)Q, Hour.val, Hour.exponent, out v, out e);
                            break;
                        case TimeUnit.Day:
                            Multiplication(Val, (int)Q, Day.val, Day.exponent, out v, out e);
                            break;
                        case TimeUnit.Week:
                            Multiplication(Val, (int)Q, Week.val, Week.exponent, out v, out e);
                            break;
                        case TimeUnit.Year:
                            Multiplication(Val, (int)Q, Year.val, Year.exponent, out v, out e);
                            break;
                    }
                    val = v;
                    exponent = e;
                }
                public Time(decimal Second, int Exponent)
                {
                    val = Second;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(Time Second)
                {
                    return Second.val * (10 ^ Second.exponent);
                }
                public static explicit operator Time(decimal Second)
                {
                    return new Time(Second, Base, TimeUnit.Second);
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
                    switch (U)
                    {
                        case MassUnit.Gram:
                            v = Val;
                            e = (int)Q;
                            break;
                        case MassUnit.Dalton:
                            Multiplication(Val, (int)Q, Dalton.val, Dalton.exponent, out v, out e);
                            break;
                    }
                    val = v;
                    exponent = e;
                }
                public Mass(decimal Gram, int Exponent)
                {
                    val = Gram;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(Mass Gram)
                {
                    return Gram.val * (10 ^ Gram.exponent);
                }
                public static explicit operator Mass(decimal Gram)
                {
                    return new Mass(Gram, Base, MassUnit.Gram);
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
                    switch (U)
                    {
                        case AoSubstanceUnit.Mole:
                            v = Val;
                            e = (int)Q;
                            break;
                        case AoSubstanceUnit.Grams:
                            Multiplication(Val, (int)Q, MoleGram.val, MoleGram.exponent, out v, out e);
                            break;
                    }
                    val = v;
                    exponent = e;
                }
                public AoSubstance(decimal Mole, int Exponent)
                {
                    val = Mole;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(AoSubstance Mole)
                {
                    return Mole.val * (10 ^ Mole.exponent);
                }
                public static explicit operator AoSubstance(decimal Mole)
                {
                    return new AoSubstance(Mole, Base, AoSubstanceUnit.Mole);
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
                    switch (U)
                    {
                        case ElectricCurrentUnit.Ampere:
                            v = Val;
                            e = (int)Q;
                            break;
                    }
                    val = v;
                    exponent = e;
                }
                public ElectricCurrent(decimal Ampere, int Exponent)
                {
                    val = Ampere;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(ElectricCurrent Ampere)
                {
                    return Ampere.val * (10 ^ Ampere.exponent);
                }
                public static explicit operator ElectricCurrent(decimal Ampere)
                {
                    return new ElectricCurrent(Ampere, Base, ElectricCurrentUnit.Ampere);
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
                    switch (U)
                    {
                        case ThermoDynaTempUnit.Kelvin:
                            v = Val;
                            e = (int)Q;
                            break;
                        case ThermoDynaTempUnit.Celcius:
                            v = Val + (decimal)273.15;
                            e = (int)Q;
                            break;
                        case ThermoDynaTempUnit.Fahrenheit:
                            v = (Val + (decimal)459.67) * 5 / 9;
                            e = (int)Q;
                            break;
                    }
                    val = v;
                    exponent = e;
                }
                public ThermoDynaTemp(decimal Kelvin, int Exponent)
                {
                    val = Kelvin;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(ThermoDynaTemp Kelvin)
                {
                    return Kelvin.val * (10 ^ Kelvin.exponent);
                }
                public static explicit operator ThermoDynaTemp(decimal Kelvin)
                {
                    return new ThermoDynaTemp(Kelvin, Base, ThermoDynaTempUnit.Kelvin);
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
                    switch (U)
                    {
                        case LuminousIntensityUnit.Candela:
                            v = Val;
                            e = (int)Q;
                            break;
                    }
                    val = v;
                    exponent = e;
                }
                public LuminousIntensity(decimal Candela, int Exponent)
                {
                    val = Candela;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(LuminousIntensity Candela)
                {
                    return Candela.val * (10 ^ Candela.exponent);
                }
                public static explicit operator LuminousIntensity(decimal Candela)
                {
                    return new LuminousIntensity(Candela, Base, LuminousIntensityUnit.Candela);
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
                    switch (U)
                    {
                        case FrequencyUnit.Hertz:
                            v = Val;
                            e = (int)Q;
                            break;
                    }
                    val = v;
                    exponent = e;
                }
                public Frequency(decimal Hertz, int Exponent)
                {
                    val = Hertz;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(Frequency Hertz)
                {
                    return Hertz.val * (10 ^ Hertz.exponent);
                }
                public static explicit operator Frequency(decimal Hertz)
                {
                    return new Frequency(Hertz, Base, FrequencyUnit.Hertz);
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
                    switch (U)
                    {
                        case ActivityUnit.Becquerel:
                            v = Val;
                            e = (int)Q;
                            break;
                    }
                    val = v;
                    exponent = e;
                }
                public Activity(decimal Becquerel, int Exponent)
                {
                    val = Becquerel;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(Activity Becquerel)
                {
                    return Becquerel.val * (10 ^ Becquerel.exponent);
                }
                public static explicit operator Activity(decimal Becquerel)
                {
                    return new Activity(Becquerel, Base, ActivityUnit.Becquerel);
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

            //AngularVelocity
            //D1;   T^-1
            //Base Unit: RadPSecond
            public struct AngularVelocity
            {
                public decimal val;
                public int exponent;

                public AngularVelocity(decimal Val, Quantifier Q, AngularVelocityUnit U)
                {
                    switch (U)
                    {
                        case AngularVelocityUnit.RadPSecond:
                            v = Val;
                            e = (int)Q;
                            break;
                        case AngularVelocityUnit.DegreePSecond:
                            Multiplication(Val, (int)Q, DegreePSecond.val, DegreePSecond.exponent, out v, out e);
                            break;
                    }
                    val = v;
                    exponent = e;
                }
                public AngularVelocity(decimal RadPSecond, int Exponent)
                {
                    val = RadPSecond;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(AngularVelocity RadPSecond)
                {
                    return RadPSecond.val * (10 ^ RadPSecond.exponent);
                }
                public static explicit operator AngularVelocity(decimal RadPSecond)
                {
                    return new AngularVelocity(RadPSecond, Base, AngularVelocityUnit.RadPSecond);
                }

                //explicit operators
                public static AngularVelocity operator +(AngularVelocity A, AngularVelocity B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (A.val * Factor) + B.val;
                    return new AngularVelocity(Val, Exponent);
                }
                public static AngularVelocity operator -(AngularVelocity A, AngularVelocity B)
                {
                    int Exponent = A.exponent - B.exponent;
                    long Factor = 1;
                    if (Exponent != 0)
                        Factor = 10 ^ Exponent;
                    decimal Val = (-A.val * Factor) + B.val;
                    return new AngularVelocity(Val, Exponent);
                }

                public static AngularVelocity SetExponent(AngularVelocity M)
                {
                    decimal v = M.val;
                    int e = M.exponent;
                    Functions.Entities.SetExponent(ref v, ref e);
                    return new AngularVelocity(v, e);
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
                    switch (U)
                    {
                        case LuminousFluxUnit.Lumen:
                            v = Val;
                            e = (int)Q;
                            break;
                    }
                    val = v;
                    exponent = e;
                }
                public LuminousFlux(decimal Lumen, int Exponent)
                {
                    val = Lumen;
                    exponent = Exponent;
                }

                //auto cast to decimal, float, BigInt
                public static explicit operator decimal(LuminousFlux Lumen)
                {
                    return Lumen.val * (10 ^ Lumen.exponent);
                }
                public static explicit operator LuminousFlux(decimal Lumen)
                {
                    return new LuminousFlux(Lumen, Base, LuminousFluxUnit.Lumen);
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
            #endregion
        }
    }
}
