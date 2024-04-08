using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject1
{
    [TestClass]
    public class Task_1_Tests
    {
        [TestMethod]
        public void ArrayDiff_equal_series_1()
        {
            var task = new Task1();

            int[] a = new int[] { 1, 2 };
            int[] b = new int[] { 1 };

            int[] expected = new int[] { 2 };

            CollectionAssert.AreEqual(expected, task.ArrayDiff(a, b));
        }

        [TestMethod]
        public void ArrayDiff_equal_series_2()
        {
            var task = new Task1();

            int[] a = new int[] { 1, 2, 2 };
            int[] b = new int[] { 1 };

            int[] expected = new int[] { 2, 2 };

            CollectionAssert.AreEqual(expected, task.ArrayDiff(a, b));
        }

        [TestMethod]
        public void ArrayDiff_equal_series_3()
        {
            var task = new Task1();

            int[] a = new int[] { 1, 2, 2 };
            int[] b = new int[] { 2 };

            int[] expected = new int[] { 1 };

            CollectionAssert.AreEqual(expected, task.ArrayDiff(a, b));
        }

        [TestMethod]
        public void ArrayDiff_equal_series_4()
        {
            var task = new Task1();

            int[] a = new int[] { 1, 2, 2 };
            int[] b = new int[] { };

            int[] expected = new int[] { 1, 2, 2 };

            CollectionAssert.AreEqual(expected, task.ArrayDiff(a, b));
        }

        [TestMethod]
        public void ArrayDiff_equal_series_5()
        {
            var task = new Task1();

            int[] a = new int[] { };
            int[] b = new int[] { 1, 2 };

            int[] expected = new int[] { };

            CollectionAssert.AreEqual(expected, task.ArrayDiff(a, b));
        }

        [TestMethod]
        public void ArrayDiff_equal_series_6()
        {
            var task = new Task1();

            int[] a = new int[] { 1, 2, 3 };
            int[] b = new int[] { 1, 2 };

            int[] expected = new int[] { 3 };

            CollectionAssert.AreEqual(expected, task.ArrayDiff(a, b));
        }

    }
    public class Task1
    {
        public int[] ArrayDiff(int[] a, int[] b)
        {
            if (a.Length == 0 || b.Length == 0)
            {
                return a;
            }

            List<int> result = new List<int>();

            foreach (var element in a)
            {
                if (!b.Contains(element))
                {
                    result.Add(element);
                }
            }

            return result.ToArray();
        }
    }
}
