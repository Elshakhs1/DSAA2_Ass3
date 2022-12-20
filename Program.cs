using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAA2_Ass3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();

            string menu = "Welcome \n\n" +
                "Please enter the amount you want to withdraw:";
            Console.WriteLine(menu);
            int inputMoney = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter amount of maximum coins to be shown.");
            int inputAmountCoins = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" +
                "Printing... Please wait!\n");

            atm.printAllOptions(inputMoney,inputAmountCoins, 0);
        }
    }
}