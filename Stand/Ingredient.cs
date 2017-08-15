using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand
{
    class Ingredient
    {
        public int shelfLife_days;
        private decimal costPrice_dollars;
        public decimal CostPrice_dollars
        {
            get
            {
                return costPrice_dollars;
            }
            set
            {
                costPrice_dollars = 1;
            }
        }
        public decimal giveawayPrice_dollars;
        protected string unit;
        public int quantity_units;
        public int normalization_units;
        private int finishedGood_units;
        public int FinishedGood_units
        {
            get
            {
                return finishedGood_units;
            }
            set
            {

                finishedGood_units = (quantity_units - ((quantity_units) % normalization_units)) / normalization_units;
            }
        }

        public int orderQuantity_units;
        public int maxCost_units;
        public int minCost_units;

    protected void Expiration(int shelfLife)
        {

        }
    }
}
