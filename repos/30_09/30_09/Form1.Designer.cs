namespace _30_09
{
    partial class BackAll
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
            this.btn_click = new System.Windows.Forms.Button();
            this.lbtext = new System.Windows.Forms.Label();
            this.checkca = new System.Windows.Forms.CheckBox();
            this.checkcua = new System.Windows.Forms.CheckBox();
            this.checkmuc = new System.Windows.Forms.CheckBox();
            this.listbox = new System.Windows.Forms.ListBox();
            this.list_nguon = new System.Windows.Forms.ListBox();
            this.list_dich = new System.Windows.Forms.ListBox();
            this.move = new System.Windows.Forms.Button();
            this.back_all = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.move_all = new System.Windows.Forms.Button();
            this.btnFr2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_click
            // 
            this.btn_click.Location = new System.Drawing.Point(24, 181);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(96, 50);
            this.btn_click.TabIndex = 0;
            this.btn_click.Text = "Click";
            this.btn_click.UseVisualStyleBackColor = true;
            this.btn_click.Click += new System.EventHandler(this.btn_click_Click);
            // 
            // lbtext
            // 
            this.lbtext.AutoSize = true;
            this.lbtext.Location = new System.Drawing.Point(144, 32);
            this.lbtext.Name = "lbtext";
            this.lbtext.Size = new System.Drawing.Size(37, 16);
            this.lbtext.TabIndex = 1;
            this.lbtext.Text = "label";
            // 
            // checkca
            // 
            this.checkca.AutoSize = true;
            this.checkca.Location = new System.Drawing.Point(31, 28);
            this.checkca.Name = "checkca";
            this.checkca.Size = new System.Drawing.Size(46, 20);
            this.checkca.TabIndex = 2;
            this.checkca.Text = "Cá";
            this.checkca.UseVisualStyleBackColor = true;
            // 
            // checkcua
            // 
            this.checkcua.AutoSize = true;
            this.checkcua.Location = new System.Drawing.Point(31, 72);
            this.checkcua.Name = "checkcua";
            this.checkcua.Size = new System.Drawing.Size(53, 20);
            this.checkcua.TabIndex = 3;
            this.checkcua.Text = "Cua";
            this.checkcua.UseVisualStyleBackColor = true;
            this.checkcua.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkmuc
            // 
            this.checkmuc.AutoSize = true;
            this.checkmuc.Location = new System.Drawing.Point(31, 115);
            this.checkmuc.Name = "checkmuc";
            this.checkmuc.Size = new System.Drawing.Size(54, 20);
            this.checkmuc.TabIndex = 4;
            this.checkmuc.Text = "Mực";
            this.checkmuc.UseVisualStyleBackColor = true;
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 16;
            this.listbox.Items.AddRange(new object[] {
            "Cá",
            "Cua",
            "Ghẹ",
            "Mực",
            "Hầu"});
            this.listbox.Location = new System.Drawing.Point(147, 72);
            this.listbox.Name = "listbox";
            this.listbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listbox.Size = new System.Drawing.Size(114, 116);
            this.listbox.TabIndex = 5;
            // 
            // list_nguon
            // 
            this.list_nguon.FormattingEnabled = true;
            this.list_nguon.ItemHeight = 16;
            this.list_nguon.Items.AddRange(new object[] {
            "chicken",
            "fish",
            "pig",
            "lion",
            "tiger"});
            this.list_nguon.Location = new System.Drawing.Point(387, 56);
            this.list_nguon.Name = "list_nguon";
            this.list_nguon.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.list_nguon.Size = new System.Drawing.Size(113, 132);
            this.list_nguon.TabIndex = 6;
            // 
            // list_dich
            // 
            this.list_dich.FormattingEnabled = true;
            this.list_dich.ItemHeight = 16;
            this.list_dich.Location = new System.Drawing.Point(649, 56);
            this.list_dich.Name = "list_dich";
            this.list_dich.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.list_dich.Size = new System.Drawing.Size(116, 132);
            this.list_dich.TabIndex = 7;
            // 
            // move
            // 
            this.move.Location = new System.Drawing.Point(547, 56);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(53, 29);
            this.move.TabIndex = 8;
            this.move.Text = ">";
            this.move.UseVisualStyleBackColor = true;
            this.move.Click += new System.EventHandler(this.move_Click);
            // 
            // back_all
            // 
            this.back_all.Enabled = false;
            this.back_all.Location = new System.Drawing.Point(547, 161);
            this.back_all.Name = "back_all";
            this.back_all.Size = new System.Drawing.Size(53, 29);
            this.back_all.TabIndex = 9;
            this.back_all.Text = "<<";
            this.back_all.UseVisualStyleBackColor = true;
            this.back_all.Click += new System.EventHandler(this.back_all_Click);
            // 
            // back
            // 
            this.back.Enabled = false;
            this.back.Location = new System.Drawing.Point(547, 126);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(53, 29);
            this.back.TabIndex = 10;
            this.back.Text = "<";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // move_all
            // 
            this.move_all.Location = new System.Drawing.Point(547, 91);
            this.move_all.Name = "move_all";
            this.move_all.Size = new System.Drawing.Size(53, 29);
            this.move_all.TabIndex = 11;
            this.move_all.Text = ">>";
            this.move_all.UseVisualStyleBackColor = true;
            this.move_all.Click += new System.EventHandler(this.move_all_Click);
            // 
            // btnFr2
            // 
            this.btnFr2.Location = new System.Drawing.Point(211, 302);
            this.btnFr2.Name = "btnFr2";
            this.btnFr2.Size = new System.Drawing.Size(104, 49);
            this.btnFr2.TabIndex = 12;
            this.btnFr2.Text = "btnForm2";
            this.btnFr2.UseVisualStyleBackColor = true;
            this.btnFr2.Click += new System.EventHandler(this.btnFr1_Click);
            // 
            // BackAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFr2);
            this.Controls.Add(this.move_all);
            this.Controls.Add(this.back);
            this.Controls.Add(this.back_all);
            this.Controls.Add(this.move);
            this.Controls.Add(this.list_dich);
            this.Controls.Add(this.list_nguon);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.checkmuc);
            this.Controls.Add(this.checkcua);
            this.Controls.Add(this.checkca);
            this.Controls.Add(this.lbtext);
            this.Controls.Add(this.btn_click);
            this.Name = "BackAll";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_click;
        private System.Windows.Forms.Label lbtext;
        private System.Windows.Forms.CheckBox checkca;
        private System.Windows.Forms.CheckBox checkcua;
        private System.Windows.Forms.CheckBox checkmuc;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.ListBox list_nguon;
        private System.Windows.Forms.ListBox list_dich;
        private System.Windows.Forms.Button move;
        private System.Windows.Forms.Button back_all;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button move_all;
        private System.Windows.Forms.Button btnFr2;
    }
}

