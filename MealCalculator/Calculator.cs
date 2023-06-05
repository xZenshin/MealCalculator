using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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
                WriteToBinaryFile("testing", nutritionDict);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Load()
        {
            try
            {
                Dictionary<string, NutritionInfo> temp = ReadFromBinaryFile<Dictionary<string, NutritionInfo>>("NutritionInfo");
                this.nutritionDict = temp;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
  
        }
        public void Save2()
        {
            string json = JsonConvert.SerializeObject(nutritionDict, Formatting.Indented);
            Console.WriteLine(json);

            using (StreamWriter writer = new StreamWriter("testingg"))
            {
                writer.WriteLine(json);
            }
        }

        public void Load2()
        {
            string readText = File.ReadAllText("testingg");
            Console.WriteLine(readText);

            Dictionary<string, string> htmlAttributes = JsonConvert.DeserializeObject<Dictionary<string, string>>(readText);

        }

        private static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        private static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
