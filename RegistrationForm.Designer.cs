namespace KONTROL
{
    partial class RegistrationForm
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
            panel2 = new Panel();
            passwordRegBox = new TextBox();
            panel1 = new Panel();
            usernameRegBox = new TextBox();
            label1 = new Label();
            buttonContinueRegistration = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(246, 246, 246);
            panel2.Controls.Add(passwordRegBox);
            panel2.Location = new Point(74, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 35);
            panel2.TabIndex = 3;
            // 
            // passwordRegBox
            // 
            passwordRegBox.BackColor = Color.FromArgb(246, 246, 246);
            passwordRegBox.BorderStyle = BorderStyle.None;
            passwordRegBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            passwordRegBox.Location = new Point(12, 9);
            passwordRegBox.Name = "passwordRegBox";
            passwordRegBox.PlaceholderText = "Пароль";
            passwordRegBox.Size = new Size(166, 18);
            passwordRegBox.TabIndex = 1;
            passwordRegBox.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 246, 246);
            panel1.Controls.Add(usernameRegBox);
            panel1.Location = new Point(74, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 35);
            panel1.TabIndex = 2;
            // 
            // usernameRegBox
            // 
            usernameRegBox.BackColor = Color.FromArgb(246, 246, 246);
            usernameRegBox.BorderStyle = BorderStyle.None;
            usernameRegBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            usernameRegBox.Location = new Point(12, 8);
            usernameRegBox.Name = "usernameRegBox";
            usernameRegBox.PlaceholderText = "Логин";
            usernameRegBox.Size = new Size(166, 18);
            usernameRegBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(90, 60);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 6;
            label1.Text = "РЕГИСТРАЦИЯ";
            // 
            // buttonContinueRegistration
            // 
            buttonContinueRegistration.BackColor = Color.FromArgb(9, 9, 9);
            buttonContinueRegistration.Cursor = Cursors.Hand;
            buttonContinueRegistration.FlatAppearance.BorderSize = 0;
            buttonContinueRegistration.FlatAppearance.MouseDownBackColor = Color.Black;
            buttonContinueRegistration.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            buttonContinueRegistration.FlatStyle = FlatStyle.Flat;
            buttonContinueRegistration.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonContinueRegistration.ForeColor = Color.White;
            buttonContinueRegistration.Location = new Point(74, 239);
            buttonContinueRegistration.Name = "buttonContinueRegistration";
            buttonContinueRegistration.Size = new Size(180, 48);
            buttonContinueRegistration.TabIndex = 7;
            buttonContinueRegistration.Text = "Далее";
            buttonContinueRegistration.UseVisualStyleBackColor = false;
            buttonContinueRegistration.Click += buttonContinueRegistration_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(329, 374);
            Controls.Add(buttonContinueRegistration);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegistrationForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private TextBox passwordRegBox;
        private Panel panel1;
        private TextBox usernameRegBox;
        private Label label1;
        private Button buttonContinueRegistration;
    }
}