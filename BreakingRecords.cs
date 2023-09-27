using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getTotalX
{
    public class BreakingRecords
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            int min = scores[0];
            int countMin = 0;
            int max = scores[0];
            int countMax = 0;
            List<int> result = new List<int>();

            for(int i = 1; i < scores.Count; i++)
            {
                if (scores[i] < min) { 
                    min = scores[i];
                    countMin++;
                }
                if (scores[i] > max)
                {
                    max = scores[i];
                    countMax++;
                }
            }

            result.Add(countMax);
            result.Add(countMin);


            return result;

        }
    }
}
