using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class Task_2_Tests_Decode
    {
        [TestMethod]
        public void Decode_equal_series_1()
        {
            var task = new Task2_2();

            string a = "10001111";

            string expected = "07";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_2()
        {
            var task = new Task2_2();

            string a = "001100001100001100001110001110001110011101110111001110001110001110001111001111001111001100001100001100";

            string expected = "444666333666777444";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_3()
        {
            var task = new Task2_2();

            string a = "01110111110001100100011000000110000011110011110111011100110000110001100110";

            string expected = "33198877334422";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_4()
        {
            var task = new Task2_2();

            string a = "001110001110101011110011010011010011000011000001100000011000";

            string expected = "660011554488";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_5()
        {
            var task = new Task2_2();

            string a = "00110000110000111100111100111100111100011000000110000001100000011000001100001100";

            string expected = "447777888844";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_6()
        {
            var task = new Task2_2();

            string a = "10000110000110";

            string expected = "082";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_7()
        {
            var task = new Task2_2();

            string a = "00110110";

            string expected = "50";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_8()
        {
            var task = new Task2_2();

            string a = "0110011001100111011101111010100110011001100011010011010011010111011101111100011001";

            string expected = "22233300022255533319";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_9()
        {
            var task = new Task2_2();

            string a = "001101001101001101111111001110001110001110001101001101001101001111001111001111111111";

            string expected = "555111666555777111";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_10()
        {
            var task = new Task2_2();

            string a = "0011100011100111011111000110010001100000011000001100001100";

            string expected = "6633198844";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_11()
        {
            var task = new Task2_2();

            string a = "1010100011110011110011110011110011110011111111110001100100011001000110010011010011010011011111111100011001000110000001100000011000011101110111";

            string expected = "00077777711199955511119888333";

            Assert.AreEqual(expected, task.Decode(a));
        }

        [TestMethod]
        public void Decode_equal_series_12()
        {
            var task = new Task2_2();

            string a = "0001100100011000";

            string expected = "98";

            Assert.AreEqual(expected, task.Decode(a));
        }
    }
    public class Task2_2
    {
        public string Decode(string inputStr)
        {
            Dictionary<string, char> encodingTable = new Dictionary<string, char>
            {
                {"10", '0'},
                {"11", '1'},
                {"0110", '2'},
                {"0111", '3'},
                {"001100", '4'},
                {"001101", '5'},
                {"001110", '6'},
                {"001111", '7'},
                {"00011000", '8'},
                {"00011001", '9'},
            };

            StringBuilder result = new StringBuilder();
            int i = 0;

            while (i < inputStr.Length)
            {
                int j = 1;
                while (i + j <= inputStr.Length && !encodingTable.ContainsKey(inputStr.Substring(i, j)))
                {
                    j++;
                }

                if (i + j <= inputStr.Length)
                {
                    result.Append(encodingTable[inputStr.Substring(i, j)]);
                    i += j;
                }
                else
                {
                    // Не найден подходящий код, возможно, ошибка в строке или таблице шифрования
                    throw new InvalidOperationException("Invalid input or encoding table.");
                }
            }

            return result.ToString();
        }
    }
}
