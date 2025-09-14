

namespace _03_Is_N_Divisible_By_X_And_Y
{
    public class IsNDivisibleByXAndY
    {
        public static bool IsDivisible(int n, int x, int y)
        {
            //if (n % x == 0 && n % y == 0)
            //{
            //    return true;
            //}
            //return false;
            return n % x == 0 && n % y == 0;
        }
    }
}
