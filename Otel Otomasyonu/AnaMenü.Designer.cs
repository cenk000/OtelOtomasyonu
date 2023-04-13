namespace Otel_Otomasyonu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OdaK = new System.Windows.Forms.ToolStripButton();
            this.Odalarlist = new System.Windows.Forms.ToolStripButton();
            this.MusList = new System.Windows.Forms.ToolStripButton();
            this.PerKayit = new System.Windows.Forms.ToolStripButton();
            this.YH = new System.Windows.Forms.ToolStripButton();
            this.GG = new System.Windows.Forms.ToolStripButton();
            this.YP = new System.Windows.Forms.ToolStripButton();
            this.Cikis = new System.Windows.Forms.ToolStripButton();
            this.Hak = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.ToolStripLabel();
            this.time1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gray;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OdaK,
            this.Odalarlist,
            this.MusList,
            this.PerKayit,
            this.YH,
            this.GG,
            this.YP,
            this.Cikis,
            this.Hak});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(61, 679);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // OdaK
            // 
            this.OdaK.AutoSize = false;
            this.OdaK.BackColor = System.Drawing.Color.Transparent;
            this.OdaK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OdaK.BackgroundImage")));
            this.OdaK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OdaK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OdaK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OdaK.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.OdaK.Name = "OdaK";
            this.OdaK.Size = new System.Drawing.Size(60, 60);
            this.OdaK.Text = "Oda Kayıt";
            this.OdaK.Click += new System.EventHandler(this.OdaK_Click);
            // 
            // Odalarlist
            // 
            this.Odalarlist.AutoSize = false;
            this.Odalarlist.BackColor = System.Drawing.Color.Transparent;
            this.Odalarlist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Odalarlist.BackgroundImage")));
            this.Odalarlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Odalarlist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Odalarlist.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Odalarlist.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Odalarlist.Name = "Odalarlist";
            this.Odalarlist.Size = new System.Drawing.Size(60, 60);
            this.Odalarlist.Text = "Oda Bilgisi";
            this.Odalarlist.Click += new System.EventHandler(this.Odalarlist_Click);
            // 
            // MusList
            // 
            this.MusList.AutoSize = false;
            this.MusList.BackColor = System.Drawing.Color.Transparent;
            this.MusList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MusList.BackgroundImage")));
            this.MusList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MusList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MusList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MusList.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.MusList.Name = "MusList";
            this.MusList.Size = new System.Drawing.Size(60, 60);
            this.MusList.Text = "Müşteri Listesi";
            this.MusList.Click += new System.EventHandler(this.MusList_Click);
            // 
            // PerKayit
            // 
            this.PerKayit.AutoSize = false;
            this.PerKayit.BackColor = System.Drawing.Color.Transparent;
            this.PerKayit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PerKayit.BackgroundImage")));
            this.PerKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PerKayit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PerKayit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PerKayit.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.PerKayit.Name = "PerKayit";
            this.PerKayit.Size = new System.Drawing.Size(60, 60);
            this.PerKayit.Text = "PersonelKayıt";
            this.PerKayit.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // YH
            // 
            this.YH.AutoSize = false;
            this.YH.BackColor = System.Drawing.Color.Transparent;
            this.YH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("YH.BackgroundImage")));
            this.YH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.YH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.YH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.YH.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.YH.Name = "YH";
            this.YH.Size = new System.Drawing.Size(60, 60);
            this.YH.Text = "Stok";
            this.YH.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // GG
            // 
            this.GG.AutoSize = false;
            this.GG.BackColor = System.Drawing.Color.Transparent;
            this.GG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GG.BackgroundImage")));
            this.GG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GG.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GG.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.GG.Name = "GG";
            this.GG.Size = new System.Drawing.Size(60, 60);
            this.GG.Text = "Gelir-Gider";
            this.GG.Click += new System.EventHandler(this.GG_Click);
            // 
            // YP
            // 
            this.YP.AutoSize = false;
            this.YP.BackColor = System.Drawing.Color.Transparent;
            this.YP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("YP.BackgroundImage")));
            this.YP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.YP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.YP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.YP.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.YP.Name = "YP";
            this.YP.Size = new System.Drawing.Size(60, 60);
            this.YP.Text = "Yönetici Paneli";
            this.YP.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // Cikis
            // 
            this.Cikis.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Cikis.AutoSize = false;
            this.Cikis.BackColor = System.Drawing.Color.Transparent;
            this.Cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cikis.BackgroundImage")));
            this.Cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cikis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cikis.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Cikis.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(60, 60);
            this.Cikis.Text = "ÇIKIŞ";
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // Hak
            // 
            this.Hak.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Hak.AutoSize = false;
            this.Hak.BackColor = System.Drawing.Color.Transparent;
            this.Hak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Hak.BackgroundImage")));
            this.Hak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Hak.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Hak.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Hak.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Hak.Name = "Hak";
            this.Hak.Size = new System.Drawing.Size(60, 60);
            this.Hak.Text = "Hakkında";
            this.Hak.Click += new System.EventHandler(this.Hak_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(157, 28);
            this.time.Text = "toolStripLabel1";
            this.time.Click += new System.EventHandler(this.time_Click);
            // 
            // time1
            // 
            this.time1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(157, 28);
            this.time1.Text = "toolStripLabel2";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Gray;
            this.toolStrip2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip2.BackgroundImage")));
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.time,
            this.time1});
            this.toolStrip2.Location = new System.Drawing.Point(61, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip2.Size = new System.Drawing.Size(1406, 31);
            this.toolStrip2.TabIndex = 18;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1467, 679);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Otel Otomasyonu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton PerKayit;
        private System.Windows.Forms.ToolStripButton MusList;
        private System.Windows.Forms.ToolStripButton OdaK;
        private System.Windows.Forms.ToolStripButton YH;
        private System.Windows.Forms.ToolStripButton YP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton GG;
        private System.Windows.Forms.ToolStripButton Odalarlist;
        private System.Windows.Forms.ToolStripButton Cikis;
        private System.Windows.Forms.ToolStripButton Hak;
        private System.Windows.Forms.ToolStripLabel time;
        private System.Windows.Forms.ToolStripLabel time1;
        private System.Windows.Forms.ToolStrip toolStrip2;
    }
}