namespace getTotalX
{
    public class FindDigits
    {
        public static int findDigits(int n)
        {
            string nString = n.ToString();
            int divisors = 0;

            for (int i = 0; i < nString.Length; i++)
            {
                int actualNumber = int.Parse(nString[i].ToString());
                if (actualNumber == 0)
                {
                    continue;
                }
                else if (n % actualNumber == 0)
                {
                    divisors++;
                }
            }

            return divisors;

        }
    }
}
