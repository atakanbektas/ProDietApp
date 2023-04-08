using System;
using System.Collections.Generic;
using WFA_ProDiet.MODELS.Enums;

namespace WFA_ProDiet.MODELS.Models
{
    public class Meal
    {
        public Meal()
        {
            MealDetails = new List<MealDetail>();
        }
       

        public int MealId { get; set; }
        public MealName Name { get; set; }
        public DateTime EatDay { get; set; } = DateTime.Now;
        public double? MealCalorie { get; set; } = 0;
        public double? MealCarbohydrate { get; set; } = 0;
        public double? MealProtein { get; set; } = 0;
        public double? MealFat { get; set; } = 0;
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual ICollection<MealDetail> MealDetails { get; set; }
    }
}
