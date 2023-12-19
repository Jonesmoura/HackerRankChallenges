using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getTotalX
{
    public class UtopianTree
    {
        public static int utopianTree(int n)
        {
            int height = 1;
            for(int i = 0; i<n;i++)
            {
                if(i % 2 == 1)
                {
                    height ++;
                }
                else
                {
                    height *=2;    
                }
            }
            
            return height;
        }
    }
}