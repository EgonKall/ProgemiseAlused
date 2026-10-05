namespace IfElseMaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta maja suurus");
            int maja = int.Parse(Console.ReadLine());

            if (maja >= 0 && maja <= 40)
            {
                Console.WriteLine($"Sinu maja suurus on {maja} m2");
            }
            else if (maja >= 41 && maja <= 90)
            {
                Console.WriteLine($"Sinu maja suurus on {maja} m2");
            }
            else if (maja >= 91 && maja <= 130)
            {
                Console.WriteLine($"Sinu maja suurus on {maja} m2");
            }
            else if (maja >= 131)
            {
                Console.WriteLine($"Sinu maja suurus on {maja} m2");
            }
            else
            {
                Console.WriteLine("Sisestatud väärtus ei kehti");
            }



        }
    }
}
