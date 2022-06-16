using Bunifu.Framework.UI;
using formsDragControl;

namespace SimRenMovie
{
    partial class AdminPanel
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
            this.dc = new formsDragControl.DragControl();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.buttonMinimized = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelRight = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonFilmList = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonMainPage = new System.Windows.Forms.Button();
            this.DragPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dc
            // 
            this.dc.SelectControl = this.DragPanel;
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.Transparent;
            this.DragPanel.Controls.Add(this.exitButton);
            this.DragPanel.Controls.Add(this.buttonMinimized);
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragPanel.Location = new System.Drawing.Point(0, 0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(979, 80);
            this.DragPanel.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(927, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(37, 42);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.exitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            this.exitButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseMove);
            // 
            // buttonMinimized
            // 
            this.buttonMinimized.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMinimized.FlatAppearance.BorderSize = 0;
            this.buttonMinimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMinimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimized.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinimized.ForeColor = System.Drawing.Color.White;
            this.buttonMinimized.Location = new System.Drawing.Point(874, 0);
            this.buttonMinimized.Name = "buttonMinimized";
            this.buttonMinimized.Size = new System.Drawing.Size(37, 42);
            this.buttonMinimized.TabIndex = 2;
            this.buttonMinimized.Text = "_";
            this.buttonMinimized.UseVisualStyleBackColor = false;
            this.buttonMinimized.Click += new System.EventHandler(this.ButtonMinimized_Click);
            this.buttonMinimized.MouseLeave += new System.EventHandler(this.ButtonMinimized_MouseLeave);
            this.buttonMinimized.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonMinimized_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.flowLayoutPanelRight);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 645);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanelRight
            // 
            this.flowLayoutPanelRight.AutoScroll = true;
            this.flowLayoutPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelRight.Location = new System.Drawing.Point(200, 0);
            this.flowLayoutPanelRight.Name = "flowLayoutPanelRight";
            this.flowLayoutPanelRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanelRight.Size = new System.Drawing.Size(779, 645);
            this.flowLayoutPanelRight.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.buttonLogOut);
            this.panel2.Controls.Add(this.buttonFilmList);
            this.panel2.Controls.Add(this.buttonUsers);
            this.panel2.Controls.Add(this.buttonMainPage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 645);
            this.panel2.TabIndex = 1;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonLogOut.Location = new System.Drawing.Point(3, 166);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(200, 41);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "Выход";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.ButtonLogOut_Click);
            // 
            // buttonFilmList
            // 
            this.buttonFilmList.FlatAppearance.BorderSize = 0;
            this.buttonFilmList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.buttonFilmList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilmList.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFilmList.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonFilmList.Location = new System.Drawing.Point(0, 111);
            this.buttonFilmList.Name = "buttonFilmList";
            this.buttonFilmList.Size = new System.Drawing.Size(200, 50);
            this.buttonFilmList.TabIndex = 4;
            this.buttonFilmList.Text = "Список фильмов";
            this.buttonFilmList.UseVisualStyleBackColor = true;
            this.buttonFilmList.Click += new System.EventHandler(this.ButtonAddTable_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.FlatAppearance.BorderSize = 0;
            this.buttonUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUsers.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonUsers.Location = new System.Drawing.Point(0, 55);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(200, 50);
            this.buttonUsers.TabIndex = 3;
            this.buttonUsers.Text = "Пользователи";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.ButtonAddTable_Click);
            // 
            // buttonMainPage
            // 
            this.buttonMainPage.FlatAppearance.BorderSize = 0;
            this.buttonMainPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.buttonMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainPage.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMainPage.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonMainPage.Location = new System.Drawing.Point(0, -1);
            this.buttonMainPage.Name = "buttonMainPage";
            this.buttonMainPage.Size = new System.Drawing.Size(200, 50);
            this.buttonMainPage.TabIndex = 2;
            this.buttonMainPage.Text = "Главная страница";
            this.buttonMainPage.UseVisualStyleBackColor = true;
            this.buttonMainPage.Click += new System.EventHandler(this.ButtonMainPage_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::SimRenMovie.Properties.Resources.Background_login_red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(979, 725);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.DragPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DragControl dc;
        private System.Windows.Forms.Panel DragPanel;
        private System.Windows.Forms.Button buttonMinimized;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
     
       
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonMainPage;
        private System.Windows.Forms.Button buttonFilmList;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRight;
        private System.Windows.Forms.Button buttonLogOut;
    }
}