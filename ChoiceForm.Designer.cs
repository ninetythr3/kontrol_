namespace KONTROL
{
    partial class ChoiceForm
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
            buttonObjectsChoice = new Button();
            buttonSettingsChoice = new Button();
            buttonAccountChoice = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // buttonObjectsChoice
            // 
            buttonObjectsChoice.BackColor = Color.FromArgb(9, 9, 9);
            buttonObjectsChoice.Cursor = Cursors.Hand;
            buttonObjectsChoice.FlatAppearance.BorderSize = 0;
            buttonObjectsChoice.FlatAppearance.MouseDownBackColor = Color.Black;
            buttonObjectsChoice.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            buttonObjectsChoice.FlatStyle = FlatStyle.Flat;
            buttonObjectsChoice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonObjectsChoice.ForeColor = Color.White;
            buttonObjectsChoice.Image = Properties.Resources.Objects_icon_w;
            buttonObjectsChoice.ImageAlign = ContentAlignment.BottomCenter;
            buttonObjectsChoice.Location = new Point(-10, 0);
            buttonObjectsChoice.Name = "buttonObjectsChoice";
            buttonObjectsChoice.Size = new Size(368, 110);
            buttonObjectsChoice.TabIndex = 7;
            buttonObjectsChoice.Text = "Объекты";
            buttonObjectsChoice.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonObjectsChoice.UseVisualStyleBackColor = false;
            buttonObjectsChoice.Click += buttonObjectsChoice_Click;
            // 
            // buttonSettingsChoice
            // 
            buttonSettingsChoice.BackColor = Color.FromArgb(9, 9, 9);
            buttonSettingsChoice.Cursor = Cursors.Hand;
            buttonSettingsChoice.FlatAppearance.BorderSize = 0;
            buttonSettingsChoice.FlatAppearance.MouseDownBackColor = Color.Black;
            buttonSettingsChoice.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            buttonSettingsChoice.FlatStyle = FlatStyle.Flat;
            buttonSettingsChoice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSettingsChoice.ForeColor = Color.White;
            buttonSettingsChoice.Image = Properties.Resources.Settings_icon_w;
            buttonSettingsChoice.Location = new Point(-10, 110);
            buttonSettingsChoice.Name = "buttonSettingsChoice";
            buttonSettingsChoice.Size = new Size(368, 110);
            buttonSettingsChoice.TabIndex = 8;
            buttonSettingsChoice.Text = "Настройки";
            buttonSettingsChoice.TextAlign = ContentAlignment.BottomCenter;
            buttonSettingsChoice.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonSettingsChoice.UseVisualStyleBackColor = false;
            buttonSettingsChoice.Click += buttonSettingsChoice_Click;
            // 
            // buttonAccountChoice
            // 
            buttonAccountChoice.BackColor = Color.FromArgb(9, 9, 9);
            buttonAccountChoice.Cursor = Cursors.Hand;
            buttonAccountChoice.FlatAppearance.BorderSize = 0;
            buttonAccountChoice.FlatAppearance.MouseDownBackColor = Color.Black;
            buttonAccountChoice.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            buttonAccountChoice.FlatStyle = FlatStyle.Flat;
            buttonAccountChoice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAccountChoice.ForeColor = Color.White;
            buttonAccountChoice.Image = Properties.Resources.Account_icon_w;
            buttonAccountChoice.Location = new Point(-10, 220);
            buttonAccountChoice.Name = "buttonAccountChoice";
            buttonAccountChoice.Size = new Size(368, 110);
            buttonAccountChoice.TabIndex = 9;
            buttonAccountChoice.Text = "Аккаунт";
            buttonAccountChoice.TextAlign = ContentAlignment.BottomCenter;
            buttonAccountChoice.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonAccountChoice.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 1);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 219);
            panel2.Name = "panel2";
            panel2.Size = new Size(351, 1);
            panel2.TabIndex = 11;
            // 
            // ChoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 9);
            ClientSize = new Size(351, 331);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(buttonObjectsChoice);
            Controls.Add(buttonSettingsChoice);
            Controls.Add(buttonAccountChoice);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ChoiceForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выберите пункт";
            Load += ChoiceForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonObjectsChoice;
        private Button buttonSettingsChoice;
        private Button buttonAccountChoice;
        private Panel panel1;
        private Panel panel2;
    }
}