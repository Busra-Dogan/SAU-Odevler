using NDPProject.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPProject.Metotlar
{
    public abstract class MeyveHesapla
    {
        public abstract double VitaminAHesapla(IMeyve meyve, int gram, int verim);
        public abstract double VitaminCHesapla(IMeyve meyve, int gram, int verim);

    }


}
