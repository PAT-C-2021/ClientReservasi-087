﻿using System;
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
    public partial class Register : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public Register()
        {
            InitializeComponent();
            TampilData();
            tbID.Visible = false;
            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string kategori = cmbKategori.Text;
            string a = service.Register(username, password, kategori);

            if (tbUsername.Text == "" || tbPassword.Text == "" || cmbKategori.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi.");
            } else
            {
                MessageBox.Show(a);
                Refresh();
                TampilData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string kategori = cmbKategori.Text;
            int id = Convert.ToInt32(tbID.Text);
            string a = service.UpdateRegister(username, password, kategori, id);

            if (tbUsername.Text == "" || tbPassword.Text == "" || cmbKategori.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi.");
            } else
            {
                MessageBox.Show(a);
                Clear();
                TampilData();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;

            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Hapus Data", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string a = service.DeleteRegister(username);
                MessageBox.Show(a);
                Clear();
                TampilData();
            } else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void TampilData()
        {
            var list = service.DataRegist();
            dgRegister.DataSource = list;
        }

        public void Clear()
        {
            tbUsername.Clear();
            tbPassword.Clear();
            cmbKategori.SelectedItem = null;

            btnSimpan.Enabled = true;
            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void dgRegister_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = Convert.ToString(dgRegister.Rows[e.RowIndex].Cells[0].Value);
            tbUsername.Text = Convert.ToString(dgRegister.Rows[e.RowIndex].Cells[1].Value);
            tbPassword.Text = Convert.ToString(dgRegister.Rows[e.RowIndex].Cells[2].Value);
            cmbKategori.Text = Convert.ToString(dgRegister.Rows[e.RowIndex].Cells[3].Value);

            btnUpdate.Enabled = true;
            btnHapus.Enabled = true;

            btnSimpan.Enabled = false;
        }
    }
}
