using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_ProDiet.MODELS.Models;

namespace WFA_ProDiet.DAL.Controllers
{
    public  class CategoryControllers : ISettable
    {
        public void SetModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });
            modelBuilder.Entity<Food>(entity =>
            {
                entity.Property(f => f.MeasureType).HasColumnType("nvarchar(50)");
            });
        }
    }
}
