using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInDepth
{
    internal class Program
    {

        static void highestNo(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    Console.WriteLine($"The highest no is {max}!");
                }
                else if (min > arr[i]) {
                    {
                        min = arr[i];
                    }
                }
                Console.WriteLine($"The Lowest no is {min}!");
            }
        } 
       public static void Main(string[] args)
        { 
            int[] startGuessNumber = { 10, 25, 55, 26, 6, 69 };

            highestNo(startGuessNumber);


           // Array.Sort(startGuessNumber);
           
           /* for (int i = 0; i < startGuessNumber.Length; i++)
            {
                Console.WriteLine(startGuessNumber[i]);
            }
           */
            Console.ReadKey();
        }
    }
}
