using System;

namespace Sandbox.ThirtyDaysOfCode.Day19
{
    public class Calculator : IAdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
