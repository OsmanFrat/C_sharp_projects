using System;

namespace sinif_ekle
{
    class Silindir
    {
        private double r, h;
        public double hacim(double r, double h)
        {
            return Math.PI * r * r * h;
        }
    }
}
