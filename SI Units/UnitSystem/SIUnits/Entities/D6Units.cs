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
    public class D6Units
    {
        public static decimal v;
        public static int e;
        
        //Power
        //D6;  M^1 * L^2 * T^-3
        //Base Unit: Watt
        public struct Power
        {
            public decimal val;
            public int exponent;

            public Power(decimal Val, Quantifier Q, PowerUnit U)
            {
                switch (U)
                {
                    case PowerUnit.Watt:
                        v = Val;
                        e = (int)Q;
                        break;
                }
                val = v;
                exponent = e;
            }
            public Power(decimal Watt, int Exponent)
            {
                val = Watt;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Power Watt)
            {
                return Watt.val * (10 ^ Watt.exponent);
            }
            public static explicit operator Power(decimal Watt)
            {
                return new Power(Watt, Base, PowerUnit.Watt);
            }

            //explicit operators
            public static Power operator +(Power A, Power B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new Power(Val, Exponent);
            }
            public static Power operator -(Power A, Power B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new Power(Val, Exponent);
            }

            public static Power SetExponent(Power M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new Power(v, e);
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

        //MagneticFlux
        //D6;   M^1 * L^2 * T^-2 * I^-1
        //Base Unit: Weber
        public struct MagneticFlux
        {
            public decimal val;
            public int exponent;

            public MagneticFlux(decimal Val, Quantifier Q, MagneticFluxUnit U)
            {
                switch (U)
                {
                    case MagneticFluxUnit.Weber:
                        v = Val;
                        e = (int)Q;
                        break;
                }
                val = v;
                exponent = e;
            }
            public MagneticFlux(decimal Weber, int Exponent)
            {
                val = Weber;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(MagneticFlux Weber)
            {
                return Weber.val * (10 ^ Weber.exponent);
            }
            public static explicit operator MagneticFlux(decimal Weber)
            {
                return new MagneticFlux(Weber, Base, MagneticFluxUnit.Weber);
            }

            //explicit operators
            public static MagneticFlux operator +(MagneticFlux A, MagneticFlux B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new MagneticFlux(Val, Exponent);
            }
            public static MagneticFlux operator -(MagneticFlux A, MagneticFlux B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new MagneticFlux(Val, Exponent);
            }

            public static MagneticFlux SetExponent(MagneticFlux M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new MagneticFlux(v, e);
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
