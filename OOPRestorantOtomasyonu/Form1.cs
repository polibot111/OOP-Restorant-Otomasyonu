using OOPRestorantOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPRestorantOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<AraSicak> araSicak = new List<AraSicak>
            {
                new AraSicak{Ad="", Fiyat=0},
                new AraSicak{Ad="Mercimek Çorbası", Fiyat=10},
                new AraSicak{Ad="İşkembe Çorbası", Fiyat=10},
                new AraSicak{Ad="Kellepaça Çorbası", Fiyat=10},
                new AraSicak{Ad="Tarhana Çorbası", Fiyat=10},
            };
            foreach (AraSicak item in araSicak)
            {
                cmbAraSicak.Items.Add(item);
            }
            List<AnaYemek> anaYemek = new List<AnaYemek>
            {
                new AnaYemek{Ad="", Fiyat=0},
                new AnaYemek{Ad="Mantı", Fiyat=20},
                new AnaYemek{Ad="Pilav Üstü Tavuk", Fiyat=25},
                new AnaYemek{Ad="İskender", Fiyat=25},
                new AnaYemek{Ad="Kızarmış Bonfile", Fiyat=35},
                new AnaYemek{Ad="Adana Kebap", Fiyat=15},
            };
            foreach (AnaYemek item in anaYemek)
            {
                cmbAnaYemek.Items.Add(item);
            }
            List<Tatli> tatli = new List<Tatli>
            {
                new Tatli{Ad="", Fiyat=0},
                new Tatli{Ad="Sütlaç", Fiyat=10},
                new Tatli{Ad="Kellepaça", Fiyat=10},
                new Tatli{Ad="Baklava", Fiyat=10},
                new Tatli{Ad="Künefe", Fiyat=10},

            };
            foreach (Tatli item in tatli)
            {
                cmbTatli.Items.Add(item);
            }
            List<Icecek> icecek = new List<Icecek>
            {
                new Icecek{ Ad = "", Fiyat = 0 },
                new Icecek{Ad="Cola", Fiyat=20},
                new Icecek{Ad="Fanta", Fiyat=20},
                new Icecek{Ad="Gazoz", Fiyat=20},
                new Icecek{Ad="Ayran", Fiyat=10},
                new Icecek{Ad="Su", Fiyat=5},
                new Icecek{Ad="Soda", Fiyat=15},

            };
            foreach (Icecek item in icecek)
            {
                cmbIcecek.Items.Add(item);
            }
        }



        private void btnEkle_Click_1(object sender, EventArgs e)
        {
           
            Siparis s = new Siparis();
            s.Adet = Convert.ToInt16(nmrAdet.Value);
            string a = null;
            foreach (ComboBox item in grpMenu.Controls)
            {
                a += item.Text;
            }
            if (a == "")
            {
                MessageBox.Show("Lütfen Değer Giriniz");
                return;
            }
            try
            {
                uint b = Convert.ToUInt32(txtMasaNum.Text);
                s.SiparisAnaYemek = cmbAnaYemek.SelectedItem as AnaYemek;
                s.SiparisAraSicak = cmbAraSicak.SelectedItem as AraSicak;
                s.SiparisIcecekler = cmbIcecek.SelectedItem as Icecek;
                s.SiparisTatli = cmbTatli.SelectedItem as Tatli;
                s.MasaNumarasi = b;
                s.TutarHesapla();
                lstSiparis.Items.Add(s);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCiro_Click(object sender, EventArgs e)
        {
            decimal toplam = 0;
            foreach(Siparis item in lstSiparis.Items)
            {
                toplam += item.Fiyat;
            }
            MessageBox.Show($"{toplam:C2}");
        }
    }
}
