using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_ProDiet.MODELS.Models;

namespace WFA_ProDiet.DAL.Controllers
{
    public class MealControllers : ISettable
    {
        public void SetModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meal>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50).HasColumnType("nvarchar(50)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Meals)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Meals_Customers");
            });
        }
    }
}
