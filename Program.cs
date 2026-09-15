
namespace C_sharp_3__assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        #region Ninth question

        static bool TryToGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }

            price = 0;
            return false;
        }

        #endregion
    }
}
