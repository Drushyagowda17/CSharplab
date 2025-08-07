namespace DataEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person Person1 = new Person();

            Person1.Name = "dhaiwik";
            Person1.Age = 25;
            Console.WriteLine($"Name: {Person1.Name} Age: {Person1.Age}");
        }
    }
}
