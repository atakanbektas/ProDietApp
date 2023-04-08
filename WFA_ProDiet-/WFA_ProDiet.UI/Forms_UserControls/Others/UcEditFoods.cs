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
    public partial class UcEditFoods : UserControl
    {
        public UcEditFoods()
        {
            InitializeComponent();
            dgvFoods.DataSource = CrudProcess.GetAll<Food>();
            cbCategory.SelectedIndex = 0;
            cbMeasure.SelectedIndex = 0;
            dgvFoods.Columns["PicturePath"].Width = 0;
            dgvFoods.Columns[0].Width = 0;//foodID
            dgvFoods.Columns["CategoryId"].Width = 0;
        }
        string picturePath;
        private void btnAdd_Click(object sender, EventArgs e)
        {

            Category catagory = ProDietDb._context.Categories.Where(x => x.CategoryId == cbCategory.SelectedIndex+1).FirstOrDefault();//kategori yakalama

            Food food = new()
            {
                Name = txtFoodName.Text,
                Protein = (double)nudProteinQ.Value,
                Carbohydrate = (double)nudCarbohydrateQ.Value,
                Fat = (double)nudFatQ.Value,
                Calorie = (double)nudCalorieQ.Value,
            };

            food.Category = catagory;
            food.CategoryId = catagory.CategoryId;
            food.MeasureType = (MeasureType)(cbMeasure.SelectedIndex);
            food.PicturePath = picturePath ?? "";

            CrudProcess.Add(food);
            MessageBox.Show($"{food.Name} Eklendi");


            dgvFoods.DataSource = CrudProcess.GetAll<Food>();
        }


        private void btnAddPict_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg,*.png)|*.jpg;*.jpeg;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbFood.Image = Image.FromFile(openFileDialog.FileName);
                    picturePath = openFileDialog.FileName;
                }
            }
        }
    }
}
