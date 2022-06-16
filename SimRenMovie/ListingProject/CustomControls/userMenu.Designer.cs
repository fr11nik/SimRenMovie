namespace SimRenMovie.Forms
{
    partial class userMenu
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
            this.buttonTape = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonPurchases = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTape
            // 
            this.buttonTape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonTape.FlatAppearance.BorderSize = 0;
            this.buttonTape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTape.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTape.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonTape.Location = new System.Drawing.Point(8, -5);
            this.buttonTape.Name = "buttonTape";
            this.buttonTape.Size = new System.Drawing.Size(189, 32);
            this.buttonTape.TabIndex = 0;
            this.buttonTape.Text = "Лента";
            this.buttonTape.UseVisualStyleBackColor = false;
            this.buttonTape.Click += new System.EventHandler(this.ButtonTape_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSettings.Location = new System.Drawing.Point(8, 57);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(189, 40);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "Настройки";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // buttonPurchases
            // 
            this.buttonPurchases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonPurchases.FlatAppearance.BorderSize = 0;
            this.buttonPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPurchases.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPurchases.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPurchases.Location = new System.Drawing.Point(8, 26);
            this.buttonPurchases.Name = "buttonPurchases";
            this.buttonPurchases.Size = new System.Drawing.Size(189, 36);
            this.buttonPurchases.TabIndex = 0;
            this.buttonPurchases.Text = "Мои покупки";
            this.buttonPurchases.UseVisualStyleBackColor = false;
            this.buttonPurchases.Click += new System.EventHandler(this.ButtonPurchases_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogOut.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLogOut.Location = new System.Drawing.Point(8, 94);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(189, 31);
            this.buttonLogOut.TabIndex = 0;
            this.buttonLogOut.Text = "Выход";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.ButtonLogOut_Click);
            // 
            // userMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonPurchases);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonTape);
            this.Location = new System.Drawing.Point(1577, 68);
            this.Name = "userMenu";
            this.Size = new System.Drawing.Size(208, 145);
            this.Load += new System.EventHandler(this.UserMenu_Load);
            this.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTape;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonPurchases;
        private System.Windows.Forms.Button buttonLogOut;
    }
}
