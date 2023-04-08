using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_ProDiet.MODELS.Models;

namespace WFA_ProDiet.BLL
{
    public static class CrudProcess
    {
        public static List<T> GetAll<T>() where T : class
        {
            return ProDietDb._context.Set<T>().ToList();
        }
        public static bool Add<T>(T model) where T : class
        {
            if (model != null)
            {
                ProDietDb._context.Set<T>().Add(model);
                ProDietDb._context.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool AddRange<T>(List<T> models) where T : class
        {
            if (models != null)
            {
                ProDietDb._context.Set<T>().AddRange(models);
                ProDietDb._context.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool Edit<T>(T model) where T : class 
        {
            if (model != null)
            {
                ProDietDb._context.Set<T>().Attach(model);
                ProDietDb._context.Entry(model).State = EntityState.Modified;
                ProDietDb._context.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool Delete<T>(T model) where T : class 
        {
            if (model != null)
            {
                ProDietDb._context.Set<T>().Remove(model);
                ProDietDb._context.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool DeleteRange<T>(ICollection<T> models) where T : class
        {
            if (models != null)
            {
                ProDietDb._context.Set<T>().RemoveRange(models);
                ProDietDb._context.SaveChanges();
                return true;
            }
            return false;
        }
        public static T GetByID<T>(int id) where T : class
        {
            return ProDietDb._context.Set<T>().Find(id);
        }

        public static List<T> Search<T>(Func<T, bool> predicate) where T : class
        {
            List<T> findedModels = new List<T>();

            foreach (var model in ProDietDb._context.Set<T>())
            {
                if (predicate(model))
                {
                    findedModels.Add(model);
                }
            }
            return findedModels;
        }
    }
}
