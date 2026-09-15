
namespace C_sharp_3__assignment
{
    internal class Program
    {
       
		
        static void Main(string[] args)
        {
            #region Eleventh question

            PrintBookInfo(pages: 450,title :"Clean Code");
            PrintBookInfo (title: "Clean Code",pages: 400);
            
        }
        static void PrintBookInfo(string title, int pages = 300) => Console.WriteLine($"Title: {title}, Pages: {pages}");

#endregion
    }
}
