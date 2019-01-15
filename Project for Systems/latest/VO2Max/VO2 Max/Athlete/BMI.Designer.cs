namespace VO2_Max.Athlete
{
    partial class BMI
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
            this.btnResetBMI = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtResultBMI = new System.Windows.Forms.TextBox();
            this.radioButtonChild = new System.Windows.Forms.RadioButton();
            this.radioButtonAdult = new System.Windows.Forms.RadioButton();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblCalculate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblPounts = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.ComboMeasurement = new System.Windows.Forms.ComboBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResetBMI
            // 
            this.btnResetBMI.ForeColor = System.Drawing.Color.Blue;
            this.btnResetBMI.Location = new System.Drawing.Point(336, 345);
            this.btnResetBMI.Name = "btnResetBMI";
            this.btnResetBMI.Size = new System.Drawing.Size(80, 28);
            this.btnResetBMI.TabIndex = 29;
            this.btnResetBMI.Text = "Reset";
            this.btnResetBMI.UseVisualStyleBackColor = true;
            this.btnResetBMI.Click += new System.EventHandler(this.btnResetBMI_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(55, 341);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 47);
            this.btnCalculate.TabIndex = 28;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtResultBMI
            // 
            this.txtResultBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultBMI.Location = new System.Drawing.Point(44, 427);
            this.txtResultBMI.Multiline = true;
            this.txtResultBMI.Name = "txtResultBMI";
            this.txtResultBMI.Size = new System.Drawing.Size(448, 50);
            this.txtResultBMI.TabIndex = 26;
            this.txtResultBMI.TextChanged += new System.EventHandler(this.txtResultBMI_TextChanged);
            // 
            // radioButtonChild
            // 
            this.radioButtonChild.AutoSize = true;
            this.radioButtonChild.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonChild.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonChild.Location = new System.Drawing.Point(326, 70);
            this.radioButtonChild.Name = "radioButtonChild";
            this.radioButtonChild.Size = new System.Drawing.Size(136, 28);
            this.radioButtonChild.TabIndex = 21;
            this.radioButtonChild.TabStop = true;
            this.radioButtonChild.Text = "Children BMI";
            this.radioButtonChild.UseVisualStyleBackColor = false;
            this.radioButtonChild.CheckedChanged += new System.EventHandler(this.radioButtonChild_CheckedChanged);
            // 
            // radioButtonAdult
            // 
            this.radioButtonAdult.AutoSize = true;
            this.radioButtonAdult.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonAdult.Location = new System.Drawing.Point(193, 68);
            this.radioButtonAdult.Name = "radioButtonAdult";
            this.radioButtonAdult.Size = new System.Drawing.Size(108, 28);
            this.radioButtonAdult.TabIndex = 20;
            this.radioButtonAdult.TabStop = true;
            this.radioButtonAdult.Text = "Adult BMI";
            this.radioButtonAdult.UseVisualStyleBackColor = false;
            this.radioButtonAdult.CheckedChanged += new System.EventHandler(this.radioButtonAdult_CheckedChanged);
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.BackColor = System.Drawing.Color.Transparent;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLine.Location = new System.Drawing.Point(8, 98);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(488, 25);
            this.lblLine.TabIndex = 16;
            this.lblLine.Text = "--------------------------------------------------------------------";
            this.lblLine.Click += new System.EventHandler(this.lblLine_Click);
            // 
            // lblCalculate
            // 
            this.lblCalculate.AutoSize = true;
            this.lblCalculate.BackColor = System.Drawing.Color.Transparent;
            this.lblCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCalculate.Location = new System.Drawing.Point(12, 68);
            this.lblCalculate.Name = "lblCalculate";
            this.lblCalculate.Size = new System.Drawing.Size(140, 25);
            this.lblCalculate.TabIndex = 15;
            this.lblCalculate.Text = "Calculate For";
            this.lblCalculate.Click += new System.EventHandler(this.lblCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.lblPounts);
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Controls.Add(this.ComboMeasurement);
            this.groupBox1.Controls.Add(this.lblWeight);
            this.groupBox1.Controls.Add(this.lblHeight);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 203);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(244, 36);
            this.txtHeight.Multiline = true;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(82, 35);
            this.txtHeight.TabIndex = 36;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // lblPounts
            // 
            this.lblPounts.AutoSize = true;
            this.lblPounts.BackColor = System.Drawing.Color.Transparent;
            this.lblPounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPounts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPounts.Location = new System.Drawing.Point(332, 134);
            this.lblPounts.Name = "lblPounts";
            this.lblPounts.Size = new System.Drawing.Size(107, 25);
            this.lblPounts.TabIndex = 35;
            this.lblPounts.Text = "Kilograms";
            this.lblPounts.Click += new System.EventHandler(this.lblPounts_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(244, 123);
            this.txtWeight.Multiline = true;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(82, 35);
            this.txtWeight.TabIndex = 34;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // ComboMeasurement
            // 
            this.ComboMeasurement.FormattingEnabled = true;
            this.ComboMeasurement.Items.AddRange(new object[] {
            "Cm",
            "M",
            "Feet"});
            this.ComboMeasurement.Location = new System.Drawing.Point(352, 37);
            this.ComboMeasurement.Name = "ComboMeasurement";
            this.ComboMeasurement.Size = new System.Drawing.Size(68, 28);
            this.ComboMeasurement.TabIndex = 30;
            this.ComboMeasurement.SelectedIndexChanged += new System.EventHandler(this.ComboMeasurement_SelectedIndexChanged);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.Transparent;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWeight.Location = new System.Drawing.Point(28, 134);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(131, 25);
            this.lblWeight.TabIndex = 29;
            this.lblWeight.Text = "Your Weight";
            this.lblWeight.Click += new System.EventHandler(this.lblWeight_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.BackColor = System.Drawing.Color.Transparent;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeight.Location = new System.Drawing.Point(28, 36);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(130, 50);
            this.lblHeight.TabIndex = 28;
            this.lblHeight.Text = "Your Height";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblHeight.Click += new System.EventHandler(this.lblHeight_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Red;
            this.labelTitle.Location = new System.Drawing.Point(458, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(305, 42);
            this.labelTitle.TabIndex = 31;
            this.labelTitle.Text = "Body Mass Index";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(722, 492);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(103, 47);
            this.buttonBack.TabIndex = 32;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VO2_Max.Properties.Resources.sport_running_less;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 566);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnResetBMI);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResultBMI);
            this.Controls.Add(this.radioButtonChild);
            this.Controls.Add(this.radioButtonAdult);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(870, 566);
            this.MinimumSize = new System.Drawing.Size(870, 566);
            this.Name = "BMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI";
            this.Load += new System.EventHandler(this.BMI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetBMI;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtResultBMI;
        private System.Windows.Forms.RadioButton radioButtonChild;
        private System.Windows.Forms.RadioButton radioButtonAdult;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPounts;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.ComboBox ComboMeasurement;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox txtHeight;
    }
}