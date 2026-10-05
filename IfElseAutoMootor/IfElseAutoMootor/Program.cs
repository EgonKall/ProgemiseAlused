namespace IfElseAutoMootor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta hobujõud:");

            int mootor = int.Parse(Console.ReadLine());

            if (mootor >= 0 && mootor <= 100)
            {
                Console.WriteLine($"Sinu auto mootori võimsus on {mootor} hj");
            }
            else if (mootor >= 101 && mootor <= 150)
            {
                Console.WriteLine($"Sinu auto mootori võimsus on {mootor} hj");
            }
            else if (mootor >= 151 && mootor <= 250)
            {
                Console.WriteLine($"Sinu auto mootori võimsus on {mootor} hj");
            }
            else
            {
                Console.WriteLine("Üle 250 hj");
            }
        }
    }
}
