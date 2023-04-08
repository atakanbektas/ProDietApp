using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_ProDiet.MODELS.Models;

namespace WFA_ProDiet.DAL.Controllers
{
    public class MealDetailControllers : ISettable
    {
        public void SetModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MealDetail>(entity =>
            {
                entity.HasKey(e => new { e.MealId, e.FoodId });

                entity.Property(e => e.MealId).HasColumnName("MealID");

                entity.Property(e => e.FoodId).HasColumnName("FoodID");

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.MealDetails)
                    .HasForeignKey(d => d.FoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MealDetails_Foods");

                entity.HasOne(d => d.Meal)
                    .WithMany(p => p.MealDetails)
                    .HasForeignKey(d => d.MealId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MealDetails_Meals");
            });

        }
    }
}
