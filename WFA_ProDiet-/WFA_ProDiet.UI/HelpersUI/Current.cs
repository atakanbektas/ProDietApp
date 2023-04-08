using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_ProDiet.MODELS.Enums;
using WFA_ProDiet.MODELS.Models;

namespace WFA_ProDiet.UI.HelpersUI
{
    public static class Current
    {
        public static Customer Customer { get; set; }

        public static void CustomerCalculateBmr()
        {
            if (Customer.Gender == Gender.Man)
            {
                Customer.Bmr = (10 * Customer.Weight) + (6.25 * Customer.Height) - (5 * (DateTime.Now.Year - Customer.BirthDate.Year)) + 5;
            }
            else
            {
                Customer.Bmr = (10 * Customer.Weight) + (6.25 * Customer.Height) - (5 * (DateTime.Now.Year - Customer.BirthDate.Year)) - 161;
            }

            if (Customer.ActivityLevel == ActivityLevel.NoActivitiy)
            {
                Customer.Bmr += 0;
            }
            else if (Customer.ActivityLevel == ActivityLevel.LessActive)
            {
                Customer.Bmr += 100;
            }
            else if (Customer.ActivityLevel == ActivityLevel.Active)
            {
                Customer.Bmr += 200;
            }
            else if (Customer.ActivityLevel == ActivityLevel.MoreActive)
            {
                Customer.Bmr += 400;
            }
        }
        public static void CustomerCalculateNeedKcal()
        {
            TimeSpan diffDate = Customer.TargetDate.Date - DateTime.Now.Date; // gerekli gün sayısı
            int difDay = diffDate.Days;

            Customer.TargetCalorie = Customer.Bmr + ((Customer.TargetWeight - Customer.Weight) * 7000) / (difDay); // günde harcaması gereken kalori

          

            if (Customer.TargetCalorie < 1200)
            {
                Customer.TargetCalorie = 1200;
                MessageBox.Show("Hedef kiloya ulaşmak için bu süre sağlığınız için uygun değildir. Sizin için en yakın tarihi biz seçtik!");
            }
            else if (Customer.TargetCalorie > 2500)
            {
                Customer.TargetCalorie = 2500;
                MessageBox.Show("Hedef kiloya ulaşmak için bu süre sağlığınız için uygun değildir. Sizin için en yakın tarihi biz seçtik!");
            }
            else
            {
                MessageBox.Show("Seçtiğiniz tarih uygun.");
            }

            if (Customer.TargetCalorie != Customer.Bmr) // hedef kilosunda ise
            {
                difDay = (int)(((Customer.TargetWeight - Customer.Weight) * 7000) / (Customer.TargetCalorie - Customer.Bmr)); // gereken gün hesaplandı 
            }
            Customer.TargetDate = DateTime.Now.AddDays(difDay); // datetimepickerda seçildi.
        }

        public static void CustomerCreatePlan(int height, double currentWeight, double targetWeight, DateTime targetDate)
        {
            Customer.Height = height;
            Customer.Weight = currentWeight;
            Customer.TargetWeight = targetWeight;
            Customer.TargetDate = targetDate;
        }
    }
}
