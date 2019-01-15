namespace VO2_Max.Athlete
{
    partial class HeartRate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeartRate));
            this.btnReset = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.ComboExercise = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblExerciseLevel = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.ForeColor = System.Drawing.Color.Blue;
            this.btnReset.Location = new System.Drawing.Point(287, 263);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 32);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(64, 249);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(110, 46);
            this.buttonCalculate.TabIndex = 14;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(64, 410);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(367, 58);
            this.txtResults.TabIndex = 13;
            // 
            // ComboExercise
            // 
            this.ComboExercise.FormattingEnabled = true;
            this.ComboExercise.Items.AddRange(new object[] {
            "50",
            "75",
            "100"});
            this.ComboExercise.Location = new System.Drawing.Point(297, 185);
            this.ComboExercise.Name = "ComboExercise";
            this.ComboExercise.Size = new System.Drawing.Size(84, 21);
            this.ComboExercise.TabIndex = 12;
            this.ComboExercise.SelectedIndexChanged += new System.EventHandler(this.ComboExercise_SelectedIndexChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(287, 115);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 11;
            // 
            // lblExerciseLevel
            // 
            this.lblExerciseLevel.AutoSize = true;
            this.lblExerciseLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblExerciseLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExerciseLevel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExerciseLevel.Location = new System.Drawing.Point(29, 170);
            this.lblExerciseLevel.Name = "lblExerciseLevel";
            this.lblExerciseLevel.Size = new System.Drawing.Size(234, 37);
            this.lblExerciseLevel.TabIndex = 10;
            this.lblExerciseLevel.Text = "Exercise Level";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(280, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(384, 42);
            this.labelTitle.TabIndex = 16;
            this.labelTitle.Text = "Calculate Heart Rate";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAge.Location = new System.Drawing.Point(29, 100);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(107, 37);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(517, 410);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 145);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 497);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(103, 47);
            this.buttonBack.TabIndex = 33;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // HeartRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VO2_Max.Properties.Resources.speed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 556);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.ComboExercise);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblExerciseLevel);
            this.Controls.Add(this.lblAge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(938, 556);
            this.MinimumSize = new System.Drawing.Size(938, 556);
            this.Name = "HeartRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeartRate";
            this.Load += new System.EventHandler(this.HeartRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.ComboBox ComboExercise;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblExerciseLevel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBack;
    }
}