namespace _07_Price_of_Mangoes
{
    public class PriceOfMangoes
    {
        public static int Mango(int quantity, int price)
        {
            //quantity -= (quantity / 3);
            //return quantity * price;
            return (quantity - (quantity / 3)) * price;
        }
    }
}
