/*
* 10. Write a program to calculate the sum (with accuracy of 0.001):
* 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
*/

using System;
using System.Linq;

class SumOfFractions
{
    static void Main()
    {
        decimal expression = 1;
        int maxDenominator = 10;
        

        Console.Write("1 ");
        for (int denominator = 2; denominator <= maxDenominator; denominator++)
        {
            if (denominator % 2 == 0)
            {
                Console.Write("+ 1/{0} ", denominator);
                expression = expression + 1m / denominator;
            }
            else
            {
                Console.Write("- 1/{0} ", denominator);
                expression = expression - 1m / denominator;
            }
        }

        Console.Write("= {0:F3}\n\n", expression);
    }
}