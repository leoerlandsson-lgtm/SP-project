using System;

namespace SP_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Pokemon pikachu = new Pokemon("Pikachu", 40, 10);
            Pokemon bulbasaur = new Pokemon("Bulbasaur", 45, 8);

            Console.WriteLine("Striden börjar! En vild Bulbasaur dyker upp!");
            Console.WriteLine("------------------------------------------\n");

            
            while (pikachu.HP > 0 && bulbasaur.HP > 0)
            {
                
                Console.WriteLine($"--- {pikachu.Name}s tur ({pikachu.HP} HP kvar) ---");
                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("1. Attackera");
                Console.WriteLine("2. Använd Heal Potion (+15 HP)");
                Console.Write("Gör ditt val (1-2): ");

                string val = Console.ReadLine();
                Console.WriteLine();

                if (val == "1")
                {
                    pikachu.AttackTarget(bulbasaur);
                }
                else if (val == "2")
                {
                    pikachu.Heal();
                }
                else
                {
                    
                    Console.WriteLine("Du tvekade och missade din chans att agera!");
                }

                
                if (bulbasaur.HP <= 0)
                {
                    Console.WriteLine($"\n{bulbasaur.Name} svimmade! {pikachu.Name} vann striden!");
                    break; 
                }

                
                Console.WriteLine("\nTryck på valfri tangent för datorns tur...");
                Console.ReadKey();
                Console.Clear(); 

               
                Console.WriteLine($"--- {bulbasaur.Name}s tur ({bulbasaur.HP} HP kvar) ---");

                
                bulbasaur.AttackTarget(pikachu);

                
                if (pikachu.HP <= 0)
                {
                    Console.WriteLine($"\n{pikachu.Name} svimmade! {bulbasaur.Name} vann striden!");
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

    public class Pokemon
    {
       
        public string Name { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; } 
        public int Attack { get; set; }

        
        public Pokemon(string name, int hp, int attack)
        {
            Name = name;
            HP = hp;
            MaxHP = hp; 
            Attack = attack;
        }

        
        public void AttackTarget(Pokemon target)
        {
            Console.WriteLine($"{this.Name} attackerar {target.Name}!");
            target.HP -= this.Attack;

            
            if (target.HP < 0)
            {
                target.HP = 0;
            }

            Console.WriteLine($"{target.Name} tog {this.Attack} skada och har nu {target.HP} HP kvar.");
        }

       
        public void Heal()
        {
            int healAmount = 15;
            this.HP += healAmount;

            
            if (this.HP > this.MaxHP)
            {
                this.HP = this.MaxHP;
            }

            Console.WriteLine($"{this.Name} drack en Potion och helade sig till {this.HP} HP!");
        }
    }
}