namespace getTotalX
{
    public class JumpingOnClouds
    {
        public static int jumpingOnClouds(int[] c, int k)
        {
            int energy = 100;
            int count = 0;
            int n = c.Length;
            do
            {
                if (c[(count + k) % n] == 0)
                {
                    energy--;
                }
                else
                {
                    energy -= 3;
                }
                count += k;

            }while(count % n != 0);

            return energy;
        }
    }
}
