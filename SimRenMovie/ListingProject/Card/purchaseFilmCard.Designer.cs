namespace SimRenMovie.Forms
{
    partial class purchaseFilmCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(purchaseFilmCard));
            this.labelGenre = new System.Windows.Forms.Label();
            this.buttonFilmName = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonImageContainer = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buttonImageContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenre.ForeColor = System.Drawing.Color.Silver;
            this.labelGenre.Location = new System.Drawing.Point(157, 331);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(55, 15);
            this.labelGenre.TabIndex = 0;
            this.labelGenre.Text = "Fantastic";
            // 
            // buttonFilmName
            // 
            this.buttonFilmName.Activecolor = System.Drawing.Color.Transparent;
            this.buttonFilmName.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilmName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFilmName.BorderRadius = 0;
            this.buttonFilmName.ButtonText = "Coco";
            this.buttonFilmName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilmName.DisabledColor = System.Drawing.Color.Gray;
            this.buttonFilmName.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonFilmName.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonFilmName.Iconimage")));
            this.buttonFilmName.Iconimage_right = null;
            this.buttonFilmName.Iconimage_right_Selected = null;
            this.buttonFilmName.Iconimage_Selected = null;
            this.buttonFilmName.IconMarginLeft = 0;
            this.buttonFilmName.IconMarginRight = 0;
            this.buttonFilmName.IconRightVisible = false;
            this.buttonFilmName.IconRightZoom = 0D;
            this.buttonFilmName.IconVisible = false;
            this.buttonFilmName.IconZoom = 90D;
            this.buttonFilmName.IsTab = false;
            this.buttonFilmName.Location = new System.Drawing.Point(22, 296);
            this.buttonFilmName.Name = "buttonFilmName";
            this.buttonFilmName.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonFilmName.OnHovercolor = System.Drawing.Color.Transparent;
            this.buttonFilmName.OnHoverTextColor = System.Drawing.Color.IndianRed;
            this.buttonFilmName.selected = false;
            this.buttonFilmName.Size = new System.Drawing.Size(205, 38);
            this.buttonFilmName.TabIndex = 2;
            this.buttonFilmName.Text = "Coco";
            this.buttonFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFilmName.Textcolor = System.Drawing.Color.White;
            this.buttonFilmName.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonFilmName.Click += new System.EventHandler(this.ButtonImageContainer_Click);
            // 
            // buttonImageContainer
            // 
            this.buttonImageContainer.BackColor = System.Drawing.Color.Transparent;
            this.buttonImageContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonImageContainer.BackgroundImage")));
            this.buttonImageContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonImageContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImageContainer.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageContainer.Image")));
            this.buttonImageContainer.ImageActive = ((System.Drawing.Image)(resources.GetObject("buttonImageContainer.ImageActive")));
            this.buttonImageContainer.Location = new System.Drawing.Point(22, 15);
            this.buttonImageContainer.Name = "buttonImageContainer";
            this.buttonImageContainer.Size = new System.Drawing.Size(190, 275);
            this.buttonImageContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonImageContainer.TabIndex = 1;
            this.buttonImageContainer.TabStop = false;
            this.buttonImageContainer.Zoom = 5;
            this.buttonImageContainer.Click += new System.EventHandler(this.ButtonImageContainer_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.ForeColor = System.Drawing.Color.RosyBrown;
            this.labelPrice.Location = new System.Drawing.Point(19, 349);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 16);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "3.99$";
            // 
            // purchaseFilmCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.buttonImageContainer);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.buttonFilmName);
            this.Margin = new System.Windows.Forms.Padding(25, 0, 3, 3);
            this.Name = "purchaseFilmCard";
            this.Size = new System.Drawing.Size(235, 377);
            ((System.ComponentModel.ISupportInitialize)(this.buttonImageContainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton buttonImageContainer;
        private System.Windows.Forms.Label labelGenre;
        private Bunifu.Framework.UI.BunifuFlatButton buttonFilmName;
        private System.Windows.Forms.Label labelPrice;
    }
}
