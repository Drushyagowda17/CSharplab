using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY2
 {
    public class Library
    {
        private readonly List<int> _bookIds = new List<int> { 101, 102, 105, 109, 210 };

        public void BorrowBook(int bookId)
        {
            Console.WriteLine($"\n->tempting to borrow book ID: {bookId}...");

            if (!_bookIds.Contains(bookId))
            {
                string message = $"ERROR: Book ID '{bookId}' not found in the library catalog.";
                throw new BookNotFoundException(message);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"SUCCESS: Book ID {bookId} has been successfully borrowed.");
            Console.ResetColor();
        }
    }
}