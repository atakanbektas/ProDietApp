namespace WFA_ProDiet.UI
{
    partial class AddMeals
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
            btnClose = new FontAwesome.Sharp.IconButton();
            dgvFoods = new DataGridView();
            txtSearchFood = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            btnRemove = new FontAwesome.Sharp.IconButton();
            lstDailyMeal = new ListBox();
            dtpMealDate = new DateTimePicker();
            lblMealName = new Label();
            panel5 = new Panel();
            cbOrderByFilter = new ComboBox();
            label3 = new Label();
            btnAddMeal = new FontAwesome.Sharp.IconButton();
            txtFood = new TextBox();
            nudQuantity = new NumericUpDown();
            panel3 = new Panel();
            pbFoods = new PictureBox();
            lblMeasure = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFoods).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoods).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.HomePageBanner;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1041, 100);
            panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 255, 192);
            btnClose.Dock = DockStyle.Bottom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 120, 80);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(141, 197, 61);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = SystemColors.Window;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnClose.IconColor = Color.FromArgb(0, 64, 64);
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 50;
            btnClose.Location = new Point(0, 583);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(1041, 67);
            btnClose.TabIndex = 4;
            btnClose.TextImageRelation = TextImageRelation.ImageAboveText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // dgvFoods
            // 
            dgvFoods.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoods.Dock = DockStyle.Fill;
            dgvFoods.Location = new Point(416, 264);
            dgvFoods.MultiSelect = false;
            dgvFoods.Name = "dgvFoods";
            dgvFoods.ReadOnly = true;
            dgvFoods.RowTemplate.Height = 25;
            dgvFoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoods.Size = new Size(625, 319);
            dgvFoods.TabIndex = 3;
            dgvFoods.SelectionChanged += dgvFoods_SelectionChanged;
            dgvFoods.MouseClick += dgvFoods_MouseClick;
            // 
            // txtSearchFood
            // 
            txtSearchFood.Location = new Point(12, 31);
            txtSearchFood.Name = "txtSearchFood";
            txtSearchFood.Size = new Size(192, 27);
            txtSearchFood.TabIndex = 1;
            txtSearchFood.TextChanged += txtSearchFood_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(192, 24);
            label1.TabIndex = 5;
            label1.Text = "Yemek Adı";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(416, 483);
            panel2.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(lstDailyMeal);
            panel4.Controls.Add(dtpMealDate);
            panel4.Controls.Add(lblMealName);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 164);
            panel4.Name = "panel4";
            panel4.Size = new Size(416, 319);
            panel4.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnUpdate);
            panel6.Controls.Add(btnRemove);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 274);
            panel6.Name = "panel6";
            panel6.Size = new Size(416, 45);
            panel6.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.Dock = DockStyle.Left;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(198, 198, 198);
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            btnUpdate.IconColor = Color.FromArgb(192, 192, 0);
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.Location = new Point(0, 0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(204, 45);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Güncelle";
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Dock = DockStyle.Right;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatAppearance.MouseDownBackColor = Color.FromArgb(198, 198, 198);
            btnRemove.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            btnRemove.IconColor = Color.FromArgb(192, 0, 0);
            btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRemove.IconSize = 45;
            btnRemove.ImageAlign = ContentAlignment.MiddleRight;
            btnRemove.Location = new Point(204, 0);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(212, 45);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Sil";
            btnRemove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lstDailyMeal
            // 
            lstDailyMeal.BackColor = Color.FromArgb(224, 224, 224);
            lstDailyMeal.Dock = DockStyle.Fill;
            lstDailyMeal.FormattingEnabled = true;
            lstDailyMeal.ItemHeight = 20;
            lstDailyMeal.Location = new Point(0, 73);
            lstDailyMeal.Name = "lstDailyMeal";
            lstDailyMeal.Size = new Size(416, 246);
            lstDailyMeal.TabIndex = 1;
            lstDailyMeal.SelectedIndexChanged += lstDailyMeal_SelectedIndexChanged;
            // 
            // dtpMealDate
            // 
            dtpMealDate.Dock = DockStyle.Top;
            dtpMealDate.Location = new Point(0, 46);
            dtpMealDate.Name = "dtpMealDate";
            dtpMealDate.Size = new Size(416, 27);
            dtpMealDate.TabIndex = 0;
            dtpMealDate.ValueChanged += dtpMealDate_ValueChanged;
            // 
            // lblMealName
            // 
            lblMealName.Dock = DockStyle.Top;
            lblMealName.Font = new Font("Segoe MDL2 Assets", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMealName.Location = new Point(0, 0);
            lblMealName.Name = "lblMealName";
            lblMealName.Size = new Size(416, 46);
            lblMealName.TabIndex = 1;
            lblMealName.Text = "KAHVALTI";
            lblMealName.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(cbOrderByFilter);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(txtSearchFood);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(416, 164);
            panel5.TabIndex = 9;
            // 
            // cbOrderByFilter
            // 
            cbOrderByFilter.FormattingEnabled = true;
            cbOrderByFilter.Items.AddRange(new object[] { "Ketojenik diyet için ideal ( düşük karbonhidrat )", "Dukan diyeti için ideal ( yüksek protein )", "Kaloriye göre azalan", "Kaloriye göre artan", "Proteine göre azalan", "Proteine göre artan", "Karbonhidrata göre azalan", "Karbonhidrata göre artan", "Yağa göre azalan", "Yağa göre artan", "" });
            cbOrderByFilter.Location = new Point(210, 30);
            cbOrderByFilter.Name = "cbOrderByFilter";
            cbOrderByFilter.Size = new Size(192, 28);
            cbOrderByFilter.TabIndex = 2;
            cbOrderByFilter.SelectedIndexChanged += cbOrderByFilter_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Location = new Point(210, 4);
            label3.Name = "label3";
            label3.Size = new Size(192, 24);
            label3.TabIndex = 5;
            label3.Text = "Sıralama Filtresi";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAddMeal
            // 
            btnAddMeal.BackColor = Color.Transparent;
            btnAddMeal.FlatAppearance.BorderSize = 0;
            btnAddMeal.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 120, 80);
            btnAddMeal.FlatAppearance.MouseOverBackColor = Color.FromArgb(141, 197, 61);
            btnAddMeal.FlatStyle = FlatStyle.Flat;
            btnAddMeal.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            btnAddMeal.Font = new Font("Segoe MDL2 Assets", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddMeal.ForeColor = Color.Black;
            btnAddMeal.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            btnAddMeal.IconColor = Color.DarkGreen;
            btnAddMeal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddMeal.IconSize = 40;
            btnAddMeal.Location = new Point(189, 98);
            btnAddMeal.Name = "btnAddMeal";
            btnAddMeal.Padding = new Padding(0, 6, 0, 0);
            btnAddMeal.Size = new Size(400, 63);
            btnAddMeal.TabIndex = 0;
            btnAddMeal.Text = "EKLE";
            btnAddMeal.TextAlign = ContentAlignment.MiddleRight;
            btnAddMeal.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddMeal.UseVisualStyleBackColor = false;
            btnAddMeal.Click += btnAddMeal_Click;
            // 
            // txtFood
            // 
            txtFood.Font = new Font("Segoe MDL2 Assets", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtFood.Location = new Point(189, 5);
            txtFood.Name = "txtFood";
            txtFood.ReadOnly = true;
            txtFood.Size = new Size(400, 34);
            txtFood.TabIndex = 1;
            // 
            // nudQuantity
            // 
            nudQuantity.Font = new Font("Segoe MDL2 Assets", 20F, FontStyle.Regular, GraphicsUnit.Point);
            nudQuantity.Location = new Point(248, 54);
            nudQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(131, 34);
            nudQuantity.TabIndex = 2;
            nudQuantity.TextAlign = HorizontalAlignment.Center;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel3
            // 
            panel3.Controls.Add(pbFoods);
            panel3.Controls.Add(lblMeasure);
            panel3.Controls.Add(nudQuantity);
            panel3.Controls.Add(btnAddMeal);
            panel3.Controls.Add(txtFood);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(416, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(625, 164);
            panel3.TabIndex = 9;
            // 
            // pbFoods
            // 
            pbFoods.BorderStyle = BorderStyle.Fixed3D;
            pbFoods.Dock = DockStyle.Left;
            pbFoods.Location = new Point(0, 0);
            pbFoods.Name = "pbFoods";
            pbFoods.Size = new Size(164, 164);
            pbFoods.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoods.TabIndex = 4;
            pbFoods.TabStop = false;
            // 
            // lblMeasure
            // 
            lblMeasure.Font = new Font("Segoe MDL2 Assets", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblMeasure.Location = new Point(385, 54);
            lblMeasure.Name = "lblMeasure";
            lblMeasure.Size = new Size(204, 34);
            lblMeasure.TabIndex = 3;
            lblMeasure.Text = "fincan/kase";
            // 
            // AddMeals
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1041, 650);
            Controls.Add(dgvFoods);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "AddMeals";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMeals";
            Load += AddMeals_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFoods).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoods).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnClose;
        private DataGridView dgvFoods;
        private TextBox txtSearchFood;
        private Label label1;
        private Panel panel2;
        private Panel panel4;
        private Label lblMealName;
        private ComboBox cbOrderByFilter;
        private FontAwesome.Sharp.IconButton btnAddMeal;
        private TextBox txtFood;
        private NumericUpDown nudQuantity;
        private Panel panel3;
        private Label lblMeasure;
        private DateTimePicker dtpMealDate;
        private Panel panel5;
        private ListBox lstDailyMeal;
        private Label label3;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnRemove;
        private PictureBox pbFoods;
    }
}