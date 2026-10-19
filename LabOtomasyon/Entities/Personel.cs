using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabOtomasyon.Abstract;

namespace LabOtomasyon.Entities
{
    internal class Personel : BaseEntity
    {
        private string ad;
        private string soyad;
        private string gorev;
        private string kullaniciAdi;
        private string sifre;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }

        public string Gorev
        {
            get { return gorev; }
            set { gorev = value; }
        }

        public string KullaniciAdi
        {
            get { return kullaniciAdi; }
            set { kullaniciAdi = value; }
        }

        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }


        public Personel(string ad, string soyad, string gorev, string kullaniciAdi, string sifre)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.gorev = gorev;
            this.kullaniciAdi = kullaniciAdi;
            this.sifre = sifre;
        }


        public override void BilgiYaz()
        {
            MessageBox.Show("Personel : " + ad + " " + soyad);
        }
    }
}
