
namespace C_sharp_3__assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Eighth question

            double[] prices = { 5.0, 7.5, 10.0, 2.75 };
            ReplaceArray(ref prices);
            Console.WriteLine(prices.Length);
        }
        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }

            #endregion
    }
}
