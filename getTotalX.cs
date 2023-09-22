using System;

namespace getTotalX
{
    internal class getTotalX
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>(2);
            a.Add(2);
            a.Add(4);

            List<int> b = new List<int>(2);
            b.Add(16);
            b.Add(32);
            b.Add(96);



            int resultado = Result.getTotalX(a, b);

            Console.WriteLine(resultado);

        }
    }

    class Result
    {

        /*
         * Complete the 'getTotalX' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */

        public static int getTotalX(List<int> a, List<int> b)
        {

            int result = 0;

            for(int num = a.Max(); num <= b.Min(); num++)
            {
                bool addNum = true;
                foreach(int numAtualA in a)
                {
                    if (num % numAtualA != 0)
                    {
                        addNum = false;
                        break;
                    }
                }
                foreach(int numAtualB in b)
                {
                    if(numAtualB % num != 0)
                    {
                        addNum = false;
                        break;
                    }
                }

                if (addNum == true)
                {
                    result++;
                }

            }

            return result;

        }

    }
}