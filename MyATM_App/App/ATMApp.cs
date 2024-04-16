using MyATM_App.UI;

AppScreen.Welcome();

long cardNumber = Validator.Convert<long>("Your card number");
Console.WriteLine($"Your card number is {cardNumber}");

Utility.PressEnterToContinue();