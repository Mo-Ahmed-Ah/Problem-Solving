namespace _05_Reversed_Strings
{
    public class ReversedStrings
    {
        public static string Solution(string str)
        {
            if (str == null) return null;
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = charArray.Length - 1; i < j; i++, j--)
            {
                char temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
            }
            return new string(charArray);
        }
    }
}
