using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getTotalX
{
    public class SalesByMath
    {
        public static int sockMerchant(int n, List<int> ar)
        {
            int pairs = 0;
            List<int> numbersToCheck = ar;

            for(int j = 0; j < numbersToCheck.Count -1; j++)
            {
                for(int i=j+1; i<numbersToCheck.Count; i++)
                {
                    if (numbersToCheck[j] == numbersToCheck[i])
                    {
                        numbersToCheck.RemoveAt(i);
                        numbersToCheck.RemoveAt(j);
                        pairs ++;
                        j = -1;
                        break;
                    }
                }
            }

            return pairs;

        }
    }
}
