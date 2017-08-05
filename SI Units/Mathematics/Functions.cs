using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Physics.Mathematics.Constants.MathematicalConstants;

namespace Physics.Mathematics
{
    public class Functions
    {
        public class Entities
        {
            public static string Entity2String(decimal Val, int Exp)
            {
                string s = Val.ToString() + " * 10^" + Exp.ToString();
                return s;
            }

            public static void SetExponent(ref decimal Val, ref int Exp)
            {
                if (Val != 0)
                {
                    decimal Abs = Math.Abs(Val);
                    while (Abs > 10)
                    {
                        Abs = Abs / 10;
                        Val = Val / 10;
                        Exp++;
                    }
                    while (Abs < (decimal)0.1)
                    {
                        Abs = Abs * 10;
                        Val = Val * 10;
                        Exp--;
                    }
                }
            }

            public static bool IsOdd(int num)
            {
                int i = 0;
                bool odd = false;

                while (i != num)
                {
                    odd = !odd;
                    i = i + 1;
                }

                return odd;
            }

            //Divide, Multiply
            public static void Division(decimal ValL, int ExpL, decimal ValR, int ExpR, out decimal Value, out int Exponent)
            {
                Value = ValL / ValR;
                Exponent = ExpL - ExpR;
                SetExponent(ref Value, ref Exponent);
            }
            public static void Multiplication(decimal ValL, int ExpL, decimal ValR, int ExpR, out decimal Value, out int Exponent)
            {
                Value = ValL * ValR;
                Exponent = ExpL + ExpR;
                SetExponent(ref Value, ref Exponent);
            }

            //Power2, SquareRoot
            public static void Power2(decimal Val, int Exp, out decimal Value, out int Exponent)
            {
                Value = Val * Val;
                Exponent = Exp * 2;
            }

            public static void SquareRoot(decimal Val, int Exp, out decimal Value, out int Exponent)
            {
                Value = Val;
                Exponent = Exp;
                if (IsOdd(Exponent))
                {
                    Value = Value * 10;
                    Exponent--;
                }
                Value = (decimal)Math.Sqrt((double)Value);
            }

            //convert to Quantity
            public static void ToQuantity(decimal Val, int Exp, Quantifier Q, out decimal Value, out int Exponent)
            {
                Value = Val;
                Exponent = Exp - (int)Q;
            }
        }
    }
}
