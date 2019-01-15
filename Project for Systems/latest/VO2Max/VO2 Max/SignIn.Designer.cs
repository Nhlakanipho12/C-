namespace VO2_Max
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.grpSocialNetworks = new System.Windows.Forms.GroupBox();
            this.picInsta = new System.Windows.Forms.PictureBox();
            this.picFB = new System.Windows.Forms.PictureBox();
            this.picTwitter = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.linkLabelSignUp = new System.Windows.Forms.LinkLabel();
            this.linkLabelAbout = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afrikaansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isiZuluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.grpSocialNetworks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInsta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwitter)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSocialNetworks
            // 
            this.grpSocialNetworks.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpSocialNetworks.Controls.Add(this.picInsta);
            this.grpSocialNetworks.Controls.Add(this.picFB);
            this.grpSocialNetworks.Controls.Add(this.picTwitter);
            this.grpSocialNetworks.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grpSocialNetworks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.grpSocialNetworks, "grpSocialNetworks");
            this.grpSocialNetworks.Name = "grpSocialNetworks";
            this.grpSocialNetworks.TabStop = false;
            // 
            // picInsta
            // 
            resources.ApplyResources(this.picInsta, "picInsta");
            this.picInsta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picInsta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picInsta.Name = "picInsta";
            this.picInsta.TabStop = false;
            this.picInsta.Click += new System.EventHandler(this.picInsta_Click);
            // 
            // picFB
            // 
            resources.ApplyResources(this.picFB, "picFB");
            this.picFB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFB.Name = "picFB";
            this.picFB.TabStop = false;
            this.picFB.Click += new System.EventHandler(this.picFB_Click);
            // 
            // picTwitter
            // 
            resources.ApplyResources(this.picTwitter, "picTwitter");
            this.picTwitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picTwitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTwitter.Name = "picTwitter";
            this.picTwitter.TabStop = false;
            this.picTwitter.Click += new System.EventHandler(this.picTwitter_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // linkLabelSignUp
            // 
            resources.ApplyResources(this.linkLabelSignUp, "linkLabelSignUp");
            this.linkLabelSignUp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabelSignUp.Name = "linkLabelSignUp";
            this.linkLabelSignUp.TabStop = true;
            this.linkLabelSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignUp_LinkClicked);
            // 
            // linkLabelAbout
            // 
            resources.ApplyResources(this.linkLabelAbout, "linkLabelAbout");
            this.linkLabelAbout.BackColor = System.Drawing.Color.Teal;
            this.linkLabelAbout.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabelAbout.Name = "linkLabelAbout";
            this.linkLabelAbout.TabStop = true;
            this.linkLabelAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.manualToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afrikaansToolStripMenuItem,
            this.englishToolStripMenuItem,
            this.isiZuluToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // afrikaansToolStripMenuItem
            // 
            this.afrikaansToolStripMenuItem.Name = "afrikaansToolStripMenuItem";
            resources.ApplyResources(this.afrikaansToolStripMenuItem, "afrikaansToolStripMenuItem");
            this.afrikaansToolStripMenuItem.Click += new System.EventHandler(this.afrikaansToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // isiZuluToolStripMenuItem
            // 
            this.isiZuluToolStripMenuItem.Name = "isiZuluToolStripMenuItem";
            resources.ApplyResources(this.isiZuluToolStripMenuItem, "isiZuluToolStripMenuItem");
            this.isiZuluToolStripMenuItem.Click += new System.EventHandler(this.isiZuluToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            resources.ApplyResources(this.manualToolStripMenuItem, "manualToolStripMenuItem");
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUsername.Name = "lblUsername";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPassword.Name = "lblPassword";
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // SignIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.grpSocialNetworks);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.linkLabelSignUp);
            this.Controls.Add(this.linkLabelAbout);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.grpSocialNetworks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInsta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwitter)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSocialNetworks;
        private System.Windows.Forms.PictureBox picInsta;
        private System.Windows.Forms.PictureBox picFB;
        private System.Windows.Forms.PictureBox picTwitter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel linkLabelSignUp;
        private System.Windows.Forms.LinkLabel linkLabelAbout;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afrikaansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isiZuluToolStripMenuItem;
        private System.Windows.Forms.Button btnLogin;
    }
}