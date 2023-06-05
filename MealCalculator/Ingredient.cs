using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealCalculator
{
    public class Ingredient
    {
        private string Name;
        private int Grams;

        public Ingredient(string name, int grams)
        {
            Name = name;
            Grams = grams;
        }

        public string getName() { return Name; }
        public int getGrams() { return Grams; }
    }
}
