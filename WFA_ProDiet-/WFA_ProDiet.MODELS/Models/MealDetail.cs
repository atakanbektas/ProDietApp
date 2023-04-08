using System;
using System.Collections.Generic;

namespace WFA_ProDiet.MODELS.Models
{
    public class MealDetail
    {
        public int MealId { get; set; }
        public int FoodId { get; set; }
        public int Quantity { get; set; } = 1;

        public virtual Food Food { get; set; } = null!;
        public virtual Meal Meal { get; set; } = null!;
    }
}
