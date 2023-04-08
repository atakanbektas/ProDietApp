using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_ProDiet.MODELS.Models;

namespace WFA_ProDiet.DAL.Controllers
{
    public class CustomerControllers : ISettable
    {
        public void SetModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {

                entity.Property(e => e.ActivityLevel).HasColumnType("nvarchar(50)");

                entity.Property(e => e.ActivityLevel).HasMaxLength(50);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasColumnType("nvarchar(50)");

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.PicturePath).HasColumnType("nvarchar(MAX)");

                entity.Property(e => e.TargetDate).HasColumnType("date");
            });
        }
    }
}
