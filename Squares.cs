namespace getTotalX
{
    public class Squares
    {
        public static int squares(int a, int b)
        {
            int ceil = (int)Math.Floor(Math.Sqrt(b));
            int floor = (int)Math.Ceiling(Math.Sqrt(a));
            return ceil - floor + 1;
        }
    }
}
