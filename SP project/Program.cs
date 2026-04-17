namespace SP_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two Pokémon to test the system
            Pokemon pikachu = new Pokemon("Pikachu", 35, 10);
            Pokemon bulbasaur = new Pokemon("Bulbasaur", 45, 8);

            // Simple test output
            Console.WriteLine($"{pikachu.Name} HP: {pikachu.HP}");
            Console.WriteLine($"{bulbasaur.Name} HP: {bulbasaur.HP}");
        }
    }

    // FIRST thing you need: a Pokémon class
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

            
            if (target.HP < 0) target.HP = 0;

            Console.WriteLine($"{target.Name} tog {this.Attack} skada och har nu {target.HP} HP kvar.");
        }







    }
}
