using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace MealCalculator
{
    [Serializable]
    public class Calculator
    {
        private Dictionary<string, NutritionInfo> nutritionDict;
        private XmlSerializer serializer;

        public Calculator() 
        { 
            nutritionDict = new Dictionary<string, NutritionInfo>();
            serializer = new XmlSerializer(typeof(item[]), new XmlRootAttribute() { ElementName = "items" });
            //this.Load();
        }

        public void PrintAll()
        {
            Console.WriteLine("Printing All: ");
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
                //string fileName = "NutrionInfo.json"; 
                //string jsonString = JsonSerializer.Serialize(nutritionDict);
                //File.WriteAllText(fileName, jsonString);
                //serializer.Serialize(stream, nutritionDict.Select(kv=>new item(){id = kv.Key,value=kv.Value}).ToArray() )
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
    public class item   
    {
        [XmlAttribute]
        public string name;
        [XmlAttribute]
        public NutritionInfo value;
    }
}
