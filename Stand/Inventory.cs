using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand
{
    class Inventory
    {
        Sugar sugar = new Sugar();
        Lemon lemon = new Lemon();
        Ice ice = new Ice();
        Cup cup = new Cup();

        private int[] lemonade = new int[4];
        public int[] Lemonade
        {
            get
            {
                return lemonade;
            }
            set
            {
                lemonade[0] = cup.quantity_units;
                lemonade[1] = lemon.quantity_units;
                lemonade[2] = sugar.quantity_units;
                lemonade[3] = ice.quantity_units;
            }
        }
    }
}
