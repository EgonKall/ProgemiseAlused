namespace IfElseAutoMootor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta hobujõud");
            int mootor = 
            


            string mootor = Console.ReadLine();

            if (mootor == "0-100")
            {
                Console.WriteLine("Sinu auto mootori võimusus on 0-100 hj");
            }
            else if (mootor == "101-150")
            {
                Console.WriteLine("Sinu auto mootori võimusus on 0-100 hj");
            }
            else if (mootor == "151-250")
            {
                Console.WriteLine("Sinu auto mootori võimusus on 151-250");
            }
            else
            {
                Console.WriteLine("Üle 250 hj");
            }



        }
    }
}
