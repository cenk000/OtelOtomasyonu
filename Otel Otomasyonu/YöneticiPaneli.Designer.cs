namespace Otel_Otomasyonu
{
    partial class YöneticiPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YöneticiPaneli));
            this.YP = new System.Windows.Forms.DataGridView();
            this.EKLE = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.SIL = new System.Windows.Forms.Button();
            this.AD = new System.Windows.Forms.TextBox();
            this.SOYAD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.YP)).BeginInit();
            this.SuspendLayout();
            // 
            // YP
            // 
            this.YP.AllowUserToAddRows = false;
            this.YP.AllowUserToDeleteRows = false;
            this.YP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.YP.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.YP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.YP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.YP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YP.Location = new System.Drawing.Point(12, 230);
            this.YP.Name = "YP";
            this.YP.ReadOnly = true;
            this.YP.Size = new System.Drawing.Size(776, 153);
            this.YP.TabIndex = 0;
            this.YP.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.YP_CellEnter);
            // 
            // EKLE
            // 
            this.EKLE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EKLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EKLE.Location = new System.Drawing.Point(404, 175);
            this.EKLE.Name = "EKLE";
            this.EKLE.Size = new System.Drawing.Size(124, 49);
            this.EKLE.TabIndex = 1;
            this.EKLE.Text = "Ekle";
            this.EKLE.UseVisualStyleBackColor = false;
            this.EKLE.Click += new System.EventHandler(this.EKLE_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UPDATE.Location = new System.Drawing.Point(534, 175);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(124, 49);
            this.UPDATE.TabIndex = 2;
            this.UPDATE.Text = "Güncelle";
            this.UPDATE.UseVisualStyleBackColor = false;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // SIL
            // 
            this.SIL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SIL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SIL.Location = new System.Drawing.Point(664, 175);
            this.SIL.Name = "SIL";
            this.SIL.Size = new System.Drawing.Size(124, 49);
            this.SIL.TabIndex = 3;
            this.SIL.Text = "Sil";
            this.SIL.UseVisualStyleBackColor = false;
            this.SIL.Click += new System.EventHandler(this.SIL_Click);
            // 
            // AD
            // 
            this.AD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AD.Location = new System.Drawing.Point(12, 110);
            this.AD.Name = "AD";
            this.AD.Size = new System.Drawing.Size(206, 30);
            this.AD.TabIndex = 4;
            // 
            // SOYAD
            // 
            this.SOYAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SOYAD.Location = new System.Drawing.Point(12, 175);
            this.SOYAD.Name = "SOYAD";
            this.SOYAD.Size = new System.Drawing.Size(206, 30);
            this.SOYAD.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kullanıcı Şifre";
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID.Location = new System.Drawing.Point(15, 23);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(206, 30);
            this.ID.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(664, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YöneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SOYAD);
            this.Controls.Add(this.AD);
            this.Controls.Add(this.SIL);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.EKLE);
            this.Controls.Add(this.YP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YöneticiPaneli";
            this.Text = "YöneticiPaneli";
            this.Load += new System.EventHandler(this.YöneticiPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView YP;
        private System.Windows.Forms.Button EKLE;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button SIL;
        private System.Windows.Forms.TextBox AD;
        private System.Windows.Forms.TextBox SOYAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}