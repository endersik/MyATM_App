﻿using MyATM_App.UI;
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

            ATMApp atmApp = new ATMApp();
            atmApp.InitializeData();
            atmApp.CheckUserCardNumAndPassword();
            atmApp.Welcome();
        }
    }
}
