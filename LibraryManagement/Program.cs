namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("Harry Potter", "J.K. Rowling");
            b.DisplayDetails();
            Book e = new EBook("dragon Games", "Somebody", 688, "EPUB");
            e.DisplayDetails();
        }
    }
}