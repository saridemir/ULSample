using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace UL.Core.ULMath
{
    public static class FactorialExtension
    {
        public static T Fak<T>(this T number) where T : INumber<T>
        {
            if (T.IsInteger(number) && T.IsPositive(number))
            {

                /* //stack overflow problem
                 if (number > T.One)
                {
                    checked
                    {
                        return (number * (number - T.One)) * Fak<T>(number - (T.One + T.One));
                    }
                }
                else
                {
                    return T.One;
                }*/
             
                if (number == T.Zero) return T.One;
                var n = T.One;
                for (T i = number; i > T.One; i--)
                {
                    checked
                    {
                        n *= i;
                    }
                }
                return n;
            }
            else
            {
                throw new Exception("Number should be positive");
            }
        }        
    }
}


