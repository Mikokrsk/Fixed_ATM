using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixed_ATM
{
    public class Banknote
    {
        public int cost;
        public int number;
        public Banknote(int cost,int number) 
        {
            this.cost = cost;
            this.number = number;
        }

        public int GetSum()
        {
            return cost*number;
        }
    }
}
