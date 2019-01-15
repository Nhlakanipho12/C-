namespace VO2_Max
{
    partial class Welcome
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
            this.lblUser = new System.Windows.Forms.Label();
            this.groupBoxCalculate = new System.Windows.Forms.GroupBox();
            this.comboCurrentLevel = new System.Windows.Forms.ComboBox();
            this.comboSex = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.comboLevel = new System.Windows.Forms.ComboBox();
            this.lblExerciseLevel = new System.Windows.Forms.Label();
            this.comboShuttle = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboHeight = new System.Windows.Forms.ComboBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblHeart = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblShuttles = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.linkLabelAbout = new System.Windows.Forms.LinkLabel();
            this.groupBoxCalculate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(103, 22);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(37, 19);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "User";
            // 
            // groupBoxCalculate
            // 
            this.groupBoxCalculate.Controls.Add(this.comboCurrentLevel);
            this.groupBoxCalculate.Controls.Add(this.comboSex);
            this.groupBoxCalculate.Controls.Add(this.lblSex);
            this.groupBoxCalculate.Controls.Add(this.comboLevel);
            this.groupBoxCalculate.Controls.Add(this.lblExerciseLevel);
            this.groupBoxCalculate.Controls.Add(this.comboShuttle);
            this.groupBoxCalculate.Controls.Add(this.comboBox1);
            this.groupBoxCalculate.Controls.Add(this.comboHeight);
            this.groupBoxCalculate.Controls.Add(this.txtHeight);
            this.groupBoxCalculate.Controls.Add(this.lblHeight);
            this.groupBoxCalculate.Controls.Add(this.txtAge);
            this.groupBoxCalculate.Controls.Add(this.lblHeart);
            this.groupBoxCalculate.Controls.Add(this.lblTime);
            this.groupBoxCalculate.Controls.Add(this.label1);
            this.groupBoxCalculate.Controls.Add(this.txtTime);
            this.groupBoxCalculate.Controls.Add(this.lblLevel);
            this.groupBoxCalculate.Controls.Add(this.btnCalculate);
            this.groupBoxCalculate.Controls.Add(this.txtWeight);
            this.groupBoxCalculate.Controls.Add(this.lblShuttles);
            this.groupBoxCalculate.Controls.Add(this.lblWeight);
            this.groupBoxCalculate.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCalculate.Location = new System.Drawing.Point(12, 44);
            this.groupBoxCalculate.Name = "groupBoxCalculate";
            this.groupBoxCalculate.Size = new System.Drawing.Size(538, 514);
            this.groupBoxCalculate.TabIndex = 6;
            this.groupBoxCalculate.TabStop = false;
            this.groupBoxCalculate.Text = "VO2 MAX Calculator";
            this.groupBoxCalculate.Enter += new System.EventHandler(this.groupBoxCalculate_Enter);
            // 
            // comboCurrentLevel
            // 
            this.comboCurrentLevel.FormattingEnabled = true;
            this.comboCurrentLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboCurrentLevel.Location = new System.Drawing.Point(299, 273);
            this.comboCurrentLevel.Name = "comboCurrentLevel";
            this.comboCurrentLevel.Size = new System.Drawing.Size(70, 31);
            this.comboCurrentLevel.TabIndex = 24;
            // 
            // comboSex
            // 
            this.comboSex.FormattingEnabled = true;
            this.comboSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboSex.Location = new System.Drawing.Point(298, 376);
            this.comboSex.Name = "comboSex";
            this.comboSex.Size = new System.Drawing.Size(71, 31);
            this.comboSex.TabIndex = 23;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(16, 382);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(138, 20);
            this.lblSex.TabIndex = 22;
            this.lblSex.Text = "Select your Gender : ";
            // 
            // comboLevel
            // 
            this.comboLevel.FormattingEnabled = true;
            this.comboLevel.Items.AddRange(new object[] {
            "50",
            "75",
            "100"});
            this.comboLevel.Location = new System.Drawing.Point(298, 322);
            this.comboLevel.Name = "comboLevel";
            this.comboLevel.Size = new System.Drawing.Size(70, 31);
            this.comboLevel.TabIndex = 21;
            // 
            // lblExerciseLevel
            // 
            this.lblExerciseLevel.AutoSize = true;
            this.lblExerciseLevel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExerciseLevel.Location = new System.Drawing.Point(16, 328);
            this.lblExerciseLevel.Name = "lblExerciseLevel";
            this.lblExerciseLevel.Size = new System.Drawing.Size(179, 20);
            this.lblExerciseLevel.TabIndex = 20;
            this.lblExerciseLevel.Text = "Select your Exercise Level :";
            // 
            // comboShuttle
            // 
            this.comboShuttle.FormattingEnabled = true;
            this.comboShuttle.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboShuttle.Location = new System.Drawing.Point(299, 225);
            this.comboShuttle.Name = "comboShuttle";
            this.comboShuttle.Size = new System.Drawing.Size(70, 31);
            this.comboShuttle.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kg",
            "Pounds"});
            this.comboBox1.Location = new System.Drawing.Point(440, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(65, 31);
            this.comboBox1.TabIndex = 18;
            // 
            // comboHeight
            // 
            this.comboHeight.FormattingEnabled = true;
            this.comboHeight.Items.AddRange(new object[] {
            "Cm",
            "M",
            "Feet"});
            this.comboHeight.Location = new System.Drawing.Point(440, 52);
            this.comboHeight.Name = "comboHeight";
            this.comboHeight.Size = new System.Drawing.Size(65, 31);
            this.comboHeight.TabIndex = 17;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(298, 52);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(115, 31);
            this.txtHeight.TabIndex = 16;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(18, 58);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(166, 20);
            this.lblHeight.TabIndex = 15;
            this.lblHeight.Text = "Enter Your current Height :";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(299, 178);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(70, 28);
            this.txtAge.TabIndex = 14;
            // 
            // lblHeart
            // 
            this.lblHeart.AutoSize = true;
            this.lblHeart.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeart.Location = new System.Drawing.Point(17, 186);
            this.lblHeart.Name = "lblHeart";
            this.lblHeart.Size = new System.Drawing.Size(41, 17);
            this.lblHeart.TabIndex = 13;
            this.lblHeart.Text = "Age :";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(17, 146);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(48, 17);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "Time :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 224);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 11;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(298, 135);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(115, 28);
            this.txtTime.TabIndex = 10;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(17, 281);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLevel.Size = new System.Drawing.Size(172, 17);
            this.lblLevel.TabIndex = 8;
            this.lblLevel.Text = "Select your current level :";
            // 
            // btnCalculate
            // 
            this.btnCalculate.ForeColor = System.Drawing.Color.Maroon;
            this.btnCalculate.Location = new System.Drawing.Point(20, 436);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(218, 36);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(299, 92);
            this.txtWeight.Multiline = true;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(114, 31);
            this.txtWeight.TabIndex = 5;
            // 
            // lblShuttles
            // 
            this.lblShuttles.AutoSize = true;
            this.lblShuttles.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShuttles.Location = new System.Drawing.Point(20, 233);
            this.lblShuttles.Name = "lblShuttles";
            this.lblShuttles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblShuttles.Size = new System.Drawing.Size(102, 17);
            this.lblShuttles.TabIndex = 2;
            this.lblShuttles.Text = "Enter shuttles:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(20, 100);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(162, 17);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Enter current weight in :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.linkLabelAbout);
            this.groupBox1.Controls.Add(this.groupBoxCalculate);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1050, 631);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(576, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 503);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(51, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(51, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(51, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(51, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(51, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 420);
            this.textBox1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(944, 589);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 32);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // linkLabelAbout
            // 
            this.linkLabelAbout.AutoSize = true;
            this.linkLabelAbout.BackColor = System.Drawing.Color.Teal;
            this.linkLabelAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAbout.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabelAbout.Location = new System.Drawing.Point(535, 593);
            this.linkLabelAbout.Name = "linkLabelAbout";
            this.linkLabelAbout.Size = new System.Drawing.Size(94, 24);
            this.linkLabelAbout.TabIndex = 13;
            this.linkLabelAbout.TabStop = true;
            this.linkLabelAbout.Text = "Click here";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1051, 632);
            this.Controls.Add(this.groupBox1);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.groupBoxCalculate.ResumeLayout(false);
            this.groupBoxCalculate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.GroupBox groupBoxCalculate;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblHeart;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblShuttles;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabelAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboShuttle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.ComboBox comboLevel;
        private System.Windows.Forms.Label lblExerciseLevel;
        private System.Windows.Forms.ComboBox comboSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox comboCurrentLevel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

