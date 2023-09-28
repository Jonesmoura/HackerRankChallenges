namespace getTotalX
{
    public class Birthday
    {
        public static int birthday(List<int> s, int d, int m)
        {
            int sumLength = m;
            int sumResult = d;
            int chocolatesSquares = 0;

            for(int i = 0; i<= (s.Count - m); i++)
            {
                int tempSum = 0;

                for(int j = 0; j < sumLength; j++)
                {
                    tempSum += s[i + j];
                }

                if(tempSum == sumResult)
                {
                    chocolatesSquares++;
                }
            }

            return chocolatesSquares;

        }
    }
}
