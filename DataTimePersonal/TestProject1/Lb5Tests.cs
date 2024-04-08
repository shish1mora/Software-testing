using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    class Lb5Tests
    {
        [TestClass]
        public class Task_1_Tests
        {
            [TestMethod]
            public void NormalTime()
            {
                string input= "00:01";

                double actual = Lb5Class.ConvertToMinutes(input);

                double expected = 1;

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void MinTime()
            {
                string input = "00:00";

                double actual = Lb5Class.ConvertToMinutes(input);

                double expected = 0;

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void MaxTime()
            {
                string input = "00:01";

                double actual = Lb5Class.ConvertToMinutes(input);

                double expected = 1;

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void AvgTime()
            {
                string input = "00:01";

                double actual = Lb5Class.ConvertToMinutes(input);

                double expected = 1;

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void DataToChart()
            {
                string input = "00:01";

                double actual = Lb5Class.ConvertToMinutes(input);

                double expected = 1;

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void DataToChartBig()
            {
                string input = "00:01";

                double actual = Lb5Class.ConvertToMinutes(input);

                double expected = 1;

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void DataToChartMin()
            {
                string input = "00:01";

                double actual = Lb5Class.ConvertToMinutes(input);

                double expected = 1;

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void DataToChartMax()
            {
                string input = "00:01";

                double actual = Lb5Class.ConvertToMinutes(input);

                double expected = 1;

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void DataToChartAvg()
            {
                string input = "00:01";

                double actual = Lb5Class.ConvertToMinutes(input);

                double expected = 1;

                Assert.AreEqual(expected, actual);
            }

        }
        public class Lb5Class
        {
            public static double ConvertToMinutes(string timeString)
            {
                // Разбиваем строку времени на часы и минуты
                string[] timeParts = timeString.Split(':');

                // Парсим часы и минуты из строкового представления в числа
                if (timeParts.Length == 2 && int.TryParse(timeParts[0], out int hours) && int.TryParse(timeParts[1], out int minutes))
                {
                    // Преобразуем часы в минуты и складываем с минутами
                    return hours * 60 + minutes;
                }
                else
                {
                    // В случае ошибки ввода возвращаем значение, которое можно обработать
                    return -1;
                }
            }

            public static string RemoveDecimalPart(string input)
            {
                // Находим индекс точки в строке
                int dotIndex = input.IndexOf('.');

                // Если точка не найдена, возвращаем исходную строку
                if (dotIndex == -1)
                {
                    return input;
                }

                // Обрезаем строку до точки, включительно
                string result = input.Substring(0, dotIndex + 1);

                return result;
            }
        }
    }
}
