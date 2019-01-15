namespace VO2_Max.Athlete
{
    partial class Speed
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
            this.components = new System.ComponentModel.Container();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.btnResetPace = new System.Windows.Forms.Button();
            this.btnCalculatePace = new System.Windows.Forms.Button();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblRunning = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtResults = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(149, 152);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(70, 20);
            this.txtDistance.TabIndex = 15;
            // 
            // btnResetPace
            // 
            this.btnResetPace.ForeColor = System.Drawing.Color.Blue;
            this.btnResetPace.Location = new System.Drawing.Point(149, 215);
            this.btnResetPace.Name = "btnResetPace";
            this.btnResetPace.Size = new System.Drawing.Size(70, 26);
            this.btnResetPace.TabIndex = 13;
            this.btnResetPace.Text = "Reset";
            this.btnResetPace.UseVisualStyleBackColor = true;
            this.btnResetPace.Click += new System.EventHandler(this.btnResetPace_Click);
            // 
            // btnCalculatePace
            // 
            this.btnCalculatePace.Location = new System.Drawing.Point(32, 199);
            this.btnCalculatePace.Name = "btnCalculatePace";
            this.btnCalculatePace.Size = new System.Drawing.Size(93, 42);
            this.btnCalculatePace.TabIndex = 12;
            this.btnCalculatePace.Text = "Calculate";
            this.btnCalculatePace.UseVisualStyleBackColor = true;
            this.btnCalculatePace.Click += new System.EventHandler(this.btnCalculatePace_Click);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.BackColor = System.Drawing.Color.Transparent;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDistance.Location = new System.Drawing.Point(25, 152);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(96, 25);
            this.lblDistance.TabIndex = 11;
            this.lblDistance.Text = "Distance";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTime.Location = new System.Drawing.Point(25, 91);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(59, 25);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Time";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.BackColor = System.Drawing.Color.Transparent;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLine.Location = new System.Drawing.Point(12, 47);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(719, 25);
            this.lblLine.TabIndex = 9;
            this.lblLine.Text = "---------------------------------------------------------------------------------" +
    "--------------------";
            // 
            // lblRunning
            // 
            this.lblRunning.AutoSize = true;
            this.lblRunning.BackColor = System.Drawing.Color.Transparent;
            this.lblRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunning.ForeColor = System.Drawing.Color.White;
            this.lblRunning.Location = new System.Drawing.Point(273, 23);
            this.lblRunning.Name = "lblRunning";
            this.lblRunning.Size = new System.Drawing.Size(209, 25);
            this.lblRunning.TabIndex = 8;
            this.lblRunning.Text = "Calculate Your Pace";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(32, 322);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(265, 44);
            this.txtResults.TabIndex = 16;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(666, 437);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(103, 47);
            this.buttonBack.TabIndex = 34;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(149, 91);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(125, 20);
            this.txtTime.TabIndex = 14;
            // 
            // Speed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(781, 496);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnResetPace);
            this.Controls.Add(this.btnCalculatePace);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblRunning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(781, 496);
            this.MinimumSize = new System.Drawing.Size(781, 496);
            this.Name = "Speed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speed";
            this.Load += new System.EventHandler(this.Speed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Button btnResetPace;
        private System.Windows.Forms.Button btnCalculatePace;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblRunning;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox txtTime;
    }
}