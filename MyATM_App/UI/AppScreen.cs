using System;
using MyATM_App.Domain.Entities;

namespace MyATM_App.UI
{
	public static class AppScreen
	{
		internal static void Welcome()
        {
            Console.Clear();
            Console.Title = "My ATM App";

            Console.WriteLine("------------------Welcome to My ATM App------------------");
            Utility.PressEnterToContinue();
        }

        internal static UserAccounts UserLoginForm()
        {
            UserAccounts tempUserAccount = new UserAccounts();

            tempUserAccount.CardNumber = Validator.Convert<long>("your card number.");
            tempUserAccount.CardPin = Convert.ToInt32(Utility.GetSecretInput("Enter your card PIN"));

            return tempUserAccount;
        }

        internal static void LoginProgress()
        {
            Console.WriteLine("\nChecking card number and PIN...");
            Utility.PrintDotAnimation();
        }

        internal static void PrintLockScreen()
        {
            Console.Clear();
            Utility.PrintMessage("Your account is locked. Please go to the nearest branch" +
                " to unlock your account. Thank you.", true);
            Environment.Exit(1);
        }
    }
}

