using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NDPProject.Metotlar;
using NDPProject.Sınıflar;

namespace NDPProject
{
    public partial class Form1 : Form
    {
        int sayi = 60;
        Random rastgele = new Random();
        static Image armut = Image.FromFile("armut.png");
        static Image elma = Image.FromFile("elma.png");
        static Image cilek = Image.FromFile("cilek.png");
        static Image portakal = Image.FromFile("portakal.png");
        static Image mandalina = Image.FromFile("mandalina.png");
        static Image greyfurt = Image.FromFile("greyfurt.png");
        List<Image> meyveler = new List<Image> { armut, elma, cilek, portakal, mandalina, greyfurt };
        private int gram;
        private int index;
        private int verim;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            index = rastgele.Next(0, 6);
            gram = rastgele.Next(70, 120);
            pictureBox1.Image = meyveler[index];

            if (index == 0 || index == 1 || index == 2)
            {
                narenciyeButton.Enabled = false;
                verim = rastgele.Next(80, 95);
            }
            else
            {
                katiMeyveButton.Enabled = false;
                verim = rastgele.Next(30, 70);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (sayi > 0)
            {
                timer1.Interval = 1000;
                timer1.Enabled = true;
                int sayac = sayi--;
                label1.Text = sayac.ToString();
            }
            else if (sayi == 0)
            {
                narenciyeButton.Enabled = false;
                katiMeyveButton.Enabled = false;
            }
        }

        private void narenciyeButton_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = meyveler[index];
            if (index == 3)
            {
                PortakalHesapla armutHesapla = new PortakalHesapla();
                vitaminALabel.Text += Convert.ToDouble(vitaminALabel.Text)+ armutHesapla.VitaminAHesapla(new Portakal(), gram, verim);
                vitaminCLabel.Text += Convert.ToDouble(vitaminCLabel.Text) + armutHesapla.VitaminCHesapla(new Portakal(), gram, verim);

            }
            else if (index == 4)
            {
                MandalinaHesapla armutHesapla = new MandalinaHesapla();
                vitaminALabel.Text += Convert.ToDouble(vitaminALabel.Text) + armutHesapla.VitaminAHesapla(new Mandalina(), gram, verim);
                vitaminCLabel.Text += Convert.ToDouble(vitaminCLabel.Text) + armutHesapla.VitaminCHesapla(new Mandalina(), gram, verim);
            }
            else if (index == 5)
            {
                GreyfurtHesapla armutHesapla = new GreyfurtHesapla();
                vitaminALabel.Text += Convert.ToDouble(vitaminALabel.Text) + armutHesapla.VitaminAHesapla(new Greyfurt(), gram, verim);
                vitaminCLabel.Text += Convert.ToDouble(vitaminCLabel.Text) + armutHesapla.VitaminCHesapla(new Greyfurt(), gram, verim);
            }
            index = rastgele.Next(0, 6);
            pictureBox1.Image = meyveler[index];

            gram = rastgele.Next(70, 120);
            if (index == 0 || index == 1 || index == 2)
            {
                narenciyeButton.Enabled = false;
                katiMeyveButton.Enabled = true;
                verim = rastgele.Next(80, 95);
            }
            else
            {
                katiMeyveButton.Enabled = false;
                narenciyeButton.Enabled = true;
                verim = rastgele.Next(30, 70);
            }
        }

        private void katiMeyveButton_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = meyveler[index];

            if (index == 0)
            {
                ArmutHesapla armutHesapla = new ArmutHesapla();
                vitaminALabel.Text += Convert.ToDouble(vitaminALabel.Text) + armutHesapla.VitaminAHesapla(new Armut(), gram, verim);
                vitaminCLabel.Text += Convert.ToDouble(vitaminCLabel.Text) + armutHesapla.VitaminCHesapla(new Armut(), gram, verim);

            }
            else if (index == 1)
            {
                ElmaHesapla armutHesapla = new ElmaHesapla();
                vitaminALabel.Text += Convert.ToDouble(vitaminALabel.Text) + armutHesapla.VitaminAHesapla(new Elma(), gram, verim);
                vitaminCLabel.Text += Convert.ToDouble(vitaminCLabel.Text) + armutHesapla.VitaminCHesapla(new Elma(), gram, verim);
            }
            else if (index == 2)
            {
                CilekHesapla armutHesapla = new CilekHesapla();
                vitaminALabel.Text += Convert.ToDouble(vitaminALabel.Text) + armutHesapla.VitaminAHesapla(new Cilek(), gram, verim);
                vitaminCLabel.Text += Convert.ToDouble(vitaminCLabel.Text) + armutHesapla.VitaminCHesapla(new Cilek(), gram, verim);
            }
            index = rastgele.Next(0, 6);
            pictureBox1.Image = meyveler[index];
            gram = rastgele.Next(70, 120);

            if (index == 0 || index == 1 || index == 2)
            {
                narenciyeButton.Enabled = false;
                katiMeyveButton.Enabled = true;
                verim = rastgele.Next(80, 95);
            }
            else
            {
                katiMeyveButton.Enabled = false;
                narenciyeButton.Enabled = true;
                verim = rastgele.Next(30, 70);
            }
        }
    }
}
