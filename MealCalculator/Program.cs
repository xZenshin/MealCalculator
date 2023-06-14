
using System.Collections;

namespace MealCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            NutritionInfo N1 = new NutritionInfo("Jasmine Rice", 9.0, 0.3, 77.0);
            NutritionInfo N2 = new NutritionInfo("Borger", 9.0, 0.3, 77.0);
            Calculator calc = new Calculator();

            
            //calc.addNutritionItem(N1);
            //calc.addNutritionItem(N2);
            //calc.Save();
            calc.Load();
            calc.PrintAll();


        }
    }
}