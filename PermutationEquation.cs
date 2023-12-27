using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getTotalX
{
    public class PermutationEquation
    {
        public static List<int> permutationEquation(List<int> p)
        {
            List<int> result = new List<int>(); 
            
            for(int i = 1;i<=p.Count;i++)
            {
                int res = p.IndexOf(p.IndexOf(i)+1)+1;
                result.Add(res);
            }
            
            return result;

        }
    }
}