using GradeSystem.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeSystem
{
    namespace GradeSystem
    {
        public class GradingService
        {
            public void ValidateMarks(int marks)
            {
                Console.WriteLine($"Validating marks: {marks}");

                if (marks < 0 || marks > 100)
                {
                    throw new InvalidMarksException(marks);
                }

                Console.WriteLine($"SUCCESS: Marks {marks} are valid.");
                Console.ResetColor();
            }

            public int AutoCorrectMarks(int marks)
            {
                if (marks < 0)
                {
                    Console.WriteLine($"[Auto-Correction]: Adjusting negative marks ({marks}) to 0.");
                    return 0;
                }
                if (marks > 100)
                {
                    Console.WriteLine($"[Auto-Correction]: Adjusting overflow marks ({marks}) to 100.");
                    return 100;
                }
                return marks;
            }
        }
    }
}
