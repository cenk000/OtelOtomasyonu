namespace Otel_Otomasyonu
{
    partial class Personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel));
            this.Ad = new System.Windows.Forms.TextBox();
            this.Soyad = new System.Windows.Forms.TextBox();
            this.TC = new System.Windows.Forms.TextBox();
            this.Ptablo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.Ekle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Cikis = new System.Windows.Forms.Button();
            this.Dtarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Cinsiyet = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ptablo)).BeginInit();
            this.SuspendLayout();
            // 
            // Ad
            // 
            this.Ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ad.Location = new System.Drawing.Point(12, 73);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(153, 30);
            this.Ad.TabIndex = 0;
            // 
            // Soyad
            // 
            this.Soyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Soyad.Location = new System.Drawing.Point(13, 109);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(153, 30);
            this.Soyad.TabIndex = 1;
            // 
            // TC
            // 
            this.TC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TC.Location = new System.Drawing.Point(12, 181);
            this.TC.MaxLength = 11;
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(153, 30);
            this.TC.TabIndex = 3;
            this.TC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TC_KeyPress);
            // 
            // Ptablo
            // 
            this.Ptablo.AllowUserToAddRows = false;
            this.Ptablo.AllowUserToDeleteRows = false;
            this.Ptablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Ptablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ptablo.Location = new System.Drawing.Point(307, 12);
            this.Ptablo.Name = "Ptablo";
            this.Ptablo.ReadOnly = true;
            this.Ptablo.Size = new System.Drawing.Size(585, 326);
            this.Ptablo.TabIndex = 4;
            this.Ptablo.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Ptablo_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(171, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(172, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(172, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cinsiyeti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(171, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "T.C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(172, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "E-Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(172, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefon";
            // 
            // mail
            // 
            this.mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mail.Location = new System.Drawing.Point(13, 253);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(153, 30);
            this.mail.TabIndex = 10;
            // 
            // Ekle
            // 
            this.Ekle.BackColor = System.Drawing.Color.Transparent;
            this.Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ekle.Location = new System.Drawing.Point(13, 392);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(104, 51);
            this.Ekle.TabIndex = 13;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = false;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // Sil
            // 
            this.Sil.BackColor = System.Drawing.Color.Transparent;
            this.Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sil.Location = new System.Drawing.Point(123, 392);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(104, 51);
            this.Sil.TabIndex = 14;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = false;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Transparent;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Location = new System.Drawing.Point(233, 392);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(104, 51);
            this.Update.TabIndex = 15;
            this.Update.Text = "Güncelle";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.Transparent;
            this.Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cikis.Location = new System.Drawing.Point(788, 392);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(104, 51);
            this.Cikis.TabIndex = 17;
            this.Cikis.Text = "Çıkış";
            this.Cikis.UseVisualStyleBackColor = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // Dtarihi
            // 
            this.Dtarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Dtarihi.Location = new System.Drawing.Point(12, 289);
            this.Dtarihi.Name = "Dtarihi";
            this.Dtarihi.Size = new System.Drawing.Size(154, 30);
            this.Dtarihi.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(172, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Doğum Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(171, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Id";
            this.label8.Visible = false;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cinsiyet.FormattingEnabled = true;
            this.Cinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.Cinsiyet.Location = new System.Drawing.Point(13, 142);
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.Size = new System.Drawing.Size(152, 33);
            this.Cinsiyet.TabIndex = 22;
            // 
            // Id
            // 
            this.Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Id.Enabled = false;
            this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Id.Location = new System.Drawing.Point(12, 37);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(153, 30);
            this.Id.TabIndex = 20;
            this.Id.Visible = false;
            // 
            // Tel
            // 
            this.Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tel.Location = new System.Drawing.Point(12, 217);
            this.Tel.Mask = "(999) 000-0000";
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(152, 30);
            this.Tel.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 51);
            this.button1.TabIndex = 25;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 455);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.Cinsiyet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Dtarihi);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ptablo);
            this.Controls.Add(this.TC);
            this.Controls.Add(this.Soyad);
            this.Controls.Add(this.Ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Personel";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ptablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.TextBox Soyad;
        private System.Windows.Forms.TextBox TC;
        private System.Windows.Forms.DataGridView Ptablo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Cikis;
        private System.Windows.Forms.DateTimePicker Dtarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Cinsiyet;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.MaskedTextBox Tel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}