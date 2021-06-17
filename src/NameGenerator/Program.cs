namespace NameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Generate.Name();
            
            System.Console.WriteLine(name);
            System.Console.ReadLine();
        }
    }
}
