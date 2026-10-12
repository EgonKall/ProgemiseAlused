namespace SwitchColour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta värv");
            //kasutada switchi
            //sisestab värvi nime
            //Red, Green , Blue , White ja Yellow
            //iga värvi puhul näitab vastava värviga konsooli + tekst
            //kui sisestatakse muu värv, siis näitab "Värv puudub"
            string värv = Console.ReadLine();

            switch (värv)
            {
                case "Red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Red");
                    break;
                case "Green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("Green");
                    break;
                case "Blue":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.WriteLine("Blue");
                    break;
                case "White":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("White");
                    break;
                case "Yellow":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.WriteLine("Yellow");
                    break;
                default:
                    Console.WriteLine("Värv puudub");
                    break;
            }
        }
    }
}
