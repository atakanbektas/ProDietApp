using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_ProDiet.UI.HelpersUI;
using WFA_ProDiet.MODELS.Enums;
using WFA_ProDiet.BLL;
using Microsoft.Win32;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace WFA_ProDiet.UI
{
    public partial class UcUserInfo : UserControl
    {
        public UcUserInfo()
        {
            InitializeComponent();
            rbMale.Checked = Current.Customer.Gender == Gender.Man;
            rbFemale.Checked = Current.Customer.Gender == Gender.Woman;
            txtEmail.Text = Current.Customer.Email;
            txtFirstName.Text = Current.Customer.FirstName;
            txtLastName.Text = Current.Customer.LastName;
            dtpBirthDate.Value = Current.Customer.BirthDate;
            nudHeight.Value = Current.Customer.Height;
            cbAktivite.SelectedIndex = (int)Current.Customer.ActivityLevel;
            nudWeight.Value = (decimal)Current.Customer.Weight;
            try
            { pbUserPic.Image = Image.FromFile(Current.Customer.PicturePath); }
            catch (Exception)
            { pbUserPic.Image = Properties.Resources.logo; }

        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {

            Current.Customer.FirstName = txtFirstName.Text;
            Current.Customer.LastName = txtLastName.Text;
            Current.Customer.BirthDate = dtpBirthDate.Value.Date;
            Current.Customer.ActivityLevel = (ActivityLevel)cbAktivite.SelectedIndex;
            Current.Customer.Height = (int)nudHeight.Value;
            Current.Customer.Gender = rbMale.Checked ? Gender.Man : Gender.Woman;
            CrudProcess.Edit(Current.Customer);

        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.bmp;*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbUserPic.Image = Image.FromFile(openFileDialog.FileName);
                    Current.Customer.PicturePath = openFileDialog.FileName;
                    CrudProcess.Edit(Current.Customer);
                }

            }
        }
    }
}