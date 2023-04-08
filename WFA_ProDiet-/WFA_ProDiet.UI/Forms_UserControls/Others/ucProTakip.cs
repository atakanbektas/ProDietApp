using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_ProDiet.BLL;
using WFA_ProDiet.MODELS.Enums;
using WFA_ProDiet.MODELS.Models;
using WFA_ProDiet.UI.HelpersUI;

namespace WFA_ProDiet.UI
{
    public partial class ucProTakip : UserControl
    {
        public ucProTakip()
        {
            InitializeComponent();
            lblTargetCalorie.Text = (Convert.ToInt32(Current.Customer.TargetCalorie)).ToString();      
            lblCurrentKcalBF.Text = GetCurrentKcal(MealName.Breakfast);
            lblCurrentKcalLunch.Text = GetCurrentKcal(MealName.Lunch);
            lblCurrentKcalDinner.Text = GetCurrentKcal(MealName.Dinner);
            lblCurrentKcalExtra.Text = GetCurrentKcal(MealName.Extra);
        }

        private string GetCurrentKcal(MealName mealName)
        {
            Meal calorie = CrudProcess.Search<Meal>(x => x.EatDay == dtpMealDate.Value.Date && x.Name == mealName && x.CustomerId == Current.Customer.CustomerId).FirstOrDefault();
            if (calorie != null)
            {
                return calorie.MealCalorie.ToString();
            }

            return "0";

        }

        private void btnAddBreakFast_Click(object sender, EventArgs e)
        {
            ShowDialogAddMeals(lblBreakfast.Text, dtpMealDate.Value);
        }
        private void btnAddLunch_Click(object sender, EventArgs e)
        {
            ShowDialogAddMeals(lblLunch.Text, dtpMealDate.Value);
        }
        private void btnAddDinner_Click(object sender, EventArgs e)
        {
            ShowDialogAddMeals(lblDinner.Text, dtpMealDate.Value);
        }
        private void btnAddExtra_Click(object sender, EventArgs e)
        {
            ShowDialogAddMeals(lblExtra.Text, dtpMealDate.Value);
        }
        private void ShowDialogAddMeals(string mealName, DateTime date)
        {
            AddMeals addMeals = new AddMeals(mealName, date);
            addMeals.ShowDialog();
        }

        private void pnlCurrentKcal_Paint(object sender, PaintEventArgs e)
        {

        }

        public void dtpMealDate_ValueChanged(object sender, EventArgs e)
        {
            lblTargetCalorie.Text = (Convert.ToInt32(Current.Customer.TargetCalorie)).ToString(); 
            lblCurrentKcalBF.Text = GetCurrentKcal(MealName.Breakfast);
            lblCurrentKcalLunch.Text = GetCurrentKcal(MealName.Lunch);
            lblCurrentKcalDinner.Text = GetCurrentKcal(MealName.Dinner);
            lblCurrentKcalExtra.Text = GetCurrentKcal(MealName.Extra);

            lblTargetKcalBF.Text = (Convert.ToDouble(lblTargetCalorie.Text) * 0.25).ToString();
            lblTargetKcalDinner.Text = (Convert.ToDouble(lblTargetCalorie.Text) * 0.375).ToString();
            lblTargetKcalLunch.Text = (Convert.ToDouble(lblTargetCalorie.Text) * 0.375).ToString();

        }
    }
}
