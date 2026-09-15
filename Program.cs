
namespace C_sharp_3__assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sixth question

            double[] prices = { 25.5, 40.0 };
            ApplyDiscount(prices);
            Console.WriteLine(prices[0]);

            //the value if the item will change since array is passed by reference
        }
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        } 
            #endregion
    }
}
