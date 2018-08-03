using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class ClaimsRepo
    {
        Queue<Item> _claimlist = new Queue<Item>();

        public void AddItem(Item cid)
        {
            _claimlist.Enqueue(cid);
        }


        public void PrintList(Queue<Item> List)
        {
            foreach (Item item in List)
            {
                Console.WriteLine(item);
            }
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
