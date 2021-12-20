
namespace ClientReservasi_087
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbNoTelepon = new System.Windows.Forms.TextBox();
            this.tbJumlah = new System.Windows.Forms.TextBox();
            this.tbIDLokasi = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgPemesanan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPemesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Reservasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "No Telepon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah Pemesanan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Lokasi";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(187, 28);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(322, 20);
            this.tbID.TabIndex = 5;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(187, 76);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(322, 20);
            this.tbNama.TabIndex = 6;
            // 
            // tbNoTelepon
            // 
            this.tbNoTelepon.Location = new System.Drawing.Point(187, 122);
            this.tbNoTelepon.Name = "tbNoTelepon";
            this.tbNoTelepon.Size = new System.Drawing.Size(322, 20);
            this.tbNoTelepon.TabIndex = 7;
            // 
            // tbJumlah
            // 
            this.tbJumlah.Location = new System.Drawing.Point(187, 166);
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.Size = new System.Drawing.Size(322, 20);
            this.tbJumlah.TabIndex = 8;
            // 
            // tbIDLokasi
            // 
            this.tbIDLokasi.Location = new System.Drawing.Point(187, 210);
            this.tbIDLokasi.Name = "tbIDLokasi";
            this.tbIDLokasi.Size = new System.Drawing.Size(322, 20);
            this.tbIDLokasi.TabIndex = 9;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(574, 48);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 10;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(574, 92);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(574, 135);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 12;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(574, 178);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgPemesanan
            // 
            this.dgPemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPemesanan.Location = new System.Drawing.Point(28, 262);
            this.dgPemesanan.Name = "dgPemesanan";
            this.dgPemesanan.Size = new System.Drawing.Size(646, 139);
            this.dgPemesanan.TabIndex = 14;
            this.dgPemesanan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPemesanan_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 424);
            this.Controls.Add(this.dgPemesanan);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.tbIDLokasi);
            this.Controls.Add(this.tbJumlah);
            this.Controls.Add(this.tbNoTelepon);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgPemesanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbNoTelepon;
        private System.Windows.Forms.TextBox tbJumlah;
        private System.Windows.Forms.TextBox tbIDLokasi;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgPemesanan;
    }
}

