namespace _08_Cat_years__Dog_years
{
    public class CatYearsDogYears
    {
        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {
            int catYears = 0;
            int dogYears = 0;
            /* 
             * This solution works but is not the most efficient one
             * the Big O notation is O(n)
            */
            #region Frist Solution
            //if (humanYears >= 1)
            //{
            //    for (int i = 1; i <= humanYears; i++)
            //    {
            //        if (i == 1)
            //        {
            //            catYears += 15;
            //            dogYears += 15;
            //        }
            //        else if (i == 2)
            //        {
            //            catYears += 9;
            //            dogYears += 9;
            //        }
            //        else
            //        {
            //            catYears += 4;
            //            dogYears += 5;
            //        }
            //    }
            //}
            #endregion

            /*
             * This solution is more efficient.
             * the Big O notation is O(1)
            */
            #region Second Solution
            if (humanYears == 1)
            {
                catYears = 15;
                dogYears = 15;
            }
            else if (humanYears == 2)
            {
                catYears = 24;
                dogYears = 24;
            }
            else if (humanYears > 2)
            {
                catYears = 24 + (humanYears - 2) * 4;
                dogYears = 24 + (humanYears - 2) * 5;
            }
            #endregion
            return new int[] { humanYears, catYears, dogYears };
        }
    }
}
