using System;
using System.Collections.Generic;
using System.Text;

namespace Random_Menu_Generator
{
    class MenuItem
    {
        public Random Randomizer = new Random();
        public string[] Proteins = { "Tofu", "Pastrami", "Ham", "Salami", "Roast beef", "Turkey"};
        public string[] Condiments = { "yellow mustard", "honey mustard", "brown mustard", "mayo", "relish", "french dressing"};
        public string[] Breads = { "pumpernickel", "rye", "white", "wheat", "a roll"};

        public string Description = "";
        public string Price = "";
        

        public void Generate()
        {
            string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];

            Description = randomProtein + " with " + randomCondiment + " on " + randomBread;

            decimal bucks = Randomizer.Next(2, 5);
            decimal cents = Randomizer.Next(1, 98);
            decimal price = bucks + (cents * 0.1M);
            Price = price.ToString("c");
        }
    }
}
