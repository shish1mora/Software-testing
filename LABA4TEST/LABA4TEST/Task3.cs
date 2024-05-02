using System;
using System.Collections.Generic;
using System.Linq;

namespace LABA4TEST
{
    public class Task3
    {
        public string  SumOfDivided(int[] arr)
        {
            int maxNum = Math.Max(Math.Abs(arr.Min()), arr.Max());
            List<int> primes = new List<int>();
            for (int num = 2; num <= maxNum; num++)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(num);
                }
            }

            string result = "";
            foreach (int prime in primes)
            {
                int sum = 0;
                bool hasDivisibleNumber = false;
                foreach (int num in arr)
                {
                    if (num % prime == 0)
                    {
                        hasDivisibleNumber = true;
                        sum += num;
                    }
                }

                if (hasDivisibleNumber)
                {
                    result += "(" + prime + " " + sum + ")";
                }
            }

            return result;
        }
    }
}
