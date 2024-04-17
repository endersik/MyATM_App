using MyATM_App.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.App
{
    class Entry
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();

            long cardNumber = Validator.Convert<long>("your card number");
            Utility.PrintMessage("Valid Input.");
            Console.WriteLine($"Your card number is {cardNumber}");

            Utility.PressEnterToContinue();
        }
    }
}
