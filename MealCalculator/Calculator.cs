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
        private NutritionDB DB;
        private XmlSerializer serializer;

        public Calculator() 
        { 
            DB = new NutritionDB();
            //serializer = new XmlSerializer(typeof(item[]), new XmlRootAttribute() { ElementName = "items" });
            //this.Load();
        }

        public void printAll()
        {
            DB.printAll();
        }


        public void calculateMeal(Meal m)
        {
            var i = m.getIngredients();
            
        }

        private (double p, double f, double c) nutritionPerServing(Ingredient i) 
        {
            var nutInfo = DB.getInfoFromName(i.getName());
            var grams = i.getGrams();
            
            var p = (nutInfo.getProtein()) / (Convert.ToDouble(grams));
            var f = (nutInfo.getFat()) / (Convert.ToDouble(grams));
            var c = (nutInfo.getProtein()) / (Convert.ToDouble(grams));

            return (p, f, c);
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
