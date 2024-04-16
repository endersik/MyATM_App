using System;
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

        
    }
}

