using Microsoft.VisualStudio.TestTools.UnitTesting;
using LABA4TEST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABA4TESTTests;

namespace LABA4TEST.Tests
{
    [TestClass()]
    public class Task1Tests
    {
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





        [TestMethod]
        public void Code_equal_series_1()
        {
            var task = new Task2();

            string a = "1119441933000055";

            string expected = "1111110001100100110000110011000110010111011110101010001101001101";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_2()
        {
            var task = new Task2();

            string a = "69";

            string expected = "00111000011001";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_3()
        {
            var task = new Task2();

            string a = "86";

            string expected = "00011000001110";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_4()
        {
            var task = new Task2();

            string a = "974";

            string expected = "00011001001111001100";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_5()
        {
            var task = new Task2();

            string a = "5191";

            string expected = "001101110001100111";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_6()
        {
            var task = new Task2();

            string a = "112222228855";

            string expected = "11110110011001100110011001100001100000011000001101001101";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_7()
        {
            var task = new Task2();

            string a = "55992266775519";

            string expected = "0011010011010001100100011001011001100011100011100011110011110011010011011100011001";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_8()
        {
            var task = new Task2();

            string a = "278";

            string expected = "011000111100011000";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_9()
        {
            var task = new Task2();

            string a = "4477221119";

            string expected = "0011000011000011110011110110011011111100011001";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_10()
        {
            var task = new Task2();

            string a = "29";

            string expected = "011000011001";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_11()
        {
            var task = new Task2();

            string a = "240";

            string expected = "011000110010";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_12()
        {
            var task = new Task2();

            string a = "55555511119333333444";

            string expected = "0011010011010011010011010011010011011111111100011001011101110111011101110111001100001100001100";

            Assert.AreEqual(expected, task.Code(a));
        }


        [TestMethod]
        public void Decode_equal_series_1()
        {
            var task = new Task2();

            string a = "10001111";

            string expected = "07";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_2()
        {
            var task = new Task2();

            string a = "001100001100001100001110001110001110011101110111001110001110001110001111001111001111001100001100001100";

            string expected = "444666333666777444";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_3()
        {
            var task = new Task2();

            string a = "01110111110001100100011000000110000011110011110111011100110000110001100110";

            string expected = "33198877334422";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_4()
        {
            var task = new Task2();

            string a = "001110001110101011110011010011010011000011000001100000011000";

            string expected = "660011554488";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_5()
        {
            var task = new Task2();

            string a = "00110000110000111100111100111100111100011000000110000001100000011000001100001100";

            string expected = "447777888844";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_6()
        {
            var task = new Task2();

            string a = "10000110000110";

            string expected = "082";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_7()
        {
            var task = new Task2();

            string a = "00110110";

            string expected = "50";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_8()
        {
            var task = new Task2();

            string a = "0110011001100111011101111010100110011001100011010011010011010111011101111100011001";

            string expected = "22233300022255533319";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_9()
        {
            var task = new Task2();

            string a = "001101001101001101111111001110001110001110001101001101001101001111001111001111111111";

            string expected = "555111666555777111";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_10()
        {
            var task = new Task2();

            string a = "0011100011100111011111000110010001100000011000001100001100";

            string expected = "6633198844";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_11()
        {
            var task = new Task2();

            string a = "1010100011110011110011110011110011110011111111110001100100011001000110010011010011010011011111111100011001000110000001100000011000011101110111";

            string expected = "00077777711199955511119888333";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_12()
        {
            var task = new Task2();

            string a = "0001100100011000";

            string expected = "98";

            Assert.AreEqual(expected, task.Decode(a));
        }



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
}