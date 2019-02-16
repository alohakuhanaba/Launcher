namespace Launcher
{
    partial class LauncherForm
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
            this.usernameIcon = new FontAwesome.Sharp.IconPictureBox();
            this.usernameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.passwordIcon = new FontAwesome.Sharp.IconPictureBox();
            this.passwordTextbox = new MetroFramework.Controls.MetroTextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.ip0Textbox = new MetroFramework.Controls.MetroTextBox();
            this.ip1Textbox = new MetroFramework.Controls.MetroTextBox();
            this.ip2Textbox = new MetroFramework.Controls.MetroTextBox();
            this.ip3Textbox = new MetroFramework.Controls.MetroTextBox();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usernameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameIcon
            // 
            this.usernameIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.usernameIcon.ForeColor = System.Drawing.SystemColors.Control;
            this.usernameIcon.IconChar = FontAwesome.Sharp.IconChar.User;
            this.usernameIcon.IconColor = System.Drawing.SystemColors.Control;
            this.usernameIcon.IconSize = 23;
            this.usernameIcon.Location = new System.Drawing.Point(17, 68);
            this.usernameIcon.Name = "usernameIcon";
            this.usernameIcon.Size = new System.Drawing.Size(23, 23);
            this.usernameIcon.TabIndex = 0;
            this.usernameIcon.TabStop = false;
            // 
            // usernameTextbox
            // 
            // 
            // 
            // 
            this.usernameTextbox.CustomButton.Image = null;
            this.usernameTextbox.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.usernameTextbox.CustomButton.Name = "";
            this.usernameTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.usernameTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernameTextbox.CustomButton.TabIndex = 1;
            this.usernameTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameTextbox.CustomButton.UseSelectable = true;
            this.usernameTextbox.CustomButton.Visible = false;
            this.usernameTextbox.Lines = new string[0];
            this.usernameTextbox.Location = new System.Drawing.Point(46, 68);
            this.usernameTextbox.MaxLength = 32767;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.PasswordChar = '\0';
            this.usernameTextbox.PromptText = "Username";
            this.usernameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameTextbox.SelectedText = "";
            this.usernameTextbox.SelectionLength = 0;
            this.usernameTextbox.SelectionStart = 0;
            this.usernameTextbox.ShortcutsEnabled = true;
            this.usernameTextbox.Size = new System.Drawing.Size(231, 23);
            this.usernameTextbox.Style = MetroFramework.MetroColorStyle.Orange;
            this.usernameTextbox.TabIndex = 0;
            this.usernameTextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.usernameTextbox.UseSelectable = true;
            this.usernameTextbox.WaterMark = "Username";
            this.usernameTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernameTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passwordIcon
            // 
            this.passwordIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.passwordIcon.ForeColor = System.Drawing.SystemColors.Control;
            this.passwordIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.passwordIcon.IconColor = System.Drawing.SystemColors.Control;
            this.passwordIcon.IconSize = 23;
            this.passwordIcon.Location = new System.Drawing.Point(17, 97);
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.Size = new System.Drawing.Size(23, 23);
            this.passwordIcon.TabIndex = 0;
            this.passwordIcon.TabStop = false;
            // 
            // passwordTextbox
            // 
            // 
            // 
            // 
            this.passwordTextbox.CustomButton.Image = null;
            this.passwordTextbox.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.passwordTextbox.CustomButton.Name = "";
            this.passwordTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextbox.CustomButton.TabIndex = 1;
            this.passwordTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextbox.CustomButton.UseSelectable = true;
            this.passwordTextbox.CustomButton.Visible = false;
            this.passwordTextbox.Lines = new string[0];
            this.passwordTextbox.Location = new System.Drawing.Point(46, 97);
            this.passwordTextbox.MaxLength = 32767;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '●';
            this.passwordTextbox.PromptText = "Password";
            this.passwordTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextbox.SelectedText = "";
            this.passwordTextbox.SelectionLength = 0;
            this.passwordTextbox.SelectionStart = 0;
            this.passwordTextbox.ShortcutsEnabled = true;
            this.passwordTextbox.Size = new System.Drawing.Size(231, 23);
            this.passwordTextbox.Style = MetroFramework.MetroColorStyle.Orange;
            this.passwordTextbox.TabIndex = 1;
            this.passwordTextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.passwordTextbox.UseSelectable = true;
            this.passwordTextbox.UseSystemPasswordChar = true;
            this.passwordTextbox.WaterMark = "Password";
            this.passwordTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconSize = 23;
            this.iconPictureBox1.Location = new System.Drawing.Point(17, 126);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(23, 23);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.loginButton.Location = new System.Drawing.Point(46, 126);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(81, 23);
            this.loginButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginButton.UseCustomBackColor = true;
            this.loginButton.UseCustomForeColor = true;
            this.loginButton.UseSelectable = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // ip0Textbox
            // 
            // 
            // 
            // 
            this.ip0Textbox.CustomButton.Image = null;
            this.ip0Textbox.CustomButton.Location = new System.Drawing.Point(9, 1);
            this.ip0Textbox.CustomButton.Name = "";
            this.ip0Textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ip0Textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ip0Textbox.CustomButton.TabIndex = 1;
            this.ip0Textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ip0Textbox.CustomButton.UseSelectable = true;
            this.ip0Textbox.CustomButton.Visible = false;
            this.ip0Textbox.Enabled = false;
            this.ip0Textbox.Lines = new string[0];
            this.ip0Textbox.Location = new System.Drawing.Point(133, 126);
            this.ip0Textbox.MaxLength = 3;
            this.ip0Textbox.Name = "ip0Textbox";
            this.ip0Textbox.PasswordChar = '\0';
            this.ip0Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ip0Textbox.SelectedText = "";
            this.ip0Textbox.SelectionLength = 0;
            this.ip0Textbox.SelectionStart = 0;
            this.ip0Textbox.ShortcutsEnabled = true;
            this.ip0Textbox.Size = new System.Drawing.Size(31, 23);
            this.ip0Textbox.Style = MetroFramework.MetroColorStyle.Orange;
            this.ip0Textbox.TabIndex = 3;
            this.ip0Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ip0Textbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ip0Textbox.UseSelectable = true;
            this.ip0Textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ip0Textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ip1Textbox
            // 
            // 
            // 
            // 
            this.ip1Textbox.CustomButton.Image = null;
            this.ip1Textbox.CustomButton.Location = new System.Drawing.Point(9, 1);
            this.ip1Textbox.CustomButton.Name = "";
            this.ip1Textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ip1Textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ip1Textbox.CustomButton.TabIndex = 1;
            this.ip1Textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ip1Textbox.CustomButton.UseSelectable = true;
            this.ip1Textbox.CustomButton.Visible = false;
            this.ip1Textbox.Enabled = false;
            this.ip1Textbox.Lines = new string[0];
            this.ip1Textbox.Location = new System.Drawing.Point(170, 126);
            this.ip1Textbox.MaxLength = 3;
            this.ip1Textbox.Name = "ip1Textbox";
            this.ip1Textbox.PasswordChar = '\0';
            this.ip1Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ip1Textbox.SelectedText = "";
            this.ip1Textbox.SelectionLength = 0;
            this.ip1Textbox.SelectionStart = 0;
            this.ip1Textbox.ShortcutsEnabled = true;
            this.ip1Textbox.Size = new System.Drawing.Size(31, 23);
            this.ip1Textbox.Style = MetroFramework.MetroColorStyle.Orange;
            this.ip1Textbox.TabIndex = 4;
            this.ip1Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ip1Textbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ip1Textbox.UseSelectable = true;
            this.ip1Textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ip1Textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ip2Textbox
            // 
            // 
            // 
            // 
            this.ip2Textbox.CustomButton.Image = null;
            this.ip2Textbox.CustomButton.Location = new System.Drawing.Point(9, 1);
            this.ip2Textbox.CustomButton.Name = "";
            this.ip2Textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ip2Textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ip2Textbox.CustomButton.TabIndex = 1;
            this.ip2Textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ip2Textbox.CustomButton.UseSelectable = true;
            this.ip2Textbox.CustomButton.Visible = false;
            this.ip2Textbox.Enabled = false;
            this.ip2Textbox.Lines = new string[0];
            this.ip2Textbox.Location = new System.Drawing.Point(207, 126);
            this.ip2Textbox.MaxLength = 3;
            this.ip2Textbox.Name = "ip2Textbox";
            this.ip2Textbox.PasswordChar = '\0';
            this.ip2Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ip2Textbox.SelectedText = "";
            this.ip2Textbox.SelectionLength = 0;
            this.ip2Textbox.SelectionStart = 0;
            this.ip2Textbox.ShortcutsEnabled = true;
            this.ip2Textbox.Size = new System.Drawing.Size(31, 23);
            this.ip2Textbox.Style = MetroFramework.MetroColorStyle.Orange;
            this.ip2Textbox.TabIndex = 5;
            this.ip2Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ip2Textbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ip2Textbox.UseSelectable = true;
            this.ip2Textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ip2Textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ip3Textbox
            // 
            // 
            // 
            // 
            this.ip3Textbox.CustomButton.Image = null;
            this.ip3Textbox.CustomButton.Location = new System.Drawing.Point(9, 1);
            this.ip3Textbox.CustomButton.Name = "";
            this.ip3Textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ip3Textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ip3Textbox.CustomButton.TabIndex = 1;
            this.ip3Textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ip3Textbox.CustomButton.UseSelectable = true;
            this.ip3Textbox.CustomButton.Visible = false;
            this.ip3Textbox.Enabled = false;
            this.ip3Textbox.Lines = new string[0];
            this.ip3Textbox.Location = new System.Drawing.Point(244, 126);
            this.ip3Textbox.MaxLength = 3;
            this.ip3Textbox.Name = "ip3Textbox";
            this.ip3Textbox.PasswordChar = '\0';
            this.ip3Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ip3Textbox.SelectedText = "";
            this.ip3Textbox.SelectionLength = 0;
            this.ip3Textbox.SelectionStart = 0;
            this.ip3Textbox.ShortcutsEnabled = true;
            this.ip3Textbox.Size = new System.Drawing.Size(31, 23);
            this.ip3Textbox.Style = MetroFramework.MetroColorStyle.Orange;
            this.ip3Textbox.TabIndex = 6;
            this.ip3Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ip3Textbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ip3Textbox.UseSelectable = true;
            this.ip3Textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ip3Textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(207, 39);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(0, 0);
            this.exitButton.TabIndex = 999;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // LauncherForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(300, 174);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.passwordIcon);
            this.Controls.Add(this.ip3Textbox);
            this.Controls.Add(this.ip2Textbox);
            this.Controls.Add(this.ip1Textbox);
            this.Controls.Add(this.ip0Textbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.usernameIcon);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LauncherForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "OpenMS";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.usernameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox usernameIcon;
        private MetroFramework.Controls.MetroTextBox usernameTextbox;
        private FontAwesome.Sharp.IconPictureBox passwordIcon;
        private MetroFramework.Controls.MetroTextBox passwordTextbox;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private MetroFramework.Controls.MetroButton loginButton;
        private MetroFramework.Controls.MetroTextBox ip0Textbox;
        private MetroFramework.Controls.MetroTextBox ip1Textbox;
        private MetroFramework.Controls.MetroTextBox ip2Textbox;
        private MetroFramework.Controls.MetroTextBox ip3Textbox;
        private System.Windows.Forms.Button exitButton;
    }
}

