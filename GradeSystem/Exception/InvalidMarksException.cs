using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeSystem.Exceptions
{
    public class InvalidMarksException : Exception
    {
        public int InvalidMarks { get; }
        public InvalidMarksException(int invalidMarks)
            : base("Invalid Marks: choose between  (0-100).")
        {
            InvalidMarks = invalidMarks;
        }
        public string GetErrorDetails()
        {
            return $"--- ERROR DETAILS ---\n" +
                   $"Marks Entered: {InvalidMarks}\n" +
                   $"Message: {Message}\n" +
                   $"Valid range is 0 to 100.";
        }
        public int AutoCorrectBadPractice()
        {
            if (InvalidMarks < 0) return 0;
            if (InvalidMarks > 100) return 100;
            return InvalidMarks;
        }
    }
}