namespace getTotalX
{
    public class AppendAndDelete
    {
        public static string appendAndDelete(string s, string t, int k)
        {
            int sIndex = 0;
            int tIndex = 0;

            while(sIndex < s.Length && tIndex < t.Length)
            {
                if (s[sIndex] == t[tIndex])
                {
                    sIndex++;
                    tIndex++;
                }
                else
                {
                    break;
                }
            
            }

            int opNeeded = 0;
            opNeeded = s.Length - sIndex + t.Length - tIndex;

            if (k < opNeeded)
            {
                return "No";
            }
            if(k>= s.Length + t.Length || (k - opNeeded) % 2 == 0)
            {
                return "Yes";
            }
            return "No";
        }
    }
}
