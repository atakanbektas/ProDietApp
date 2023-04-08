namespace WFA_ProDiet.UI
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnReturnLogin = new FontAwesome.Sharp.IconButton();
            btnUser = new FontAwesome.Sharp.IconButton();
            pnlAllMenu = new Panel();
            pnlFoods = new Panel();
            btnEditFoods = new FontAwesome.Sharp.IconButton();
            btnFoods = new FontAwesome.Sharp.IconButton();
            pnlReports = new Panel();
            btnExtraReports = new FontAwesome.Sharp.IconButton();
            btnMonthlyReport = new FontAwesome.Sharp.IconButton();
            btnWeeklyReport = new FontAwesome.Sharp.IconButton();
            btnReports = new FontAwesome.Sharp.IconButton();
            pnlMeals = new Panel();
            btnProTakip = new FontAwesome.Sharp.IconButton();
            btnProPlan = new FontAwesome.Sharp.IconButton();
            btnTakip = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            pnlScreen = new Panel();
            panel1.SuspendLayout();
            pnlAllMenu.SuspendLayout();
            pnlFoods.SuspendLayout();
            pnlReports.SuspendLayout();
            pnlMeals.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.HomePageBanner;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(btnReturnLogin);
            panel1.Controls.Add(btnUser);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1177, 75);
            panel1.TabIndex = 0;
            // 
            // btnReturnLogin
            // 
            btnReturnLogin.Dock = DockStyle.Right;
            btnReturnLogin.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btnReturnLogin.FlatStyle = FlatStyle.Flat;
            btnReturnLogin.ForeColor = Color.Black;
            btnReturnLogin.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            btnReturnLogin.IconColor = Color.FromArgb(0, 40, 0);
            btnReturnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReturnLogin.IconSize = 45;
            btnReturnLogin.Location = new Point(1074, 0);
            btnReturnLogin.Name = "btnReturnLogin";
            btnReturnLogin.Size = new Size(58, 75);
            btnReturnLogin.TabIndex = 1;
            btnReturnLogin.UseVisualStyleBackColor = true;
            btnReturnLogin.Click += btnReturnLogin_Click;
            // 
            // btnUser
            // 
            btnUser.BackgroundImageLayout = ImageLayout.Zoom;
            btnUser.Dock = DockStyle.Right;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            btnUser.IconColor = Color.FromArgb(0, 40, 0);
            btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUser.IconSize = 45;
            btnUser.Location = new Point(1132, 0);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(45, 75);
            btnUser.TabIndex = 0;
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // pnlAllMenu
            // 
            pnlAllMenu.AutoScroll = true;
            pnlAllMenu.BackColor = Color.FromArgb(141, 197, 62);
            pnlAllMenu.Controls.Add(pnlFoods);
            pnlAllMenu.Controls.Add(btnFoods);
            pnlAllMenu.Controls.Add(pnlReports);
            pnlAllMenu.Controls.Add(btnReports);
            pnlAllMenu.Controls.Add(pnlMeals);
            pnlAllMenu.Controls.Add(btnTakip);
            pnlAllMenu.Controls.Add(panel3);
            pnlAllMenu.Dock = DockStyle.Left;
            pnlAllMenu.Location = new Point(0, 75);
            pnlAllMenu.Name = "pnlAllMenu";
            pnlAllMenu.Size = new Size(217, 560);
            pnlAllMenu.TabIndex = 1;
            // 
            // pnlFoods
            // 
            pnlFoods.BackColor = Color.FromArgb(198, 198, 198);
            pnlFoods.Controls.Add(btnEditFoods);
            pnlFoods.Dock = DockStyle.Top;
            pnlFoods.Location = new Point(0, 534);
            pnlFoods.Name = "pnlFoods";
            pnlFoods.Size = new Size(200, 93);
            pnlFoods.TabIndex = 7;
            pnlFoods.Tag = "1";
            pnlFoods.Visible = false;
            // 
            // btnEditFoods
            // 
            btnEditFoods.Dock = DockStyle.Top;
            btnEditFoods.FlatAppearance.BorderSize = 0;
            btnEditFoods.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEditFoods.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 235, 171);
            btnEditFoods.FlatStyle = FlatStyle.Flat;
            btnEditFoods.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditFoods.ForeColor = Color.FromArgb(35, 38, 31);
            btnEditFoods.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            btnEditFoods.IconColor = Color.FromArgb(35, 38, 31);
            btnEditFoods.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditFoods.IconSize = 30;
            btnEditFoods.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditFoods.Location = new Point(0, 0);
            btnEditFoods.Name = "btnEditFoods";
            btnEditFoods.Size = new Size(200, 40);
            btnEditFoods.TabIndex = 5;
            btnEditFoods.Text = "Besin Ekle";
            btnEditFoods.TextAlign = ContentAlignment.MiddleLeft;
            btnEditFoods.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditFoods.UseVisualStyleBackColor = true;
            btnEditFoods.Click += btnEditFoods_Click;
            // 
            // btnFoods
            // 
            btnFoods.Dock = DockStyle.Top;
            btnFoods.FlatAppearance.BorderSize = 0;
            btnFoods.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFoods.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 235, 171);
            btnFoods.FlatStyle = FlatStyle.Flat;
            btnFoods.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFoods.ForeColor = Color.FromArgb(35, 38, 31);
            btnFoods.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            btnFoods.IconColor = Color.FromArgb(35, 38, 31);
            btnFoods.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFoods.IconSize = 40;
            btnFoods.ImageAlign = ContentAlignment.MiddleLeft;
            btnFoods.Location = new Point(0, 480);
            btnFoods.Name = "btnFoods";
            btnFoods.Size = new Size(200, 54);
            btnFoods.TabIndex = 2;
            btnFoods.Text = "Besinler";
            btnFoods.TextAlign = ContentAlignment.MiddleLeft;
            btnFoods.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFoods.UseVisualStyleBackColor = true;
            btnFoods.Click += btnFoods_Click;
            // 
            // pnlReports
            // 
            pnlReports.BackColor = Color.FromArgb(198, 198, 198);
            pnlReports.Controls.Add(btnExtraReports);
            pnlReports.Controls.Add(btnMonthlyReport);
            pnlReports.Controls.Add(btnWeeklyReport);
            pnlReports.Dock = DockStyle.Top;
            pnlReports.Location = new Point(0, 311);
            pnlReports.Name = "pnlReports";
            pnlReports.Size = new Size(200, 169);
            pnlReports.TabIndex = 5;
            pnlReports.Tag = "1";
            pnlReports.Visible = false;
            // 
            // btnExtraReports
            // 
            btnExtraReports.Dock = DockStyle.Top;
            btnExtraReports.FlatAppearance.BorderSize = 0;
            btnExtraReports.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExtraReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 235, 171);
            btnExtraReports.FlatStyle = FlatStyle.Flat;
            btnExtraReports.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExtraReports.ForeColor = Color.FromArgb(35, 38, 31);
            btnExtraReports.IconChar = FontAwesome.Sharp.IconChar.Superpowers;
            btnExtraReports.IconColor = Color.FromArgb(35, 38, 31);
            btnExtraReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExtraReports.IconSize = 30;
            btnExtraReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnExtraReports.Location = new Point(0, 80);
            btnExtraReports.Name = "btnExtraReports";
            btnExtraReports.Size = new Size(200, 40);
            btnExtraReports.TabIndex = 8;
            btnExtraReports.Text = "İstatistikler";
            btnExtraReports.TextAlign = ContentAlignment.MiddleLeft;
            btnExtraReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExtraReports.UseVisualStyleBackColor = true;
            btnExtraReports.Click += btnExtraReports_Click;
            // 
            // btnMonthlyReport
            // 
            btnMonthlyReport.Dock = DockStyle.Top;
            btnMonthlyReport.FlatAppearance.BorderSize = 0;
            btnMonthlyReport.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMonthlyReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 235, 171);
            btnMonthlyReport.FlatStyle = FlatStyle.Flat;
            btnMonthlyReport.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMonthlyReport.ForeColor = Color.FromArgb(35, 38, 31);
            btnMonthlyReport.IconChar = FontAwesome.Sharp.IconChar.Superpowers;
            btnMonthlyReport.IconColor = Color.FromArgb(35, 38, 31);
            btnMonthlyReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMonthlyReport.IconSize = 30;
            btnMonthlyReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnMonthlyReport.Location = new Point(0, 40);
            btnMonthlyReport.Name = "btnMonthlyReport";
            btnMonthlyReport.Size = new Size(200, 40);
            btnMonthlyReport.TabIndex = 7;
            btnMonthlyReport.Text = "Aylık Rapor";
            btnMonthlyReport.TextAlign = ContentAlignment.MiddleLeft;
            btnMonthlyReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMonthlyReport.UseVisualStyleBackColor = true;
            btnMonthlyReport.Click += btnMonthlyReport_Click;
            // 
            // btnWeeklyReport
            // 
            btnWeeklyReport.Dock = DockStyle.Top;
            btnWeeklyReport.FlatAppearance.BorderSize = 0;
            btnWeeklyReport.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnWeeklyReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 235, 171);
            btnWeeklyReport.FlatStyle = FlatStyle.Flat;
            btnWeeklyReport.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnWeeklyReport.ForeColor = Color.FromArgb(35, 38, 31);
            btnWeeklyReport.IconChar = FontAwesome.Sharp.IconChar.Superpowers;
            btnWeeklyReport.IconColor = Color.FromArgb(35, 38, 31);
            btnWeeklyReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnWeeklyReport.IconSize = 30;
            btnWeeklyReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnWeeklyReport.Location = new Point(0, 0);
            btnWeeklyReport.Name = "btnWeeklyReport";
            btnWeeklyReport.Size = new Size(200, 40);
            btnWeeklyReport.TabIndex = 6;
            btnWeeklyReport.Text = "Haftalık Rapor";
            btnWeeklyReport.TextAlign = ContentAlignment.MiddleLeft;
            btnWeeklyReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnWeeklyReport.UseVisualStyleBackColor = true;
            btnWeeklyReport.Click += btnWeeklyReport_Click;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 235, 171);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReports.ForeColor = Color.FromArgb(35, 38, 31);
            btnReports.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            btnReports.IconColor = Color.FromArgb(35, 38, 31);
            btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReports.IconSize = 40;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(0, 257);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(200, 54);
            btnReports.TabIndex = 1;
            btnReports.Text = "Raporlar";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += ıconButton4_Click;
            // 
            // pnlMeals
            // 
            pnlMeals.BackColor = Color.FromArgb(198, 198, 198);
            pnlMeals.Controls.Add(btnProTakip);
            pnlMeals.Controls.Add(btnProPlan);
            pnlMeals.Dock = DockStyle.Top;
            pnlMeals.Location = new Point(0, 150);
            pnlMeals.Name = "pnlMeals";
            pnlMeals.Size = new Size(200, 107);
            pnlMeals.TabIndex = 3;
            pnlMeals.Tag = "1";
            pnlMeals.Visible = false;
            // 
            // btnProTakip
            // 
            btnProTakip.Dock = DockStyle.Top;
            btnProTakip.FlatAppearance.BorderSize = 0;
            btnProTakip.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProTakip.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 235, 171);
            btnProTakip.FlatStyle = FlatStyle.Flat;
            btnProTakip.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnProTakip.ForeColor = Color.FromArgb(35, 38, 31);
            btnProTakip.IconChar = FontAwesome.Sharp.IconChar.Mask;
            btnProTakip.IconColor = Color.FromArgb(35, 38, 31);
            btnProTakip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProTakip.IconSize = 30;
            btnProTakip.ImageAlign = ContentAlignment.MiddleLeft;
            btnProTakip.Location = new Point(0, 41);
            btnProTakip.Name = "btnProTakip";
            btnProTakip.Size = new Size(200, 40);
            btnProTakip.TabIndex = 1;
            btnProTakip.Text = "Pro Takip";
            btnProTakip.TextAlign = ContentAlignment.MiddleLeft;
            btnProTakip.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProTakip.UseVisualStyleBackColor = true;
            btnProTakip.Click += btnProTakip_Click;
            // 
            // btnProPlan
            // 
            btnProPlan.Dock = DockStyle.Top;
            btnProPlan.FlatAppearance.BorderSize = 0;
            btnProPlan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProPlan.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 235, 171);
            btnProPlan.FlatStyle = FlatStyle.Flat;
            btnProPlan.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnProPlan.ForeColor = Color.FromArgb(35, 38, 31);
            btnProPlan.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            btnProPlan.IconColor = Color.FromArgb(35, 38, 31);
            btnProPlan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProPlan.IconSize = 30;
            btnProPlan.ImageAlign = ContentAlignment.MiddleLeft;
            btnProPlan.Location = new Point(0, 0);
            btnProPlan.Name = "btnProPlan";
            btnProPlan.Size = new Size(200, 41);
            btnProPlan.TabIndex = 0;
            btnProPlan.Text = "Pro Planım";
            btnProPlan.TextAlign = ContentAlignment.MiddleLeft;
            btnProPlan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProPlan.UseVisualStyleBackColor = true;
            btnProPlan.Click += btnProPlan_Click;
            // 
            // btnTakip
            // 
            btnTakip.Dock = DockStyle.Top;
            btnTakip.FlatAppearance.BorderSize = 0;
            btnTakip.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTakip.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 235, 171);
            btnTakip.FlatStyle = FlatStyle.Flat;
            btnTakip.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTakip.ForeColor = Color.FromArgb(35, 38, 31);
            btnTakip.IconChar = FontAwesome.Sharp.IconChar.Road;
            btnTakip.IconColor = Color.FromArgb(35, 38, 31);
            btnTakip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTakip.ImageAlign = ContentAlignment.MiddleLeft;
            btnTakip.Location = new Point(0, 96);
            btnTakip.Name = "btnTakip";
            btnTakip.Size = new Size(200, 54);
            btnTakip.TabIndex = 0;
            btnTakip.Text = "Takip";
            btnTakip.TextAlign = ContentAlignment.MiddleLeft;
            btnTakip.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTakip.UseVisualStyleBackColor = true;
            btnTakip.Click += ıconButton1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(141, 197, 62);
            panel3.BackgroundImage = Properties.Resources.PRODİET_TRANSPARAN_DENEME_13;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 96);
            panel3.TabIndex = 0;
            // 
            // pnlScreen
            // 
            pnlScreen.Dock = DockStyle.Fill;
            pnlScreen.Location = new Point(217, 75);
            pnlScreen.Name = "pnlScreen";
            pnlScreen.Size = new Size(960, 560);
            pnlScreen.TabIndex = 2;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1177, 635);
            Controls.Add(pnlScreen);
            Controls.Add(pnlAllMenu);
            Controls.Add(panel1);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            Activated += HomePage_Activated;
            FormClosed += HomePage_FormClosed;
            panel1.ResumeLayout(false);
            pnlAllMenu.ResumeLayout(false);
            pnlFoods.ResumeLayout(false);
            pnlReports.ResumeLayout(false);
            pnlMeals.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlAllMenu;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnTakip;
        private Panel pnlReports;
        private FontAwesome.Sharp.IconButton btnWeeklyReport;
        private FontAwesome.Sharp.IconButton btnReports;
        private Panel pnlMeals;
        private FontAwesome.Sharp.IconButton btnProPlan;
        private FontAwesome.Sharp.IconButton btnMonthlyReport;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton btnExtraReports;
        private Panel pnlFoods;
        private FontAwesome.Sharp.IconButton btnEditFoods;
        private FontAwesome.Sharp.IconButton btnFoods;
        public Panel pnlScreen;
        public FontAwesome.Sharp.IconButton btnProTakip;
        private FontAwesome.Sharp.IconButton btnReturnLogin;
    }
}