namespace VO2_Max.Athlete
{
    partial class vomax
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.btnCalculation = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerT = new System.Windows.Forms.DateTimePicker();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Time :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(133, 155);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(85, 20);
            this.txtHeight.TabIndex = 31;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Height :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(405, 425);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 28;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // btnCalculation
            // 
            this.btnCalculation.Location = new System.Drawing.Point(43, 309);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(75, 23);
            this.btnCalculation.TabIndex = 27;
            this.btnCalculation.Text = "Calculate";
            this.btnCalculation.UseVisualStyleBackColor = true;
            this.btnCalculation.Click += new System.EventHandler(this.btnCalculation_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(132, 54);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(85, 20);
            this.txtAge.TabIndex = 25;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(133, 200);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(85, 20);
            this.txtWeight.TabIndex = 24;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // comboGender
            // 
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(132, 247);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(66, 21);
            this.comboGender.TabIndex = 22;
            this.comboGender.SelectedIndexChanged += new System.EventHandler(this.comboGender_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Gender :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Weight :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Age :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePickerT
            // 
            this.dateTimePickerT.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerT.Location = new System.Drawing.Point(132, 115);
            this.dateTimePickerT.Name = "dateTimePickerT";
            this.dateTimePickerT.Size = new System.Drawing.Size(97, 20);
            this.dateTimePickerT.TabIndex = 34;
            this.dateTimePickerT.ValueChanged += new System.EventHandler(this.dateTimePickerT_ValueChanged);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(43, 367);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(314, 20);
            this.txtResults.TabIndex = 35;
            this.txtResults.TextChanged += new System.EventHandler(this.txtResults_TextChanged);
            // 
            // vomax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 479);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.dateTimePickerT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.btnCalculation);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vomax";
            this.Text = "vomax";
            this.Load += new System.EventHandler(this.vomax_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button btnCalculation;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerT;
        private System.Windows.Forms.TextBox txtResults;
    }
}