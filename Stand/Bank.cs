using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand
{
    class Bank
    {
        public decimal balance = 0;
        private decimal salesReceipt;
        private decimal wasteReceipt;
        private decimal vendorReceipt;
        private decimal Balance()
        {
            balance = 20;
            balance -= vendorReceipt;
            balance += salesReceipt;
            return balance;
        }
    }
}
