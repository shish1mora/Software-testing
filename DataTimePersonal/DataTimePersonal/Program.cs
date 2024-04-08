using System;
using System.Collections.Generic;

namespace DataTimePersonal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*DataTimeLigic dt = new DataTimeLigic();
            DataTimeLigic dt2 = new DataTimeLigic();

            dt2.AddSeconds(1);
            dt2.AddMinutes(1);
            dt2.AddHours(1);

            dt2.AddDays(30);
            dt2.AddMonths(1);
            dt2.AddYears(1);

            Console.WriteLine($"Current date: {dt.GetDate()}\nAdd date: {dt2.GetDate()}");

            Console.WriteLine("Разница между датами: " + dt.CompareDates(dt2));

            Console.WriteLine($"Current date: {dt.GetDate()}");
            dt.DivideBy(2);
            Console.WriteLine($"Date /2: {dt.GetDate()}");*/

            List<string> getElements(List<string> a)
            {
                string[] input = { "0","1","2","3","4","5","6","7","8","9" };
                string result = "";
                foreach (string c in input)
                {
                    int digit = int.Parse(c.ToString());
                    string binaryRepresentation = Convert.ToString(digit, 2);
                    int k = binaryRepresentation.Length;

                    // Append k-1 zeros followed by "1" to the result
                    result += new string('0', k - 1) + '1';
                    // Append the binary representation of the digit to the result
                    result += binaryRepresentation;
                    a.Add(result);
                }

                return a;
            }

            List<string> a = new List<string>();
            a = getElements(a);
            string expected = "011000110010";
            Console.WriteLine($"{expected}");
            a.ForEach(item => Console.WriteLine(item));

            string Decode(string input)
            {
                string result = "";
                int index = 0;

                while (index < input.Length)
                {
                    // Find the position of the first "1"
                    int onesIndex = input.IndexOf('1', index);

                    // Extract the substring from the current position to the first "1"
                    string segment = input.Substring(index, onesIndex - index + 1);
                    int k = segment.Length;

                    // Move the index to the next segment
                    index = onesIndex + 1;

                    // Extract the binary representation part and convert it to decimal
                    string binaryPart = input.Substring(index, k - 1);
                    int digit = Convert.ToInt32(binaryPart, 2);

                    // Append the decoded digit to the result
                    result += digit.ToString();

                    // Move the index to the next segment
                    index += k - 1;
                }

                return result;
            }



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
