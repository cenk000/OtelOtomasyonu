namespace Otel_Otomasyonu
{
    partial class YH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YH));
            this.YP = new System.Windows.Forms.DataGridView();
            this.SIL = new System.Windows.Forms.Button();
            this.EKLE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.satis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.miktar = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.TF = new System.Windows.Forms.TextBox();
            this.Cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.YP)).BeginInit();
            this.SuspendLayout();
            // 
            // YP
            // 
            this.YP.AllowUserToAddRows = false;
            this.YP.AllowUserToDeleteRows = false;
            this.YP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.YP.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.YP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YP.Location = new System.Drawing.Point(8, 195);
            this.YP.Name = "YP";
            this.YP.ReadOnly = true;
            this.YP.Size = new System.Drawing.Size(776, 175);
            this.YP.TabIndex = 10;
            this.YP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.YP_CellContentClick);
            this.YP.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.YP_CellEnter);
            // 
            // SIL
            // 
            this.SIL.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SIL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SIL.Location = new System.Drawing.Point(510, 121);
            this.SIL.Name = "SIL";
            this.SIL.Size = new System.Drawing.Size(124, 49);
            this.SIL.TabIndex = 12;
            this.SIL.Text = "Sil";
            this.SIL.UseVisualStyleBackColor = false;
            this.SIL.Click += new System.EventHandler(this.SIL_Click);
            // 
            // EKLE
            // 
            this.EKLE.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.EKLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EKLE.Location = new System.Drawing.Point(380, 121);
            this.EKLE.Name = "EKLE";
            this.EKLE.Size = new System.Drawing.Size(124, 49);
            this.EKLE.TabIndex = 11;
            this.EKLE.Text = "Ekle";
            this.EKLE.UseVisualStyleBackColor = false;
            this.EKLE.Click += new System.EventHandler(this.EKLE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "İsim";
            // 
            // AD
            // 
            this.AD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AD.Location = new System.Drawing.Point(12, 85);
            this.AD.Name = "AD";
            this.AD.Size = new System.Drawing.Size(206, 30);
            this.AD.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(256, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fiyat";
            // 
            // fiyat
            // 
            this.fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyat.Location = new System.Drawing.Point(256, 23);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(206, 30);
            this.fiyat.TabIndex = 15;
            this.fiyat.TextChanged += new System.EventHandler(this.fiyat_TextChanged);
            this.fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fiyat_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID";
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id.Location = new System.Drawing.Point(12, 23);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(206, 30);
            this.id.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(256, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Satış";
            // 
            // satis
            // 
            this.satis.Enabled = false;
            this.satis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satis.Location = new System.Drawing.Point(256, 85);
            this.satis.Name = "satis";
            this.satis.Size = new System.Drawing.Size(206, 30);
            this.satis.TabIndex = 19;
            this.satis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.miktar_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(507, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Miktar";
            // 
            // miktar
            // 
            this.miktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.miktar.Location = new System.Drawing.Point(510, 23);
            this.miktar.Name = "miktar";
            this.miktar.Size = new System.Drawing.Size(206, 30);
            this.miktar.TabIndex = 23;
            this.miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.miktar_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(507, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Toplam Fiyat";
            // 
            // TF
            // 
            this.TF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TF.Location = new System.Drawing.Point(510, 85);
            this.TF.Name = "TF";
            this.TF.Size = new System.Drawing.Size(206, 30);
            this.TF.TabIndex = 25;
            this.TF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.miktar_KeyPress);
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.DarkGray;
            this.Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cikis.Location = new System.Drawing.Point(640, 121);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(121, 49);
            this.Cikis.TabIndex = 27;
            this.Cikis.Text = "Çıkış";
            this.Cikis.UseVisualStyleBackColor = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // YH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(792, 378);
            this.ControlBox = false;
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.miktar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.satis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AD);
            this.Controls.Add(this.SIL);
            this.Controls.Add(this.EKLE);
            this.Controls.Add(this.YP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YH";
            this.ShowIcon = false;
            this.Text = "Stok";
            this.Load += new System.EventHandler(this.YH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView YP;
        private System.Windows.Forms.Button SIL;
        private System.Windows.Forms.Button EKLE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox satis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox miktar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TF;
        private System.Windows.Forms.Button Cikis;
    }
}