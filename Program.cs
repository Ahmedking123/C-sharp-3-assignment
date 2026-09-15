
namespace C_sharp_3__assignment
{
    internal class Program
    {
        #region Tenth question
		
        static void Main(string[] args)
        {

            PrintBookInfo("Clean Code");
            PrintBookInfo("The Pragmatic Programmer", 450);
        }
        static void PrintBookInfo(string title, int pages = 300) => Console.WriteLine($"Title: {title}, Pages: {pages}");

#endregion
    }
}
