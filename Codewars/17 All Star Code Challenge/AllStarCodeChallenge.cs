namespace _17_All_Star_Code_Challenge
{
    public class AllStarCodeChallenge
    {
        public static int StrCount(string str, char letter)
        {
            if (str is null || str.Length == 0) return 0;
            int count = 0;
            foreach (char c in str)
            {
                if (c == letter) count++;
            }
            return count;
        }
    }
}
