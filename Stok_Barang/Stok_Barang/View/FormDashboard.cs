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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void btnDaftarBarang_Click(object sender, EventArgs e)
        {
            FormDaftarStock daftarStockForm = new FormDaftarStock();
            daftarStockForm.Show();
        }
        private void btnRekapBarangMasuk_Click(object sender, EventArgs e)
        {
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
        }
    }
}
