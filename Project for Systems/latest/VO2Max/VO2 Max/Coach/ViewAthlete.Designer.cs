namespace VO2_Max.Coach
{
    partial class ViewAthlete
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
            this.panelDatabase = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDatabase
            // 
            this.panelDatabase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDatabase.Controls.Add(this.dataGridView1);
            this.panelDatabase.Location = new System.Drawing.Point(22, 63);
            this.panelDatabase.Name = "panelDatabase";
            this.panelDatabase.Size = new System.Drawing.Size(624, 480);
            this.panelDatabase.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(384, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ViewAthlete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 578);
            this.Controls.Add(this.panelDatabase);
            this.MaximumSize = new System.Drawing.Size(714, 617);
            this.MinimumSize = new System.Drawing.Size(714, 39);
            this.Name = "ViewAthlete";
            this.Text = "ViewAthlete";
            this.panelDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDatabase;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}