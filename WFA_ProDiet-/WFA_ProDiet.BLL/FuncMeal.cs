using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_ProDiet.MODELS.Models;

namespace WFA_ProDiet.BLL
{
    public class FuncMeal
    {
        public static List<Meal> GetMeals()
        {
            return ProDietDb._context.Meals.ToList();
        }
        public static bool AddMeal(Meal meal)
        {
            if (meal != null)
            {
                ProDietDb._context.Meals.Add(meal);
                ProDietDb._context.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool AddRangeMeal(List<Meal> meals)
        {
            if (meals != null)
            {
                ProDietDb._context.Meals.AddRange(meals);
                ProDietDb._context.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool UpdateMeal(Meal meal)
        {
            if (meal != null)
            {
                ProDietDb._context.Meals.Attach(meal);
                ProDietDb._context.Entry(meal).State = EntityState.Modified;
                ProDietDb._context.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool RemoveMeal(Meal meal)
        {
            if (meal != null)
            {
                ProDietDb._context.Meals.Remove(meal);
                ProDietDb._context.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool RemoveRangeMeal(ICollection<Meal> meals)
        {
            if (meals != null)
            {
                ProDietDb._context.Meals.RemoveRange(meals);
                ProDietDb._context.SaveChanges();
                return true;
            }
            return false;
        }

        public static Meal GetMealsByID(int mealID)
        {
            return ProDietDb._context.Meals.Find(mealID);
        }

        public static List<Meal> SearchCustomer(Func<Meal, bool> predicate)
        {
            List<Meal> findedMeals = new List<Meal>();

            foreach (Meal user in ProDietDb._context.Meals)
            {
                if (predicate(user))
                {
                    findedMeals.Add(user);
                }
            }
            return findedMeals;
        }

    }
}
