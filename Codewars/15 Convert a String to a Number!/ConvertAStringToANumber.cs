namespace _15_Convert_a_String_to_a_Number_
{
    public class ConvertAStringToANumber
    {
        public static int StringToNumber(String str)
        {
            return int.TryParse(str, out int result)? result : 0;
        }
    }
}
