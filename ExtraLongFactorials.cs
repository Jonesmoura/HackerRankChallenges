using System.Numerics;

namespace getTotalX
{
    public class ExtraLongFactorials
    {
        public static void extraLongFactorials(int n)
        {
            BigInteger result = n;

            while (n != 1)
            {
                n--;
                result *= n;
            }

            Console.WriteLine(result.ToString());
        }
    }
}
