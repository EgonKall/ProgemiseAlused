namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number");
            float firstnr = float.Parse(Console.ReadLine());

            //siin valitakse switchi case
            Console.WriteLine("Vali tehe: *, /, +, -");

            string input = Console.ReadLine();

            Console.WriteLine("Sisesta teine number");
            float secondnr = float.Parse(Console.ReadLine());


            //nüüd tuleb teha switchi valik, kas *, /, +, -
            //tleb teha neli case, kus toimub soovitud tehe
            //peab näitama tehte tulemust
            //kasutage floati Parsimisel


            switch (input)
            {
                case "*":
                    Console.WriteLine($"Korrutamise tulemus: {firstnr} * {secondnr} = {firstnr * secondnr} ");
                    break;
                case "/":
                    if (secondnr == 0 || firstnr == 0)
                    {
                        Console.WriteLine("Nulliga jagamine ei ole lubatud");
                    }
                    else
                    {
                        Console.WriteLine($"Korrutamise tulemus: {firstnr} / {secondnr} = {firstnr / secondnr} ");
                    }
                    break;
                case "+":
                    Console.WriteLine($"Korrutamise tulemus: {firstnr} + {secondnr} = {firstnr + secondnr} ");
                    break;
                case "-":
                    Console.WriteLine($"Korrutamise tulemus: {firstnr} - {secondnr} = {firstnr - secondnr} ");
                    break;
                default:
                    Console.WriteLine("Sellist tehet ei ole");
                    break;
            }

        }
    }
}
