namespace _14_Beginner_Reduce_but_Grow
{
    public class BeginnerReducebutGrow
    {
        public static int Grow(int[] x)
        {
            if (x is null )
                return 0;
            //return x.Aggregate(1, (a, b) => a * b);
            int result = 1;
            foreach (var item in x)
            {
                result *= item;
            }
            return result;
        }
    }
}
