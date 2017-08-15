using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand
{
    class UI
    {
        public bool bankrupcy;
        Cup cup = new Cup();
        Lemon lemon = new Lemon();
        Sugar sugar = new Sugar();
        Ice ice = new Ice();

        private void GetOrder()
        {
            Console.WriteLine("Make your daily purchasing order:");
            Console.WriteLine("How many cups?");
            cup.orderQuantity_units = int.Parse(Console.ReadLine());
            Console.WriteLine("How many lemons?");
            lemon.orderQuantity_units = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cups of sugar?");
            sugar.orderQuantity_units = int.Parse(Console.ReadLine());
            Console.WriteLine("How many ice cubes?");
            ice.orderQuantity_units = int.Parse(Console.ReadLine());
        }
        private void SetReceipe()
        {
            Console.WriteLine("Make your daily lemonade receipe:");
            cup.normalization_units = 1;
            Console.WriteLine("How many lemons in a cup?");
            lemon.normalization_units = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cups of sugar in a cup?");
            sugar.normalization_units = int.Parse(Console.ReadLine());
            Console.WriteLine("How many ice cubes in a cup?");
            ice.normalization_units = int.Parse(Console.ReadLine());
        }

    }
}
