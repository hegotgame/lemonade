using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand
{
    class UI
    {
        public int supplyPrice;
        Sugar sugar = new Sugar();
        Lemon lemon = new Lemon();
        Ice ice = new Ice();
        Cup cup = new Cup();

        private int[] receipe = new int[5];
        public int[] Receipe
        {
            get
            {
                return receipe;
            }
            set
            {
                receipe[0] = supplyPrice;
                receipe[1] = cup.quantity;
                receipe[2] = lemon.quantity;
                receipe[3] = sugar.quantity;
                receipe[4] = ice.quantity;

            }
        }
        public int[] order = new int[4];
        public bool bankrupcy;
    }
}
