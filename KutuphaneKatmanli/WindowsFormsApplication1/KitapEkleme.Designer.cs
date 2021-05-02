namespace WindowsFormsApplication1
{
    partial class KitapEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEkleme));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_kitapAd = new System.Windows.Forms.TextBox();
            this.tb_kitapYazar = new System.Windows.Forms.TextBox();
            this.tb_kitBasYıl = new System.Windows.Forms.TextBox();
            this.tb_kitSaySayi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Yazarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap Baskı Yılı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sayfa Sayısı:";
            // 
            // tb_kitapAd
            // 
            this.tb_kitapAd.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kitapAd.Location = new System.Drawing.Point(204, 47);
            this.tb_kitapAd.Name = "tb_kitapAd";
            this.tb_kitapAd.Size = new System.Drawing.Size(184, 29);
            this.tb_kitapAd.TabIndex = 4;
            // 
            // tb_kitapYazar
            // 
            this.tb_kitapYazar.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kitapYazar.Location = new System.Drawing.Point(204, 88);
            this.tb_kitapYazar.Name = "tb_kitapYazar";
            this.tb_kitapYazar.Size = new System.Drawing.Size(184, 29);
            this.tb_kitapYazar.TabIndex = 5;
            this.tb_kitapYazar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_kitapYazar_KeyPress);
            // 
            // tb_kitBasYıl
            // 
            this.tb_kitBasYıl.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kitBasYıl.Location = new System.Drawing.Point(204, 130);
            this.tb_kitBasYıl.Name = "tb_kitBasYıl";
            this.tb_kitBasYıl.Size = new System.Drawing.Size(184, 29);
            this.tb_kitBasYıl.TabIndex = 6;
            this.tb_kitBasYıl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_kitBasYıl_KeyPress);
            // 
            // tb_kitSaySayi
            // 
            this.tb_kitSaySayi.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kitSaySayi.Location = new System.Drawing.Point(204, 168);
            this.tb_kitSaySayi.Name = "tb_kitSaySayi";
            this.tb_kitSaySayi.Size = new System.Drawing.Size(184, 29);
            this.tb_kitSaySayi.TabIndex = 7;
            this.tb_kitSaySayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_kitSaySayi_KeyPress);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(94, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 108);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kitap Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KitapEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(439, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_kitSaySayi);
            this.Controls.Add(this.tb_kitBasYıl);
            this.Controls.Add(this.tb_kitapYazar);
            this.Controls.Add(this.tb_kitapAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KitapEkleme";
            this.Text = "KitapEkleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KitapEkleme_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_kitapAd;
        private System.Windows.Forms.TextBox tb_kitapYazar;
        private System.Windows.Forms.TextBox tb_kitBasYıl;
        private System.Windows.Forms.TextBox tb_kitSaySayi;
        private System.Windows.Forms.Button button1;
    }
}