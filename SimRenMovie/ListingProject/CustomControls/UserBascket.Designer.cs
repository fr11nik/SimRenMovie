namespace SimRenMovie.CustomControls
{
    partial class UserBascket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBascket));
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonBascket = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBascket)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.labelCount.Font = new System.Drawing.Font("Arial Black", 5.25F, System.Drawing.FontStyle.Bold);
            this.labelCount.Location = new System.Drawing.Point(22, 23);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(10, 10);
            this.labelCount.TabIndex = 1;
            this.labelCount.Text = "0";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBascket
            // 
            this.buttonBascket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonBascket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBascket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBascket.Image = ((System.Drawing.Image)(resources.GetObject("buttonBascket.Image")));
            this.buttonBascket.ImageActive = null;
            this.buttonBascket.Location = new System.Drawing.Point(3, 0);
            this.buttonBascket.Name = "buttonBascket";
            this.buttonBascket.Size = new System.Drawing.Size(32, 68);
            this.buttonBascket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonBascket.TabIndex = 0;
            this.buttonBascket.TabStop = false;
            this.buttonBascket.Zoom = 6;
            // 
            // UserBascket
            // 
            this.Load += UserBascket_Load;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonBascket);
            this.Name = "UserBascket";
            this.Size = new System.Drawing.Size(38, 68);
            ((System.ComponentModel.ISupportInitialize)(this.buttonBascket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton buttonBascket;
        private System.Windows.Forms.Label labelCount;
    }
}
