namespace VO2_Max.Coach
{
    partial class CoachWelcome
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
            this.label = new System.Windows.Forms.Label();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.radioButtonVo2max = new System.Windows.Forms.RadioButton();
            this.radioButtonSpeed = new System.Windows.Forms.RadioButton();
            this.radioButtonBMI = new System.Windows.Forms.RadioButton();
            this.radioButtonHeartRate = new System.Windows.Forms.RadioButton();
            this.listBoxSchedule = new System.Windows.Forms.ListBox();
            this.labelSchedule = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dataGridViewAthletes = new System.Windows.Forms.DataGridView();
            this.groupBoxSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAthletes)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(36, 46);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(109, 20);
            this.label.TabIndex = 0;
            this.label.Text = "Coach name";
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamName.Location = new System.Drawing.Point(724, 46);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(102, 20);
            this.labelTeamName.TabIndex = 3;
            this.labelTeamName.Text = "Team name";
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.Controls.Add(this.radioButtonVo2max);
            this.groupBoxSort.Controls.Add(this.radioButtonSpeed);
            this.groupBoxSort.Controls.Add(this.radioButtonBMI);
            this.groupBoxSort.Controls.Add(this.radioButtonHeartRate);
            this.groupBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSort.Location = new System.Drawing.Point(805, 92);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Size = new System.Drawing.Size(200, 178);
            this.groupBoxSort.TabIndex = 4;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Sort by";
            // 
            // radioButtonVo2max
            // 
            this.radioButtonVo2max.AutoSize = true;
            this.radioButtonVo2max.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonVo2max.Location = new System.Drawing.Point(24, 135);
            this.radioButtonVo2max.Name = "radioButtonVo2max";
            this.radioButtonVo2max.Size = new System.Drawing.Size(78, 20);
            this.radioButtonVo2max.TabIndex = 4;
            this.radioButtonVo2max.TabStop = true;
            this.radioButtonVo2max.Text = "Vo2 Max";
            this.radioButtonVo2max.UseVisualStyleBackColor = true;
            // 
            // radioButtonSpeed
            // 
            this.radioButtonSpeed.AutoSize = true;
            this.radioButtonSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSpeed.Location = new System.Drawing.Point(24, 100);
            this.radioButtonSpeed.Name = "radioButtonSpeed";
            this.radioButtonSpeed.Size = new System.Drawing.Size(67, 20);
            this.radioButtonSpeed.TabIndex = 2;
            this.radioButtonSpeed.TabStop = true;
            this.radioButtonSpeed.Text = "Speed";
            this.radioButtonSpeed.UseVisualStyleBackColor = true;
            // 
            // radioButtonBMI
            // 
            this.radioButtonBMI.AutoSize = true;
            this.radioButtonBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBMI.Location = new System.Drawing.Point(24, 62);
            this.radioButtonBMI.Name = "radioButtonBMI";
            this.radioButtonBMI.Size = new System.Drawing.Size(129, 20);
            this.radioButtonBMI.TabIndex = 1;
            this.radioButtonBMI.TabStop = true;
            this.radioButtonBMI.Text = "Body Mass Index";
            this.radioButtonBMI.UseVisualStyleBackColor = true;
            // 
            // radioButtonHeartRate
            // 
            this.radioButtonHeartRate.AutoSize = true;
            this.radioButtonHeartRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHeartRate.Location = new System.Drawing.Point(24, 21);
            this.radioButtonHeartRate.Name = "radioButtonHeartRate";
            this.radioButtonHeartRate.Size = new System.Drawing.Size(91, 20);
            this.radioButtonHeartRate.TabIndex = 0;
            this.radioButtonHeartRate.TabStop = true;
            this.radioButtonHeartRate.Text = "Heart Rate";
            this.radioButtonHeartRate.UseVisualStyleBackColor = true;
            // 
            // listBoxSchedule
            // 
            this.listBoxSchedule.FormattingEnabled = true;
            this.listBoxSchedule.Location = new System.Drawing.Point(805, 388);
            this.listBoxSchedule.Name = "listBoxSchedule";
            this.listBoxSchedule.Size = new System.Drawing.Size(200, 238);
            this.listBoxSchedule.TabIndex = 5;
            // 
            // labelSchedule
            // 
            this.labelSchedule.AutoSize = true;
            this.labelSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchedule.Location = new System.Drawing.Point(805, 365);
            this.labelSchedule.Name = "labelSchedule";
            this.labelSchedule.Size = new System.Drawing.Size(125, 20);
            this.labelSchedule.TabIndex = 6;
            this.labelSchedule.Text = "Gym Schedule";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(922, 637);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(96, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dataGridViewAthletes
            // 
            this.dataGridViewAthletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAthletes.Location = new System.Drawing.Point(22, 97);
            this.dataGridViewAthletes.Name = "dataGridViewAthletes";
            this.dataGridViewAthletes.Size = new System.Drawing.Size(760, 563);
            this.dataGridViewAthletes.TabIndex = 8;
            // 
            // CoachWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 672);
            this.Controls.Add(this.dataGridViewAthletes);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.labelSchedule);
            this.Controls.Add(this.listBoxSchedule);
            this.Controls.Add(this.groupBoxSort);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.label);
            this.MaximumSize = new System.Drawing.Size(1063, 711);
            this.MinimumSize = new System.Drawing.Size(1063, 711);
            this.Name = "CoachWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoachWelcome";
            this.Load += new System.EventHandler(this.CoachWelcome_Load);
            this.groupBoxSort.ResumeLayout(false);
            this.groupBoxSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAthletes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.RadioButton radioButtonVo2max;
        private System.Windows.Forms.RadioButton radioButtonSpeed;
        private System.Windows.Forms.RadioButton radioButtonBMI;
        private System.Windows.Forms.RadioButton radioButtonHeartRate;
        private System.Windows.Forms.ListBox listBoxSchedule;
        private System.Windows.Forms.Label labelSchedule;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dataGridViewAthletes;
    }
}