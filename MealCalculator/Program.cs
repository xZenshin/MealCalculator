
using System.Collections;

namespace MealCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {

            
            Calculator calc = new Calculator();
            /*
            var ing1 = new Ingredient("Oat Meal", 80);
            var ing2 = new Ingredient("Milk", 200);
            Ingredient[] ingArr = {ing1,ing2};

            var ing3 = new Ingredient("Javisst", 140);
            var ing4 = new Ingredient("Chicken Slices", 36);
            var ing5 = new Ingredient("Gouda Skiveost", 47);
            Ingredient[] ingArr2 = {ing3, ing4, ing5};

            var ing6 = new Ingredient("Chicken Breast", 250);
            var ing7 = new Ingredient("Jasmine Rice", 1);
            var ing8 = new Ingredient("Broccoli", 100);
            Ingredient[] ingArr3 = {ing6,ing7,ing8};

            var ing9 = new Ingredient("Protein Powder", 35);
            var ing10 = new Ingredient("Milk", 300);
            Ingredient[] ingArr4 = {ing9,ing10};


            var meal1 = new Meal(MealType.Breakfast, "Havregryn med mælk", ingArr);
            var meal2 = new Meal(MealType.Lunch, "Sandwich", ingArr2);
            var meal3 = new Meal(MealType.Dinner, "Kylling og ris", ingArr3);
            var meal4 = new Meal(MealType.Lunch, "Protein Shake", ingArr4);
            Meal[] mealArr = {meal1,meal2,meal3,meal4};            
            
            calc.calculateMeals(mealArr);
            */

            var ing7 = new Ingredient("Jasmine Rice", 100);
            calc.calculateIngredient(ing7);
            
        }
    }
}