namespace WindowsFormsApplication1
{
    partial class KitapIslemleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapIslemleri));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_kitapBaskiYil = new System.Windows.Forms.TextBox();
            this.tb_KitapSaySayi = new System.Windows.Forms.TextBox();
            this.tb_kitapYazar = new System.Windows.Forms.TextBox();
            this.tb_kitapAd = new System.Windows.Forms.TextBox();
            this.tb_kitapNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_kitapSil = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 258);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tb_kitapBaskiYil);
            this.groupBox1.Controls.Add(this.tb_KitapSaySayi);
            this.groupBox1.Controls.Add(this.tb_kitapYazar);
            this.groupBox1.Controls.Add(this.tb_kitapAd);
            this.groupBox1.Controls.Add(this.tb_kitapNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 312);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Güncelleme :";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(289, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 115);
            this.button1.TabIndex = 10;
            this.button1.Text = "Kitap Güncelle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_kitapBaskiYil
            // 
            this.tb_kitapBaskiYil.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kitapBaskiYil.Location = new System.Drawing.Point(453, 44);
            this.tb_kitapBaskiYil.Name = "tb_kitapBaskiYil";
            this.tb_kitapBaskiYil.Size = new System.Drawing.Size(100, 29);
            this.tb_kitapBaskiYil.TabIndex = 9;
            this.tb_kitapBaskiYil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_kitapBaskiYil_KeyPress);
            // 
            // tb_KitapSaySayi
            // 
            this.tb_KitapSaySayi.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_KitapSaySayi.Location = new System.Drawing.Point(453, 101);
            this.tb_KitapSaySayi.Name = "tb_KitapSaySayi";
            this.tb_KitapSaySayi.Size = new System.Drawing.Size(100, 29);
            this.tb_KitapSaySayi.TabIndex = 8;
            this.tb_KitapSaySayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KitapSaySayi_KeyPress);
            // 
            // tb_kitapYazar
            // 
            this.tb_kitapYazar.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kitapYazar.Location = new System.Drawing.Point(164, 155);
            this.tb_kitapYazar.Name = "tb_kitapYazar";
            this.tb_kitapYazar.Size = new System.Drawing.Size(100, 29);
            this.tb_kitapYazar.TabIndex = 7;
            this.tb_kitapYazar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_kitapYazar_KeyPress);
            // 
            // tb_kitapAd
            // 
            this.tb_kitapAd.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kitapAd.Location = new System.Drawing.Point(131, 98);
            this.tb_kitapAd.Name = "tb_kitapAd";
            this.tb_kitapAd.Size = new System.Drawing.Size(100, 29);
            this.tb_kitapAd.TabIndex = 6;
            // 
            // tb_kitapNo
            // 
            this.tb_kitapNo.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kitapNo.Location = new System.Drawing.Point(131, 44);
            this.tb_kitapNo.Name = "tb_kitapNo";
            this.tb_kitapNo.ReadOnly = true;
            this.tb_kitapNo.Size = new System.Drawing.Size(100, 29);
            this.tb_kitapNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kitap Sayfa Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kitap Baskı Yılı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap Yazarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_kitapSil);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(623, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 219);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Silme :";
            // 
            // tb_kitapSil
            // 
            this.tb_kitapSil.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kitapSil.Location = new System.Drawing.Point(129, 61);
            this.tb_kitapSil.Name = "tb_kitapSil";
            this.tb_kitapSil.Size = new System.Drawing.Size(214, 29);
            this.tb_kitapSil.TabIndex = 5;
            this.tb_kitapSil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_kitapSil_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(476, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Silmek İstediğiniz Kitabın Numarasını Giriniz:";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(145, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 99);
            this.button3.TabIndex = 3;
            this.button3.Text = "Kitap Sil";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(844, 502);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(228, 99);
            this.button4.TabIndex = 4;
            this.button4.Text = "Ana Menü";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(623, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 99);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kitap Ekle";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KitapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1153, 613);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KitapIslemleri";
            this.Text = "KitapIslemleri";
            this.Activated += new System.EventHandler(this.KitapIslemleri_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KitapIslemleri_FormClosing);
            this.Load += new System.EventHandler(this.KitapIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_kitapBaskiYil;
        private System.Windows.Forms.TextBox tb_KitapSaySayi;
        private System.Windows.Forms.TextBox tb_kitapYazar;
        private System.Windows.Forms.TextBox tb_kitapAd;
        private System.Windows.Forms.TextBox tb_kitapNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_kitapSil;
        private System.Windows.Forms.Label label6;
    }
}