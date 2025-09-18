using GradeSystem.Exceptions;
using GradeSystem.GradeSystem;
using System.Transactions;

namespace GradeSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GradingService service = new GradingService();

            Console.WriteLine("Student Grading System");
            Console.Write("Enter student marks :");

            if (!int.TryParse(Console.ReadLine(), out int inputMarks))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }
            try
            {
                service.ValidateMarks(inputMarks);
            }
            catch (InvalidMarksException ex)
            {
                Console.WriteLine("skill issue found ");
                Console.WriteLine(ex.GetErrorDetails());
                Console.WriteLine("shwoing correct way ");
                Console.WriteLine("exeption corrected itself");
                Console.WriteLine("answer right but bad practise");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" error came {ex.Message}");
                Console.ResetColor();
            }
            Console.WriteLine("correct way to write ");
            int correctedMarks = service.AutoCorrectMarks(inputMarks);
            service.ValidateMarks(correctedMarks);
        }
    }
}