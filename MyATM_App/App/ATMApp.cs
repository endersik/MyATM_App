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

            UserAccounts tempUserAccount = new UserAccounts();

            tempUserAccount.CardNumber = Validator.Convert<long>("your card number.");
            tempUserAccount.CardPin = Convert.ToInt32(Utility.GetSecretInput("Enter your card PIN"));
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

