using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            WhirlWind spell1 = new WhirlWind();
            FireBall spell2 = new FireBall();
            book.AddSpell(spell1);
            book.AddSpell(spell2);

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.AddItem(new Staff());
            gandalf.AddItem(book);

            Dwarf gimli = new Dwarf("Gimli");
            gimli.AddItem(new Axe());
            gimli.AddItem(new Helmet());
            gimli.AddItem(new Shield());

            Console.WriteLine($"Gimli has {gimli.Health} HP points");
            Console.WriteLine($"Gandalf attacks Gimli with {gandalf.AttackValue} points.");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has {gimli.Health} HP");

            gimli.Cure();

            Console.WriteLine($"Gimli has {gimli.Health} HP");
        }
    }
}
