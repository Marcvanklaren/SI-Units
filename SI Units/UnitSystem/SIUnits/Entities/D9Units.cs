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
    class D9Units
    {
        public static decimal v;
        public static int e;
        
        //Capacitance
        //D9;   M^-1 * L^-2 * T^4 * I^2
        //Base Unit: Farad
        public struct Capacitance
        {
            public decimal val;
            public int exponent;

            public Capacitance(decimal Val, Quantifier Q, CapacitanceUnit U)
            {
                switch (U)
                {
                    case CapacitanceUnit.Farad:
                        v = Val;
                        e = (int)Q;
                        break;
                }
                val = v;
                exponent = e;
            }
            public Capacitance(decimal Farad, int Exponent)
            {
                val = Farad;
                exponent = Exponent;
            }

            //auto cast to decimal, float, BigInt
            public static explicit operator decimal(Capacitance Farad)
            {
                return Farad.val * (10 ^ Farad.exponent);
            }
            public static explicit operator Capacitance(decimal Farad)
            {
                return new Capacitance(Farad, Base, CapacitanceUnit.Farad);
            }

            //explicit operators
            public static Capacitance operator +(Capacitance A, Capacitance B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (A.val * Factor) + B.val;
                return new Capacitance(Val, Exponent);
            }
            public static Capacitance operator -(Capacitance A, Capacitance B)
            {
                int Exponent = A.exponent - B.exponent;
                long Factor = 1;
                if (Exponent != 0)
                    Factor = 10 ^ Exponent;
                decimal Val = (-A.val * Factor) + B.val;
                return new Capacitance(Val, Exponent);
            }

            public static Capacitance SetExponent(Capacitance M)
            {
                decimal v = M.val;
                int e = M.exponent;
                Functions.Entities.SetExponent(ref v, ref e);
                return new Capacitance(v, e);
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
