using WFA_ProDiet.BLL;
using WFA_ProDiet.MODELS.Models;
using WFA_ProDiet.UI.HelpersUI;
using WFA_ProDiet.UI.Properties;

namespace WFA_ProDiet.UI
{
    public partial class Form1 : Form
    {
        CreateAccount create;
        HomePage homePage;
        public Form1()
        {
            InitializeComponent();
            HelperUI.SetOpacityWhenOpen(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var path = CrudProcess.GetAll<Food>().Where(x => x.FoodId == 1).FirstOrDefault();

            pictureBox1.Image = Image.FromFile("..\\..\\..\\Resources\\logo.jpeg");
        }
        private void lnkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {      
            create = new CreateAccount();
            create.ShowDialog();
        }

 

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar; // þifre gözüküyorsa maskeler, maskeli ise gösterir.
            btnShowPassword.IconChar = txtPassword.UseSystemPasswordChar ? FontAwesome.Sharp.IconChar.Lock : FontAwesome.Sharp.IconChar.LockOpen; // þifre iconu þartlara göre gösterilir.
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var allCustomer = CrudProcess.GetAll<Customer>();
            var customer = allCustomer.Where(cus=>cus.Email==txtEmail.Text).FirstOrDefault();

            if (customer!=null)
            {
                if (customer.VerifyPassword(txtPassword.Text))
                {
                    Current.Customer= customer;
                    homePage = new HomePage();
                    HelperUI.SetOpacityWhenOpen(homePage);
                    homePage.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Þifreniz hatalýdýr.");
                }
            }
            else 
            {
                MessageBox.Show("Kullanýcý adý bulunamadý.");
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}