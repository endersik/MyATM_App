using System;
namespace MyATM_App.UI
{
	public static class Utility
	{
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine($"Enter {prompt}");
            return Console.ReadLine();
        }

        public static void PressEnterToContinue()
        {
            Console.WriteLine("\n\nPress enter to continue...\n");
            Console.ReadLine();
        }
    }
}

