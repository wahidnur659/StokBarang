using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Barang
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string idKaryawan = txtIDKaryawan.Text;
            string password = txtPassword.Text;

            // Simulasi validasi login
            if (idKaryawan == "admin" && password == "12345")
            {
                MessageBox.Show("Login Berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Buka form Rekap Barang
                FormRekapBarang rekapBarangForm = new FormRekapBarang();
                rekapBarangForm.Show();
                this.Close(); // Menutup form login
            }
            else
            {
                // Login gagal
                MessageBox.Show("ID Karyawan atau Password salah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
