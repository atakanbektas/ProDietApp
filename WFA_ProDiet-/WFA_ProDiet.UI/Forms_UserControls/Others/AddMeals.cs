using Microsoft.VisualBasic;
using OxyPlot;
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
    public partial class AddMeals : Form
    {
        public AddMeals(string mealName, DateTime dateTime)
        {
            InitializeComponent();
            lblMealName.Text = mealName;
            dtpMealDate.Value = dateTime;
        }

        private void AddMeals_Load(object sender, EventArgs e)
        {
            dgvFoods.DataSource = CrudProcess.GetAll<Food>();
            dgvFoods.Columns["PicturePath"].Width = 0;

            txtFood.Text = "";
            lstMealRefresh();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            Meal addmeal = GetDayMeal();
            Food food = (Food)dgvFoods.CurrentRow.DataBoundItem;

            MealDetail md = GetMealDetail(food, addmeal);
            //CrudProcess.GetAll<MealDetail>().Where(x => x.Food == food && x.Meal == addmeal).FirstOrDefault();
            if (md == null)//bu öğün aynı yemekten içeriyor mu?
            {
                double quantity = (double)nudQuantity.Value;

                var foodControl = ProDietDb._context.Meals.Where(x => x.EatDay == dtpMealDate.Value.Date && x.Name == GetMealName() && x.CustomerId == Current.Customer.CustomerId).ToList();

                if (foodControl.Count == 0)
                {
                    addmeal = new()
                    {
                        Customer = Current.Customer,
                        CustomerId = Current.Customer.CustomerId,
                        EatDay = dtpMealDate.Value.Date,
                        MealCalorie = (food.Calorie * quantity),
                        MealCarbohydrate = ((double)food.Carbohydrate * quantity),
                        MealProtein = ((double)food.Protein * quantity),
                        MealFat = ((double)food.Fat * quantity)

                    };
                    addmeal.Name = GetMealName();
                    CrudProcess.Add(addmeal);
                }
                else
                {
                    addmeal.MealCalorie += (food.Calorie * quantity);
                    addmeal.MealCarbohydrate += ((double)food.Carbohydrate * quantity);
                    addmeal.MealProtein += ((double)food.Protein * quantity);
                    addmeal.MealFat += ((double)food.Fat * quantity);
                    CrudProcess.Edit(addmeal);
                }

                MealDetail mealDetail = new() { Food = food, FoodId = food.FoodId, Meal = addmeal, MealId = addmeal.MealId, Quantity = (int)quantity };

                CrudProcess.Add(mealDetail);
            }
            else
            {
                MessageBox.Show("Seçtiğiniz yemeği daha önce öğününüze eklenmiş, öğününüzdeki yemeğin adetini değişitirmek isterseniz,adet alanından değişklik yapıp yaparak 'GÜNCELLE' butonuna basınız. ");
            }

            lstMealRefresh();
            nudQuantity.Value = 1;
        }

        private void txtSearchFood_TextChanged(object sender, EventArgs e)
        {
            //Yemek Arama-ok
            dgvFoods.DataSource = CrudProcess.Search<Food>(x => x.Name.ToLower().Contains(txtSearchFood.Text.ToLower()));
        }

        private void cbOrderByFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fİltreleme-ok
            if (cbOrderByFilter.SelectedIndex == 0)
            {
                dgvFoods.DataSource = CrudProcess.GetAll<Food>().OrderBy(x => x.Carbohydrate).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 1)
            {
                dgvFoods.DataSource = CrudProcess.GetAll<Food>().OrderBy(x => x.Protein).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 2)
            {
                dgvFoods.DataSource = CrudProcess.GetAll<Food>().OrderByDescending(x => x.Calorie).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 3)
            {
                dgvFoods.DataSource = CrudProcess.GetAll<Food>().OrderBy(x => x.Calorie).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 4)
            {
                dgvFoods.DataSource = CrudProcess.GetAll<Food>().OrderByDescending(x => x.Protein).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 5)
            {
                dgvFoods.DataSource = CrudProcess.GetAll<Food>().OrderBy(x => x.Protein).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 6)
            {
                dgvFoods.DataSource = CrudProcess.GetAll<Food>().OrderByDescending(x => x.Carbohydrate).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 7)
            {
                dgvFoods.DataSource = CrudProcess.GetAll<Food>().OrderBy(x => x.Carbohydrate).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 8)
            {
                dgvFoods.DataSource = CrudProcess.GetAll<Food>().OrderByDescending(x => x.Fat).ToList();
            }
            else if (cbOrderByFilter.SelectedIndex == 9)
            {
                dgvFoods.DataSource = CrudProcess.GetAll<Food>().OrderBy(x => x.Fat).ToList();
            }
        }

        private void dtpMealDate_ValueChanged(object sender, EventArgs e)
        {
            lstMealRefresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Food newFood = (Food)dgvFoods.CurrentRow.DataBoundItem;
            Food removeFood = (Food)lstDailyMeal.SelectedItem;
            Meal meal = GetDayMeal();
            MealDetail md = GetMealDetail(newFood, meal);
            MealDetail updateFoodFromMeal = GetMealDetail(removeFood, meal);

            if (newFood != null && meal != null && removeFood != null && updateFoodFromMeal != null)
            {
                CrudProcess.Delete(updateFoodFromMeal);
                int newQuantity = (md == null) ? ((int)nudQuantity.Value) : ((int)nudQuantity.Value - updateFoodFromMeal.Quantity);
                if (md != null)//eğer aynı yemeğin sadece adetini değiştireceksem
                {
                    meal.MealCalorie += (newFood.Calorie * newQuantity);
                    meal.MealCarbohydrate += (newFood.Carbohydrate * newQuantity);
                    meal.MealProtein += (newFood.Protein * newQuantity);
                    meal.MealFat += (newFood.Fat * newQuantity);

                }
                else
                {
                    updateFoodFromMeal.FoodId = newFood.FoodId;
                    updateFoodFromMeal.Food = newFood;
                    //calori güncelleme
                    meal.MealCalorie += ((newFood.Calorie * newQuantity) - (removeFood.Calorie * updateFoodFromMeal.Quantity));

                    meal.MealCarbohydrate += ((newFood.Carbohydrate * newQuantity) - (removeFood.Carbohydrate * updateFoodFromMeal.Quantity));

                    meal.MealProtein += ((newFood.Protein * newQuantity) - (removeFood.Protein * updateFoodFromMeal.Quantity));

                    meal.MealFat += ((newFood.Fat * newQuantity) - (removeFood.Fat * updateFoodFromMeal.Quantity));

                }

                updateFoodFromMeal.Quantity = (int)nudQuantity.Value;
                CrudProcess.Add(updateFoodFromMeal);

                CrudProcess.Edit(meal);

            }
            lstMealRefresh();
        }


        private void lstDailyMeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDailyMeal.SelectedIndex != -1)
            {
                Meal meal = GetDayMeal();
                Food selectedFood = (Food)lstDailyMeal.SelectedItem;
                nudQuantity.Value = (selectedFood.MealDetails.Where(x => x.Food == selectedFood && x.Meal == meal).FirstOrDefault().Quantity);

                int foodID = ProDietDb._context.Foods.Where(x => x.FoodId == ((Food)lstDailyMeal.SelectedItem).FoodId).FirstOrDefault().FoodId;

                foreach (DataGridViewRow row in dgvFoods.Rows)//row seçme
                {
                    if ((int)row.Cells["FoodId"].Value == foodID)
                    {
                        dgvFoods.CurrentCell = row.Cells[0];
                        row.Selected = true;
                        txtFood.Text = row.Cells["Name"].Value.ToString();
                        lblMeasure.Text = row.Cells["MeasureType"].Value.ToString();
                        break;
                    }
                }
            }
        }
        private void dgvFoods_SelectionChanged(object sender, EventArgs e)
        {
            txtFood.Text = dgvFoods.CurrentRow.Cells["Name"].Value.ToString();
            lblMeasure.Text = dgvFoods.CurrentRow.Cells["MeasureType"].Value.ToString();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Meal meal = GetDayMeal();
            Food food = ((Food)lstDailyMeal.SelectedItem);
            MealDetail removefood = GetMealDetail(food, meal);
            if (food != null && meal != null && meal.MealDetails.Count > 1)//food remove olunca sadece cross tablodan silinir, sonuçta ben yemek silmiyorum öğündeki yemeği siliyorum...
            {
                meal.MealCalorie -= (removefood.Food.Calorie * removefood.Quantity);
                meal.MealCarbohydrate -= (food.Carbohydrate * removefood.Quantity);
                meal.MealProtein -= (food.Protein * removefood.Quantity);
                meal.MealFat -= (food.Fat * removefood.Quantity);
                MessageBox.Show($"{food.Name} silindi.");
                CrudProcess.Delete(removefood);
                CrudProcess.Edit(meal);
            }
            else if (food != null && meal != null)
            {
                MessageBox.Show($"{food.Name} silindi.Öğünde yemek kalmadı!");
                CrudProcess.Delete(removefood);
                CrudProcess.Delete(meal);
            }
            lstMealRefresh();
        }
        private MealDetail GetMealDetail(Food food, Meal meal)
        {
            return CrudProcess.GetAll<MealDetail>().Where(x => x.Food == food && x.Meal == meal).FirstOrDefault();


        }
        private MealName GetMealName()
        {
            MealName mealName = MealName.Breakfast;

            if (lblMealName.Text == "KAHVALTI")
                mealName = MealName.Breakfast;
            else if (lblMealName.Text == "ÖĞLE YEMEĞİ")
                mealName = MealName.Lunch;
            else if (lblMealName.Text == "AKŞAM YEMEĞİ")
                mealName = MealName.Dinner;
            else if (lblMealName.Text == "EKSTRA")
                mealName = MealName.Extra;

            return mealName;
        }
        private void lstMealRefresh()
        {
            lstDailyMeal.Items.Clear();
            Meal meal = GetDayMeal();

            var mealDetail = CrudProcess.Search<MealDetail>(x => x.Meal == meal);

            if (meal != null && mealDetail != null)
            {
                var foods = meal.MealDetails.Select(f => f.Food);
                lstDailyMeal.Items.AddRange(foods.ToArray());
            }
        }
        private Meal GetDayMeal()
        {
            Meal meal = CrudProcess.GetAll<Meal>().Where(x => x.EatDay.Date == dtpMealDate.Value.Date && x.Name == GetMealName() && x.Customer == Current.Customer).FirstOrDefault();

            return meal;
        }

        private void dgvFoods_MouseClick(object sender, MouseEventArgs e)
        {
            var path = dgvFoods.CurrentRow.Cells["PicturePath"].Value ?? "";
            if (path != "")
            {
                try
                {
                    pbFoods.Image = Image.FromFile(path.ToString());

                }
                catch
                {
                    pbFoods.Image = WFA_ProDiet.UI.Properties.Resources.basephoto;
                }
            }
            else
            { pbFoods.Image = Properties.Resources.basephoto; }
        }

       

       
    }
}
