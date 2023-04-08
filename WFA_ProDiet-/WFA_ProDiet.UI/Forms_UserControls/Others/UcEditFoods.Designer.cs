namespace WFA_ProDiet.UI
{
    partial class UcEditFoods
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbFood = new System.Windows.Forms.PictureBox();
            this.btnAddPict = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudCalorieQ = new System.Windows.Forms.NumericUpDown();
            this.nudFatQ = new System.Windows.Forms.NumericUpDown();
            this.nudCarbohydrateQ = new System.Windows.Forms.NumericUpDown();
            this.nudProteinQ = new System.Windows.Forms.NumericUpDown();
            this.cbMeasure = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalorieQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFatQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbohydrateQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProteinQ)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnAdd.Font = new System.Drawing.Font("Segoe MDL2 Assets", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(62)))));
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 50;
            this.btnAdd.Location = new System.Drawing.Point(597, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(270, 73);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvFoods
            // 
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFoods.Location = new System.Drawing.Point(0, 0);
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.ReadOnly = true;
            this.dgvFoods.RowTemplate.Height = 25;
            this.dgvFoods.Size = new System.Drawing.Size(960, 254);
            this.dgvFoods.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbFood);
            this.panel1.Controls.Add(this.btnAddPict);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.nudQuantity);
            this.panel1.Controls.Add(this.nudCalorieQ);
            this.panel1.Controls.Add(this.nudFatQ);
            this.panel1.Controls.Add(this.nudCarbohydrateQ);
            this.panel1.Controls.Add(this.nudProteinQ);
            this.panel1.Controls.Add(this.cbMeasure);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFoodName);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 306);
            this.panel1.TabIndex = 6;
            // 
            // pbFood
            // 
            this.pbFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFood.Location = new System.Drawing.Point(35, 12);
            this.pbFood.Name = "pbFood";
            this.pbFood.Size = new System.Drawing.Size(150, 150);
            this.pbFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFood.TabIndex = 12;
            this.pbFood.TabStop = false;
            // 
            // btnAddPict
            // 
            this.btnAddPict.Location = new System.Drawing.Point(35, 173);
            this.btnAddPict.Name = "btnAddPict";
            this.btnAddPict.Size = new System.Drawing.Size(150, 47);
            this.btnAddPict.TabIndex = 9;
            this.btnAddPict.Text = "Resim Ekle";
            this.btnAddPict.UseVisualStyleBackColor = true;
            this.btnAddPict.Click += new System.EventHandler(this.btnAddPict_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Av Hayvanları",
            "Balıklar",
            "Bitkisel Yağlar",
            "Çeşniler",
            "Çorbalar",
            "Deniz Ürünleri",
            "Diğer Besinler",
            "Ekmek vb.",
            "Et Ürünleri",
            "Hayvansal Yağlar",
            "İçecekler",
            "Kırmızı Etler",
            "Kurubaklagiller",
            "Kümes Hayvanları",
            "Meyveler",
            "Peynirler",
            "Sakatatlar",
            "Sebzeler",
            "Soslar",
            "Süt ve Ürünleri",
            "Şeker ve Şeker Ürünleri",
            "Tahıl Ürünleri",
            "Tatlılar",
            "Yumurtalar"});
            this.cbCategory.Location = new System.Drawing.Point(363, 250);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(156, 29);
            this.cbCategory.TabIndex = 7;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(363, 218);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(156, 28);
            this.nudQuantity.TabIndex = 6;
            // 
            // nudCalorieQ
            // 
            this.nudCalorieQ.Location = new System.Drawing.Point(363, 148);
            this.nudCalorieQ.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.nudCalorieQ.Name = "nudCalorieQ";
            this.nudCalorieQ.Size = new System.Drawing.Size(156, 28);
            this.nudCalorieQ.TabIndex = 4;
            // 
            // nudFatQ
            // 
            this.nudFatQ.Location = new System.Drawing.Point(363, 114);
            this.nudFatQ.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.nudFatQ.Name = "nudFatQ";
            this.nudFatQ.Size = new System.Drawing.Size(156, 28);
            this.nudFatQ.TabIndex = 3;
            // 
            // nudCarbohydrateQ
            // 
            this.nudCarbohydrateQ.Location = new System.Drawing.Point(363, 80);
            this.nudCarbohydrateQ.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nudCarbohydrateQ.Name = "nudCarbohydrateQ";
            this.nudCarbohydrateQ.Size = new System.Drawing.Size(156, 28);
            this.nudCarbohydrateQ.TabIndex = 2;
            // 
            // nudProteinQ
            // 
            this.nudProteinQ.Location = new System.Drawing.Point(363, 46);
            this.nudProteinQ.Margin = new System.Windows.Forms.Padding(4);
            this.nudProteinQ.Name = "nudProteinQ";
            this.nudProteinQ.Size = new System.Drawing.Size(156, 28);
            this.nudProteinQ.TabIndex = 1;
            // 
            // cbMeasure
            // 
            this.cbMeasure.FormattingEnabled = true;
            this.cbMeasure.Items.AddRange(new object[] {
            "gram",
            "adet",
            "dilim",
            "fincan",
            "kutu",
            "kadeh",
            "porsiyon",
            "baş",
            "bütün",
            "tatlı kaşığı",
            "bardak"});
            this.cbMeasure.Location = new System.Drawing.Point(363, 182);
            this.cbMeasure.Name = "cbMeasure";
            this.cbMeasure.Size = new System.Drawing.Size(156, 29);
            this.cbMeasure.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(191, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "Kategori :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(191, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Miktar :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(191, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ölçü Birimi :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(191, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kalori Miktarı :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(191, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yağ Miktarı :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(191, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Karbonhidrat Miktarı :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(191, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Protein Miktarı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(191, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(363, 12);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(156, 28);
            this.txtFoodName.TabIndex = 0;
            // 
            // UcEditFoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvFoods);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcEditFoods";
            this.Size = new System.Drawing.Size(960, 560);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalorieQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFatQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbohydrateQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProteinQ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAdd;
        private DataGridView dgvFoods;
        private Panel panel1;
        private NumericUpDown nudProteinQ;
        private ComboBox cbMeasure;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtFoodName;
        private ComboBox cbCategory;
        private NumericUpDown nudCalorieQ;
        private NumericUpDown nudFatQ;
        private NumericUpDown nudCarbohydrateQ;
        private Label label8;
        private Label label7;
        private PictureBox pbFood;
        private Button btnAddPict;
        private NumericUpDown nudQuantity;
    }
}
