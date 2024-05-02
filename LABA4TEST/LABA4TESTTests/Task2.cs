using System;
using System.Text;

namespace LABA4TESTTests
{
    public class Task2
    {
        public  string Code(string input)
        {
            string result = "";

            foreach (char c in input)
            {
                int num = int.Parse(c.ToString());
                string binary = Convert.ToString(num, 2);
                int k = binary.Length;
                result += new string('0', k - 1) + "1" + binary;
            }
            return result;
        }

        public  string Decode(string input)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length;)
            {
                int k = 0;
                while (input[i] == '0')
                {
                    k++;
                    i++;
                }
                i++;
                k++;

                result.Append(Convert.ToInt32(input.Substring(i, k), 2).ToString());
                i += k;
            }

            return result.ToString();
        }
    }
}
