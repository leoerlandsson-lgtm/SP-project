using System;

namespace SP_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var pikachu = ("Pikachu", 40, 40, 10);
            var bulbasaur = ("Bulbasaur", 45, 45, 8);

            Console.WriteLine("A wild Bulbasaur appeared!");
            Console.WriteLine("------------------------------------------\n");

            while (pikachu.Item2 > 0 && bulbasaur.Item2 > 0)
            {
             
                Console.WriteLine($"--- {pikachu.Item1}s turn ({pikachu.Item2} HP left) ---");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Use Heal Potion (+15 HP)");
                Console.Write("Choose your next move: ");

                string val = Console.ReadLine();
                Console.WriteLine();

                if (val == "1")
                {
                    
                    bulbasaur.Item2 -= pikachu.Item4;
                    Console.WriteLine($"{pikachu.Item1} attacks and makes {pikachu.Item4} hurt!");
                }
                else if (val == "2")
                {
                    
                    pikachu.Item2 += 15;
                    if (pikachu.Item2 > pikachu.Item3) pikachu.Item2 = pikachu.Item3;
                    Console.WriteLine($"{pikachu.Item1} used a Heal Potion!");
                }
                else
                {
                    Console.WriteLine("You hesitated and missed!");
                }

                if (bulbasaur.Item2 <= 0)
                {
                    Console.WriteLine($"\n{bulbasaur.Item1} fainted! {pikachu.Item1} won!");
                    break;
                }

               
                Console.WriteLine($"\n--- {bulbasaur.Item1}s turn ({bulbasaur.Item2} HP left) ---");

                
                pikachu.Item2 -= bulbasaur.Item4;
                Console.WriteLine($"{bulbasaur.Item1} attacks and makes {bulbasaur.Item4} hurt!");

                if (pikachu.Item2 <= 0)
                {
                    Console.WriteLine($"\n{pikachu.Item1} fainted! {bulbasaur.Item1} won!");
                    break;
                }

                Console.WriteLine("\nPress anything to continue...");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("\nYou won the battle!.");
            Console.ReadLine();
        }
    }
} 

