﻿namespace baitap2
{
    partial class frmMain
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Enter += new System.EventHandler(this.frmMain_Enter);
            this.textBox1.Leave += new System.EventHandler(this.frmMain_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Enter += new System.EventHandler(this.frmMain_Enter);
            this.textBox2.Leave += new System.EventHandler(this.frmMain_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(85, 179);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.Enter += new System.EventHandler(this.frmMain_Enter);
            this.textBox3.Leave += new System.EventHandler(this.frmMain_Leave);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(85, 238);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 3;
            this.textBox4.Enter += new System.EventHandler(this.frmMain_Enter);
            this.textBox4.Leave += new System.EventHandler(this.frmMain_Leave);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(85, 290);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 22);
            this.textBox5.TabIndex = 4;
            this.textBox5.Enter += new System.EventHandler(this.frmMain_Enter);
            this.textBox5.Leave += new System.EventHandler(this.frmMain_Leave);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Enter += new System.EventHandler(this.frmMain_Enter);
            this.Leave += new System.EventHandler(this.frmMain_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

