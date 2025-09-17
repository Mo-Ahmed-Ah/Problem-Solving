namespace _11_Find_Maximum_and_Minimum_Values_of_a_List
{
    public class FindMaximumAndMinimumValuesOfAList
    {
        public static int Min(int[] list)
        {
            
            if(list == null || list.Length == 0)
                throw new ArgumentException("List cannot be null or empty");
            if(list.Length == 1)
                return list[0];
            for(int i = 0; i < list.Length; i++)
            {
                if(list[i] < list[0])
                {
                    list[0] = list[i];
                }
            }
            return list[0];
        }

        public static int Max(int[] list)
        {
            if (list == null || list.Length == 0)
                throw new ArgumentException("List cannot be null or empty");
            if (list.Length == 1)
                return list[0];
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > list[0])
                {
                    list[0] = list[i];
                }
            }
            return list[0];
        }

    }
}
    