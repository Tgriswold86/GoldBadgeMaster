using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class MenuRepo
    {
        List<Item> items = new List<Item>();

        public void addItemToList(Item mItem)
        {
            items.Add(mItem);
        }

        public List<Item> getList()
        {
            return items;
        }

        public void printList(List<Item> menuList)
        {
            foreach (Item show in menuList)
            {
                Console.WriteLine(show);
            }
        }

        public void removeFromList(string Name)
        {
            int theIndex = items.FindIndex(item => item.Name == Name);
            items.RemoveAt(theIndex);
        }
    }
}
