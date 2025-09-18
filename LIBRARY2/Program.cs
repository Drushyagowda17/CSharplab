namespace LIBRARY2
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Library library = new Library();

            int[] testIds = { 105, 999, 210 };

            foreach (int id in testIds)
            {
                try
                {
                    library.BorrowBook(id);
                }
                catch (BookNotFoundException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("LIBRARY SYSTEM ALERT:");
                    Console.WriteLine($"Message: {ex.Message}");
                    Console.WriteLine("Action: Please check the ID and try again.");
                    Console.WriteLine("---------------------------------------------");
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                    Console.ResetColor();
                }
            }
        }
    }
}