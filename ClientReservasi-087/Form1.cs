using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientReservasi_087
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public Form1()
        {
            InitializeComponent();

            TampilData();
            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string IDPemesanan = tbID.Text;
            string NamaCustomer = tbNama.Text;
            string NoTelepon = tbNoTelepon.Text;
            int JumlahPemesanan = int.Parse(tbJumlah.Text);
            string IDLokasi = tbIDLokasi.Text;

            var a = service.pemesanan(IDPemesanan, NamaCustomer, NoTelepon, JumlahPemesanan, IDLokasi);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string IDPemesanan = tbID.Text;
            string NamaCustomer = tbNama.Text;
            string NoTelepon = tbNoTelepon.Text;

            var a = service.editPemesanan(IDPemesanan, NamaCustomer, NoTelepon);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            String IDPemesanan = tbID.Text;

            var a = service.deletePemesanan(IDPemesanan);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        public void TampilData()
        {
            var List = service.Pemesanan1();
            dgPemesanan.DataSource = List;
        }

        public void Clear()
        {
            tbID.Clear();
            tbNama.Clear();
            tbNoTelepon.Clear();
            tbJumlah.Clear();
            tbIDLokasi.Clear();

            tbJumlah.Enabled = true;
            tbIDLokasi.Enabled = true;

            btnSimpan.Enabled = true;
            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;

            tbID.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgPemesanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = Convert.ToString(dgPemesanan.Rows[e.RowIndex].Cells[0].Value);
            tbNama.Text = Convert.ToString(dgPemesanan.Rows[e.RowIndex].Cells[3].Value);
            tbNoTelepon.Text = Convert.ToString(dgPemesanan.Rows[e.RowIndex].Cells[4].Value);
            tbJumlah.Text = Convert.ToString(dgPemesanan.Rows[e.RowIndex].Cells[1].Value);
            tbIDLokasi.Text = Convert.ToString(dgPemesanan.Rows[e.RowIndex].Cells[2].Value);

            tbJumlah.Enabled = false;
            tbIDLokasi.Enabled = false;

            btnUpdate.Enabled = true;
            btnHapus.Enabled = true;

            btnSimpan.Enabled = false;
            tbID.Enabled = false;
        }
    }
}
