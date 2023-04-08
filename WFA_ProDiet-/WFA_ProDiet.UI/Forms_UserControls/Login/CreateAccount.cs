using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
    public partial class CreateAccount : Form
    {
        Customer customer;
        List<Customer> customerList = CrudProcess.GetAll<Customer>();
        string welcomeMessage = "ile sağlıklı yaşama başla.";
        int welcomeCounter = 0;
        bool isEmailValid = false, isPasswordValid = false, isNameValid = false, isLastNameValid = false, isPasswordCheck = false;
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        public CreateAccount()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Mousee ile butondan çıkıldığında info açılır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
        }

        /// <summary>
        /// Mouse ile butondan çıkıldığında info kapanır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            tmrWelcome.Start();
            this.SetOpacityWhenOpen();
        }

        private void tmrWelcome_Tick(object sender, EventArgs e)
        {
            if (welcomeCounter < welcomeMessage.Length)
            {
                lblText.Text += welcomeMessage[welcomeCounter++];
            }
            else
            {
                tmrWelcome.Stop();
            }
        }

        private void tmrOpenForm_Tick(object sender, EventArgs e)
        {
            if (Width < 1105)
            {
                Width += 10;
            }
            else
            {
                tmrOpenForm.Stop();
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var password = txtPassword.Text;
            var password2 = txtPasswordCheck.Text;

            if (isNameValid && isLastNameValid && isEmailValid)
            {
                if (password == password2 && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber) && password.Any(char.IsPunctuation) && password.Length > 8) // şifre kontrol
                {
                    customer = new Customer()
                    {
                        FirstName = txtName.Text,
                        LastName = txtLastName.Text,
                        Email = txtEmail.Text,
                    };
                    customer.SetPassword(txtPassword.Text);
                    CrudProcess.Add(customer);
                    pnlUserInfo.Visible = true;
                    tmrOpenForm.Start();
                }
                else
                {
                    if (password != password2)
                    {

                        MessageBox.Show("Şifreler aynı değil.");
                    }
                    else
                    {
                        MessageBox.Show("Şifreniz en az 8 karakter uzunluğunda olmalı ve şunları içermelidir : \n Büyük Harf\nKüçük Harf\nSayı\nÖzel Karakter ");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurunuz.");
            }



        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            customer.BirthDate = dtpBirthDate.Value;
            customer.Gender = rbMale.Checked ? Gender.Man : Gender.Woman;
            customer.Height = (int)nudHeight.Value;
            customer.Weight = (double)nudWeight.Value;

            if (cbActivityLevel.SelectedIndex == 0) // aktivite yok
            {
                customer.ActivityLevel = ActivityLevel.NoActivitiy;
            }
            else if (cbActivityLevel.SelectedIndex == 2) // aktif
            {
                customer.ActivityLevel = ActivityLevel.Active;
            }
            else if (cbActivityLevel.SelectedIndex == 3) // çok aktif
            {
                customer.ActivityLevel = ActivityLevel.MoreActive;
            }
            else // az aktif (default) 
            {
                customer.ActivityLevel = ActivityLevel.LessActive;
            }
            CrudProcess.Edit(customer);
            HelperUI.SetOpacityWhenClose(this);
        }

        private void txtPasswordCheck_TextChanged(object sender, EventArgs e)
        {
            lblPasswordCheckInfo.Visible = true;
            lblPasswordCheckInfo.Text = "Şifreler aynı değil";
            if (txtPassword.Text == txtPasswordCheck.Text) // girilen şifreler aynı mı
            {
                lblPasswordCheckInfo.Visible = false;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtName.Text = textInfo.ToTitleCase(txtName.Text); // ilk harfi büyük, diğerlerini küçük yapar
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            txtLastName.Text = textInfo.ToTitleCase(txtLastName.Text);// ilk harfi büyük, diğerlerini küçük yapar
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            isNameValid = false; // isim uygun değil


            if (txtName.Text.Length < 2) //  isim 2 harften kısa ise..
            {
                lblNameInfo.Visible = true; // hata göster
                lblNameInfo.Text = "Ad en az 2 karakterden oluşmalıdır."; // hata mesajı
            }
            else if (!txtName.Text.All(char.IsLetter)) //  hepsi harften oluşmuyor ise.
            {
                lblNameInfo.Visible = true; // hata göster
                lblNameInfo.Text = "Ad sadece harf içerebilir."; // hata mesajı
            }
            else // isim uygun ise
            {
                lblNameInfo.Visible = false; // hata gösterme
                isNameValid = true; // isim uygun

            }
        }
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            isLastNameValid = false;

            if (txtLastName.Text.Length < 2) //  isim 2 harften kısa ise ..
            {
                lblLastNameInfo.Visible = true;
                lblLastNameInfo.Text = "Soyad en az 2 karakterden oluşmalıdır.";
            }
            else if (!txtLastName.Text.All(char.IsLetter)) //  hepsi harften oluşmuyor ise.
            {
                lblLastNameInfo.Visible = true;
                lblLastNameInfo.Text = "Soyad sadece harf içerebilir.";
            }
            else // isim uygun ise
            {
                isLastNameValid = true;
                lblLastNameInfo.Visible = false;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            isEmailValid = false;


            if (!(email.Length > 8 && email.Contains("@") && email.Contains(".") && !email.Any(char.IsUpper))) // email 8 harften büyük mü ve "@." içeriyor mu ve hepsi küçük harf mi kontrolü.
            {
                lblEmailInfo.Visible = true;
                lblEmailInfo.Text = "Email uygun formatta değil";
            }
            else if (customerList.Any(cus => cus.Email == email)) // bu emailde bir customer var mı kontrolü
            {
                lblEmailInfo.Visible = true;
                lblEmailInfo.Text = "Bu email adresi zaten mevcut.";
            }
            else // email uygun
            {
                isEmailValid = true;
                lblEmailInfo.Visible = false;
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string password = txtPassword.Text;


            if (password.Length > 11 && password.Any(char.IsDigit) && password.Any(char.IsPunctuation) && password.Any(char.IsUpper) && password.Any(char.IsLower))
            {
                lblPasswordInfo.Visible = true;
                lblPasswordInfo.Text = "Yüksek Güvenlik";
                lblPasswordInfo.ForeColor = Color.DarkGreen;
            }
            else if (password.Length > 11)
            {
                lblPasswordInfo.Visible = true;
                lblPasswordInfo.Text = "Orta Güvenlik";
                lblPasswordInfo.ForeColor = Color.FromArgb(150, 170, 60);
            }
            else
            {
                lblPasswordInfo.Visible = true;
                lblPasswordInfo.Text = "Güvenlik Yok";
                lblPasswordInfo.ForeColor = Color.Red;
            }
        }
    }
}
