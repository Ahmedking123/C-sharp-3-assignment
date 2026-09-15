
namespace C_sharp_3__assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fifth question
		
            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);
            // pages value will still the same since we are only passing and modifing a copy of the value
        }
        static void AddBonusPages(int pages) => pages += 50;

#endregion
    }
}
