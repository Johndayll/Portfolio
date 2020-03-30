using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter n number of integers");
            int n = int.Parse(Console.ReadLine());
            double mean = 0, median = 0;
            int highest, lowest, i, input;
            int[] array = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Enter number " + (i + 1));
                input = int.Parse(Console.ReadLine());
                array[i] = input;
                mean += array[i];
            }
            Array.Sort(array);
            if (n % 2 == 0)
            {
                median = (array[(n / 2) - 1] + array[(n / 2)]);
                median /= 2;
            }
            else
            {
                median = array[(n / 2)];
            }
            int count = 0;
            int max = 0;
            int mode = 0;
            for (int j = 0; j < n - 1; j++)
            {
                if (array[j] == array[j + 1])
                {
                    count++;
                }
                if (count > max)
                {
                    max = count;
                    mode = array[j];
                }
                count = 0;
            }
            highest = array[array.Length - 1];
            lowest = array[0];
            mean /= n;
            Console.WriteLine("======================");
            Console.WriteLine($"Median is {median}");
            Console.WriteLine($"Mean is {mean}");
            Console.WriteLine($"Mode is {mode}");
            Console.WriteLine($"Highest is {highest}");
            Console.WriteLine($"Lowest is {lowest}");
        }
    }
}
