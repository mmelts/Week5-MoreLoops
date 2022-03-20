using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //ˇmängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //mängija, kes viskab rohkem, ongi mängu võitja
            //*täringuid visatakse kolm korda
            //programm kuulutab võitjat.

            Random rnd = new Random();

           
            int cpuScore = 0;
            int userScore = 0;
            for (int i = 0; i < 5; i++)
            {
                //arvuti vise
                int cpuRandom = rnd.Next(1, 7);
                //kasutaja vise
                int userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas: {cpuRandom}");
                Console.WriteLine($"Kasutaja viskas: {userRandom}");

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
            if (cpuScore < userScore)
            {
                Console.WriteLine($"Teie võit {userScore} : {cpuScore}");
            }
            else if (cpuScore > userScore)
            {
                Console.WriteLine($"Arvuti võit {cpuScore} : {userScore}");
            }
            else
            {
                Console.WriteLine("Teil vedas, jäite viiki!");
            }


        }
    }
}
