namespace SkyForce_Sport_Management_System
{
    partial class VO2Max
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
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.dateTimePickerT = new System.Windows.Forms.DateTimePicker();
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Image = global::SkyForce_Sport_Management_System.Properties.Resources.HelpRecent;
            this.button3.Location = new System.Drawing.Point(707, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 45);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 45);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(155, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculate VO2 Max";
            // 
            // button2
            // 
            this.button2.Image = global::SkyForce_Sport_Management_System.Properties.Resources.Cancel;
            this.button2.Location = new System.Drawing.Point(649, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 45);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(27, 363);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(366, 20);
            this.txtResults.TabIndex = 48;
            this.txtResults.TextChanged += new System.EventHandler(this.txtResults_TextChanged);
            // 
            // dateTimePickerT
            // 
            this.dateTimePickerT.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerT.Location = new System.Drawing.Point(131, 111);
            this.dateTimePickerT.Name = "dateTimePickerT";
            this.dateTimePickerT.Size = new System.Drawing.Size(112, 20);
            this.dateTimePickerT.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Time :";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(132, 151);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(98, 20);
            this.txtHeight.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Height :";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(649, 382);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(122, 23);
            this.buttonBack.TabIndex = 43;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // btnCalculation
            // 
            this.btnCalculation.Location = new System.Drawing.Point(27, 305);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(87, 23);
            this.btnCalculation.TabIndex = 42;
            this.btnCalculation.Text = "Calculate";
            this.btnCalculation.UseVisualStyleBackColor = true;
            this.btnCalculation.Click += new System.EventHandler(this.btnCalculation_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(131, 77);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(98, 20);
            this.txtAge.TabIndex = 41;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(132, 196);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(98, 20);
            this.txtWeight.TabIndex = 40;
            // 
            // comboGender
            // 
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(131, 243);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(76, 21);
            this.comboGender.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Gender :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Weight :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Age :";
            // 
            // VO2Max
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(787, 432);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VO2Max";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VO2Max";
            this.Load += new System.EventHandler(this.VO2Max_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.DateTimePicker dateTimePickerT;
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
        private System.Windows.Forms.Label label4;
    }
}