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
    class D4Units
    {
        public static decimal v;
        public static int e;
        
        //Density
        //D4;   M^1 * L^-3 (* 10^-3)
        //Base Unit: GramPcm3
        //Density
        public struct Density
        {
            public decimal val;
            public int exponent;

            public Density(decimal Val, Quantifier Q, DensityUnit U)
            {
                switch (U)
                {
                    case DensityUnit.GramPCm3:
                        v = Val;
                        e = (int)Q;
                        break;
                    case DensityUnit.GramPLiter:
                        Multiplication(Val, (int)Q, GramPLiter.val, GramPLiter.exponent, out v, out e);
                        break;
                }
                val = v;
                exponent = e;
            }
            public Density(decimal GramPCm3, int Exponent)
            {
                val = GramPCm3;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Density GramPCm3)
            {
                return GramPCm3.val * (10 ^ GramPCm3.exponent);
            }
            public static explicit operator Density(decimal GramPCm3)
            {
                return new Density(GramPCm3, Base, DensityUnit.GramPCm3);
            }

            //explicit operators
            public static Density operator +(Density A, Density B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new Density(Val, Exponent);
            }
            public static Density operator -(Density A, Density B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new Density(Val, Exponent);
            }

            public static Density SetExponent(Density M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new Density(v, e);
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

        //Force
        //D4;   M^1 * L^1 * T^-2 (* 10^-3)
        //Base Unit: Newton
        //Force
        public struct Force
        {
            public decimal val;
            public int exponent;

            public Force(decimal Val, Quantifier Q, ForceUnit U)
            {
                switch (U)
                {
                    case ForceUnit.Newton:
                        v = Val;
                        e = (int)Q;
                        break;
                }
                val = v;
                exponent = e;
            }
            public Force(decimal Newton, int Exponent)
            {
                val = Newton;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Force Newton)
            {
                return Newton.val * (10 ^ Newton.exponent);
            }
            public static explicit operator Force(decimal Newton)
            {
                return new Force(Newton, Base, ForceUnit.Newton);
            }

            //explicit operators
            public static Force operator +(Force A, Force B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new Force(Val, Exponent);
            }
            public static Force operator -(Force A, Force B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new Force(Val, Exponent);
            }

            public static Force SetExponent(Force M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new Force(v, e);
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

        //Pressure
        //D4;   M^1 * L^-1 * T^-2
        //Base Unit: Pascal
        public struct Pressure
        {
            public decimal val;
            public int exponent;

            public Pressure(decimal Val, Quantifier Q, PressureUnit U)
            {
                switch (U)
                {
                    case PressureUnit.Pascal:
                        v = Val;
                        e = (int)Q;
                        break;
                }
                val = v;
                exponent = e;
            }
            public Pressure(decimal Pascal, int Exponent)
            {
                val = Pascal;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Pressure Pascal)
            {
                return Pascal.val * (10 ^ Pascal.exponent);
            }
            public static explicit operator Pressure(decimal Pascal)
            {
                return new Pressure(Pascal, Base, PressureUnit.Pascal);
            }

            //explicit operators
            public static Pressure operator +(Pressure A, Pressure B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new Pressure(Val, Exponent);
            }
            public static Pressure operator -(Pressure A, Pressure B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new Pressure(Val, Exponent);
            }

            public static Pressure SetExponent(Pressure M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new Pressure(v, e);
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

        //AbsorbedDose
        //D4;   L^2 * T^-2
        //Base Unit: Gray
        public struct AbsorbedDose
        {
            public decimal val;
            public int exponent;

            public AbsorbedDose(decimal Val, Quantifier Q, AbsorbedDoseUnit U)
            {
                switch (U)
                {
                    case AbsorbedDoseUnit.Gray:
                        v = Val;
                        e = (int)Q;
                        break;
                }
                val = v;
                exponent = e;
            }
            public AbsorbedDose(decimal Gray, int Exponent)
            {
                val = Gray;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(AbsorbedDose Gray)
            {
                return Gray.val * (10 ^ Gray.exponent);
            }
            public static explicit operator AbsorbedDose(decimal Gray)
            {
                return new AbsorbedDose(Gray, Base, AbsorbedDoseUnit.Gray);
            }

            //explicit operators
            public static AbsorbedDose operator +(AbsorbedDose A, AbsorbedDose B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new AbsorbedDose(Val, Exponent);
            }
            public static AbsorbedDose operator -(AbsorbedDose A, AbsorbedDose B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new AbsorbedDose(Val, Exponent);
            }

            public static AbsorbedDose SetExponent(AbsorbedDose M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new AbsorbedDose(v, e);
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

        //DoseEquivalent
        //D4;   L^2 * T^-2
        //Base Unit: Sievert
        public struct DoseEquivalent
        {
            public decimal val;
            public int exponent;

            public DoseEquivalent(decimal Val, Quantifier Q, DoseEquivalentUnit U)
            {
                switch (U)
                {
                    case DoseEquivalentUnit.Sievert:
                        v = Val;
                        e = (int)Q;
                        break;
                }
                val = v;
                exponent = e;
            }
            public DoseEquivalent(decimal Sievert, int Exponent)
            {
                val = Sievert;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(DoseEquivalent Sievert)
            {
                return Sievert.val * (10 ^ Sievert.exponent);
            }
            public static explicit operator DoseEquivalent(decimal Sievert)
            {
                return new DoseEquivalent(Sievert, Base, DoseEquivalentUnit.Sievert);
            }

            //explicit operators
            public static DoseEquivalent operator +(DoseEquivalent A, DoseEquivalent B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new DoseEquivalent(Val, Exponent);
            }
            public static DoseEquivalent operator -(DoseEquivalent A, DoseEquivalent B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new DoseEquivalent(Val, Exponent);
            }

            public static DoseEquivalent SetExponent(DoseEquivalent M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new DoseEquivalent(v, e);
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

        //MagneticFluxDensity
        //D4;   M^1 * T^-2 * I^-1
        //Base Unit: Tesla
        public struct MagneticFluxDensity
        {
            public decimal val;
            public int exponent;

            public MagneticFluxDensity(decimal Val, Quantifier Q, MagneticFluxDensityUnit U)
            {
                switch (U)
                {
                    case MagneticFluxDensityUnit.Tesla:
                        v = Val;
                        e = (int)Q;
                        break;
                }
                val = v;
                exponent = e;
            }
            public MagneticFluxDensity(decimal Tesla, int Exponent)
            {
                val = Tesla;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(MagneticFluxDensity Tesla)
            {
                return Tesla.val * (10 ^ Tesla.exponent);
            }
            public static explicit operator MagneticFluxDensity(decimal Tesla)
            {
                return new MagneticFluxDensity(Tesla, Base, MagneticFluxDensityUnit.Tesla);
            }

            //explicit operators
            public static MagneticFluxDensity operator +(MagneticFluxDensity A, MagneticFluxDensity B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new MagneticFluxDensity(Val, Exponent);
            }
            public static MagneticFluxDensity operator -(MagneticFluxDensity A, MagneticFluxDensity B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new MagneticFluxDensity(Val, Exponent);
            }

            public static MagneticFluxDensity SetExponent(MagneticFluxDensity M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new MagneticFluxDensity(v, e);
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
