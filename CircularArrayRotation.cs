namespace getTotalX
{
    public class CircularArrayRotation
    {
        public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
        {
            int length = a.Count;
            List<int> result = new List<int>(length);
            foreach( int i in queries )
            {
                int newPos = (length - k + i) % length;
                result.Add(a[newPos]);
            }

            return result;

        }
    }
}
