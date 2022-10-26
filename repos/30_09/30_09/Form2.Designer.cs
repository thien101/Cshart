namespace _30_09
{
    partial class Form2
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
            this.chcklbox1 = new System.Windows.Forms.CheckedListBox();
            this.btnclick = new System.Windows.Forms.Button();
            this.lblkq = new System.Windows.Forms.Label();
            this.listTT = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // chcklbox1
            // 
            this.chcklbox1.CheckOnClick = true;
            this.chcklbox1.FormattingEnabled = true;
            this.chcklbox1.Items.AddRange(new object[] {
            "Ca",
            "Cua",
            "Muc",
            "Tom",
            "Ghe",
            "Oc"});
            this.chcklbox1.Location = new System.Drawing.Point(55, 28);
            this.chcklbox1.Name = "chcklbox1";
            this.chcklbox1.Size = new System.Drawing.Size(129, 157);
            this.chcklbox1.TabIndex = 0;
            // 
            // btnclick
            // 
            this.btnclick.Location = new System.Drawing.Point(75, 227);
            this.btnclick.Name = "btnclick";
            this.btnclick.Size = new System.Drawing.Size(95, 41);
            this.btnclick.TabIndex = 1;
            this.btnclick.Text = "Click";
            this.btnclick.UseVisualStyleBackColor = true;
            this.btnclick.Click += new System.EventHandler(this.btnclick_Click);
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkq.Location = new System.Drawing.Point(402, 28);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(137, 29);
            this.lblkq.TabIndex = 3;
            this.lblkq.Text = "Tong Tien: ";
            // 
            // listTT
            // 
            this.listTT.FormattingEnabled = true;
            this.listTT.ItemHeight = 16;
            this.listTT.Items.AddRange(new object[] {
            "10",
            "30",
            "25",
            "70",
            "60",
            "35"});
            this.listTT.Location = new System.Drawing.Point(196, 29);
            this.listTT.Name = "listTT";
            this.listTT.Size = new System.Drawing.Size(78, 148);
            this.listTT.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listTT);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.btnclick);
            this.Controls.Add(this.chcklbox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chcklbox1;
        private System.Windows.Forms.Button btnclick;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.ListBox listTT;
    }
}