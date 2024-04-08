using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject1
{
    [TestClass]
    public class Task_3_Tests
    {
        [TestMethod]
        public void SumOfDividedTests_simple_equal()
        {
            var task = new Task3();

            int[] lst = new int[] { 12, 15 };

            string expected = "(2 12)(3 27)(5 15)";

            Assert.AreEqual(expected, task.SumOfDivided(lst));
        }

        [TestMethod]
        public void SumOfDividedTests_simple_not_equal()
        {
            var task = new Task3();

            int[] lst = new int[] { 12, 15, 4 };

            string expected = "(2 15)(3 27)(5 15)";

            Assert.AreNotEqual(expected, task.SumOfDivided(lst));
        }

        [TestMethod]
        public void SumOfDividedTests_hard_one()
        {
            var task = new Task3();

            int[] lst = new int[] { 173471 };

            string expected = "(41 173471)(4231 173471)";

            Assert.AreEqual(expected, task.SumOfDivided(lst));
        }

        [TestMethod]
        public void SumOfDividedTests_hard_series_1()
        {
            var task = new Task3();

            int[] lst = new int[] { 15, 21, 24, 30, 45 };

            string expected = "(2 54)(3 135)(5 90)(7 21)";

            Assert.AreEqual(expected, task.SumOfDivided(lst));
        }

        [TestMethod]
        public void SumOfDividedTests_hard_series_2()
        {
            var task = new Task3();

            int[] lst = new int[] { 107, 158, 204, 100, 118, 123, 126, 110, 116, 100 };

            string expected = "(2 1032)(3 453)(5 310)(7 126)(11 110)(17 204)(29 116)(41 123)(59 118)(79 158)(107 107)";

            Assert.AreEqual(expected, task.SumOfDivided(lst));
        }

        [TestMethod]
        public void SumOfDividedTests_hard_series_3()
        {
            var task = new Task3();

            int[] lst = new int[] { -29804, -4209, -28265, -72769, -31744 };

            string expected = "(2 -61548)(3 -4209)(5 -28265)(23 -4209)(31 -31744)(53 -72769)(61 -4209)(1373 -72769)(5653 -28265)(7451 -29804)";

            Assert.AreEqual(expected, task.SumOfDivided(lst));
        }

        [TestMethod]
        public void SumOfDividedTests_hard_series_4()
        {
            var task = new Task3();

            int[] lst = new int[] { 17, -17, 51, -51 };

            string expected = "(3 0)(17 0)";

            Assert.AreEqual(expected, task.SumOfDivided(lst));
        }

        [TestMethod]
        public void SumOfDividedTests_hard_series_5()
        {
            var task = new Task3();

            int[] lst = new int[] { 100000, 1000000 };

            string expected = "(2 1100000)(5 1100000)";

            Assert.AreEqual(expected, task.SumOfDivided(lst));
        }

        [TestMethod]
        public void SumOfDividedTests_simple_seris_6()
        {
            var task = new Task3();

            int[] lst = new int[] { 12, 15, 43 };

            string expected = "(2 12)(3 27)(5 15)(43 43)";

            Assert.AreEqual(expected, task.SumOfDivided(lst));
        }
    }
    public class Task3
    {
        public string SumOfDivided(int[] lst)
        {
            if (lst == null || lst.Length == 0)
            {
                return "";
            }

            int max = Math.Abs(lst.Max());
            List<int> primes = GetPrimes(max);

            List<string> result = new List<string>();

            foreach (int prime in primes)
            {
                int sum = lst.Where(x => x % prime == 0).Sum();
                if (sum != 0)
                {
                    result.Add($"({prime} {sum})");
                }
            }

            return result.Any() ? string.Join("", result) : "";
        }

        private List<int> GetPrimes(int n)
        {
            List<int> primes = new List<int>();
            bool[] isPrime = new bool[n + 1];

            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true;
            }

            for (int p = 2; p * p <= n; p++)
            {
                if (isPrime[p])
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        isPrime[i] = false;
                    }
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                {
                    primes.Add(i);
                }
            }

            return primes;
        }
    }
}
