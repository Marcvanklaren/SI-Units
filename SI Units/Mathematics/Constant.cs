using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Physics.Mathematics.Functions.Entities;

namespace Physics.Mathematics
{
    public class Constant
    {
        public decimal val;
        public int exponent;

        public Constant(decimal Val, int Exponent)
        {
            val = Val;
            exponent = Exponent;
        }

        //auto cast to decimal, float, BigInt
        public static explicit operator decimal(Constant d)
        {
            return d.val * (10 ^ d.exponent);
        }
        public static explicit operator Constant(decimal d)
        {
            return new Constant(d, 0);
        }

        //explicit operators
        public static Constant operator +(Constant A, Constant B)
        {
            int Exponent = A.exponent - B.exponent;
            long Factor = 1;
            if (Exponent != 0)
                Factor = 10 ^ Exponent;
            decimal Val = (A.val * Factor) + B.val;
            return new Constant(Val, Exponent);
        }
        public static Constant operator -(Constant A, Constant B)
        {
            int Exponent = A.exponent - B.exponent;
            long Factor = 1;
            if (Exponent != 0)
                Factor = 10 ^ Exponent;
            decimal Val = (-A.val * Factor) + B.val;
            return new Constant(Val, Exponent);
        }

        public static Constant SetExponent(Constant M)
        {
            decimal v = M.val;
            int e = M.exponent;
            Functions.Entities.SetExponent(ref v, ref e);
            return new Constant(v, e);
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
