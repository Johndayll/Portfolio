using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int converted = 0, power = 1;
            int counter = 0;
            Console.WriteLine("Enter your binary code");
            string binary = Console.ReadLine();

            for(int i = binary.Length - 1; i  >= 0; i--, power*= 2, counter++)
            {
                if (i == binary.Length - 1 && binary[i] == '1') converted += 1;
                if(counter > 0)
                {
                    if (binary[i] == '1') converted += power;  
                    
                }           
            }
            Console.WriteLine(converted);
        }
    }
}
