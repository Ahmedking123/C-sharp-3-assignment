
namespace C_sharp_3__assignment
{
    internal class Program
    {


        static void Main(string[] args)
        {

            #region Twelfth question

            PrintAllTitles("Clean Code", "The Pragmatic Programmer", "Refactoring");
        }
        static void PrintAllTitles(params string[] titles)
        {
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
        } 
            #endregion
    }
}
