
namespace C_sharp_3__assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First question

            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);

            #endregion

            #region Second question

            double[,] shelfsCopies = { {3,5 }, {1,4 } };
            Console.WriteLine(shelfsCopies[1,0]);

            #endregion
        }
    }
}
