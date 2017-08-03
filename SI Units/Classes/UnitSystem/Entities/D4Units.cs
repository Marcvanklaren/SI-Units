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
    class D4Units
    {
        //Density
        //D4;   M^1 * L^-3 [*10^4]
        //Base Unit: GramPcm3
        //Density
        public struct Density
        {
            public decimal val;
            public int exponent;

            public Density(decimal Val, Quantifier Q, DensityUnit U)
            {
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public Density(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Density d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator Density(decimal d)
            {
                return new Density(d, Base, DensityUnit.GramPcm3);
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
        //D4;   M^1 * D^1 * T^-2
        //Base Unit: Newton (KiloGram * (Meter/Second2)) [*10^-3]
        //Force
        public struct Force
        {
            public decimal val;
            public int exponent;

            public Force(decimal Val, Quantifier Q, ForceUnit U)
            {
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public Force(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Force d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator Force(decimal d)
            {
                return new Force(d, Base, ForceUnit.Newton);
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
        //D4;   M^1 * L^1 * T^-2 * L^-2
        //Base Unit: Pascal
        public struct Pressure
        {
            public decimal val;
            public int exponent;

            public Pressure(decimal Val, Quantifier Q, PressureUnit U)
            {
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public Pressure(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Pressure d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator Pressure(decimal d)
            {
                return new Pressure(d, Base, PressureUnit.Pascal);
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
        //D4;   M^1 * L^2 * T^-2 * M^-1
        //Base Unit: Gray
        public struct AbsorbedDose
        {
            public decimal val;
            public int exponent;

            public AbsorbedDose(decimal Val, Quantifier Q, AbsorbedDoseUnit U)
            {
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public AbsorbedDose(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(AbsorbedDose d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator AbsorbedDose(decimal d)
            {
                return new AbsorbedDose(d, Base, AbsorbedDoseUnit.Gray);
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
        //D4;   M^1 * L^2 * T^-2 * M^-1
        //Base Unit: Sievert
        public struct DoseEquivalent
        {
            public decimal val;
            public int exponent;

            public DoseEquivalent(decimal Val, Quantifier Q, DoseEquivalentUnit U)
            {
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public DoseEquivalent(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(DoseEquivalent d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator DoseEquivalent(decimal d)
            {
                return new DoseEquivalent(d, Base, DoseEquivalentUnit.Sievert);
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
                val = Val;
                exponent = (int)Q + (int)U;
            }
            public MagneticFluxDensity(decimal Val, int Exponent)
            {
                val = Val;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(MagneticFluxDensity d)
            {
                return d.val * (10 ^ d.exponent);
            }
            public static explicit operator MagneticFluxDensity(decimal d)
            {
                return new MagneticFluxDensity(d, Base, MagneticFluxDensityUnit.Tesla);
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
