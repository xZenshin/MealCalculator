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
        private double Calories;
        private double Protein;
        private double Fat;
        private double Carbs;

        public Ingredient(string name, double calories, double protein, double fat, double carbs)
        {
            Name = name;
            Calories = calories;
            Protein = protein;
            Fat = fat;
            Carbs = carbs;
        }

        public string getName() { return Name; }
        public double getCalories() { return Calories; }
        public double getProtein() {  return Protein; }
        public double getFat() { return Fat; } 
        public double getCarbs() {  return Carbs; }
    }
}
