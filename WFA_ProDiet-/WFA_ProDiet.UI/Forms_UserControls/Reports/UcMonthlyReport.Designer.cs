namespace WFA_ProDiet.UI
{
    partial class UcMonthlyReport
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
            this.plistMonthlyGraph = new OxyPlot.WindowsForms.PlotView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMeals = new System.Windows.Forms.GroupBox();
            this.rbBreakFast = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbExtra = new System.Windows.Forms.RadioButton();
            this.rbLaunch = new System.Windows.Forms.RadioButton();
            this.rbDinner = new System.Windows.Forms.RadioButton();
            this.btnCompareByCalorie = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.cbMeals.SuspendLayout();
            this.SuspendLayout();
            // 
            // plistMonthlyGraph
            // 
            this.plistMonthlyGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plistMonthlyGraph.Location = new System.Drawing.Point(0, 122);
            this.plistMonthlyGraph.Name = "plistMonthlyGraph";
            this.plistMonthlyGraph.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plistMonthlyGraph.Size = new System.Drawing.Size(960, 438);
            this.plistMonthlyGraph.TabIndex = 0;
            this.plistMonthlyGraph.Text = "plotView1";
            this.plistMonthlyGraph.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plistMonthlyGraph.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plistMonthlyGraph.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbMeals);
            this.panel1.Controls.Add(this.btnCompareByCalorie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 122);
            this.panel1.TabIndex = 5;
            // 
            // cbMeals
            // 
            this.cbMeals.Controls.Add(this.rbBreakFast);
            this.cbMeals.Controls.Add(this.rbAll);
            this.cbMeals.Controls.Add(this.rbExtra);
            this.cbMeals.Controls.Add(this.rbLaunch);
            this.cbMeals.Controls.Add(this.rbDinner);
            this.cbMeals.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cbMeals.Location = new System.Drawing.Point(38, 29);
            this.cbMeals.Name = "cbMeals";
            this.cbMeals.Size = new System.Drawing.Size(545, 82);
            this.cbMeals.TabIndex = 9;
            this.cbMeals.TabStop = false;
            this.cbMeals.Text = "Öğünler";
            // 
            // rbBreakFast
            // 
            this.rbBreakFast.AutoSize = true;
            this.rbBreakFast.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.rbBreakFast.FlatAppearance.BorderSize = 3;
            this.rbBreakFast.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(62)))));
            this.rbBreakFast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.rbBreakFast.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbBreakFast.Location = new System.Drawing.Point(116, 35);
            this.rbBreakFast.Name = "rbBreakFast";
            this.rbBreakFast.Size = new System.Drawing.Size(79, 23);
            this.rbBreakFast.TabIndex = 1;
            this.rbBreakFast.Text = "Kahvaltı";
            this.rbBreakFast.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.rbAll.FlatAppearance.BorderSize = 3;
            this.rbAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(62)))));
            this.rbAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.rbAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbAll.Location = new System.Drawing.Point(46, 35);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(64, 23);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Hepsi";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbExtra
            // 
            this.rbExtra.AutoSize = true;
            this.rbExtra.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.rbExtra.FlatAppearance.BorderSize = 3;
            this.rbExtra.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(62)))));
            this.rbExtra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.rbExtra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbExtra.Location = new System.Drawing.Point(442, 35);
            this.rbExtra.Name = "rbExtra";
            this.rbExtra.Size = new System.Drawing.Size(67, 23);
            this.rbExtra.TabIndex = 4;
            this.rbExtra.Text = "Ekstra";
            this.rbExtra.UseVisualStyleBackColor = true;
            // 
            // rbLaunch
            // 
            this.rbLaunch.AutoSize = true;
            this.rbLaunch.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.rbLaunch.FlatAppearance.BorderSize = 3;
            this.rbLaunch.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(62)))));
            this.rbLaunch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.rbLaunch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbLaunch.Location = new System.Drawing.Point(201, 35);
            this.rbLaunch.Name = "rbLaunch";
            this.rbLaunch.Size = new System.Drawing.Size(109, 23);
            this.rbLaunch.TabIndex = 2;
            this.rbLaunch.Text = "Öğle Yemeği";
            this.rbLaunch.UseVisualStyleBackColor = true;
            // 
            // rbDinner
            // 
            this.rbDinner.AutoSize = true;
            this.rbDinner.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.rbDinner.FlatAppearance.BorderSize = 3;
            this.rbDinner.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(62)))));
            this.rbDinner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.rbDinner.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbDinner.Location = new System.Drawing.Point(316, 35);
            this.rbDinner.Name = "rbDinner";
            this.rbDinner.Size = new System.Drawing.Size(120, 23);
            this.rbDinner.TabIndex = 3;
            this.rbDinner.Text = "Akşam Yemeği";
            this.rbDinner.UseVisualStyleBackColor = true;
            // 
            // btnCompareByCalorie
            // 
            this.btnCompareByCalorie.BackColor = System.Drawing.Color.Chocolate;
            this.btnCompareByCalorie.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCompareByCalorie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCompareByCalorie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCompareByCalorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompareByCalorie.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompareByCalorie.ForeColor = System.Drawing.Color.White;
            this.btnCompareByCalorie.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.btnCompareByCalorie.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCompareByCalorie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompareByCalorie.IconSize = 40;
            this.btnCompareByCalorie.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompareByCalorie.Location = new System.Drawing.Point(589, 42);
            this.btnCompareByCalorie.Name = "btnCompareByCalorie";
            this.btnCompareByCalorie.Size = new System.Drawing.Size(359, 69);
            this.btnCompareByCalorie.TabIndex = 7;
            this.btnCompareByCalorie.Text = "KALORİ KIYASLA";
            this.btnCompareByCalorie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompareByCalorie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompareByCalorie.UseVisualStyleBackColor = false;
            this.btnCompareByCalorie.Click += new System.EventHandler(this.btnCompareByCalorie_Click);
            // 
            // UcMonthlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plistMonthlyGraph);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcMonthlyReport";
            this.Size = new System.Drawing.Size(960, 560);
            this.panel1.ResumeLayout(false);
            this.cbMeals.ResumeLayout(false);
            this.cbMeals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plistMonthlyGraph;
        private Panel panel1;
        private GroupBox cbMeals;
        private RadioButton rbBreakFast;
        private RadioButton rbAll;
        private RadioButton rbExtra;
        private RadioButton rbLaunch;
        private RadioButton rbDinner;
        private FontAwesome.Sharp.IconButton btnCompareByCalorie;
    }
}
