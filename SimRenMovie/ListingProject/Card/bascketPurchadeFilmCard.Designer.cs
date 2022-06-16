namespace SimRenMovie.CustomControls
{
    partial class bascketPurchadeFilmCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bascketPurchadeFilmCard));
            this.labelName = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonRemoveItem = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRemoveItem)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelName.Location = new System.Drawing.Point(367, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(396, 36);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Легенда об искателе джо";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenre.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelGenre.Location = new System.Drawing.Point(369, 76);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(179, 60);
            this.labelGenre.TabIndex = 0;
            this.labelGenre.Text = "жанр: триллер\r\nстрана: Южная Корея \r\nгод выхода: 2019";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(52, -48);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(298, 284);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.ForeColor = System.Drawing.Color.LightCoral;
            this.labelPrice.Location = new System.Drawing.Point(368, 153);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(67, 25);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "150 ₽";
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.BackColor = System.Drawing.Color.Transparent;
            this.buttonRemoveItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRemoveItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveItem.Image")));
            this.buttonRemoveItem.ImageActive = null;
            this.buttonRemoveItem.Location = new System.Drawing.Point(1080, 0);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(36, 187);
            this.buttonRemoveItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonRemoveItem.TabIndex = 3;
            this.buttonRemoveItem.TabStop = false;
            this.buttonRemoveItem.Zoom = 12;
            this.buttonRemoveItem.Click += new System.EventHandler(this.ButtonRemoveItem_Click);
            // 
            // bascketPurchadeFilmCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.buttonRemoveItem);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelName);
            this.Name = "bascketPurchadeFilmCard";
            this.Size = new System.Drawing.Size(1116, 187);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRemoveItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelPrice;
        private Bunifu.Framework.UI.BunifuImageButton buttonRemoveItem;
    }
}
