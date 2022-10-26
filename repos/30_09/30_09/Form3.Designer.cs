namespace _30_09
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.lbltext = new System.Windows.Forms.Label();
            this.txttext = new System.Windows.Forms.TextBox();
            this.cbb_size = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_font = new System.Windows.Forms.ComboBox();
            this.btb_click = new System.Windows.Forms.Button();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnstop = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.txt_gio = new System.Windows.Forms.TextBox();
            this.txt_phut = new System.Windows.Forms.TextBox();
            this.txt_giay = new System.Windows.Forms.TextBox();
            this.pt_color = new System.Windows.Forms.PictureBox();
            this.txt_den = new System.Windows.Forms.TextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.time_do = new System.Windows.Forms.Timer(this.components);
            this.time_xanh = new System.Windows.Forms.Timer(this.components);
            this.time_vang = new System.Windows.Forms.Timer(this.components);
            this.btn_stop = new System.Windows.Forms.Button();
            this.btnFr2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pt_color)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext.Location = new System.Drawing.Point(34, 92);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(42, 20);
            this.lbltext.TabIndex = 1;
            this.lbltext.Text = "Size";
            // 
            // txttext
            // 
            this.txttext.Location = new System.Drawing.Point(33, 23);
            this.txttext.Name = "txttext";
            this.txttext.Size = new System.Drawing.Size(433, 22);
            this.txttext.TabIndex = 2;
            this.txttext.Text = "Hoang Thien";
            // 
            // cbb_size
            // 
            this.cbb_size.DisplayMember = "10";
            this.cbb_size.FormattingEnabled = true;
            this.cbb_size.Items.AddRange(new object[] {
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.cbb_size.Location = new System.Drawing.Point(82, 92);
            this.cbb_size.Name = "cbb_size";
            this.cbb_size.Size = new System.Drawing.Size(48, 24);
            this.cbb_size.TabIndex = 3;
            this.cbb_size.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Font";
            // 
            // cbb_font
            // 
            this.cbb_font.FormattingEnabled = true;
            this.cbb_font.Items.AddRange(new object[] {
            "Times New Roman",
            "Tahoma",
            "Arial"});
            this.cbb_font.Location = new System.Drawing.Point(200, 88);
            this.cbb_font.Name = "cbb_font";
            this.cbb_font.Size = new System.Drawing.Size(172, 24);
            this.cbb_font.TabIndex = 5;
            this.cbb_font.Text = "Arial";
            // 
            // btb_click
            // 
            this.btb_click.Location = new System.Drawing.Point(398, 85);
            this.btb_click.Name = "btb_click";
            this.btb_click.Size = new System.Drawing.Size(73, 27);
            this.btb_click.TabIndex = 6;
            this.btb_click.Text = "Click";
            this.btb_click.UseVisualStyleBackColor = true;
            this.btb_click.Click += new System.EventHandler(this.btb_click_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(38, 171);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(23, 25);
            this.lbltime.TabIndex = 7;
            this.lbltime.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnstop
            // 
            this.btnstop.Enabled = false;
            this.btnstop.Location = new System.Drawing.Point(45, 227);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(80, 36);
            this.btnstop.TabIndex = 8;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(156, 227);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(80, 36);
            this.btnstart.TabIndex = 9;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // txt_gio
            // 
            this.txt_gio.Location = new System.Drawing.Point(49, 284);
            this.txt_gio.Name = "txt_gio";
            this.txt_gio.Size = new System.Drawing.Size(75, 22);
            this.txt_gio.TabIndex = 10;
            this.txt_gio.Text = "0";
            // 
            // txt_phut
            // 
            this.txt_phut.Location = new System.Drawing.Point(157, 284);
            this.txt_phut.Name = "txt_phut";
            this.txt_phut.Size = new System.Drawing.Size(78, 22);
            this.txt_phut.TabIndex = 11;
            this.txt_phut.Text = "0";
            // 
            // txt_giay
            // 
            this.txt_giay.Location = new System.Drawing.Point(284, 284);
            this.txt_giay.Name = "txt_giay";
            this.txt_giay.Size = new System.Drawing.Size(75, 22);
            this.txt_giay.TabIndex = 12;
            this.txt_giay.Text = "0";
            // 
            // pt_color
            // 
            this.pt_color.Location = new System.Drawing.Point(600, 23);
            this.pt_color.Name = "pt_color";
            this.pt_color.Size = new System.Drawing.Size(129, 109);
            this.pt_color.TabIndex = 13;
            this.pt_color.TabStop = false;
            // 
            // txt_den
            // 
            this.txt_den.Location = new System.Drawing.Point(777, 62);
            this.txt_den.Name = "txt_den";
            this.txt_den.Size = new System.Drawing.Size(75, 22);
            this.txt_den.TabIndex = 16;
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(612, 177);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(93, 32);
            this.btn_run.TabIndex = 19;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // time_do
            // 
            this.time_do.Tick += new System.EventHandler(this.time_do_Tick);
            // 
            // time_xanh
            // 
            this.time_xanh.Tick += new System.EventHandler(this.time_xanh_Tick);
            // 
            // time_vang
            // 
            this.time_vang.Tick += new System.EventHandler(this.time_vang_Tick);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(759, 177);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(93, 32);
            this.btn_stop.TabIndex = 20;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btnFr2
            // 
            this.btnFr2.Location = new System.Drawing.Point(347, 371);
            this.btnFr2.Name = "btnFr2";
            this.btnFr2.Size = new System.Drawing.Size(104, 49);
            this.btnFr2.TabIndex = 21;
            this.btnFr2.Text = "btnForm2";
            this.btnFr2.UseVisualStyleBackColor = true;
            this.btnFr2.Click += new System.EventHandler(this.btnFr2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 540);
            this.Controls.Add(this.btnFr2);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.txt_den);
            this.Controls.Add(this.pt_color);
            this.Controls.Add(this.txt_giay);
            this.Controls.Add(this.txt_phut);
            this.Controls.Add(this.txt_gio);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.btb_click);
            this.Controls.Add(this.cbb_font);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_size);
            this.Controls.Add(this.txttext);
            this.Controls.Add(this.lbltext);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pt_color)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.TextBox txttext;
        private System.Windows.Forms.ComboBox cbb_size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_font;
        private System.Windows.Forms.Button btb_click;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.TextBox txt_gio;
        private System.Windows.Forms.TextBox txt_phut;
        private System.Windows.Forms.TextBox txt_giay;
        private System.Windows.Forms.PictureBox pt_color;
        private System.Windows.Forms.TextBox txt_den;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Timer time_do;
        private System.Windows.Forms.Timer time_xanh;
        private System.Windows.Forms.Timer time_vang;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btnFr2;
    }
}