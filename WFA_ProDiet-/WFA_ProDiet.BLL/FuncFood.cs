using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_ProDiet.MODELS.Models;

namespace WFA_ProDiet.BLL
{
    public class FuncFood
    {
        public static List<Food> GetFoods()
        {
            return ProDietDb._context.Foods.ToList();
        }
        public static bool AddFood(Food food)
        {
            if (food != null)
            {
                ProDietDb._context.Foods.Add(food);
                ProDietDb._context.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool AddRangeFood(List<Food> food)
        {
            if (food != null)
            {
                ProDietDb._context.Foods.AddRange(food);
                ProDietDb._context.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool UpdateFood(Food food)
        {
            if (food != null)
            {
                ProDietDb._context.Foods.Attach(food);
                ProDietDb._context.Entry(food).State = EntityState.Modified;
                ProDietDb._context.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool RemoveFood(Food food)
        {
            if (food != null)
            {
                ProDietDb._context.Foods.Remove(food);
                ProDietDb._context.SaveChanges();
                return true;
            }
            return false;

        }
        public static bool RemoveRangeFood(ICollection<Food> foods)
        {
            if (foods != null)
            {
                ProDietDb._context.Foods.RemoveRange(foods);
                ProDietDb._context.SaveChanges();
                return true;
            }
            return false;

        }

        public static Food GetFoodByID(int foodID)
        {
            return ProDietDb._context.Foods.Find(foodID);
        }

        public static List<Food> SearchFood(Func<Food, bool> predicate)
        {
            List<Food> findedFoods = new List<Food>();

            foreach (Food food in ProDietDb._context.Foods)
            {
                if (predicate(food))
                {
                    findedFoods.Add(food);
                }
            }

            return findedFoods;
        }
    }
}
