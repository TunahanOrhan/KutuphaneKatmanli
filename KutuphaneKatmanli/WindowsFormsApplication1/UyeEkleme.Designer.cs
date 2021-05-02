namespace WindowsFormsApplication1
{
    partial class UyeEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeEkleme));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_uyeEkleAd = new System.Windows.Forms.TextBox();
            this.tb_uyeEkleSoyad = new System.Windows.Forms.TextBox();
            this.tb_uyeEkleTel = new System.Windows.Forms.MaskedTextBox();
            this.tb_uyeEkleMail = new System.Windows.Forms.TextBox();
            this.tb_uyeEkleAdres = new System.Windows.Forms.TextBox();
            this.tb_uyeEkleTc = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "TC Kimlik No:";
            // 
            // tb_uyeEkleAd
            // 
            this.tb_uyeEkleAd.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_uyeEkleAd.Location = new System.Drawing.Point(234, 26);
            this.tb_uyeEkleAd.Name = "tb_uyeEkleAd";
            this.tb_uyeEkleAd.Size = new System.Drawing.Size(163, 29);
            this.tb_uyeEkleAd.TabIndex = 6;
            this.tb_uyeEkleAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_uyeEkleAd_KeyPress);
            // 
            // tb_uyeEkleSoyad
            // 
            this.tb_uyeEkleSoyad.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_uyeEkleSoyad.Location = new System.Drawing.Point(234, 73);
            this.tb_uyeEkleSoyad.Name = "tb_uyeEkleSoyad";
            this.tb_uyeEkleSoyad.Size = new System.Drawing.Size(163, 29);
            this.tb_uyeEkleSoyad.TabIndex = 7;
            this.tb_uyeEkleSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_uyeEkleSoyad_KeyPress);
            // 
            // tb_uyeEkleTel
            // 
            this.tb_uyeEkleTel.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_uyeEkleTel.Location = new System.Drawing.Point(234, 118);
            this.tb_uyeEkleTel.Mask = "(999) 000-0000";
            this.tb_uyeEkleTel.Name = "tb_uyeEkleTel";
            this.tb_uyeEkleTel.Size = new System.Drawing.Size(163, 29);
            this.tb_uyeEkleTel.TabIndex = 8;
            this.tb_uyeEkleTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_uyeEkleTel_KeyPress);
            // 
            // tb_uyeEkleMail
            // 
            this.tb_uyeEkleMail.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_uyeEkleMail.Location = new System.Drawing.Point(234, 163);
            this.tb_uyeEkleMail.Name = "tb_uyeEkleMail";
            this.tb_uyeEkleMail.Size = new System.Drawing.Size(163, 29);
            this.tb_uyeEkleMail.TabIndex = 9;
            // 
            // tb_uyeEkleAdres
            // 
            this.tb_uyeEkleAdres.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_uyeEkleAdres.Location = new System.Drawing.Point(234, 208);
            this.tb_uyeEkleAdres.Name = "tb_uyeEkleAdres";
            this.tb_uyeEkleAdres.Size = new System.Drawing.Size(163, 29);
            this.tb_uyeEkleAdres.TabIndex = 10;
            // 
            // tb_uyeEkleTc
            // 
            this.tb_uyeEkleTc.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_uyeEkleTc.Location = new System.Drawing.Point(234, 258);
            this.tb_uyeEkleTc.Mask = "00000000000";
            this.tb_uyeEkleTc.Name = "tb_uyeEkleTc";
            this.tb_uyeEkleTc.Size = new System.Drawing.Size(163, 29);
            this.tb_uyeEkleTc.TabIndex = 11;
            this.tb_uyeEkleTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_uyeEkleTc_KeyPress);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(120, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 100);
            this.button1.TabIndex = 12;
            this.button1.Text = "Üyeyi Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UyeEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(470, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_uyeEkleTc);
            this.Controls.Add(this.tb_uyeEkleAdres);
            this.Controls.Add(this.tb_uyeEkleMail);
            this.Controls.Add(this.tb_uyeEkleTel);
            this.Controls.Add(this.tb_uyeEkleSoyad);
            this.Controls.Add(this.tb_uyeEkleAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UyeEkleme";
            this.Text = "Üye Ekleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UyeEkleme_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_uyeEkleAd;
        private System.Windows.Forms.TextBox tb_uyeEkleSoyad;
        private System.Windows.Forms.MaskedTextBox tb_uyeEkleTel;
        private System.Windows.Forms.TextBox tb_uyeEkleMail;
        private System.Windows.Forms.TextBox tb_uyeEkleAdres;
        private System.Windows.Forms.MaskedTextBox tb_uyeEkleTc;
        private System.Windows.Forms.Button button1;
    }
}