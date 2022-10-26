namespace Baitap
{
    partial class FromChinh
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
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnulogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnulogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuclose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWork = new System.Windows.Forms.ToolStripMenuItem();
            this.work_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.work_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.find_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.find_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.mnuWork,
            this.mnuFind});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnulogin,
            this.mnulogout,
            this.mnuclose});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // mnulogin
            // 
            this.mnulogin.Name = "mnulogin";
            this.mnulogin.Size = new System.Drawing.Size(224, 26);
            this.mnulogin.Text = "Login";
            this.mnulogin.Click += new System.EventHandler(this.mnulogin_Click);
            // 
            // mnulogout
            // 
            this.mnulogout.Name = "mnulogout";
            this.mnulogout.Size = new System.Drawing.Size(224, 26);
            this.mnulogout.Text = "Logout";
            this.mnulogout.Click += new System.EventHandler(this.mnulogout_Click);
            // 
            // mnuclose
            // 
            this.mnuclose.Name = "mnuclose";
            this.mnuclose.Size = new System.Drawing.Size(139, 26);
            this.mnuclose.Text = "Close";
            // 
            // mnuWork
            // 
            this.mnuWork.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.work_1,
            this.work_2});
            this.mnuWork.Name = "mnuWork";
            this.mnuWork.Size = new System.Drawing.Size(57, 24);
            this.mnuWork.Text = "Work";
            // 
            // work_1
            // 
            this.work_1.Name = "work_1";
            this.work_1.Size = new System.Drawing.Size(134, 26);
            this.work_1.Text = "Work1";
            // 
            // work_2
            // 
            this.work_2.Name = "work_2";
            this.work_2.Size = new System.Drawing.Size(134, 26);
            this.work_2.Text = "Work2";
            // 
            // mnuFind
            // 
            this.mnuFind.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.find_1,
            this.find_2});
            this.mnuFind.Name = "mnuFind";
            this.mnuFind.Size = new System.Drawing.Size(51, 24);
            this.mnuFind.Text = "Find";
            // 
            // find_1
            // 
            this.find_1.Name = "find_1";
            this.find_1.Size = new System.Drawing.Size(128, 26);
            this.find_1.Text = "Find1";
            // 
            // find_2
            // 
            this.find_2.Name = "find_2";
            this.find_2.Size = new System.Drawing.Size(128, 26);
            this.find_2.Text = "Find2";
            // 
            // FromChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FromChinh";
            this.Text = "FormChinh";
            this.Activated += new System.EventHandler(this.FromChinh_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnulogin;
        private System.Windows.Forms.ToolStripMenuItem mnulogout;
        private System.Windows.Forms.ToolStripMenuItem mnuclose;
        private System.Windows.Forms.ToolStripMenuItem mnuWork;
        private System.Windows.Forms.ToolStripMenuItem work_1;
        private System.Windows.Forms.ToolStripMenuItem work_2;
        private System.Windows.Forms.ToolStripMenuItem mnuFind;
        private System.Windows.Forms.ToolStripMenuItem find_1;
        private System.Windows.Forms.ToolStripMenuItem find_2;
    }
}

