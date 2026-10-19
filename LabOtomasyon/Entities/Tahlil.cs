using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabOtomasyon.Abstract;

namespace LabOtomasyon.Entities
{
    internal class Tahlil : BaseEntity
    {
        private int hastaId;
        private int tahlilTurId;
        private string sonuc;
        private DateTime tarih;

        public int HastaId
        {
            get { return hastaId; }
            set { hastaId = value; }
        }

        public int TahlilTurId
        {
            get { return tahlilTurId; }
            set { tahlilTurId = value; }
        }

        public string Sonuc
        {
            get { return sonuc; }
            set { sonuc = value; }
        }

        public DateTime Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }


        public Tahlil(int hastaId, int tahlilTurId, string sonuc, DateTime tarih)
        {
            this.hastaId = hastaId;
            this.tahlilTurId = tahlilTurId;
            this.sonuc = sonuc;
            this.tarih = tarih;
        }


        public override void BilgiYaz()
        {
            MessageBox.Show("Tahlil Sonucu : " + sonuc);
        }
    }
}
