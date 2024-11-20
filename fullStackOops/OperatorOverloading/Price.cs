using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.OperatorOverloading
{
    public class Price
    {
        //fields
        string symbol;
        public int rupees;
        public int paisa;

        //constructor
        public Price(int rupees, int paisa)
        {
            symbol = "Rs.";
            this.rupees = rupees;       
            this.paisa = paisa;
        }

        public override string ToString()
        {
            return (symbol + " " + rupees + "." + paisa);
        }

        public static Price operator + (Price p, Price q)
        { 
            int rs = p.rupees + q.rupees;
            int ps = p.paisa + q.paisa;
            return new Price(rs, ps);
        }
        public static Price operator ++(Price p)
        { 
            p.rupees++;
            p.paisa++;
            return p;
        }

        public static Boolean operator > (Price p, Price q)
        {
            if (p.rupees > q.rupees)
                return true;
            return false;
            
        }

        public static Boolean operator <(Price p, Price q)
        {
            if (p.rupees < q.rupees)
                return true;
            return false;
        }

    }
}
