using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interest_rate
{
    class Program
    {
        static void Main(string[] args)
        {
            float initialInvestment, rate, earnings, moneyInBank;
            int years;

            //User Input
            Console.WriteLine("What is your initial investment");
            initialInvestment = float.Parse(Console.ReadLine());

            //Put money in the bank
            moneyInBank = initialInvestment;

            //Percentage to Decimal
            Console.WriteLine("Interest rate?");
            rate = float.Parse(Console.ReadLine());
            rate /= 100;

            //Input
            Console.WriteLine("How many years?");
            years = int.Parse(Console.ReadLine());
            Console.WriteLine($"{"End of year",-12} | {"Principal",-20} | {"Interest earning",-20} | {"Money in bank",-20}");           
           
            
            for (int i = 1; i <= years; i++)
            {
                //Calculate earnings based on interest
                earnings = initialInvestment * rate;
                //Add earnings to current money
                moneyInBank += earnings;
                //Display
                Console.WriteLine($"{i,12} | {initialInvestment,20} | {earnings,20} | {moneyInBank,20}");
                //Update initial invesment
                initialInvestment = moneyInBank;            
            }
        }
    }
}

