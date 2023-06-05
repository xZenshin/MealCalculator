using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealCalculator
{
    public class NutritionInfo
    {
        private string Name;
        private double Calories;
        private double Protein;
        private double Fat;
        private double Carbs;

        public NutritionInfo(string name, double protein, double fat, double carbs)
        {
            Name = name;
            Protein = protein;
            Fat = fat;
            Carbs = carbs;
            Calories = calculateCalories(Protein, Fat, Carbs);
        }

        private double calculateCalories(double p, double f, double c) 
        {
            return ((p * 4) + (f * 9) + (c * 9));
        }

        public string getName() { return Name; }
        public double getProtein() {  return Protein; }
        public double getFat() { return Fat; } 
        public double getCarbs() {  return Carbs; }
        public double getCalories() { return Calories; }

        public (double Protein, double Fat, double Carbs) getInfoBasedOnName(string name)
        {
            return (Protein, Fat, Carbs);
        }
    }
}
