namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("Pillow", 100.50);
            p.Display();
            EProduct e = new EProduct("Dryer", 499.99, "Sony", 2);
            e.Display();
            Smartphone s = new Smartphone("Smartphone", 50000, "google pixle", 1, "android");
            s.Display();
        }
    }
}
