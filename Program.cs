
namespace C_sharp_3__assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Seventh question

            int pages = 400;
            AddBonusPagesByRef(ref pages);
            Console.WriteLine(pages);
            // the value of the variable will change since we are passing it by reference
        }
        static void AddBonusPagesByRef(ref int pages) => pages += 50;

            #endregion
    }

}
