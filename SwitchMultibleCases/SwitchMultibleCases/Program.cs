namespace SwitchMultibleCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multible cases!");

            string input = Console.ReadLine();

            switch (input)
            {
                case "Intro to C#" or "Data Types":
                    Console.WriteLine("Basic");
                    break;

                case "OOP" or "Classes" or "Objects":
                    Console.WriteLine("Intermediate");
                    break;

                case "Asynchronous programming" or "LINQ" or "Delegates":
                    Console.WriteLine("Advanced");
                    break;

                default:
                    Console.WriteLine("Unknown course");
                    break;
            }
        }
    }
}
