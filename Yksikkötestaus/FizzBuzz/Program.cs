using System;

namespace FizzBuzzHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programRunning = true;
            while (programRunning == true)
            {
                Console.Clear();     
                Console.WriteLine();
                Console.WriteLine("Anna luku väliltä [1-100], [0] lopettaaksesi");
                Console.Write("Luku: ");
                int kayttajanSyote = int.Parse(Console.ReadLine());
                if(kayttajanSyote == 0)
                {
                    programRunning = false;
                    break;
                }
                FizzBuzz fizzBuzz = new FizzBuzz();
                var vastaus = fizzBuzz.Luku(kayttajanSyote);

                Console.WriteLine();
                Console.Write("Vastaus: ");
                Console.WriteLine(vastaus);
                Console.WriteLine();
                Console.WriteLine("Paina mitä tahansa näppäintä jatkaaksesi...");
                Console.ReadKey();
            }
        }
    }
}
