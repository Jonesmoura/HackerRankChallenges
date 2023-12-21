using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getTotalX
{
    public class BeautifulDays
    {
        public static int beautifulDays(int i, int j, int k)
        {
        int countBeautifulDays = 0;
        for(int num = i; num<=j; num++)
        {
            
            string stringI = num.ToString();
            string invertedIstring= "";
            for(int pos = stringI.Length-1;pos>=0; pos--)
            {
                invertedIstring += stringI[pos];
            }
            
            int invertedInum = int.Parse(invertedIstring);
            
            if(Math.Abs(num-invertedInum)%k ==0)
            {
                countBeautifulDays++;
            }
        }
        return countBeautifulDays;
        }
    }
}