using NDPProject.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPProject.Metotlar
{
    public class PortakalHesapla : MeyveHesapla
    {
        public override double VitaminAHesapla(IMeyve meyve, int gram, int verim)
        {
            double islemSonrasiGram = (gram * verim) / 100.00;
            meyve.VitaminA = islemSonrasiGram * 0.000238 / 100.00;
            return meyve.VitaminA;
        }

        public override double VitaminCHesapla(IMeyve meyve, int gram, int verim)
        {
            double islemSonrasiGram = (gram * verim) / 100.00;
            meyve.VitaminC = islemSonrasiGram * 0.045 / 100.00;
            return meyve.VitaminC;
        }
    }
}
