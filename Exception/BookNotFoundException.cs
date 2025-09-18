using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LIBRARY2
{
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException(string message) : base(message)
        {
        }

        public BookNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
