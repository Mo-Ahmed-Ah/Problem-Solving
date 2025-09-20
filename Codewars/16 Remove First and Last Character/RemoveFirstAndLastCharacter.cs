using System.Collections.Generic;

namespace _16_Remove_First_and_Last_Character
{
    public class RemoveFirstAndLastCharacter
    {
        public static string Remove_char(string s)
        {
            if (s.Length == 0) return "";
            return s.Substring(1, s.Length - 2); 
        }
    }
}
