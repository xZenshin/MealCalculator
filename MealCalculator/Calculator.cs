using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MealCalculator
{
    public class Calculator
    {
        private Dictionary<string, NutritionInfo> nutritionDict;

        public Calculator() { }

        public void Save()
        {
            try
            {
                WriteToBinaryFile("NutritionInfo", nutritionDict);
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
