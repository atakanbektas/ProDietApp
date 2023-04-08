using System;
using System.Collections.Generic;

namespace WFA_ProDiet.MODELS.Models
{
    public class Category
    {
        public Category()
        {
            Foods = new List<Food>();
            
        }

        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Food> Foods { get; set; }
    }
}
