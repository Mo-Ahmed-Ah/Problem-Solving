namespace _09_Invert_Values
{
    public class InvertValues
    {
        public static int[] ArraysInversion(int[] input)
        {
            #region Initial solution with loop
            if (input != null)
            {

                for (int i = 0; i < input.Length; i++)
                     input[i] = -input[i];
                return input;
            }
            return null;
            #endregion
            #region Alternative solution with LINQ Array.Select
            //return input.Select(n => -n).ToArray();
            #endregion

            #region Alternative solution with LINQ Array.ConvertAll
            //return Array.ConvertAll(input, n => -n);
            #endregion


        }
    }
}
