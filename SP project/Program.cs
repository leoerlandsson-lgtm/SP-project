using System;

namespace SP_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapa två Pokémon att testa systemet med
            Pokemon pikachu = new Pokemon("Pikachu", 35, 10);
            Pokemon bulbasaur = new Pokemon("Bulbasaur", 45, 8);

            Console.WriteLine("Striden börjar! En vild Bulbasaur dyker upp!");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Tryck på ENTER för att gå vidare i striden...\n");
            Console.ReadLine();

            
            while (pikachu.HP > 0 && bulbasaur.HP > 0)
            {
               
                pikachu.AttackTarget(bulbasaur);

                
                if (bulbasaur.HP <= 0)
                {
                    Console.WriteLine($"\n{bulbasaur.Name} svimmade! {pikachu.Name} vann striden!");
                    break; 
                }

                Console.ReadLine(); 

                
                bulbasaur.AttackTarget(pikachu);

                
                if (pikachu.HP <= 0)
                {
                    Console.WriteLine($"\n{pikachu.Name} svimmade! {bulbasaur.Name} vann striden!");
                    break; 
                }

                Console.ReadLine(); 
                Console.WriteLine("--- Nästa runda ---");
            }

            Console.WriteLine("\nStriden är slut! Tack för att du spelade.");
            Console.ReadLine(); // Håller kvar konsolfönstret i slutet
        }
    }

    // Din Pokémon-klass
    public class Pokemon
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }

        public Pokemon(string name, int hp, int attack)
        {
            Name = name;
            HP = hp;
            Attack = attack;
        }

        public void AttackTarget(Pokemon target)
        {
            Console.WriteLine($"{this.Name} attackerar {target.Name}!");
            target.HP -= this.Attack;

            // Om HP hamnar under 0, sätt det till 0 så det ser snyggare ut i texten
            if (target.HP < 0) target.HP = 0;

            Console.WriteLine($"{target.Name} tog {this.Attack} skada och har nu {target.HP} HP kvar.");
        }
    }
}