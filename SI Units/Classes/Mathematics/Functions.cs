using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
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
        }
    }
}
