using MyATM_App.Domain.Entities;
using MyATM_App.Domain.Interfaces;
using MyATM_App.UI;

namespace ATMApp
{
    public class ATMApp : IUserLogin
    {
        private List<UserAccounts> userAccountList;
        private UserAccounts selectedAccount;

        public void CheckUserCardNumAndPassword()
        {
            bool isCorrectLogin = false;
            while (isCorrectLogin == false)
            {
                UserAccounts inputAccount = AppScreen.UserLoginForm();
                AppScreen.LoginProgress();
                foreach (UserAccounts account in userAccountList)
                {
                    selectedAccount = account;
                    if (inputAccount.CardNumber.Equals(selectedAccount.CardNumber))
                    {
                        selectedAccount.TotalLogin++;

                        if (inputAccount.CardPin.Equals(selectedAccount.CardPin))
                        {
                            selectedAccount = account;

                            if (selectedAccount.IsLocked || selectedAccount.TotalLogin > 3)
                            {
                                AppScreen.PrintLockScreen();
                            }
                            else
                            {
                                selectedAccount.TotalLogin = 0;
                                isCorrectLogin = true;
                                break;
                            }
                        }
                    }
                    if (isCorrectLogin == false)
                    {
                        Utility.PrintMessage("\nInvalid card number or PIN.", false);
                        selectedAccount.IsLocked = selectedAccount.TotalLogin == 3;
                        if (selectedAccount.IsLocked)
                        {
                            AppScreen.PrintLockScreen();
                        }
                    }
                    Console.Clear();
                }
            }
        }

        public void Welcome()
        {
            Console.WriteLine($"Welcome back, {selectedAccount.FullName}");
            Utility.PressEnterToContinue();
        }



        public void InitializeData()
        {
            userAccountList = new List<UserAccounts>
            {
                new UserAccounts{Id=1, FullName = "Ender Sik", AccountNumber=123456,CardNumber =321321, CardPin=123123,AccountBalance=50000.00m,IsLocked=false},
                new UserAccounts{Id=2, FullName = "Bill Gates", AccountNumber=456789,CardNumber =654654, CardPin=456456,AccountBalance=4000.00m,IsLocked=false},
                new UserAccounts{Id=3, FullName = "Can Bonomo", AccountNumber=123555,CardNumber =987987, CardPin=789789,AccountBalance=2000.00m,IsLocked=true},
            };
        }
    }
}

