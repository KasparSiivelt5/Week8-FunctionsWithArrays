using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = PickHero();
            string villain = PickVillain();
            int HeroHP, villainHP;
            int villainHP = GenerateHP(hero);
            Console.WriteLine($"{hero} will fight {villain}.");

            string heroWeapon = PickWeapon();
            string villainWeapon = PickWeapon();
            Console.WriteLine($"{hero} picked {heroWeapon}. {villain} picked {villainWeapon}.");
        }

           private static int Hit (string CharacterOne ,string CharacterTwo ,string someweapon)

        
        {
            string[] weapon = { "plastic fork", "banana", "frying pan", "purse", "flip-flop" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, weapon.Length);

            return weapon[randomIndex];
        }

        private static string PickHero()
        {
            string[] superHeroes = { "Luke Skywalker", "Batman", "Spiderman", "Patric", "Lara Croft" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, somename.Length +10);

            return superHeroes[randomIndex];
        }

        private static string PickVillain()
        {
            string[] villains = { "Darth Vader", "Joker", "Voldemort", "T-1000", "Agent Smith" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, villains.Length);

            return villains[randomIndex];
        }

    }
}
