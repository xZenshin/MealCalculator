﻿using System;
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
        public Calculator() 
        { 
            DB = new NutritionDB();
        }

        public void printAll()
        {
            DB.printAll();
        }


        public void calculateIngredient(Ingredient ingredient)
        {
            var (p,f,c) = nutritionPerServing(ingredient);
            printNutrition(p,f,c);
        }

        public void calculateMealsCappedBy40ProteinPerMeal(Meal[] m)
        {
            double[] totalNutrition = new double[3];
            var cappedProtein = 0.0;
            foreach (Meal i in m)
            {
                var (p, f, c) = calculateMeal(i, true);
                if (p >= 40)
                {
                    cappedProtein += 40;
                } else
                {
                    cappedProtein += p;
                }
                totalNutrition[0] = totalNutrition[0] + p;
                totalNutrition[1] = totalNutrition[1] + f;
                totalNutrition[2] = totalNutrition[2] + c;
            }
            printNutrition(totalNutrition[0], totalNutrition[1], totalNutrition[2]);
            Console.WriteLine($"Total Protein by only counting 40 = {cappedProtein}");

        }

        public void calculateMeals(Meal[] m)
        {
            double[] totalNutrition = new double[3];
            foreach (Meal i in m)
            {
                var (p,f,c) = calculateMeal(i, true);
                totalNutrition[0] = totalNutrition[0] + p;
                totalNutrition[1] = totalNutrition[1] + f;
                totalNutrition[2] = totalNutrition[2] + c;
            }
            printNutrition(totalNutrition[0], totalNutrition[1], totalNutrition[2]);
        }
        public (double p, double f, double c) calculateMeal(Meal m, bool print = false)
        {
            var Ingredients = m.getIngredients();
            double[] totalNutrition = new double[3];

            foreach (Ingredient i in Ingredients)
            {
                var (p,f,c) = nutritionPerServing(i);
                totalNutrition[0] = totalNutrition[0] + p;
                totalNutrition[1] = totalNutrition[1] + f;
                totalNutrition[2] = totalNutrition[2] + c;
            }
            if(print)
            {
                Console.WriteLine("Macros for " + m.getName());
                printNutrition(totalNutrition[0], totalNutrition[1], totalNutrition[2]);
            }
            return (totalNutrition[0], totalNutrition[1], totalNutrition[2]);
        }

        private double calculateCalories(double p, double f, double c) 
        {
            return ((p * 4) + (f * 9) + (c * 4));
        }

        private (double p, double f, double c) nutritionPerServing(Ingredient i) 
        {
            var nutInfo = DB.getInfoFromName(i.getName());
            var grams = i.getGrams();
            
            var p = (nutInfo.getProtein()) * (Convert.ToDouble(grams)/100);
            var f = (nutInfo.getFat()) * (Convert.ToDouble(grams)/100);
            var c = (nutInfo.getCarbs()) * (Convert.ToDouble(grams)/100);

            return (p, f, c);
        }

        private void printNutrition(double p, double f, double c)
        {
            var calories = calculateCalories(p, f, c);
  
            Console.WriteLine("Total Calories = " + calories.ToString());            
            Console.WriteLine("Total Protein = " + p.ToString());            
            Console.WriteLine("Total Fat = " + f.ToString());            
            Console.WriteLine("Total Carbs = " + c.ToString());
            if (calories > 1500)
            {
                Console.WriteLine($"Percent Protein {((p*4) / calories) * 100}");
                Console.WriteLine($"Percent Fat {((f * 9) / calories) * 100}");
                Console.WriteLine($"Percent Carbs {((c * 4) / calories) * 100}");
            }
            Console.WriteLine();
        }
    }
}
