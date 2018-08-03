using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class Item
    {
        //3
        public Item() { }

        //4
        public Item(int number, string a, string desc, string ingred, int price)
        {
            A = a;
            Number = number;
            Desc = desc;
            Ingred = ingred;
            Price = price;
        }

        //-- Properties
        public string A { get; set; }
        public int Number { get; set; }
        public string Desc { get; set; }
        public string Ingred { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            string stringToReturn = $"{Number}\t{A}\t{Desc}\t{Ingred}\t{Price}";
            return stringToReturn;
        }
    }
}
