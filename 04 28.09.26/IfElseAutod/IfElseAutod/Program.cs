using System.Threading.Channels;

namespace IfElseAutod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta automark");
            //kasutada if ja else
            //kirjutada automark
            //valikus on BMW, Audi, Porsche,Skoda
            //Kui valitakse Skoda, siis seal ees on uuesti küsimus,et
            //mis mudelit soovid valida. Mudeli valikuks on Kodiaq ja Octavia

            Console.WriteLine("");

            string automark = Console.ReadLine();

            if (automark == "BMW")
            {
                Console.WriteLine("See on BMW");
            }
            else if (automark == "Audi")
            {
                Console.WriteLine("See on Audi");
            }
            else if (automark == "Porsche")
            {
                Console.WriteLine("See on Porsche");
            }
            else if (automark == "Skoda")
            {
                Console.WriteLine("See on Skoda");
                Console.WriteLine("Mis mudelit soovid? Kodiaq või Octavia");
                string mudel = Console.ReadLine();

                if (mudel == "Kodiaq")
                {
                    Console.WriteLine("Valisid Kodiaqi");
                }
                else if (mudel == "Octavia")
                {
                    Console.WriteLine("Valisid Octavia");
                }
                else
                {
                    Console.WriteLine("Ei valinud midagi");
                }
            }
            else
            {
                Console.WriteLine("Ei valinud automarki");
            }
        }
    }
}
