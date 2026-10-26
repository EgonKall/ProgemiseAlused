namespace SwitchTöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number");
            float first = float.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta teine number");
            float second = float.Parse(Console.ReadLine());

            Console.WriteLine("Kui vana sa oled?");
            string input = Console.ReadLine();



            switch (input)
            {
                case "16":
                    Console.WriteLine($"tulemus: {first} * {second} = {first * second} ");
                    break;
                
                default:
                    Console.WriteLine("Ei tööta");
                    break;
            }
            Console.WriteLine("Miau");
        }
    }    
}
