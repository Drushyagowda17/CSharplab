namespace RevNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Rev r = new Rev(num);
           
            r.process();
            r.display();
        }
    }
}
