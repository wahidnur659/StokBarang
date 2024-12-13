namespace Stok_Barang
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnDaftarBarang = new System.Windows.Forms.Button();
            this.btnRekapBarangMasuk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 667);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(264, 131);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(430, 410);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnDaftarBarang
            // 
            this.btnDaftarBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDaftarBarang.Location = new System.Drawing.Point(389, 282);
            this.btnDaftarBarang.Name = "btnDaftarBarang";
            this.btnDaftarBarang.Size = new System.Drawing.Size(179, 58);
            this.btnDaftarBarang.TabIndex = 2;
            this.btnDaftarBarang.Text = "Daftar Barang";
            this.btnDaftarBarang.UseVisualStyleBackColor = true;
            this.btnDaftarBarang.Click += new System.EventHandler(this.btnDaftarBarang_Click);
            // 
            // btnRekapBarangMasuk
            // 
            this.btnRekapBarangMasuk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRekapBarangMasuk.Location = new System.Drawing.Point(389, 375);
            this.btnRekapBarangMasuk.Name = "btnRekapBarangMasuk";
            this.btnRekapBarangMasuk.Size = new System.Drawing.Size(179, 58);
            this.btnRekapBarangMasuk.TabIndex = 4;
            this.btnRekapBarangMasuk.Text = "Rekap Barang Masuk";
            this.btnRekapBarangMasuk.UseVisualStyleBackColor = true;
            this.btnRekapBarangMasuk.Click += new System.EventHandler(this.btnRekapBarangMasuk_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "Stok Gudang Sejahtera";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRekapBarangMasuk);
            this.Controls.Add(this.btnDaftarBarang);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormDashboard";
            this.Text = "Dashboard Gudang";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnDaftarBarang;
        private System.Windows.Forms.Button btnRekapBarangMasuk;
        private System.Windows.Forms.Label label1;
    }
}

