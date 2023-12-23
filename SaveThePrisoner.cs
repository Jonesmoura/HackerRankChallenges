namespace getTotalX
{
    public class SaveThePrisoner
    {
        public static int saveThePrisoner(int n, int m, int s)
        {
            int remaining = m % n;

            if((remaining + s -1) % n == 0)
            {
                return n;
            }
            else
            {
                return((remaining + s -1) % n);
            }

        }
    }
}