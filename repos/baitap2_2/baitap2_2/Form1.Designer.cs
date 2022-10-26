namespace baitap2_2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtht = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.btncong = new System.Windows.Forms.Button();
            this.btnchia = new System.Windows.Forms.Button();
            this.btnnhan = new System.Windows.Forms.Button();
            this.btntru = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.ketqua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btndientich = new System.Windows.Forms.Button();
            this.txtdai = new System.Windows.Forms.TextBox();
            this.txtrong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbrong = new System.Windows.Forms.Label();
            this.btnchuvi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radvang = new System.Windows.Forms.RadioButton();
            this.raddo = new System.Windows.Forms.RadioButton();
            this.radden = new System.Windows.Forms.RadioButton();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.radga = new System.Windows.Forms.RadioButton();
            this.radca = new System.Windows.Forms.RadioButton();
            this.radmuc = new System.Windows.Forms.RadioButton();
            this.picture_food = new System.Windows.Forms.PictureBox();
            this.giaca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_food)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ho va ten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "tuoi";
            // 
            // btnok
            // 
            this.btnok.Enabled = false;
            this.btnok.Location = new System.Drawing.Point(152, 229);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(80, 35);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtht
            // 
            this.txtht.Location = new System.Drawing.Point(177, 70);
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(225, 22);
            this.txtht.TabIndex = 4;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(177, 114);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(224, 22);
            this.txtage.TabIndex = 5;
            this.txtage.Leave += new System.EventHandler(this.txtage_Leave);
            // 
            // btncong
            // 
            this.btncong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncong.Location = new System.Drawing.Point(657, 70);
            this.btncong.Name = "btncong";
            this.btncong.Size = new System.Drawing.Size(30, 30);
            this.btncong.TabIndex = 6;
            this.btncong.Text = "+";
            this.btncong.UseVisualStyleBackColor = true;
            this.btncong.Click += new System.EventHandler(this.btncong_Click);
            // 
            // btnchia
            // 
            this.btnchia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchia.Location = new System.Drawing.Point(709, 109);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(30, 30);
            this.btnchia.TabIndex = 7;
            this.btnchia.Text = "/";
            this.btnchia.UseVisualStyleBackColor = true;
            this.btnchia.Click += new System.EventHandler(this.btnchia_Click);
            // 
            // btnnhan
            // 
            this.btnnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhan.Location = new System.Drawing.Point(709, 70);
            this.btnnhan.Name = "btnnhan";
            this.btnnhan.Size = new System.Drawing.Size(30, 30);
            this.btnnhan.TabIndex = 8;
            this.btnnhan.Text = "*";
            this.btnnhan.UseVisualStyleBackColor = true;
            this.btnnhan.Click += new System.EventHandler(this.btnnhan_Click);
            // 
            // btntru
            // 
            this.btntru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntru.Location = new System.Drawing.Point(657, 109);
            this.btntru.Name = "btntru";
            this.btntru.Size = new System.Drawing.Size(30, 30);
            this.btntru.TabIndex = 9;
            this.btntru.Text = "-";
            this.btntru.UseVisualStyleBackColor = true;
            this.btntru.Click += new System.EventHandler(this.btntru_Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(555, 70);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(80, 22);
            this.number1.TabIndex = 10;
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(555, 114);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(80, 22);
            this.number2.TabIndex = 11;
            // 
            // ketqua
            // 
            this.ketqua.Location = new System.Drawing.Point(555, 181);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(80, 22);
            this.ketqua.TabIndex = 12;
            this.ketqua.TextChanged += new System.EventHandler(this.ketqua_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(580, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "=";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btndientich
            // 
            this.btndientich.Location = new System.Drawing.Point(88, 449);
            this.btndientich.Name = "btndientich";
            this.btndientich.Size = new System.Drawing.Size(85, 42);
            this.btndientich.TabIndex = 14;
            this.btndientich.Text = "dientich";
            this.btndientich.UseVisualStyleBackColor = true;
            this.btndientich.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtdai
            // 
            this.txtdai.Location = new System.Drawing.Point(181, 328);
            this.txtdai.Name = "txtdai";
            this.txtdai.Size = new System.Drawing.Size(174, 22);
            this.txtdai.TabIndex = 15;
            // 
            // txtrong
            // 
            this.txtrong.Location = new System.Drawing.Point(181, 377);
            this.txtrong.Name = "txtrong";
            this.txtrong.Size = new System.Drawing.Size(173, 22);
            this.txtrong.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "cd";
            // 
            // lbrong
            // 
            this.lbrong.AutoSize = true;
            this.lbrong.Location = new System.Drawing.Point(85, 377);
            this.lbrong.Name = "lbrong";
            this.lbrong.Size = new System.Drawing.Size(18, 16);
            this.lbrong.TabIndex = 18;
            this.lbrong.Text = "cr";
            // 
            // btnchuvi
            // 
            this.btnchuvi.Location = new System.Drawing.Point(239, 449);
            this.btnchuvi.Name = "btnchuvi";
            this.btnchuvi.Size = new System.Drawing.Size(91, 42);
            this.btnchuvi.TabIndex = 19;
            this.btnchuvi.Text = "Chuvi";
            this.btnchuvi.UseVisualStyleBackColor = true;
            this.btnchuvi.Click += new System.EventHandler(this.btnchuvi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 59);
            this.button1.TabIndex = 20;
            this.button1.Text = "text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // radvang
            // 
            this.radvang.AutoSize = true;
            this.radvang.Location = new System.Drawing.Point(491, 253);
            this.radvang.Name = "radvang";
            this.radvang.Size = new System.Drawing.Size(60, 20);
            this.radvang.TabIndex = 21;
            this.radvang.Text = "Vàng";
            this.radvang.UseVisualStyleBackColor = true;
            // 
            // raddo
            // 
            this.raddo.AutoSize = true;
            this.raddo.Location = new System.Drawing.Point(491, 296);
            this.raddo.Name = "raddo";
            this.raddo.Size = new System.Drawing.Size(45, 20);
            this.raddo.TabIndex = 22;
            this.raddo.Text = "Đỏ";
            this.raddo.UseVisualStyleBackColor = true;
            // 
            // radden
            // 
            this.radden.AutoSize = true;
            this.radden.Location = new System.Drawing.Point(491, 341);
            this.radden.Name = "radden";
            this.radden.Size = new System.Drawing.Size(52, 20);
            this.radden.TabIndex = 23;
            this.radden.Text = "Đen";
            this.radden.UseVisualStyleBackColor = true;
            // 
            // picbox
            // 
            this.picbox.BackColor = System.Drawing.Color.Yellow;
            this.picbox.Location = new System.Drawing.Point(609, 253);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(130, 114);
            this.picbox.TabIndex = 24;
            this.picbox.TabStop = false;
            // 
            // radga
            // 
            this.radga.AutoSize = true;
            this.radga.Location = new System.Drawing.Point(803, 78);
            this.radga.Name = "radga";
            this.radga.Size = new System.Drawing.Size(44, 20);
            this.radga.TabIndex = 25;
            this.radga.Text = "gà";
            this.radga.UseVisualStyleBackColor = true;
            this.radga.CheckedChanged += new System.EventHandler(this.radga_CheckedChanged);
            // 
            // radca
            // 
            this.radca.AutoSize = true;
            this.radca.Location = new System.Drawing.Point(803, 145);
            this.radca.Name = "radca";
            this.radca.Size = new System.Drawing.Size(43, 20);
            this.radca.TabIndex = 26;
            this.radca.Text = "cá";
            this.radca.UseVisualStyleBackColor = true;
            this.radca.CheckedChanged += new System.EventHandler(this.radca_CheckedChanged);
            // 
            // radmuc
            // 
            this.radmuc.AutoSize = true;
            this.radmuc.Location = new System.Drawing.Point(803, 207);
            this.radmuc.Name = "radmuc";
            this.radmuc.Size = new System.Drawing.Size(53, 20);
            this.radmuc.TabIndex = 27;
            this.radmuc.Text = "mực";
            this.radmuc.UseVisualStyleBackColor = true;
            this.radmuc.CheckedChanged += new System.EventHandler(this.radmuc_CheckedChanged);
            // 
            // picture_food
            // 
            this.picture_food.Location = new System.Drawing.Point(952, 76);
            this.picture_food.Name = "picture_food";
            this.picture_food.Size = new System.Drawing.Size(121, 117);
            this.picture_food.TabIndex = 28;
            this.picture_food.TabStop = false;
            // 
            // giaca
            // 
            this.giaca.AutoSize = true;
            this.giaca.Location = new System.Drawing.Point(973, 209);
            this.giaca.Name = "giaca";
            this.giaca.Size = new System.Drawing.Size(44, 16);
            this.giaca.TabIndex = 29;
            this.giaca.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 549);
            this.Controls.Add(this.giaca);
            this.Controls.Add(this.picture_food);
            this.Controls.Add(this.radmuc);
            this.Controls.Add(this.radca);
            this.Controls.Add(this.radga);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.radden);
            this.Controls.Add(this.raddo);
            this.Controls.Add(this.radvang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnchuvi);
            this.Controls.Add(this.lbrong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtrong);
            this.Controls.Add(this.txtdai);
            this.Controls.Add(this.btndientich);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.btntru);
            this.Controls.Add(this.btnnhan);
            this.Controls.Add(this.btnchia);
            this.Controls.Add(this.btncong);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtht);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtht;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Button btncong;
        private System.Windows.Forms.Button btnchia;
        private System.Windows.Forms.Button btnnhan;
        private System.Windows.Forms.Button btntru;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.TextBox ketqua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btndientich;
        private System.Windows.Forms.TextBox txtdai;
        private System.Windows.Forms.TextBox txtrong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbrong;
        private System.Windows.Forms.Button btnchuvi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radvang;
        private System.Windows.Forms.RadioButton raddo;
        private System.Windows.Forms.RadioButton radden;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.RadioButton radga;
        private System.Windows.Forms.RadioButton radca;
        private System.Windows.Forms.RadioButton radmuc;
        private System.Windows.Forms.PictureBox picture_food;
        private System.Windows.Forms.Label giaca;
    }
}

