using System;

namespace SP_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var pikachu = ("Pikachu", 40, 40, 10);
            var bulbasaur = ("Bulbasaur", 45, 45, 8);

            Console.WriteLine("Striden börjar! En vild Bulbasaur dyker upp!");
            Console.WriteLine("------------------------------------------\n");

            while (pikachu.Item2 > 0 && bulbasaur.Item2 > 0)
            {
             
                Console.WriteLine($"--- {pikachu.Item1}s tur ({pikachu.Item2} HP kvar) ---");
                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("1. Attackera");
                Console.WriteLine("2. Använd Heal Potion (+15 HP)");
                Console.Write("Gör ditt val (1-2): ");

                string val = Console.ReadLine();
                Console.WriteLine();

                if (val == "1")
                {
                    
                    bulbasaur.Item2 -= pikachu.Item4;
                    Console.WriteLine($"{pikachu.Item1} attackerar och gör {pikachu.Item4} skada!");
                }
                else if (val == "2")
                {
                    
                    pikachu.Item2 += 15;
                    if (pikachu.Item2 > pikachu.Item3) pikachu.Item2 = pikachu.Item3;
                    Console.WriteLine($"{pikachu.Item1} använde en Heal Potion!");
                }
                else
                {
                    Console.WriteLine("Du tvekade och missade din chans!");
                }

                if (bulbasaur.Item2 <= 0)
                {
                    Console.WriteLine($"\n{bulbasaur.Item1} svimmade! {pikachu.Item1} vann!");
                    break;
                }

               
                Console.WriteLine($"\n--- {bulbasaur.Item1}s tur ({bulbasaur.Item2} HP kvar) ---");

                
                pikachu.Item2 -= bulbasaur.Item4;
                Console.WriteLine($"{bulbasaur.Item1} attackerar och gör {bulbasaur.Item4} skada!");

                if (pikachu.Item2 <= 0)
                {
                    Console.WriteLine($"\n{pikachu.Item1} svimmade! {bulbasaur.Item1} vann!");
                    break;
                }

                Console.WriteLine("\nTryck på valfri tangent för nästa runda...");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("\nStriden är slut! Tack för att du spelade.");
            Console.ReadLine();
        }
    }
} 

