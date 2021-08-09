using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRestorantOtomasyonu.Models
{
    public class Siparis
    {
        public Siparis()
        {
        }
        
        public uint MasaNumarasi { get; set; }
        public AnaYemek SiparisAnaYemek { get; set; }

        public short Adet { get; set; }

        public AraSicak SiparisAraSicak { get; set; }

        public Tatli SiparisTatli { get; set; }

        public Icecek SiparisIcecekler { get; set; }

        public decimal Fiyat { get; private set; }





        public void TutarHesapla()
        {
            Fiyat = 0;
            if (SiparisAnaYemek != null)
            {
                Fiyat += SiparisAnaYemek.Fiyat;
            }
            if(SiparisAraSicak!=null)
            {
                Fiyat += SiparisAraSicak.Fiyat;
            }
            if(SiparisIcecekler!=null)
            {
                Fiyat += SiparisIcecekler.Fiyat;
            }
            if(SiparisTatli!=null)
            {
                Fiyat += SiparisTatli.Fiyat;
            }
            Fiyat *= Adet;

        }

        public string Yazdir()
        {
            string a = null;
            string b = null;
            string c = null;
            string d = null;
            string e = null;
            if(SiparisAnaYemek!=null)
            {
                a = $" Ana Yemek => {SiparisAnaYemek.Ad} ---";
            }
            if(SiparisAraSicak!=null)
            {
                b = $" Ara Sıcak => {SiparisAraSicak.Ad} ---";
            }
            if(SiparisIcecekler != null)
            {
                c = $" İçecek => {SiparisIcecekler.Ad} ---";
            }
            if(SiparisTatli != null)
            {
                d = $" Tatlı => {SiparisTatli.Ad} ---";
            }
            e = $"{a}{b}{c}{d}{Fiyat:C2}";
            e.TrimStart(' ');

            return e ;
        }


        public override string ToString()
        {
            return MasaNumarasi+$"=>"+Yazdir();
        }
    }
}
