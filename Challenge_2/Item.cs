using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class Item
    {
        //3
        public Item() { }

        //4
        public Item(int cid, string ctype, string cdesc, int aod, string doa, string doc)
        {
            Cid = cid;
            CType = ctype;
            CDesc = cdesc;
            AoD = aod;
            DoA = DateTime.Parse(doa);
            DoC = DateTime.Parse(doc);
            IsValid = (DoC - DoA).TotalDays < 30;
        }

        //-- Properties
        public int Cid { get; set; }
        public string CType { get; set; }
        public string CDesc { get; set; }
        public int AoD { get; set; }
        public DateTime DoA { get; set; }
        public DateTime DoC { get; set; }
        public bool IV { get; set; }
        public TimeSpan TB => DoC - DoA;

        private bool _isValid;

        public bool IsValid
        {
            get => _isValid;

            set
            {
                if (TB.Days < 30)
                    _isValid = true;

                _isValid = value;
            }
        }

        public override string ToString()
        {
            return
                $"Claim ID: {Cid} \n" +
                $"Claim Type: {CType} \n" +
                $"Description of Claim: {CDesc}\n" +
                $"Amount of Damage: {AoD} \n" +
                $"Claim Type: {DoA} \n" +
                $"Description of Claim: {DoC}\n" +
                $"Valid Claim: {IsValid}\n";
                
        }
    }
}
