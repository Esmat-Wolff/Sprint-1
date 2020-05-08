using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, 1, 15 ,0,12,23,25,17,16};
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if(arr[i] <arr[j])
                    {
                        temp = arr[i];

                        arr[i] = arr[j];

                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0},", arr[i]);
                Console.ReadKey();
            }
        }
    }
}
