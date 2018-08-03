using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class OutingRepository
    {
        List<Outings> _outingslist = new List<Outings>();

        public void AddOutingToList(Outings outinglist)
        {
            _outingslist.Add(outinglist);
        }

        public List<Outings> GetList()
        {
            return _outingslist;
        }

        public decimal TotalAllOutings()
        {
            decimal total = 0;
            foreach (Outings outing in _outingslist)
            {
                total = total + outing.Total;
            }

            return total;
        }

        public decimal TotalAllOutingsByType(Event userinput)
        {
            decimal total = 0;
            foreach (Outings outing in _outingslist)
            {
                if (outing.Type == userinput)
                {
                    total = total + outing.Total;
                }

            }

            return total;
        }
    }
}