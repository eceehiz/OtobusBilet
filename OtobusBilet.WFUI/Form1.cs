using OtobusBilet.ORM.Entity;
using OtobusBilet.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBilet.WFUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void CalisanListele()
        {
            dgvListe.DataSource = Calisanlar.Select();
            dgvListe.Columns[0].Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CalisanListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Calisan cls = new Calisan();
            
            cls.Adi = txtAd.Text;
            cls.Soyadi = txtSoyad.Text;
            cls.Tcno = txtTcno.Text;
            cls.IseBaslamaTarihi = dateIseBaslama.Value;
            cls.Cinsiyet = txtCinsiyet.Text;

            bool sonuc = Calisanlar.Insert(cls);
            if (sonuc)
            {
                MessageBox.Show("Başarılı");
                CalisanListele();
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
        }

        private void dgvListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Tag = dgvListe.CurrentRow.Cells[0].Value;
            txtAd.Text = dgvListe.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text = dgvListe.CurrentRow.Cells[3].Value.ToString();
            txtTcno.Text = dgvListe.CurrentRow.Cells[4].Value.ToString();
            dateIseBaslama.Value = (DateTime)dgvListe.CurrentRow.Cells[5].Value;
            txtCinsiyet.Text= dgvListe.CurrentRow.Cells[6].Value.ToString();

        }

        
    }
}
