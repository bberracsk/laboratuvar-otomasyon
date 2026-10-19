using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOtomasyon.Interfaces
{
    public interface ICrud
    {
        void Ekle();
        void Listele();
        void Ara(string veri);
        void Guncelle();
        void Sil(); 
    }
}
