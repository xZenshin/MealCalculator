
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
            addNutritionItem(new NutritionInfo("Chicken Breast", 21.0, 3.6, 0.0));
            addNutritionItem(new NutritionInfo("Ground Beef", 19, 8, 0));
            addNutritionItem(new NutritionInfo("Pasta", 12.0, 1.2, 71.0));
            addNutritionItem(new NutritionInfo("Chopped Tomatoes", 1.2, 0.2, 3.9));
            addNutritionItem(new NutritionInfo("Broccoli", 2.4, 0.4, 7.2));
            addNutritionItem(new NutritionInfo("Cottage Cheese", 12.0, 1.5, 2.0));
            addNutritionItem(new NutritionInfo("Egg", 12.0, 9.5, 1.2));
            addNutritionItem(new NutritionInfo("Milk", 3.5, 0.4, 4.7));
            addNutritionItem(new NutritionInfo("Gouda Skiveost", 24.0, 28.0, 0.5));
            addNutritionItem(new NutritionInfo("Chicken Slices", 21.0, 1.5, 2.0));
            addNutritionItem(new NutritionInfo("Raisins", 3.0, 0.7, 77.0));
            addNutritionItem(new NutritionInfo("Peanut Butter", 24.5, 48.3, 16.9));
            addNutritionItem(new NutritionInfo("Whole Grain Bread", 8.0, 3.0, 41.0));
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
                throw new Exception("Ingredient not found: " + name);
            }
        }
    }
}
