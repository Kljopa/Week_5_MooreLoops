using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!";
            //miil juhul konsoolis kuvatskse "Vale kasutajatunnus või salasõna. Proovi uuesti."
            //kasutaja on kolm katset

            int i = 0;

            while (i < 3)
            {
                i++;
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();

                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                if(i == 3)
                {
                    Console.WriteLine("Rohkem ei ole katset. \nKena päeva!");    //leidsin, kuidas uuele reale kirjutada
                }
                else
                {
                    Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
                    Console.WriteLine($"On jäänud {3 - i} katset.");
                }
            }
            
        }
    }
}
