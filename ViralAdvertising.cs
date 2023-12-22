namespace getTotalX
{
    public class ViralAdvertising
    {
        public static int viralAdvertising(int n)
        {
            // half of the total people will like the post
            double shared = 5;
            int acclikes = 2;
            int likes = 2;
            
            if(n == 1)
            {
                return acclikes;
            }else if(n == 0)
            {
                return 0;
            }

            for(int i= 2;i<=n; i++)
            {
                shared = likes*3;
                likes = (int)Math.Floor(shared/2);
                acclikes += likes;
            }
            
            return acclikes;
            
        }
    }
}