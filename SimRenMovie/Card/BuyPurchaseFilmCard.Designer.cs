namespace SimRenMovie.CustomControls
{
    partial class BuyPurchaseFilmCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyPurchaseFilmCard));
            this.pictureBoxImagePhoto = new System.Windows.Forms.PictureBox();
            this.labelFilmName = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.buttonAddtoBag = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBuy = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAddtoBag)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxImagePhoto
            // 
            this.pictureBoxImagePhoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxImagePhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxImagePhoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImagePhoto.Image")));
            this.pictureBoxImagePhoto.Location = new System.Drawing.Point(60, 87);
            this.pictureBoxImagePhoto.Name = "pictureBoxImagePhoto";
            this.pictureBoxImagePhoto.Size = new System.Drawing.Size(190, 275);
            this.pictureBoxImagePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagePhoto.TabIndex = 1;
            this.pictureBoxImagePhoto.TabStop = false;
            // 
            // labelFilmName
            // 
            this.labelFilmName.BackColor = System.Drawing.Color.Transparent;
            this.labelFilmName.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilmName.ForeColor = System.Drawing.Color.White;
            this.labelFilmName.Location = new System.Drawing.Point(281, 165);
            this.labelFilmName.Name = "labelFilmName";
            this.labelFilmName.Size = new System.Drawing.Size(392, 97);
            this.labelFilmName.TabIndex = 2;
            this.labelFilmName.Text = "Джокер";
            // 
            // labelGenre
            // 
            this.labelGenre.BackColor = System.Drawing.Color.Transparent;
            this.labelGenre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenre.ForeColor = System.Drawing.Color.White;
            this.labelGenre.Location = new System.Drawing.Point(17, 14);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(344, 27);
            this.labelGenre.TabIndex = 3;
            this.labelGenre.Text = "Фантастика,Боевик";
            // 
            // buttonAddtoBag
            // 
            this.buttonAddtoBag.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddtoBag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddtoBag.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddtoBag.Image")));
            this.buttonAddtoBag.ImageActive = ((System.Drawing.Image)(resources.GetObject("buttonAddtoBag.ImageActive")));
            this.buttonAddtoBag.Location = new System.Drawing.Point(548, 290);
            this.buttonAddtoBag.Name = "buttonAddtoBag";
            this.buttonAddtoBag.Size = new System.Drawing.Size(125, 72);
            this.buttonAddtoBag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonAddtoBag.TabIndex = 6;
            this.buttonAddtoBag.TabStop = false;
            this.buttonAddtoBag.Zoom = 5;
            this.buttonAddtoBag.Click += new System.EventHandler(this.ButtonAddtoBag_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.buttonAddtoBag);
            this.panel1.Controls.Add(this.buttonBuy);
            this.panel1.Controls.Add(this.labelGenre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1637, 419);
            this.panel1.TabIndex = 7;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Activecolor = System.Drawing.Color.Brown;
            this.buttonBuy.BackColor = System.Drawing.Color.Red;
            this.buttonBuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBuy.BackgroundImage")));
            this.buttonBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuy.BorderRadius = 5;
            this.buttonBuy.ButtonText = "Купить сейчас";
            this.buttonBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuy.DisabledColor = System.Drawing.Color.Gray;
            this.buttonBuy.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonBuy.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonBuy.Iconimage")));
            this.buttonBuy.Iconimage_right = null;
            this.buttonBuy.Iconimage_right_Selected = null;
            this.buttonBuy.Iconimage_Selected = null;
            this.buttonBuy.IconMarginLeft = 0;
            this.buttonBuy.IconMarginRight = 0;
            this.buttonBuy.IconRightVisible = true;
            this.buttonBuy.IconRightZoom = 0D;
            this.buttonBuy.IconVisible = true;
            this.buttonBuy.IconZoom = 55D;
            this.buttonBuy.IsTab = false;
            this.buttonBuy.Location = new System.Drawing.Point(288, 290);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Normalcolor = System.Drawing.Color.Red;
            this.buttonBuy.OnHovercolor = System.Drawing.Color.Brown;
            this.buttonBuy.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonBuy.selected = true;
            this.buttonBuy.Size = new System.Drawing.Size(235, 72);
            this.buttonBuy.TabIndex = 4;
            this.buttonBuy.Text = "Купить сейчас";
            this.buttonBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonBuy.Textcolor = System.Drawing.Color.White;
            this.buttonBuy.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buttonBuy.Click += new System.EventHandler(this.ButtonBuy_Click);
            // 
            // bascketPurchaseFilmCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelFilmName);
            this.Controls.Add(this.pictureBoxImagePhoto);
            this.Controls.Add(this.panel1);
            this.Name = "bascketPurchaseFilmCard";
            this.Size = new System.Drawing.Size(1637, 419);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAddtoBag)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImagePhoto;
        private System.Windows.Forms.Label labelFilmName;
        private System.Windows.Forms.Label labelGenre;
        private Bunifu.Framework.UI.BunifuImageButton buttonAddtoBag;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton buttonBuy;
    }
}
