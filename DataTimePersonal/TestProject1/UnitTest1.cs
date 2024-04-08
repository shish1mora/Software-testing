using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstTest()
        {
            DataTimeLigic dt = new DataTimeLigic();

            int expected = 2023;

            int result = dt.GetYears();
            Assert.AreEqual(expected, result); // Пример утверждения
        }

        [TestMethod]
        public void AddYears_UpdatesYears()
        {
            DataTimeLigic date = new DataTimeLigic();
            date.AddYears(5);
            Assert.AreEqual(2028, date.GetYears());
        }

        [TestMethod]
        public void SubtractYears_UpdatesYears()
        {
            DataTimeLigic date = new DataTimeLigic();
            date.SubtractYears(3);
            Assert.AreEqual(2020, date.GetYears());
        }

        [TestMethod]
        public void AddMonths_UpdatesMonths()
        {
            DataTimeLigic date = new DataTimeLigic();
            date.AddMonths(8);
            Assert.AreEqual(18, date.GetMonths());
        }

        [TestMethod]
        public void SubtractMonths_UpdatesMonths()
        {
            DataTimeLigic date = new DataTimeLigic();
            date.SubtractMonths(4);
            Assert.AreEqual(7, date.GetMonths());
        }

        [TestMethod]
        public void SetDate_UpdatesDate()
        {
            DataTimeLigic date = new DataTimeLigic();
            date.SetDate(2023, 11, 1);
            Assert.AreEqual(2023, date.GetYears());
            Assert.AreEqual(11, date.GetMonths());
            Assert.AreEqual(1, date.GetDays());
        }

        [TestMethod]
        public void GetDate_ReturnsDate()
        {
            DataTimeLigic date = new DataTimeLigic();
            date.SetDate(2023, 11, 1);
            string result = date.GetDate();
            Assert.AreEqual("2023 год 11 месяцев 1 дней", result);
        }

        [TestMethod]
        public void MultiplyBy_MultipliesValues()
        {
            DataTimeLigic date = new DataTimeLigic();
            date.MultiplyBy(2);
            Assert.AreEqual(4046, date.GetYears());
        }

        [TestMethod]
        public void DivideBy_DividesValues()
        {
            DataTimeLigic date = new DataTimeLigic();
            date.SetDate(2023, 12, 15);
            date.DivideBy(3);
            Assert.AreEqual(674, date.GetYears());
        }

        [TestMethod]
        public void CompareDates_ReturnsDifference()
        {
            DataTimeLigic date1 = new DataTimeLigic();
            DataTimeLigic date2 = new DataTimeLigic();
            string result = date1.CompareDates(date2);
            Assert.AreEqual("0 год 0 месяцев 0 дней 0 часов 0 минут 0 секунд", result);
        }
    }

    public class DataTimeLigic
    {
        private int years;
        private int months;
        private int days;
        private int hours;
        private int minutes;
        private int seconds;

        public DataTimeLigic()
        {
            DateTime now = DateTime.Now;
            years = now.Year;
            months = now.Month;
            days = now.Day;
            hours = now.Hour;
            minutes = now.Minute;
            seconds = now.Second;
        }

        public DataTimeLigic(DateTime date)
        {
            years = date.Year;
            months = date.Month;
            days = date.Day;
            hours = date.Hour;
            minutes = date.Minute;
            seconds = date.Second;
        }

        public void SetDate(int newYears, int newMonths, int newDays)
        {
            years = newYears;
            months = newMonths;
            days = newDays;
        }

        public int GetYears()
        {
            return years;
        }

        public int GetMonths()
        {
            return months;
        }

        public int GetDays()
        {
            return days;
        }

        public int GetHours()
        {
            return hours;
        }

        public int GetMinutes()
        {
            return minutes;
        }

        public int GetSeconds()
        {
            return seconds;
        }

        public void AddYears(int value)
        {
            years += value;
        }

        public void AddMonths(int value)
        {
            if (months + value <= 12)
                months += value;
            else
            {
                years += (value + months) / 12;
                months += (value + months) % 12;
            }
        }

        public void AddDays(int value)
        {
            if (days + value <= 31)
                days += value;
            else
            {
                months += (value + days) / 31;
                days += (value + days) % 31;
            }
        }

        public void AddHours(int value)
        {
            if (hours + value <= 23)
                hours += value;
            else
            {
                days += (value + hours) / 23;
                hours += (value + hours) % 23;
            }
        }

        public void AddMinutes(int value)
        {
            if (minutes + value <= 60)
                minutes += value;
            else
            {
                hours += value / 60;
                minutes += value % 60;
            }
        }

        public void AddSeconds(int value)
        {
            if (seconds + value <= 60)
                seconds += value;
            else
            {
                minutes += value / 60;
                seconds += value % 60;
            }
        }

        public void SubtractYears(int value)
        {
            if (years - value >= 0)
                years -= value;
            else
                years = 0;
        }

        public void SubtractMonths(int value)
        {
            if (months - value >= 0)
                months -= value;
            else
            {
                years -= value / 12;
                months -= value % 12;
            }
        }

        public void SubtractDays(int value)
        {
            if (days - value >= 0)
                days -= value;
            else
            {
                months -= value / 31;
                days -= value % 31;
            }
        }

        public void SubtractHours(int value)
        {
            if (hours - value >= 0)
                hours -= value;
            else
            {
                days -= value / 24;
                hours -= value % 24;
            }
        }

        public void SubtractMinutes(int value)
        {
            if (minutes - value >= 0)
                minutes -= value;
            else
            {
                hours -= value / 60;
                minutes -= value % 60;
            }
        }

        public void SubtractSeconds(int value)
        {
            if (seconds - value >= 0)
                seconds -= value;
            else
            {
                minutes -= value / 60;
                seconds -= value % 60;
            }
        }

        public void MultiplyBy(int factor)
        {
            years *= factor;
            months *= factor;
            days *= factor;
            hours *= factor;
            minutes *= factor;
            seconds *= factor;
        }

        public void DivideBy(int divisor)
        {
            years /= divisor;
            months /= divisor;
            days /= divisor;
            hours /= divisor;
            minutes /= divisor;
            seconds /= divisor;
        }

        public string GetDateTime()
        {
            return $"{years} год {months} месяцев {days} дней {hours} часов {minutes} минут {seconds} секунд";
        }

        public string GetDate()
        {
            return $"{years} год {months} месяцев {days} дней";
        }

        public string CompareDates(DataTimeLigic otherDate)
        {
            TimeSpan timeDifference = new TimeSpan(days, hours, minutes, seconds) -
                new TimeSpan(otherDate.days, otherDate.hours, otherDate.minutes, otherDate.seconds);

            int yearsDiff = Math.Abs(years - otherDate.years);
            int monthsDiff = Math.Abs(months - otherDate.months);
            int daysDiff = Math.Abs(timeDifference.Days % 30);
            int hoursDiff = Math.Abs(timeDifference.Hours);
            int minutesDiff = Math.Abs(timeDifference.Minutes);
            int secondsDiff = Math.Abs(timeDifference.Seconds);

            string difference = $"{yearsDiff} год {monthsDiff} месяцев {daysDiff} дней {hoursDiff} часов {minutesDiff} минут {secondsDiff} секунд";

            return difference;
        }

    }
}
