using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace getTotalX
{
    public class CountingValleys
    {
        public static int countingValleys(int steps, string path)
        {
            int altitude = 1;
            int valleyCount = 0;

            for(int i = 0; i < steps; i++)
            {
                if(altitude == 1 && path[i] == 'D')
                {
                    valleyCount++;
                }
                if (path[i] == 'D')
                {
                    altitude--;
                }
                else
                {
                    altitude++;
                }

            }

            return valleyCount;
        }
    }
}
