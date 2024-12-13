namespace Stok_Barang
{
    partial class FormDaftarStock
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
            this.Tambah = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCariBarang = new System.Windows.Forms.Button();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtExpired = new System.Windows.Forms.TextBox();
            this.txtTanggalMasuk = new System.Windows.Forms.TextBox();
            this.txtHargaSatuan = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.textJumlahBarang = new System.Windows.Forms.TextBox();
            this.txtNamaSuplier = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtIDBarang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnReset1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnHapus = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset3 = new System.Windows.Forms.Button();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Tambah.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tambah
            // 
            this.Tambah.Controls.Add(this.tabPage4);
            this.Tambah.Controls.Add(this.tabPage1);
            this.Tambah.Controls.Add(this.tabPage2);
            this.Tambah.Controls.Add(this.tabPage3);
            this.Tambah.Location = new System.Drawing.Point(6, 54);
            this.Tambah.Name = "Tambah";
            this.Tambah.SelectedIndex = 0;
            this.Tambah.Size = new System.Drawing.Size(972, 571);
            this.Tambah.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnCariBarang);
            this.tabPage4.Controls.Add(this.textBox16);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.listView1);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(964, 538);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Daftar Barang";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCariBarang
            // 
            this.btnCariBarang.Location = new System.Drawing.Point(116, 48);
            this.btnCariBarang.Name = "btnCariBarang";
            this.btnCariBarang.Size = new System.Drawing.Size(110, 37);
            this.btnCariBarang.TabIndex = 3;
            this.btnCariBarang.Text = "Cari Barang";
            this.btnCariBarang.UseVisualStyleBackColor = true;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(116, 13);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(110, 29);
            this.textBox16.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 20);
            this.label19.TabIndex = 5;
            this.label19.Text = "ID_BARANG";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 111);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(940, 413);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "DAFTAR BARANG";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtExpired);
            this.tabPage1.Controls.Add(this.txtTanggalMasuk);
            this.tabPage1.Controls.Add(this.txtHargaSatuan);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.btnTambah);
            this.tabPage1.Controls.Add(this.textJumlahBarang);
            this.tabPage1.Controls.Add(this.txtNamaSuplier);
            this.tabPage1.Controls.Add(this.txtNamaBarang);
            this.tabPage1.Controls.Add(this.txtIDBarang);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.BtnReset1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(964, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tambah";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtExpired
            // 
            this.txtExpired.Location = new System.Drawing.Point(202, 289);
            this.txtExpired.Multiline = true;
            this.txtExpired.Name = "txtExpired";
            this.txtExpired.Size = new System.Drawing.Size(183, 26);
            this.txtExpired.TabIndex = 27;
            // 
            // txtTanggalMasuk
            // 
            this.txtTanggalMasuk.Location = new System.Drawing.Point(202, 249);
            this.txtTanggalMasuk.Multiline = true;
            this.txtTanggalMasuk.Name = "txtTanggalMasuk";
            this.txtTanggalMasuk.Size = new System.Drawing.Size(183, 26);
            this.txtTanggalMasuk.TabIndex = 26;
            // 
            // txtHargaSatuan
            // 
            this.txtHargaSatuan.Location = new System.Drawing.Point(202, 205);
            this.txtHargaSatuan.Multiline = true;
            this.txtHargaSatuan.Name = "txtHargaSatuan";
            this.txtHargaSatuan.Size = new System.Drawing.Size(183, 26);
            this.txtHargaSatuan.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(35, 292);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 20);
            this.label18.TabIndex = 24;
            this.label18.Text = "EXPIRED";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(35, 252);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(147, 20);
            this.label17.TabIndex = 23;
            this.label17.Text = "TANGGAL MASUK";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 211);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "HARGA SATUAN";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(202, 346);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(85, 40);
            this.btnTambah.TabIndex = 21;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // textJumlahBarang
            // 
            this.textJumlahBarang.Location = new System.Drawing.Point(202, 163);
            this.textJumlahBarang.Multiline = true;
            this.textJumlahBarang.Name = "textJumlahBarang";
            this.textJumlahBarang.Size = new System.Drawing.Size(183, 26);
            this.textJumlahBarang.TabIndex = 20;
            // 
            // txtNamaSuplier
            // 
            this.txtNamaSuplier.Location = new System.Drawing.Point(202, 120);
            this.txtNamaSuplier.Multiline = true;
            this.txtNamaSuplier.Name = "txtNamaSuplier";
            this.txtNamaSuplier.Size = new System.Drawing.Size(183, 26);
            this.txtNamaSuplier.TabIndex = 19;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(202, 75);
            this.txtNamaBarang.Multiline = true;
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(183, 26);
            this.txtNamaBarang.TabIndex = 18;
            // 
            // txtIDBarang
            // 
            this.txtIDBarang.Location = new System.Drawing.Point(202, 32);
            this.txtIDBarang.Multiline = true;
            this.txtIDBarang.Name = "txtIDBarang";
            this.txtIDBarang.Size = new System.Drawing.Size(85, 26);
            this.txtIDBarang.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "JUMLAH BARANG";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "NAMA SUPLIER";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "NAMA BARANG";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "ID_BARANG";
            // 
            // BtnReset1
            // 
            this.BtnReset1.Location = new System.Drawing.Point(301, 346);
            this.BtnReset1.Name = "BtnReset1";
            this.BtnReset1.Size = new System.Drawing.Size(84, 40);
            this.BtnReset1.TabIndex = 12;
            this.BtnReset1.Text = "Reset";
            this.BtnReset1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox17);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btnReset2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(964, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(207, 219);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(174, 26);
            this.textBox17.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 219);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 20);
            this.label15.TabIndex = 22;
            this.label15.Text = "HARGA SATUAN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(207, 176);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(174, 26);
            this.textBox5.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(207, 133);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(174, 26);
            this.textBox6.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(207, 88);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(174, 26);
            this.textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(207, 39);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(75, 26);
            this.textBox8.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "JUMLAH BARANG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "NAMA SUPLIER";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "NAMA BARANG";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "ID_BARANG";
            // 
            // btnReset2
            // 
            this.btnReset2.Location = new System.Drawing.Point(306, 270);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(75, 35);
            this.btnReset2.TabIndex = 12;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnHapus);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.btnReset3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(964, 538);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hapus";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(203, 238);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 36);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(203, 180);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(174, 26);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(203, 137);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 26);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 92);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 26);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 26);
            this.textBox1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "TANGGAL MASUK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "NAMA SUPLIER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "NAMA BARANG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID_BARANG";
            // 
            // btnReset3
            // 
            this.btnReset3.Location = new System.Drawing.Point(302, 238);
            this.btnReset3.Name = "btnReset3";
            this.btnReset3.Size = new System.Drawing.Size(75, 36);
            this.btnReset3.TabIndex = 1;
            this.btnReset3.Text = "Reset";
            this.btnReset3.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(135, 12);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(99, 36);
            this.btnTampilkan.TabIndex = 1;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Daftar Barang";
            // 
            // FormDaftarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 629);
            this.Controls.Add(this.Tambah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTampilkan);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDaftarStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daftar Stock Gudang";
            this.Tambah.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tambah;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox textJumlahBarang;
        private System.Windows.Forms.TextBox txtNamaSuplier;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtIDBarang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnReset1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.TextBox txtExpired;
        private System.Windows.Forms.TextBox txtTanggalMasuk;
        private System.Windows.Forms.TextBox txtHargaSatuan;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCariBarang;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label15;
    }
}