namespace SimRenMovie.Forms
{
    partial class headerMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(headerMenu));
            this.userBascket = new SimRenMovie.CustomControls.UserBascket();
            this.textBoxSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDragControlHeader = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControllogo = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLeftPanel = new System.Windows.Forms.Panel();
            this.dragLeftHeader = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.buttonSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonUserProfile = new Bunifu.Framework.UI.BunifuFlatButton();        
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxSearch.ForeColor = System.Drawing.Color.White;
            this.textBoxSearch.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSearch.HintText = "Поиск Фильмов";
            this.textBoxSearch.isPassword = false;
            this.textBoxSearch.LineFocusedColor = System.Drawing.Color.IndianRed;
            this.textBoxSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxSearch.LineMouseHoverColor = System.Drawing.Color.White;
            this.textBoxSearch.LineThickness = 3;
            this.textBoxSearch.Location = new System.Drawing.Point(337, 17);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(1119, 33);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearch_KeyDown);
            // 
            // bunifuDragControlHeader
            // 
            this.bunifuDragControlHeader.Fixed = true;
            this.bunifuDragControlHeader.Horizontal = true;
            this.bunifuDragControlHeader.TargetControl = this;
            this.bunifuDragControlHeader.Vertical = true;
            // 
            // bunifuDragControllogo
            // 
            this.bunifuDragControllogo.Fixed = true;
            this.bunifuDragControllogo.Horizontal = true;
            this.bunifuDragControllogo.TargetControl = this.pictureBox1;
            this.bunifuDragControllogo.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SimRenMovie.Properties.Resources.Без_имени_1;
            this.pictureBox1.Location = new System.Drawing.Point(74, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "logo";
            // 
            // panelLeftPanel
            // 
            this.panelLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.panelLeftPanel.Controls.Add(this.pictureBox1);
            this.panelLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.panelLeftPanel.Name = "panelLeftPanel";
            this.panelLeftPanel.Size = new System.Drawing.Size(272, 68);
            this.panelLeftPanel.TabIndex = 7;
            // 
            // dragLeftHeader
            // 
            this.dragLeftHeader.Fixed = true;
            this.dragLeftHeader.Horizontal = true;
            this.dragLeftHeader.TargetControl = this.panelLeftPanel;
            this.dragLeftHeader.Vertical = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.ImageActive = null;
            this.buttonSearch.Location = new System.Drawing.Point(303, 17);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(23, 33);
            this.buttonSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.TabStop = false;
            this.buttonSearch.Tag = "searchbutton";
            this.buttonSearch.Zoom = 7;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // buttonUserProfile
            // 
            this.buttonUserProfile.Activecolor = System.Drawing.Color.Transparent;
            this.buttonUserProfile.BackColor = System.Drawing.Color.Transparent;
            this.buttonUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUserProfile.BorderRadius = 0;
            this.buttonUserProfile.ButtonText = "Fruinik";
            this.buttonUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUserProfile.DisabledColor = System.Drawing.Color.Gray;
            this.buttonUserProfile.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonUserProfile.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonUserProfile.Iconimage")));
            this.buttonUserProfile.Iconimage_right = null;
            this.buttonUserProfile.Iconimage_right_Selected = null;
            this.buttonUserProfile.Iconimage_Selected = null;
            this.buttonUserProfile.IconMarginLeft = 0;
            this.buttonUserProfile.IconMarginRight = 0;
            this.buttonUserProfile.IconRightVisible = true;
            this.buttonUserProfile.IconRightZoom = 0D;
            this.buttonUserProfile.IconVisible = true;
            this.buttonUserProfile.IconZoom = 50D;
            this.buttonUserProfile.IsTab = false;
            this.buttonUserProfile.Location = new System.Drawing.Point(1577, 3);
            this.buttonUserProfile.Name = "buttonUserProfile";
            this.buttonUserProfile.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonUserProfile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonUserProfile.OnHoverTextColor = System.Drawing.Color.IndianRed;
            this.buttonUserProfile.selected = false;
            this.buttonUserProfile.Size = new System.Drawing.Size(189, 62);
            this.buttonUserProfile.TabIndex = 2;
            this.buttonUserProfile.Tag = "buttonUser";
            this.buttonUserProfile.Text = "Fruinik";
            this.buttonUserProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserProfile.Textcolor = System.Drawing.Color.White;
            this.buttonUserProfile.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // userBascket
            // 
            this.userBascket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));           
            this.userBascket.Location = new System.Drawing.Point(1536, 0);
            this.userBascket.Name = "userBascket";
            this.userBascket.Size = new System.Drawing.Size(38, 68);
            this.userBascket.TabIndex = 9;
            // 
            // headerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.userBascket);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonUserProfile);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.panelLeftPanel);
            this.Name = "headerMenu";
            this.Size = new System.Drawing.Size(1920, 68);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLeftPanel.ResumeLayout(false);
            this.panelLeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
       
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxSearch;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlHeader;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControllogo;
        private Bunifu.Framework.UI.BunifuFlatButton buttonUserProfile;
        private Bunifu.Framework.UI.BunifuImageButton buttonSearch;
        private System.Windows.Forms.Panel panelLeftPanel;
        private Bunifu.Framework.UI.BunifuDragControl dragLeftHeader;
        private CustomControls.UserBascket userBascket;
    }
}
