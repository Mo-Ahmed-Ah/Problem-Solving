namespace _10_Remove_exclamation_marks
{
    public class RemoveExclamationMarks
    {
        public static string RemoveExclamationMark(string s)
        {

            if (s is null) return null;
            /* 
             * This sentence is the perfect solution,
             * Because the Replace method has got N logN complexity
             */
            #region Frist solution 
            s = s.Replace("!", "");
            #endregion

            /*
             * This solution has got N^2 complexity
             */
            #region Second solution
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] == '!')
            //    {
            //        s = s.Remove(i, 1);
            //        i--;
            //    }
            //}
            #endregion
            return s;
        }
    }
}
