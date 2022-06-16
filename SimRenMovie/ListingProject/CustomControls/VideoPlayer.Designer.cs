namespace SimRenMovie.CustomControls
{
    partial class Video_Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Video_Player));
            this.panel1 = new System.Windows.Forms.Panel();
            this.VTrackbarVoice = new System.Windows.Forms.TrackBar();
            this.buttonPlay = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelTime = new System.Windows.Forms.Label();
            this.trackBarTime = new Bunifu.Framework.UI.BunifuSlider();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.filmFrame = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VTrackbarVoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.VTrackbarVoice);
            this.panel1.Controls.Add(this.buttonPlay);
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.trackBarTime);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 687);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 73);
            this.panel1.TabIndex = 0;
            // 
            // VTrackbarVoice
            // 
            this.VTrackbarVoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VTrackbarVoice.Location = new System.Drawing.Point(82, 8);
            this.VTrackbarVoice.Maximum = 100;
            this.VTrackbarVoice.Name = "VTrackbarVoice";
            this.VTrackbarVoice.Size = new System.Drawing.Size(76, 45);
            this.VTrackbarVoice.TabIndex = 2;
            this.VTrackbarVoice.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VTrackbarVoice.Value = 100;
            this.VTrackbarVoice.Scroll += new System.EventHandler(this.VTrackbarVoice_Scroll);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.Image = global::SimRenMovie.Properties.Resources.pause_51px;
            this.buttonPlay.ImageActive = null;
            this.buttonPlay.Location = new System.Drawing.Point(14, 8);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(28, 31);
            this.buttonPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.TabStop = false;
            this.buttonPlay.Zoom = 5;
            this.buttonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.ImageActive")));
            this.bunifuImageButton3.Location = new System.Drawing.Point(1861, 8);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(28, 31);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 1;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 5;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(1800, 15);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(51, 17);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "0:00:00";
            // 
            // trackBarTime
            // 
            this.trackBarTime.BackColor = System.Drawing.Color.Transparent;
            this.trackBarTime.BackgroudColor = System.Drawing.Color.DarkGray;
            this.trackBarTime.BorderRadius = 5;
            this.trackBarTime.IndicatorColor = System.Drawing.Color.LightCoral;
            this.trackBarTime.Location = new System.Drawing.Point(178, 9);
            this.trackBarTime.MaximumValue = 100;
            this.trackBarTime.Name = "trackBarTime";
            this.trackBarTime.Size = new System.Drawing.Size(1616, 30);
            this.trackBarTime.TabIndex = 3;
            this.trackBarTime.Value = 0;
            this.trackBarTime.ValueChanged += new System.EventHandler(this.TrackBarTime_ValueChanged);
            this.trackBarTime.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBarTime_Scroll);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ImageActive")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(48, 8);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(28, 31);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 5;
            this.bunifuImageButton2.Click += new System.EventHandler(this.BunifuImageButton2_Click);
            // 
            // filmFrame
            // 
            this.filmFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.filmFrame.BackgroundImage = global::SimRenMovie.Properties.Resources.Без_имени_1;
            this.filmFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.filmFrame.Dock = System.Windows.Forms.DockStyle.Top;
            this.filmFrame.Location = new System.Drawing.Point(0, 0);
            this.filmFrame.Name = "filmFrame";
            this.filmFrame.Size = new System.Drawing.Size(1920, 685);
            this.filmFrame.TabIndex = 1;
            // 
            // Video_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.filmFrame);
            this.Controls.Add(this.panel1);
            this.Name = "Video_Player";
            this.Size = new System.Drawing.Size(1920, 760);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VTrackbarVoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel filmFrame;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton buttonPlay;
        private System.Windows.Forms.TrackBar VTrackbarVoice;
        private System.Windows.Forms.Label labelTime;
        private Bunifu.Framework.UI.BunifuSlider trackBarTime;
    }
}
