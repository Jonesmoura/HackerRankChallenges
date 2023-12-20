using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getTotalX
{
    public class AngryProfessor
    {
        public static string angryProfessor(int k, List<int> a)
        {
            int total = 0;
            foreach(int student in a)
            {
                if(student <= 0)
                {
                    total ++;
                }
            }
            return k<= total ? "NO" : "YES";

        }
    }
}