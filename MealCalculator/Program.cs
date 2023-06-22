﻿
using System.Collections;

namespace MealCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {

            
            Calculator calc = new Calculator();
            calc.calculateMeals(mealPlan2());

            
            
        }



        public static Meal[] mealPlan1()
        {
            //Havrergyn
            var ing1 = new Ingredient("Oat Meal", 80);
            var ing2 = new Ingredient("Milk", 200);
            Ingredient[] ingArr = {ing1,ing2};

            //Sandwich
            var ing3 = new Ingredient("Javisst", 220);
            var ing4 = new Ingredient("Chicken Slices", 54);
            var ing5 = new Ingredient("Gouda Skiveost", 70);
            Ingredient[] ingArr2 = {ing3, ing4, ing5};

            //Kylling og ris
            var ing6 = new Ingredient("Chicken Breast", 250);
            var ing7 = new Ingredient("Jasmine Rice", 100);
            var ing8 = new Ingredient("Broccoli", 100);
            Ingredient[] ingArr3 = {ing6,ing7,ing8};

            //Proteinshake
            var ing9 = new Ingredient("Protein Powder", 35);
            var ing10 = new Ingredient("Milk", 300);
            Ingredient[] ingArr4 = {ing9,ing10};


            var meal1 = new Meal(MealType.Breakfast, "Havregryn med mælk", ingArr);
            var meal2 = new Meal(MealType.Lunch, "Sandwich", ingArr2);
            var meal3 = new Meal(MealType.Dinner, "Kylling og ris", ingArr3);
            var meal4 = new Meal(MealType.Lunch, "Protein Shake", ingArr4);
            Meal[] mealArr = {meal1,meal2,meal3,meal4};   
            
            return mealArr;        
            }
        public static Meal[] mealPlan2()
        {
            //Havrergyn
            var ing1 = new Ingredient("Oat Meal", 80);
            var ing2 = new Ingredient("Milk", 200);
            Ingredient[] ingArr = {ing1,ing2};

            //Sandwich
            var ing3 = new Ingredient("Javisst", 220);
            var ing4 = new Ingredient("Chicken Slices", 54);
            var ing5 = new Ingredient("Gouda Skiveost", 70);
            Ingredient[] ingArr2 = {ing3, ing4, ing5};

            //Pasta med kødsovs
            var ing6 = new Ingredient("Ground Beef", 133);
            var ing7 = new Ingredient("Pasta", 166);
            var ing420 = new Ingredient("Chopped Tomatoes", 400);
            var ing8 = new Ingredient("Broccoli", 100);
            Ingredient[] ingArr3 = {ing6,ing7,ing8};

            //Proteinshake
            var ing9 = new Ingredient("Protein Powder", 35);
            var ing10 = new Ingredient("Milk", 300);
            Ingredient[] ingArr4 = {ing9,ing10};


            var meal1 = new Meal(MealType.Breakfast, "Havregryn med mælk", ingArr);
            var meal2 = new Meal(MealType.Lunch, "Sandwich", ingArr2);
            var meal3 = new Meal(MealType.Dinner, "Kylling og ris", ingArr3);
            var meal4 = new Meal(MealType.Lunch, "Protein Shake", ingArr4);
            Meal[] mealArr = {meal1,meal2,meal3,meal4};   
            
            return mealArr;        
            }
    }
}