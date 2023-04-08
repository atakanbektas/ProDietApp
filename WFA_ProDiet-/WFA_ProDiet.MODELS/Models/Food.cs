using System;
using System.Collections.Generic;
using System.ComponentModel;
using WFA_ProDiet.MODELS.Enums;

namespace WFA_ProDiet.MODELS.Models
{
    public class Food
    {
        public Food()
        {
            MealDetails = new List<MealDetail>();
        }
      
        public int FoodId { get; set; }
        public string Name { get; set; } = null!;
        public string? PicturePath { get; set; }
        public double Calorie { get; set; } = 0;
        public double? Carbohydrate { get; set; } = 0;
        public double? Fat { get; set; } = 0;
        public double? Protein { get; set; } = 0;
        public MeasureType MeasureType { get; set; }
        
        public int? CategoryId { get; set; }
        [Browsable(false)]
        public virtual Category? Category { get; set; }
        [Browsable(false)]
        public virtual ICollection<MealDetail> MealDetails { get; set; }

        public override string ToString()
        {
            return $"{Name} ";
        }
    }
}
