using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM3
{
    //Maintains the selected account throughout the app
    public static class Session_Manager
    {
        private static Bank _originalAccount;
        public static Bank CurrentAccount => _originalAccount;
        public static Bank AllAccounts => _originalAccount;

        public static void SetCurrentAccount(Bank account)
        {
            _originalAccount = account;
        }

        
    }
}
