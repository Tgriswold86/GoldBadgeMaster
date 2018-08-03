using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class Outings
    {
        public Outings(Event type, int people, string date, double person, decimal total)
        {
            Type = type;
            People = people;
            Date = DateTime.Parse(date);
            Person = person;
            Total = total;
        }

        public Event Type { get; set; }
        public int People { get; set; }
        public DateTime Date { get; set; }
        public double Person { get; set; }
        public decimal Total { get; set; }

        public override string ToString()
        {
            string stringToReturn = $"{Type}\n{People}\n{Date}\n{Person}\n{Total}";

            return stringToReturn;
        }
    }
}