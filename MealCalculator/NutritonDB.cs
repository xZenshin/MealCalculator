
namespace MealCalculator
{
    
    public class NutritionDB
    {
        private Dictionary<string, NutritionInfo> DB;

        public NutritionDB()
        {
            DB = new Dictionary<string, NutritionInfo>();
            fillDB();
        }

        private void fillDB() 
        {
            addNutritionItem(new NutritionInfo("Jasmine Rice", 9.0, 0.3, 77.0));
            addNutritionItem(new NutritionInfo("Oat Meal", 13.0, 1.1, 58.0));
            addNutritionItem(new NutritionInfo("Javisst", 10.0, 6.5, 43.0));
            addNutritionItem(new NutritionInfo("Protein Powder", 70, 6.5, 8));
            addNutritionItem(new NutritionInfo("Chicken Breast", 31.0, 3.6, 0.0));
            addNutritionItem(new NutritionInfo("Ground Beef", 19, 9.7, 0));
            addNutritionItem(new NutritionInfo("Pasta", 12.0, 1.2, 71.0));
            addNutritionItem(new NutritionInfo("Chopped Tomatoes", 1.2, 0.2, 3.9));
            addNutritionItem(new NutritionInfo("Broccoli", 2.4, 0.4, 7.2));
        }

        public void addNutritionItem(NutritionInfo n)
        {
            DB.Add(n.getName(), n);
        }

        public void printAll()
        {
            foreach (var item in DB)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        public NutritionInfo getInfoFromName(string name)
        {
            try 
            {
                return DB[name];
            } 
            catch(Exception e)
            {
                throw new Exception("Ingredient not found");
            }
        }
    }
}
