using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v11z1
{
    public class Dostava
    {
        string ime, vrsta;
        double cijena;

        public Dostava(string name, string type, double price)
        {
            ime = name;
            vrsta = type;
            cijena = price;
        }

        public string Ime{
            get { return ime; }
        }
        public string Vrsta
        {
            get { return vrsta; }
        }
        public double Cijena
        {
            get { return cijena; }
        }
    }
}
