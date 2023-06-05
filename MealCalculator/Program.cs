
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
            Console.WriteLine("Printing All");
            calc.PrintAll();
            Console.WriteLine("Printing Done");

            calc.addNutritionItem(N1);
            calc.addNutritionItem(N2);

            //Console.WriteLine("Start Save");
            calc.Save2();
            //Console.WriteLine("Save Complete");

            Console.WriteLine("Start Load");
            calc.Load2();
            Console.WriteLine("Load Complete");
            Console.WriteLine("Printing All");

            calc.PrintAll();

        }
    }
}