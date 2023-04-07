using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta4
{
    internal class islemler
    {
        public double topla (double x, double y)
        {
            double sonuc = x + y;
            return sonuc;
        }

        public double cıkar(double x, double y)
        {
            double sonuc = x - y;
            return sonuc;
        }

        public double carp(double x, double y)
        {
            double sonuc = x * y;
            return sonuc;
        }

        public double bol(double x, double y)
        {
            double sonuc = 0;

            if (y == 0)
            {
                MessageBox.Show("bölme işleminde bölünen sıfır olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                sonuc = x / y;

                return sonuc;
        }

        public double modAl(double x, double y)
        {
            double sonuc = x % y;
            return sonuc;
        }

        public double karekok(double x)
        {
            double sonuc = Math.Sqrt(x);
            return sonuc;
        }

        public double kupkok(double x)
        {
            double sonuc = Math.Pow(x, 1.0/3.0);
            return sonuc;
        }
    }
}
