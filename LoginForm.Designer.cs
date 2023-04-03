namespace KONTROL
{
    partial class LoginForm
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
            panel1 = new Panel();
            usernameBox = new TextBox();
            panel2 = new Panel();
            showPassword = new Panel();
            hidePassword = new Panel();
            passwordBox = new TextBox();
            rememCheck = new CheckBox();
            regLink = new LinkLabel();
            fogotPass = new LinkLabel();
            label1 = new Label();
            buttonContinueLogin = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 246, 246);
            panel1.Controls.Add(usernameBox);
            panel1.Location = new Point(81, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 35);
            panel1.TabIndex = 0;
            // 
            // usernameBox
            // 
            usernameBox.BackColor = Color.FromArgb(246, 246, 246);
            usernameBox.BorderStyle = BorderStyle.None;
            usernameBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            usernameBox.Location = new Point(12, 8);
            usernameBox.Name = "usernameBox";
            usernameBox.PlaceholderText = "Логин";
            usernameBox.Size = new Size(166, 18);
            usernameBox.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(246, 246, 246);
            panel2.Controls.Add(showPassword);
            panel2.Controls.Add(hidePassword);
            panel2.Controls.Add(passwordBox);
            panel2.Location = new Point(81, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 35);
            panel2.TabIndex = 1;
            // 
            // showPassword
            // 
            showPassword.BackgroundImage = Properties.Resources.eye_icon_b1;
            showPassword.BackgroundImageLayout = ImageLayout.Zoom;
            showPassword.Cursor = Cursors.Hand;
            showPassword.Location = new Point(148, 10);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(30, 17);
            showPassword.TabIndex = 7;
            showPassword.Click += showPassword_Click;
            // 
            // hidePassword
            // 
            hidePassword.BackgroundImage = Properties.Resources.eyenone_icon_b1;
            hidePassword.BackgroundImageLayout = ImageLayout.Zoom;
            hidePassword.Cursor = Cursors.Hand;
            hidePassword.Location = new Point(148, 10);
            hidePassword.Name = "hidePassword";
            hidePassword.Size = new Size(30, 17);
            hidePassword.TabIndex = 8;
            hidePassword.Click += hidePassword_Click;
            // 
            // passwordBox
            // 
            passwordBox.BackColor = Color.FromArgb(246, 246, 246);
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            passwordBox.Location = new Point(12, 9);
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "Пароль";
            passwordBox.Size = new Size(135, 18);
            passwordBox.TabIndex = 1;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // rememCheck
            // 
            rememCheck.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rememCheck.AutoSize = true;
            rememCheck.FlatStyle = FlatStyle.System;
            rememCheck.Location = new Point(81, 196);
            rememCheck.Margin = new Padding(0);
            rememCheck.Name = "rememCheck";
            rememCheck.Size = new Size(97, 22);
            rememCheck.TabIndex = 3;
            rememCheck.Text = "Запомнить";
            rememCheck.TextAlign = ContentAlignment.MiddleCenter;
            rememCheck.UseVisualStyleBackColor = true;
            rememCheck.CheckedChanged += rememCheck_CheckedChanged;
            // 
            // regLink
            // 
            regLink.ActiveLinkColor = Color.FromArgb(64, 64, 64);
            regLink.AutoSize = true;
            regLink.DisabledLinkColor = Color.Silver;
            regLink.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            regLink.LinkColor = Color.FromArgb(37, 37, 37);
            regLink.Location = new Point(128, 331);
            regLink.Name = "regLink";
            regLink.Size = new Size(86, 17);
            regLink.TabIndex = 5;
            regLink.TabStop = true;
            regLink.Text = "Регистрация";
            regLink.VisitedLinkColor = Color.Black;
            regLink.LinkClicked += regLink_LinkClicked;
            // 
            // fogotPass
            // 
            fogotPass.ActiveLinkColor = SystemColors.ActiveCaptionText;
            fogotPass.AutoSize = true;
            fogotPass.DisabledLinkColor = Color.FromArgb(133, 133, 133);
            fogotPass.LinkColor = Color.Gray;
            fogotPass.Location = new Point(118, 380);
            fogotPass.Name = "fogotPass";
            fogotPass.Size = new Size(107, 17);
            fogotPass.TabIndex = 6;
            fogotPass.TabStop = true;
            fogotPass.Text = "Забыли пароль?";
            fogotPass.VisitedLinkColor = Color.FromArgb(192, 192, 255);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(132, 38);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 5;
            label1.Text = "ВОЙТИ";
            // 
            // buttonContinueLogin
            // 
            buttonContinueLogin.BackColor = Color.FromArgb(9, 9, 9);
            buttonContinueLogin.Cursor = Cursors.Hand;
            buttonContinueLogin.FlatAppearance.BorderSize = 0;
            buttonContinueLogin.FlatAppearance.MouseDownBackColor = Color.Black;
            buttonContinueLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            buttonContinueLogin.FlatStyle = FlatStyle.Flat;
            buttonContinueLogin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonContinueLogin.ForeColor = Color.White;
            buttonContinueLogin.Location = new Point(81, 251);
            buttonContinueLogin.Name = "buttonContinueLogin";
            buttonContinueLogin.Size = new Size(180, 48);
            buttonContinueLogin.TabIndex = 4;
            buttonContinueLogin.Text = "Далее";
            buttonContinueLogin.UseVisualStyleBackColor = false;
            buttonContinueLogin.Click += buttonContinueLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(342, 416);
            Controls.Add(buttonContinueLogin);
            Controls.Add(label1);
            Controls.Add(fogotPass);
            Controls.Add(regLink);
            Controls.Add(rememCheck);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox usernameBox;
        private Panel panel2;
        private TextBox passwordBox;
        public CheckBox rememCheck;
        private LinkLabel regLink;
        private LinkLabel fogotPass;
        private Label label1;
        private Button buttonContinueLogin;
        private Panel showPassword;
        private Panel hidePassword;
    }
}