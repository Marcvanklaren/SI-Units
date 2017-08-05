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
    public class D2Units
    {
        public static decimal v;
        public static int e;
        public static string s;
        
        //Area
        //D2;   L^2
        //Base Unit: Meter2
        //Area
        public struct Area
        {
            public decimal val;
            public int exponent;

            public Area(decimal Val, Quantifier Q, AreaUnit U)
            {
                switch (U)
                {
                    case AreaUnit.Meter2:
                        v = Val;
                        e = (int)Q * 2;
                        break;
                }
                val = v;
                exponent = e;
            }
            public Area(decimal Meter2, int Exponent)
            {
                val = Meter2;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Area Meter2)
            {
                return Meter2.val * (10 ^ Meter2.exponent);
            }
            public static explicit operator Area(decimal Meter2)
            {
                return new Area(Meter2, Base, AreaUnit.Meter2);
            }

            //explicit operators
            public static Area operator +(Area A, Area B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new Area(Val, Exponent);
            }
            public static Area operator -(Area A, Area B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new Area(Val, Exponent);
            }

            public static Area SetExponent(Area M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new Area(v, e);
            }

            public string ToString(Quantifier Q, AreaUnit U)
            {
                switch (U)
                {
                    case AreaUnit.Meter2:
                        s = Entity2String(this.val, this.exponent, Q) + " Meter^2";
                        break;
                }
                return s;
            }

            public void Print()
            {
                string s = ToString(Base, AreaUnit.Meter2);
                Console.WriteLine(s);
            }
        }

        //Velocity
        //D2;   L^1 * T^-1
        //Base Unit: MeterPSecond
        //Velocity
        public struct LinearVelocity
        {
            public decimal val;
            public int exponent;

            public LinearVelocity(decimal Val, Quantifier Q, LinearVelocityUnit U)
            {
                switch (U)
                {
                    case LinearVelocityUnit.MeterPSecond:
                        v = Val;
                        e = (int)Q;
                        break;
                    case LinearVelocityUnit.KMeterPHour:
                        Multiplication(Val, (int)Q, KMeterPHour.val, KMeterPHour.exponent, out v, out e);
                        break;
                }
                val = v;
                exponent = e;
            }
            public LinearVelocity(decimal MeterPSecond, int Exponent)
            {
                val = MeterPSecond;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(LinearVelocity MeterPSecond)
            {
                return MeterPSecond.val * (10 ^ MeterPSecond.exponent);
            }
            public static explicit operator LinearVelocity(decimal MeterPSecond)
            {
                return new LinearVelocity(MeterPSecond, Base, LinearVelocityUnit.MeterPSecond);
            }

            //explicit operators
            public static LinearVelocity operator +(LinearVelocity A, LinearVelocity B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new LinearVelocity(Val, Exponent);
            }
            public static LinearVelocity operator -(LinearVelocity A, LinearVelocity B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new LinearVelocity(Val, Exponent);
            }

            public static LinearVelocity SetExponent(LinearVelocity M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new LinearVelocity(v, e);
            }

            public string ToString(Quantifier Q, LinearVelocityUnit U)
            {
                switch (U)
                {
                    case LinearVelocityUnit.MeterPSecond:
                        s = Entity2String(this.val, this.exponent, Q) + " Meter / Second";
                        break;
                    case LinearVelocityUnit.KMeterPHour:
                        Division(this.val, this.exponent, KMeterPHour.val, KMeterPHour.exponent, out v, out e);
                        s = Entity2String(v, e, Q) + " Kilometer / Hour";
                        break;
                }
                return s;
            }

            public void Print()
            {
                string s = ToString(Base, LinearVelocityUnit.MeterPSecond);
                Console.WriteLine(s);
            }
        }

        //ElectricCharge
        //D2;   I^1 * T^1
        //Base Unit: Coulomb
        //ElectricCharge
        public struct ElectricCharge
        {
            public decimal val;
            public int exponent;

            public ElectricCharge(decimal Val, Quantifier Q, ElectricChargeUnit U)
            {
                switch (U)
                {
                    case ElectricChargeUnit.Coulomb:
                        v = Val;
                        e = (int)Q;
                        break;
                }
                val = v;
                exponent = e;
            }
            public ElectricCharge(decimal Coulomb, int Exponent)
            {
                val = Coulomb;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(ElectricCharge Coulomb)
            {
                return Coulomb.val * (10 ^ Coulomb.exponent);
            }
            public static explicit operator ElectricCharge(decimal Coulomb)
            {
                return new ElectricCharge(Coulomb, Base, ElectricChargeUnit.Coulomb);
            }

            //explicit operators
            public static ElectricCharge operator +(ElectricCharge A, ElectricCharge B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new ElectricCharge(Val, Exponent);
            }
            public static ElectricCharge operator -(ElectricCharge A, ElectricCharge B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new ElectricCharge(Val, Exponent);
            }

            public static ElectricCharge SetExponent(ElectricCharge M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new ElectricCharge(v, e);
            }

            public string ToString(Quantifier Q, ElectricChargeUnit U)
            {
                switch (U)
                {
                    case ElectricChargeUnit.Coulomb:
                        s = Entity2String(this.val, this.exponent, Q) + " Coulomb";
                        break;
                }
                return s;
            }

            public void Print()
            {
                string s = ToString(Base, ElectricChargeUnit.Coulomb);
                Console.WriteLine(s);
            }
        }

        //CatalyticActivity
        //D2;   N^1 * T^-1
        //Base Unit: Katal
        //CatalyticActivity
        public struct CatalyticActivity
        {
            public decimal val;
            public int exponent;

            public CatalyticActivity(decimal Val, Quantifier Q, CatalyticActivityUnit U)
            {
                switch (U)
                {
                    case CatalyticActivityUnit.Katal:
                        v = Val;
                        e = (int)Q;
                        break;
                }
                val = v;
                exponent = e;
            }
            public CatalyticActivity(decimal Katal, int Exponent)
            {
                val = Katal;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(CatalyticActivity Katal)
            {
                return Katal.val * (10 ^ Katal.exponent);
            }
            public static explicit operator CatalyticActivity(decimal Katal)
            {
                return new CatalyticActivity(Katal, Base, CatalyticActivityUnit.Katal);
            }

            //explicit operators
            public static CatalyticActivity operator +(CatalyticActivity A, CatalyticActivity B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new CatalyticActivity(Val, Exponent);
            }
            public static CatalyticActivity operator -(CatalyticActivity A, CatalyticActivity B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new CatalyticActivity(Val, Exponent);
            }

            public static CatalyticActivity SetExponent(CatalyticActivity M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new CatalyticActivity(v, e);
            }

            public string ToString(Quantifier Q, CatalyticActivityUnit U)
            {
                switch (U)
                {
                    case CatalyticActivityUnit.Katal:
                        s = Entity2String(this.val, this.exponent, Q) + " Radian";
                        break;
                }
                return s;
            }

            public void Print()
            {
                string s = ToString(Base, CatalyticActivityUnit.Katal);
                Console.WriteLine(s);
            }
        }

        //AngularAcceleration
        //D2;   T^-2
        //Base Unit: RadPSecondPSecond
        public struct AngularAcceleration
        {
            public decimal val;
            public int exponent;

            public AngularAcceleration(decimal Val, Quantifier Q, AngularAccelerationUnit U)
            {
                switch (U)
                {
                    case AngularAccelerationUnit.RadPSecondPSecond:
                        v = Val;
                        e = (int)Q;
                        break;
                    case AngularAccelerationUnit.DegreesPSecondPSecond:
                        Multiplication(Val, (int)Q, DegreePSecondPSecond.val, DegreePSecondPSecond.exponent, out v, out e);
                        break;
                }
                val = v;
                exponent = e;
            }
            public AngularAcceleration(decimal RadPSecondPSecond, int Exponent)
            {
                val = RadPSecondPSecond;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(AngularAcceleration RadPSecondPSecond)
            {
                return RadPSecondPSecond.val * (10 ^ RadPSecondPSecond.exponent);
            }
            public static explicit operator AngularAcceleration(decimal RadPSecondPSecond)
            {
                return new AngularAcceleration(RadPSecondPSecond, Base, AngularAccelerationUnit.RadPSecondPSecond);
            }

            //explicit operators
            public static AngularAcceleration operator +(AngularAcceleration A, AngularAcceleration B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new AngularAcceleration(Val, Exponent);
            }
            public static AngularAcceleration operator -(AngularAcceleration A, AngularAcceleration B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new AngularAcceleration(Val, Exponent);
            }

            public static AngularAcceleration SetExponent(AngularAcceleration M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new AngularAcceleration(v, e);
            }

            public string ToString(Quantifier Q, AngularAccelerationUnit U)
            {
                switch (U)
                {
                    case AngularAccelerationUnit.RadPSecondPSecond:
                        s = Entity2String(this.val, this.exponent, Q) + " Radian / Second^2";
                        break;
                    case AngularAccelerationUnit.DegreesPSecondPSecond:
                        Division(this.val, this.exponent, DegreePSecondPSecond.val, DegreePSecondPSecond.exponent, out v, out e);
                        s = Entity2String(v, e, Q) + " Degree / Second^2";
                        break;
                }
                return s;
            }

            public void Print()
            {
                string s = ToString(Base, AngularAccelerationUnit.RadPSecondPSecond);
                Console.WriteLine(s);
            }
        }
    }
}
