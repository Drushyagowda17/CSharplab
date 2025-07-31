namespace PNZ
{
    public class Program
    {
       public static int num;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
           num = Convert.ToInt32(Console.ReadLine());
            Pnz n = new Pnz(num);
            n.check();
        }
    }
}
