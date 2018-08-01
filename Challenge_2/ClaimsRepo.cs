using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class ClaimsRepo
    {
        List<Item> items = new List<Item>();

        public void addItemToList(Item cItem)
        {
            items.Add(cItem);
        }

        public void PrintList(Queue<Item> List)
        {
            foreach (Item item in List)
            {
                Console.WriteLine(item);
            }
        }

        public void removeFromList(int theid)
        {
           int theIndex = items.FindIndex(item => item.Cid == theid);
           items.RemoveAt(theIndex);
        }

        Queue<Item> _claimlist = new Queue<Item>();

        public void AddItem(Item cid)
        {
            _claimlist.Enqueue(cid);
        }


        public Queue<Item> GetClaimList()
        {
            return _claimlist;
        }

        public Item SeeCurrentClaim()
        {
            return _claimlist.Peek();
        }

        public void RemoveItem()
        {
            _claimlist.Dequeue();
        }
    }
}
