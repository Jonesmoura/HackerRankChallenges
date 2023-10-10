using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getTotalX
{
    class MigratoryBirds
    {
        public static int migratoryBirds(List<int> arr)
        {
            List<int> types = new List<int>();
            int biggerQtd = 0;
            int minorID = arr[0];

            for(int i = 0; i<arr.Count;i++)
            {

                if (!(types.Contains(arr[i])))
                {
                    types.Add(arr[i]);

                    int actualIndex = types.Count - 1;
                    int tempQtd = 1;

                    for (int j = i+1;j < arr.Count;j++)
                    {
                        if (types[actualIndex] == arr[j])
                        {
                            tempQtd++;
                        }
                    }

                    if ((tempQtd > biggerQtd))
                    {
                        biggerQtd = tempQtd;
                        minorID = types[actualIndex];

                    }else if(tempQtd == biggerQtd && minorID > types[actualIndex])
                    {
                        minorID = types[actualIndex];
                    }

                }
            }

            return minorID;
        }

    }
}
