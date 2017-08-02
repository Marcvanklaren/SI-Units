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
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public Area(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Area d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator Area(decimal d)
            {
                return new Area(d, Base, AreaUnit.Meter2);
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
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public LinearVelocity(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(LinearVelocity d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator LinearVelocity(decimal d)
            {
                return new LinearVelocity(d, Base, LinearVelocityUnit.MeterPSecond);
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
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public ElectricCharge(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(ElectricCharge d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator ElectricCharge(decimal d)
            {
                return new ElectricCharge(d, Base, ElectricChargeUnit.Coulomb);
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

        //CatalyticActivity
        //D2;   M^1 * T^-1
        //Base Unit: Katal
        //CatalyticActivity
        public struct CatalyticActivity
        {
            public decimal val;
            public int exponent;

            public CatalyticActivity(decimal Val, Quantifier Q, CatalyticActivityUnit U)
            {
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public CatalyticActivity(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(CatalyticActivity d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator CatalyticActivity(decimal d)
            {
                return new CatalyticActivity(d, Base, CatalyticActivityUnit.Katal);
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
