using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace TestProject1
{
    [TestClass]
    public class Task_2_Tests_Code
    {
        [TestMethod]
        public void Code_equal_series_1()
        {
            var task = new Task2_1();

            string a = "1119441933000055";

            string expected = "1111110001100100110000110011000110010111011110101010001101001101";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_2()
        {
            var task = new Task2_1();

            string a = "69";

            string expected = "00111000011001";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_3()
        {
            var task = new Task2_1();

            string a = "86";

            string expected = "00011000001110";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_4()
        {
            var task = new Task2_1();

            string a = "974";

            string expected = "00011001001111001100";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_5()
        {
            var task = new Task2_1();

            string a = "5191";

            string expected = "001101110001100111";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_6()
        {
            var task = new Task2_1();

            string a = "112222228855";

            string expected = "11110110011001100110011001100001100000011000001101001101";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_7()
        {
            var task = new Task2_1();

            string a = "55992266775519";

            string expected = "0011010011010001100100011001011001100011100011100011110011110011010011011100011001";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_8()
        {
            var task = new Task2_1();

            string a = "278";

            string expected = "011000111100011000";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_9()
        {
            var task = new Task2_1();

            string a = "4477221119";

            string expected = "0011000011000011110011110110011011111100011001";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_10()
        {
            var task = new Task2_1();

            string a = "29";

            string expected = "011000011001";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_11()
        {
            var task = new Task2_1();

            string a = "240";

            string expected = "011000110010";

            Assert.AreEqual(expected, task.Code(a));
        }

        [TestMethod]
        public void Code_equal_series_12()
        {
            var task = new Task2_1();

            string a = "55555511119333333444";

            string expected = "0011010011010011010011010011010011011111111100011001011101110111011101110111001100001100001100";

            Assert.AreEqual(expected, task.Code(a));
        }

    }
    public class Task2_1
    {
            public string Code(string input)
            {
                string result = "";

                foreach (char c in input)
                {
                    int digit = int.Parse(c.ToString());
                    string binaryRepresentation = Convert.ToString(digit, 2);
                    int k = binaryRepresentation.Length;

                    // Append k-1 zeros followed by "1" to the result
                    result += new string('0', k - 1) + '1';

                    // Append the binary representation of the digit to the result
                    result += binaryRepresentation;
                }

                return result;
            }

    }
}
