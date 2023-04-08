using Microsoft.Graph.Models;
using OxyPlot.Axes;
using OxyPlot.Series;
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
using WFA_ProDiet.UI.HelpersUI;
using WFA_ProDiet.MODELS.Models;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Beta_Dist;
using WFA_ProDiet.MODELS.Enums;

namespace WFA_ProDiet.UI
{
    public partial class UcWeeklyReport : UserControl
    {
        public UcWeeklyReport()
        {
            InitializeComponent();

        }

        PlotModel plotModel; LineSeries userSeries; LineSeries avgSeries;
        List<Category> _categories = CrudProcess.GetAll<Category>();
        List<Meal> resultMeals;
        List<Meal> _meals = CrudProcess.GetAll<Meal>();
        Category category;
        Meal meal;
        DateTime today = DateTime.Now;
        List<Customer> customers = CrudProcess.GetAll<Customer>();

        double[] userCalories = new double[7];
        double[] avgCalories = new double[7];
        private void btnCompareByCalorie_Click(object sender, EventArgs e)
        {
            try{DrawAndShowGraph();}
            catch { }

        }
        ProDietDBContext _pro = new ProDietDBContext();
        private void DrawAndShowGraph()
        {
            SetGraphTittle();
            FindMeals();
            if (rbAll.Checked) // öğün seçmezse
            {
                MealsAll();
            }
            else // öğün seçtiyse
            {
                SelectedMeal();
            }
            DrawGraph();
        }


        private void SelectedMeal()
        {
            for (int i = 6; i >= 0; i--)
            {
                userCalories[i] = Convert.ToDouble(Current.Customer.Meals.Where(m => m.Name == resultMeals[0].Name && m.EatDay == DateTime.Today.Subtract(new TimeSpan(i, 0, 0, 0))).Sum(m => m.MealCalorie));

                var allMeals = CrudProcess.GetAll<Meal>().Where(m => m.EatDay == DateTime.Today.Subtract(new TimeSpan(i, 0, 0, 0)) && m.Name == resultMeals[0].Name).ToList();

                var customerMeals = allMeals.GroupBy(m => m.CustomerId).Select(g => new
                {
                    CustomerId = g.Key,
                    TotalCalories = g.Sum(m => m.MealCalorie)
                }).ToList();

                avgCalories[i] = Convert.ToDouble(customerMeals.Average(cmeal => cmeal.TotalCalories));
            }
        }
        private void MealsAll()
        {
            for (int i = 6; i >= 0; i--)
            {
                userCalories[i] = Convert.ToDouble(Current.Customer.Meals.Where(m => m.EatDay == DateTime.Today.Subtract(new TimeSpan(i, 0, 0, 0))).Sum(x => x.MealCalorie));

                var meals = CrudProcess.GetAll<Meal>().Where(m => m.EatDay == DateTime.Today.Subtract(new TimeSpan(i, 0, 0, 0))).ToList();
                var customerMeals = meals.GroupBy(m => m.CustomerId).Select(g => new
                {
                    CustomerId = g.Key,
                    TotalCalories = g.Sum(m => m.MealCalorie)
                }).ToList();

                avgCalories[i] = Convert.ToDouble(customerMeals.Average(cmeal => cmeal.TotalCalories));
            }
        }

        private void FindMeals()
        {
            if (rbAll.Checked) //  tüm öğünleri seçerse
            {
                meal = null;
            }
            else // tek öğün seçerse
            {
                if (rbBreakFast.Checked)
                {
                    resultMeals = _meals.Where(m => m.Name == MealName.Breakfast).ToList();
                }
                else if (rbDinner.Checked)
                {
                    resultMeals = _meals.Where(m => m.Name == MealName.Dinner).ToList();
                }
                else if (rbLaunch.Checked)
                {
                    resultMeals = _meals.Where(m => m.Name == MealName.Lunch).ToList();
                }
                else if (rbExtra.Checked)
                {
                    resultMeals = _meals.Where(m => m.Name == MealName.Extra).ToList();
                }
            }
        }

        private void DrawGraph()
        {
            for (int i = 0; i < userCalories.Length; i++)
            {
                userSeries.Points.Add(new DataPoint(i, userCalories[i]));
                avgSeries.Points.Add(new DataPoint(i, avgCalories[i]));
            }

            plotModel.Series.Add(userSeries);
            plotModel.Series.Add(avgSeries);

            var xAxis = new CategoryAxis { Position = AxisPosition.Bottom };
            xAxis.Labels.AddRange(new[] { "1. gün", "2. gün", "3. gün", "4. gün", "5. gün", "6. gün", "7. gün" });

            plotModel.Axes.Add(xAxis);

            var yAxis = new LinearAxis { Position = AxisPosition.Left, Title = "Kalori" };
            plotModel.Axes.Add(yAxis);
            plistWeeklyGraph.Model = plotModel;
            xAxis.StartPosition = 1;
            xAxis.EndPosition = 0;
        }
        private void SetGraphTittle()
        {
            plotModel = new PlotModel { Title = "Kullanıcı Kalori Miktarı" };
            userSeries = new LineSeries { Title = "Kullanıcı", MarkerType = MarkerType.Circle };
            avgSeries = new LineSeries { Title = "Ortalama", MarkerType = MarkerType.Circle };
        }
    }
}
