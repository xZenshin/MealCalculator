
using System.Collections;

namespace MealCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Ingredient Rice = new Ingredient("Jasmine Rice", 355.0, 9.0, 1.0, 77.0);
            Ingredient Chicken = new Ingredient("Chicken Breast", 165, 31, 3.6, 0.0);
            Ingredient Broccoli = new Ingredient("Broccoli", 35, 2.4, 0.4, 7.2);
            Ingredient[] x = {Rice, Chicken, Broccoli};

            Meal ChickenDinner = new Meal(MealType.Dinner, "Chicken with Rice and Broccoli", x);

            System.Console.WriteLine(ChickenDinner.getName());

        }
    }
}