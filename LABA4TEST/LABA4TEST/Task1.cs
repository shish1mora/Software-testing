using System;

namespace LABA4TEST
{
    public class Task1
    {
        public int[] ArrayDiff(int[] a,int[] b)
        {
            int[] result = new int[a.Length];
            int index = 0;
            foreach (int num in a)
            {
                if(Array.IndexOf(b, num) == -1)
                {
                    result[index] = num;
                    index++;
                }
            }

            Array.Resize(ref result, index);
            return result;
        }
    }
}
