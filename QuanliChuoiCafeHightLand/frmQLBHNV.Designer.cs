namespace QuanliChuoiCafeHightLand
{
    partial class frmQLBHNV
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.menuOderToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 25);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// hệThốngToolStripMenuItem
			// 
			this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
			this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
			this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
			this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
			// 
			// đăngXuấtToolStripMenuItem
			// 
			this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
			this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
			this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
			// 
			// thoátToolStripMenuItem
			// 
			this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
			this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.thoátToolStripMenuItem.Text = "Thoát";
			// 
			// menuOderToolStripMenuItem
			// 
			this.menuOderToolStripMenuItem.Name = "menuOderToolStripMenuItem";
			this.menuOderToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
			this.menuOderToolStripMenuItem.Text = "MenuOder";
			this.menuOderToolStripMenuItem.Click += new System.EventHandler(this.menuOderToolStripMenuItem_Click);
			// 
			// hóaĐơnToolStripMenuItem
			// 
			this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
			this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
			this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
			// 
			// frmQLBHNV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::QuanliChuoiCafeHightLand.Properties.Resources.cambg_51;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmQLBHNV";
			this.Text = "Phần Mền Quản Lí Hight Land Coffee";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuOderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
	}
}