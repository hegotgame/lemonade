using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand
{
    class Bank
    {
        public decimal balance_dollars;
        public decimal supplyPrice_dollars;
        public decimal demandPrice_dollars;
        private decimal salesReceipt;
        private decimal wasteReceipt;
        private decimal vendorReceipt;
        Ingredient ingredient = new Ingredient();
        Customer customer = new Customer();
        Player player = new Player();

        private decimal[] cash = new decimal[5];
        public decimal[] Cash
        {
            get
            {
                return cash;
            }
            set
            {
                cash[0] = balance_dollars;
                cash[1] = player.supplyPrice_dollars;
                cash[2] = ingredient.CostPrice_dollars;
                cash[3] = ingredient.giveawayPrice_dollars;
                cash[4] = customer.demandPrice_dollars;
            }
        }
    }
}
