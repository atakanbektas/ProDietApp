namespace WFA_ProDiet.UI
{
    partial class ucProTakip
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
            this.pnlCurrentKcal = new System.Windows.Forms.Panel();
            this.dtpMealDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTargetCalorie = new System.Windows.Forms.Label();
            this.flpMeals = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBreakFast = new System.Windows.Forms.Panel();
            this.lblCurrentKcalBF = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTargetKcalBF = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.btnAddBreakFast = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCurrentKcalLunch = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTargetKcalLunch = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblLunch = new System.Windows.Forms.Label();
            this.btnAddLunch = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCurrentKcalDinner = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTargetKcalDinner = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblDinner = new System.Windows.Forms.Label();
            this.btnAddDinner = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCurrentKcalExtra = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblExtra = new System.Windows.Forms.Label();
            this.btnAddExtra = new FontAwesome.Sharp.IconButton();
            this.pnlCurrentKcal.SuspendLayout();
            this.flpMeals.SuspendLayout();
            this.pnlBreakFast.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCurrentKcal
            // 
            this.pnlCurrentKcal.Controls.Add(this.dtpMealDate);
            this.pnlCurrentKcal.Controls.Add(this.label2);
            this.pnlCurrentKcal.Controls.Add(this.lblTargetCalorie);
            this.pnlCurrentKcal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCurrentKcal.Location = new System.Drawing.Point(0, 0);
            this.pnlCurrentKcal.Name = "pnlCurrentKcal";
            this.pnlCurrentKcal.Size = new System.Drawing.Size(960, 560);
            this.pnlCurrentKcal.TabIndex = 0;
            // 
            // dtpMealDate
            // 
            this.dtpMealDate.Location = new System.Drawing.Point(12, 52);
            this.dtpMealDate.Name = "dtpMealDate";
            this.dtpMealDate.Size = new System.Drawing.Size(246, 27);
            this.dtpMealDate.TabIndex = 0;
            this.dtpMealDate.ValueChanged += new System.EventHandler(this.dtpMealDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(537, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "kcal";
            // 
            // lblTargetCalorie
            // 
            this.lblTargetCalorie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTargetCalorie.AutoSize = true;
            this.lblTargetCalorie.Font = new System.Drawing.Font("Segoe MDL2 Assets", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTargetCalorie.ForeColor = System.Drawing.Color.Green;
            this.lblTargetCalorie.Location = new System.Drawing.Point(407, 0);
            this.lblTargetCalorie.Name = "lblTargetCalorie";
            this.lblTargetCalorie.Size = new System.Drawing.Size(141, 67);
            this.lblTargetCalorie.TabIndex = 0;
            this.lblTargetCalorie.Text = "1180";
            // 
            // flpMeals
            // 
            this.flpMeals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpMeals.AutoScroll = true;
            this.flpMeals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.flpMeals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpMeals.Controls.Add(this.pnlBreakFast);
            this.flpMeals.Controls.Add(this.panel2);
            this.flpMeals.Controls.Add(this.panel3);
            this.flpMeals.Controls.Add(this.panel4);
            this.flpMeals.Location = new System.Drawing.Point(0, 82);
            this.flpMeals.Name = "flpMeals";
            this.flpMeals.Size = new System.Drawing.Size(960, 478);
            this.flpMeals.TabIndex = 1;
            // 
            // pnlBreakFast
            // 
            this.pnlBreakFast.BackColor = System.Drawing.Color.Transparent;
            this.pnlBreakFast.BackgroundImage = global::WFA_ProDiet.UI.Properties.Resources.WhatsApp_Image_2023_03_28_at_17_021;
            this.pnlBreakFast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBreakFast.Controls.Add(this.lblCurrentKcalBF);
            this.pnlBreakFast.Controls.Add(this.label9);
            this.pnlBreakFast.Controls.Add(this.label8);
            this.pnlBreakFast.Controls.Add(this.lblTargetKcalBF);
            this.pnlBreakFast.Controls.Add(this.label5);
            this.pnlBreakFast.Controls.Add(this.label4);
            this.pnlBreakFast.Controls.Add(this.lblBreakfast);
            this.pnlBreakFast.Controls.Add(this.btnAddBreakFast);
            this.pnlBreakFast.Location = new System.Drawing.Point(12, 3);
            this.pnlBreakFast.Margin = new System.Windows.Forms.Padding(12, 3, 8, 3);
            this.pnlBreakFast.Name = "pnlBreakFast";
            this.pnlBreakFast.Size = new System.Drawing.Size(460, 210);
            this.pnlBreakFast.TabIndex = 0;
            // 
            // lblCurrentKcalBF
            // 
            this.lblCurrentKcalBF.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentKcalBF.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentKcalBF.Location = new System.Drawing.Point(150, 166);
            this.lblCurrentKcalBF.Name = "lblCurrentKcalBF";
            this.lblCurrentKcalBF.Size = new System.Drawing.Size(53, 20);
            this.lblCurrentKcalBF.TabIndex = 4;
            this.lblCurrentKcalBF.Text = "425";
            this.lblCurrentKcalBF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(206, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "kcal";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(206, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "kcal";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTargetKcalBF
            // 
            this.lblTargetKcalBF.BackColor = System.Drawing.Color.Transparent;
            this.lblTargetKcalBF.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTargetKcalBF.Location = new System.Drawing.Point(150, 140);
            this.lblTargetKcalBF.Name = "lblTargetKcalBF";
            this.lblTargetKcalBF.Size = new System.Drawing.Size(53, 20);
            this.lblTargetKcalBF.TabIndex = 3;
            this.lblTargetKcalBF.Text = "355";
            this.lblTargetKcalBF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(51, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Alınan Kalori :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(51, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hedef Kalori :";
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.BackColor = System.Drawing.Color.Transparent;
            this.lblBreakfast.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBreakfast.Location = new System.Drawing.Point(3, 3);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(285, 55);
            this.lblBreakfast.TabIndex = 1;
            this.lblBreakfast.Text = "KAHVALTI";
            this.lblBreakfast.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddBreakFast
            // 
            this.btnAddBreakFast.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBreakFast.FlatAppearance.BorderSize = 0;
            this.btnAddBreakFast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddBreakFast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddBreakFast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBreakFast.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddBreakFast.IconColor = System.Drawing.Color.Green;
            this.btnAddBreakFast.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddBreakFast.IconSize = 70;
            this.btnAddBreakFast.Location = new System.Drawing.Point(3, 61);
            this.btnAddBreakFast.Name = "btnAddBreakFast";
            this.btnAddBreakFast.Size = new System.Drawing.Size(285, 63);
            this.btnAddBreakFast.TabIndex = 0;
            this.btnAddBreakFast.UseVisualStyleBackColor = false;
            this.btnAddBreakFast.Click += new System.EventHandler(this.btnAddBreakFast_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BackgroundImage = global::WFA_ProDiet.UI.Properties.Resources.WhatsApp_Image_2023_03_28_at_17_30_58;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblCurrentKcalLunch);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lblTargetKcalLunch);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lblLunch);
            this.panel2.Controls.Add(this.btnAddLunch);
            this.panel2.Location = new System.Drawing.Point(488, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(8, 3, 10, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 210);
            this.panel2.TabIndex = 1;
            // 
            // lblCurrentKcalLunch
            // 
            this.lblCurrentKcalLunch.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentKcalLunch.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentKcalLunch.Location = new System.Drawing.Point(150, 166);
            this.lblCurrentKcalLunch.Name = "lblCurrentKcalLunch";
            this.lblCurrentKcalLunch.Size = new System.Drawing.Size(53, 20);
            this.lblCurrentKcalLunch.TabIndex = 4;
            this.lblCurrentKcalLunch.Text = "425";
            this.lblCurrentKcalLunch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(206, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "kcal";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(206, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "kcal";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTargetKcalLunch
            // 
            this.lblTargetKcalLunch.BackColor = System.Drawing.Color.Transparent;
            this.lblTargetKcalLunch.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTargetKcalLunch.Location = new System.Drawing.Point(150, 140);
            this.lblTargetKcalLunch.Name = "lblTargetKcalLunch";
            this.lblTargetKcalLunch.Size = new System.Drawing.Size(53, 20);
            this.lblTargetKcalLunch.TabIndex = 3;
            this.lblTargetKcalLunch.Text = "355";
            this.lblTargetKcalLunch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(51, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Alınan Kalori :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(51, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Hedef Kalori :";
            // 
            // lblLunch
            // 
            this.lblLunch.BackColor = System.Drawing.Color.Transparent;
            this.lblLunch.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLunch.Location = new System.Drawing.Point(3, 3);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(285, 55);
            this.lblLunch.TabIndex = 0;
            this.lblLunch.Text = "ÖĞLE YEMEĞİ";
            this.lblLunch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddLunch
            // 
            this.btnAddLunch.BackColor = System.Drawing.Color.Transparent;
            this.btnAddLunch.FlatAppearance.BorderSize = 0;
            this.btnAddLunch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddLunch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddLunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLunch.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddLunch.IconColor = System.Drawing.Color.Green;
            this.btnAddLunch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddLunch.IconSize = 70;
            this.btnAddLunch.Location = new System.Drawing.Point(3, 61);
            this.btnAddLunch.Name = "btnAddLunch";
            this.btnAddLunch.Size = new System.Drawing.Size(285, 63);
            this.btnAddLunch.TabIndex = 0;
            this.btnAddLunch.UseVisualStyleBackColor = false;
            this.btnAddLunch.Click += new System.EventHandler(this.btnAddLunch_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::WFA_ProDiet.UI.Properties.Resources.WhatsApp_Image_2023_03_28_at_17_30_57;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblCurrentKcalDinner);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.lblTargetKcalDinner);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.lblDinner);
            this.panel3.Controls.Add(this.btnAddDinner);
            this.panel3.Location = new System.Drawing.Point(12, 219);
            this.panel3.Margin = new System.Windows.Forms.Padding(12, 3, 8, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 210);
            this.panel3.TabIndex = 2;
            // 
            // lblCurrentKcalDinner
            // 
            this.lblCurrentKcalDinner.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentKcalDinner.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentKcalDinner.Location = new System.Drawing.Point(150, 165);
            this.lblCurrentKcalDinner.Name = "lblCurrentKcalDinner";
            this.lblCurrentKcalDinner.Size = new System.Drawing.Size(53, 20);
            this.lblCurrentKcalDinner.TabIndex = 4;
            this.lblCurrentKcalDinner.Text = "425";
            this.lblCurrentKcalDinner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(206, 165);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 20);
            this.label18.TabIndex = 3;
            this.label18.Text = "kcal";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(206, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 20);
            this.label19.TabIndex = 3;
            this.label19.Text = "kcal";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTargetKcalDinner
            // 
            this.lblTargetKcalDinner.BackColor = System.Drawing.Color.Transparent;
            this.lblTargetKcalDinner.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTargetKcalDinner.Location = new System.Drawing.Point(150, 140);
            this.lblTargetKcalDinner.Name = "lblTargetKcalDinner";
            this.lblTargetKcalDinner.Size = new System.Drawing.Size(53, 20);
            this.lblTargetKcalDinner.TabIndex = 3;
            this.lblTargetKcalDinner.Text = "355";
            this.lblTargetKcalDinner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(51, 165);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 20);
            this.label21.TabIndex = 2;
            this.label21.Text = "Alınan Kalori :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(51, 140);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 20);
            this.label22.TabIndex = 0;
            this.label22.Text = "Hedef Kalori :";
            // 
            // lblDinner
            // 
            this.lblDinner.BackColor = System.Drawing.Color.Transparent;
            this.lblDinner.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDinner.Location = new System.Drawing.Point(3, 3);
            this.lblDinner.Name = "lblDinner";
            this.lblDinner.Size = new System.Drawing.Size(285, 55);
            this.lblDinner.TabIndex = 1;
            this.lblDinner.Text = "AKŞAM YEMEĞİ";
            this.lblDinner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddDinner
            // 
            this.btnAddDinner.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDinner.FlatAppearance.BorderSize = 0;
            this.btnAddDinner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddDinner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddDinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDinner.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddDinner.IconColor = System.Drawing.Color.Green;
            this.btnAddDinner.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddDinner.IconSize = 70;
            this.btnAddDinner.Location = new System.Drawing.Point(3, 61);
            this.btnAddDinner.Name = "btnAddDinner";
            this.btnAddDinner.Size = new System.Drawing.Size(285, 63);
            this.btnAddDinner.TabIndex = 0;
            this.btnAddDinner.UseVisualStyleBackColor = false;
            this.btnAddDinner.Click += new System.EventHandler(this.btnAddDinner_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.BackgroundImage = global::WFA_ProDiet.UI.Properties.Resources.WhatsApp_Image_2023_03_28_at_17_02_00;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblCurrentKcalExtra);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Controls.Add(this.lblExtra);
            this.panel4.Controls.Add(this.btnAddExtra);
            this.panel4.Location = new System.Drawing.Point(488, 219);
            this.panel4.Margin = new System.Windows.Forms.Padding(8, 3, 10, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(460, 210);
            this.panel4.TabIndex = 3;
            // 
            // lblCurrentKcalExtra
            // 
            this.lblCurrentKcalExtra.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentKcalExtra.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentKcalExtra.Location = new System.Drawing.Point(150, 165);
            this.lblCurrentKcalExtra.Name = "lblCurrentKcalExtra";
            this.lblCurrentKcalExtra.Size = new System.Drawing.Size(53, 20);
            this.lblCurrentKcalExtra.TabIndex = 4;
            this.lblCurrentKcalExtra.Text = "425";
            this.lblCurrentKcalExtra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(206, 165);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 20);
            this.label25.TabIndex = 3;
            this.label25.Text = "kcal";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label28.Location = new System.Drawing.Point(51, 165);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(100, 20);
            this.label28.TabIndex = 2;
            this.label28.Text = "Alınan Kalori :";
            // 
            // lblExtra
            // 
            this.lblExtra.BackColor = System.Drawing.Color.Transparent;
            this.lblExtra.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExtra.Location = new System.Drawing.Point(3, 3);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(285, 55);
            this.lblExtra.TabIndex = 1;
            this.lblExtra.Text = "EKSTRA";
            this.lblExtra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddExtra
            // 
            this.btnAddExtra.BackColor = System.Drawing.Color.Transparent;
            this.btnAddExtra.FlatAppearance.BorderSize = 0;
            this.btnAddExtra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddExtra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExtra.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddExtra.IconColor = System.Drawing.Color.Green;
            this.btnAddExtra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddExtra.IconSize = 70;
            this.btnAddExtra.Location = new System.Drawing.Point(3, 61);
            this.btnAddExtra.Name = "btnAddExtra";
            this.btnAddExtra.Size = new System.Drawing.Size(285, 63);
            this.btnAddExtra.TabIndex = 0;
            this.btnAddExtra.UseVisualStyleBackColor = false;
            this.btnAddExtra.Click += new System.EventHandler(this.btnAddExtra_Click);
            // 
            // ucProTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpMeals);
            this.Controls.Add(this.pnlCurrentKcal);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucProTakip";
            this.Size = new System.Drawing.Size(960, 560);
            this.pnlCurrentKcal.ResumeLayout(false);
            this.pnlCurrentKcal.PerformLayout();
            this.flpMeals.ResumeLayout(false);
            this.pnlBreakFast.ResumeLayout(false);
            this.pnlBreakFast.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlCurrentKcal;
        private Label label2;
        private Label lblTargetCalorie;
        private FlowLayoutPanel flpMeals;
        private Panel pnlBreakFast;
        private Label lblTargetKcalBF;
        private Label label5;
        private Label label4;
        private Label lblBreakfast;
        private FontAwesome.Sharp.IconButton btnAddBreakFast;
        private Label label9;
        private Label label8;
        private Panel panel2;
        private Label lblCurrentKcalLunch;
        private Label label11;
        private Label label12;
        private Label lblTargetKcalLunch;
        private Label label14;
        private Label label15;
        private Label lblLunch;
        private FontAwesome.Sharp.IconButton btnAddLunch;
        private Panel panel3;
        private Label lblCurrentKcalDinner;
        private Label label18;
        private Label label19;
        private Label lblTargetKcalDinner;
        private Label label21;
        private Label label22;
        private Label lblDinner;
        private FontAwesome.Sharp.IconButton btnAddDinner;
        private Panel panel4;
        private Label lblCurrentKcalExtra;
        private Label label25;
        private Label label28;
        private Label lblExtra;
        private FontAwesome.Sharp.IconButton btnAddExtra;
        private DateTimePicker dtpMealDate;
        public Label lblCurrentKcalBF;
    }
}
