using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace getTotalX
{
    public class DivisibleSumPairs
    {
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int arrayLength = n;
            int divPer = k;
            int result = 0;
            
            for(int i = 0; i < arrayLength -1;i++)
            {
                for(int j = 1;j < arrayLength;j++)
                {
                    int next = i + j;

                    if (next < arrayLength && (ar[i] + ar[next])%divPer == 0)
                    {
                        result++;
                    }
                }
            }

            return result;

        }

    }
}
