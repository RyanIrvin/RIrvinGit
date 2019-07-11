using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            reverse(arr);
        }

        static int[] reverse(int[] arr)
        {
            int tempNum = 0;

            for (int i = 0, j = arr.Length - 1; i < arr.Length; i++, j--)
            {
                if (!(i == j))
                {
                    tempNum = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tempNum;
                }
                else
                    break;
            }

            return arr;
        }
    }
}
