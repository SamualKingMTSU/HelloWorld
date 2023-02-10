namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Hello, World!");
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}!");
        }
    }
}