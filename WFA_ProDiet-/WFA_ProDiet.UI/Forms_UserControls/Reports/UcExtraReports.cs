using System;
using System.Collections;
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
    public partial class UcExtraReports : UserControl
    {
        public UcExtraReports()
        {
            InitializeComponent();
        }

        private void btnMostConsumed_Click(object sender, EventArgs e)
        {
            dgvExtraReports.DataSource = GetFilteredMealDetails();
        }
        private void btnLeastConsumed_Click(object sender, EventArgs e)
        {
            dgvExtraReports.DataSource = GetFilteredMealDetails(false);
        }

        private List<object> GetFilteredMealDetails(bool orderByDescending = true)
        {

            var query = CrudProcess.GetAll<MealDetail>().Where(c => c.Meal.Customer == Current.Customer).GroupBy(f => f.Food).Select(f => new { Yemek = f.Key.Name, ToplamTüketilen = f.Sum(f => f.Quantity), Birim = f.Key.MeasureType, ToplamKalori = f.Sum(f => f.Quantity) * f.Key.Calorie });//query i heryerde kullanabilmek için mecbur kaldım

            //Hiçbirşey seçmezse
            //  List<object> filter;
            if ((cbMealDetail.SelectedIndex == 0 || cbMealDetail.SelectedIndex == -1) && (cbCategoryDetail.SelectedIndex == 0 || cbCategoryDetail.SelectedIndex == -1))
            {
                query = CrudProcess.GetAll<MealDetail>().Where(c => c.Meal.Customer == Current.Customer).GroupBy(f => f.Food).Select(f => new { Yemek = f.Key.Name, ToplamTüketilen = f.Sum(f => f.Quantity), Birim = f.Key.MeasureType, ToplamKalori = f.Sum(f => f.Quantity) * f.Key.Calorie });

            }
            //Sadece Öğün seçerse
            else if ((cbCategoryDetail.SelectedIndex == 0 || cbCategoryDetail.SelectedIndex == -1))
            {
                query = CrudProcess.GetAll<MealDetail>().Where(c => c.Meal.Customer == Current.Customer && c.Meal.Name == (MealName)(cbMealDetail.SelectedIndex - 1)).GroupBy(f => f.Food).Select(f => new { Yemek = f.Key.Name, ToplamTüketilen = f.Sum(f => f.Quantity), Birim = f.Key.MeasureType, ToplamKalori = f.Sum(f => f.Quantity) * f.Key.Calorie });

            }
            //Sadece Kategori Seçerse
            else if ((cbMealDetail.SelectedIndex == 0 || cbMealDetail.SelectedIndex == -1))
            {
                int categoryId = CrudProcess.GetAll<Category>().Where(c => c.Name == cbCategoryDetail.SelectedItem.ToString()).FirstOrDefault().CategoryId;

                query = CrudProcess.GetAll<MealDetail>().Where(c => c.Meal.Customer == Current.Customer && c.Food.CategoryId == categoryId).GroupBy(f => f.Food).Select(f => new { Yemek = f.Key.Name, ToplamTüketilen = f.Sum(f => f.Quantity), Birim = f.Key.MeasureType, ToplamKalori = f.Sum(f => f.Quantity) * f.Key.Calorie });

            }
            //hem kategori hem öğün seçerse
            else if (cbMealDetail.SelectedIndex > 0 && cbCategoryDetail.SelectedIndex > 0)
            {
                int categoryId = CrudProcess.GetAll<Category>().Where(c => c.Name == cbCategoryDetail.SelectedItem.ToString()).FirstOrDefault().CategoryId;

                query = CrudProcess.GetAll<MealDetail>().Where(c => c.Meal.Customer == Current.Customer && c.Food.CategoryId == categoryId && c.Meal.Name == (MealName)(cbMealDetail.SelectedIndex - 1)).GroupBy(f => f.Food).Select(f => new { Yemek = f.Key.Name, ToplamTüketilen = f.Sum(f => f.Quantity), Birim = f.Key.MeasureType, ToplamKalori = f.Sum(f => f.Quantity) * f.Key.Calorie });
            }

            query = orderByDescending ? query.OrderByDescending(f => f.ToplamTüketilen) : query.OrderBy(f => f.ToplamTüketilen);

            return query.ToList<object>();

        }


    }
}
