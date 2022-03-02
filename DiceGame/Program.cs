using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem;
            //mängija, kes viskas rohkem, ongi võitja;
            //*täringuid visatakse kolm korda;
            //programm kuulab võitjat;

            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random();

                //arvuti vise
                int cpuRandom = rnd.Next(1, 7);
                //kasutaja vise
                int userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on mängu võitnud.");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }
            }
            Console.WriteLine($"Mängu skoor--> Kasutaja {userScore} : Arvuti {cpuScore}");

            if (cpuScore < userScore)
            {
                Console.WriteLine("Kolme mängu võitja: Kasutaja.");
            }
            else if (cpuScore > userScore)
            {
                Console.WriteLine("Kolme mängu võitja: Arvuti."); 
            }
            else
            {
                Console.WriteLine("Kolme mängu järel viik.");
            }
            Console.WriteLine("Head päeva!");
        }

    }

}   