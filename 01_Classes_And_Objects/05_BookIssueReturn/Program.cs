namespace _05_BookIssueReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book B1 = new Book();

            B1.DisplayBooks();
            B1.issueBook();
            B1.ReturnBook();
        }
    }
}
