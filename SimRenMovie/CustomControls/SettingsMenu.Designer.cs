namespace SimRenMovie
{
    partial class SettingsMenu
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxPassword_confirmation = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxLogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.buttonUpdatePassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUpdateLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(443, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Редактирование профиля";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(447, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 130);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(819, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Изменение пароля";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxOldPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxOldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxOldPassword.HintForeColor = System.Drawing.Color.Gray;
            this.textBoxOldPassword.HintText = "Старый пароль";
            this.textBoxOldPassword.isPassword = true;
            this.textBoxOldPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBoxOldPassword.LineIdleColor = System.Drawing.Color.IndianRed;
            this.textBoxOldPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBoxOldPassword.LineThickness = 3;
            this.textBoxOldPassword.Location = new System.Drawing.Point(808, 121);
            this.textBoxOldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(244, 33);
            this.textBoxOldPassword.TabIndex = 3;
            this.textBoxOldPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPassword.HintForeColor = System.Drawing.Color.Gray;
            this.textBoxPassword.HintText = "Новый пароль";
            this.textBoxPassword.isPassword = true;
            this.textBoxPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBoxPassword.LineIdleColor = System.Drawing.Color.IndianRed;
            this.textBoxPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBoxPassword.LineThickness = 3;
            this.textBoxPassword.Location = new System.Drawing.Point(808, 198);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(244, 33);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxPassword_confirmation
            // 
            this.textBoxPassword_confirmation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword_confirmation.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxPassword_confirmation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPassword_confirmation.HintForeColor = System.Drawing.Color.Gray;
            this.textBoxPassword_confirmation.HintText = "Повторить новый пароль";
            this.textBoxPassword_confirmation.isPassword = true;
            this.textBoxPassword_confirmation.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBoxPassword_confirmation.LineIdleColor = System.Drawing.Color.IndianRed;
            this.textBoxPassword_confirmation.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBoxPassword_confirmation.LineThickness = 3;
            this.textBoxPassword_confirmation.Location = new System.Drawing.Point(808, 300);
            this.textBoxPassword_confirmation.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword_confirmation.Name = "textBoxPassword_confirmation";
            this.textBoxPassword_confirmation.Size = new System.Drawing.Size(244, 33);
            this.textBoxPassword_confirmation.TabIndex = 3;
            this.textBoxPassword_confirmation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxLogin.HintForeColor = System.Drawing.Color.Gray;
            this.textBoxLogin.HintText = "";
            this.textBoxLogin.isPassword = false;
            this.textBoxLogin.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBoxLogin.LineIdleColor = System.Drawing.Color.IndianRed;
            this.textBoxLogin.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBoxLogin.LineThickness = 3;
            this.textBoxLogin.Location = new System.Drawing.Point(447, 267);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(244, 33);
            this.textBoxLogin.TabIndex = 3;
            this.textBoxLogin.Text = "{Login}";
            this.textBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // buttonUpdatePassword
            // 
            this.buttonUpdatePassword.BackColor = System.Drawing.Color.IndianRed;
            this.buttonUpdatePassword.FlatAppearance.BorderSize = 0;
            this.buttonUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdatePassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdatePassword.ForeColor = System.Drawing.Color.White;
            this.buttonUpdatePassword.Location = new System.Drawing.Point(808, 366);
            this.buttonUpdatePassword.Name = "buttonUpdatePassword";
            this.buttonUpdatePassword.Size = new System.Drawing.Size(174, 34);
            this.buttonUpdatePassword.TabIndex = 4;
            this.buttonUpdatePassword.Text = "Изменить";
            this.buttonUpdatePassword.UseVisualStyleBackColor = false;
            this.buttonUpdatePassword.Click += new System.EventHandler(this.ButtonUpdatePassword_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(805, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Не менее 6 символов!";
            // 
            // buttonUpdateLogin
            // 
            this.buttonUpdateLogin.BackColor = System.Drawing.Color.IndianRed;
            this.buttonUpdateLogin.FlatAppearance.BorderSize = 0;
            this.buttonUpdateLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateLogin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateLogin.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateLogin.Location = new System.Drawing.Point(447, 329);
            this.buttonUpdateLogin.Name = "buttonUpdateLogin";
            this.buttonUpdateLogin.Size = new System.Drawing.Size(174, 34);
            this.buttonUpdateLogin.TabIndex = 4;
            this.buttonUpdateLogin.Text = "Сохранить";
            this.buttonUpdateLogin.UseVisualStyleBackColor = false;
            this.buttonUpdateLogin.Click += new System.EventHandler(this.ButtonUpdateLogin_Click);
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.buttonUpdateLogin);
            this.Controls.Add(this.buttonUpdatePassword);
            this.Controls.Add(this.textBoxPassword_confirmation);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingsMenu";
            this.Size = new System.Drawing.Size(1637, 451);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxOldPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxPassword_confirmation;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxLogin;
        private System.Windows.Forms.Button buttonUpdatePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUpdateLogin;
    }
}
