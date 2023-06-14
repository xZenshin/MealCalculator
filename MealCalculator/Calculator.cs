using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace MealCalculator
{
    [Serializable]
    public class Calculator
    {
        private Dictionary<string, NutritionInfo> nutritionDict;

        public Calculator() 
        { 
            nutritionDict = new Dictionary<string, NutritionInfo>();
        }

        public void PrintAll()
        {
            foreach (var item in nutritionDict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        public void addNutritionItem(NutritionInfo n)
        {
            nutritionDict.Add(n.getName(), n);
        }

        public void Save()
        {
            try
            {
                string fileName = "NutrionInfo.json"; 
                string jsonString = JsonSerializer.Serialize(fileName);
                File.WriteAllText(fileName, jsonString);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Load()
        {
            try
            {
                string fileName = "NutrionInfo.json";
                string jsonString = File.ReadAllText(fileName);
                var weatherForecast = JsonSerializer.Deserialize<Dictionary<string, NutritionInfo>>(jsonString)!;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
  
        }
    }
}
