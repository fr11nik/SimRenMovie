using System.Windows.Forms;

namespace SimRenMovie.Forms
{
    partial class CaruselContainer
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelGenreType = new System.Windows.Forms.Label();
            this.buttonGenreAll = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.buttonGenreAll)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 57);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(35, 35, 1, 1);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1904, 239);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // labelGenreType
            // 
            this.labelGenreType.AutoSize = true;
            this.labelGenreType.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenreType.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGenreType.Location = new System.Drawing.Point(57, 12);
            this.labelGenreType.Name = "labelGenreType";
            this.labelGenreType.Size = new System.Drawing.Size(212, 32);
            this.labelGenreType.TabIndex = 5;
            this.labelGenreType.Text = "Мультфильмы";
            // 
            // buttonGenreAll
            // 
            this.buttonGenreAll.BackColor = System.Drawing.Color.Transparent;
            this.buttonGenreAll.Image = global::SimRenMovie.Properties.Resources.icons8_forward_96;
            this.buttonGenreAll.ImageActive = null;
            this.buttonGenreAll.Location = new System.Drawing.Point(263, 9);
            this.buttonGenreAll.Name = "buttonGenreAll";
            this.buttonGenreAll.Size = new System.Drawing.Size(49, 39);
            this.buttonGenreAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonGenreAll.TabIndex = 4;
            this.buttonGenreAll.TabStop = false;
            this.buttonGenreAll.Zoom = 10;
            // 
            // CaruselContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.labelGenreType);
            this.Controls.Add(this.buttonGenreAll);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CaruselContainer";
            this.Size = new System.Drawing.Size(1904, 296);
            this.Load += new System.EventHandler(this.CaruselContainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonGenreAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuImageButton buttonGenreAll;
        private Label labelGenreType;
    }
}
