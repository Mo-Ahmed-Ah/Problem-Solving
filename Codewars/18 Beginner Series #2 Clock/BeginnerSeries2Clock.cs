namespace _18_Beginner_Series__2_Clock
{
    public class BeginnerSeries2Clock
    {
        public static int Past(int h, int m, int s)
        {
            if (h == 0 && m == 0 && s == 0) return 0;
            else if (h == 0 && m == 0) return s * 1000;
            else if (h == 0) return (m * 60 + s) * 1000;
            return (h * 3600 + m * 60 + s) * 1000;
        }
    }
}
