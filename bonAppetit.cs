using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getTotalX
{
    public class BonAppetit
    {
        // first line -> All ordered item and the index of not eaten item by Ana
        // All item
        // Amount of money paid by Ana
        public static void bonAppetit(List<int> bill, int k, int b)
        {
            int anaTotal = 0;
            int paidBill = b;

            for(int i = 0; i < bill.Count; i++)
            {
                if(i != k)
                {
                    anaTotal += bill[i];
                }
            }

            anaTotal /= 2;

            if(anaTotal < paidBill)
            {
                int diff = paidBill - anaTotal;
                Console.WriteLine(diff);
            }
            if(anaTotal == paidBill)
            {
                Console.WriteLine("Bon Appetit");
            }
        }
    }
}
