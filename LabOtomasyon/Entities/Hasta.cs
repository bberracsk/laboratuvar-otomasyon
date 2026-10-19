using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabOtomasyon.Abstract;

namespace LabOtomasyon.Entities
{
    public class Hasta : BaseEntity
    {

        private string ad;
        private string soyad;
        private string tcNo;
        private string telefon;


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

        public string TcNo
        {
            get { return tcNo; }
            set { tcNo = value; }
        }

        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }



        public Hasta(string ad, string soyad, string tcNo, string telefon)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.tcNo = tcNo;
            this.telefon = telefon;
        }


        public override void BilgiYaz()
        {
            MessageBox.Show("Hasta Bilgisi : " + ad + " " + soyad);
        }
    
    }
}
