using System;
using System.Collections.Generic;
using System.Text;

namespace Task6
{
    class Converter
    {
        public double usd;
        public double eur;
        public double rub;
        public double Uah { get; set; }

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
    }
}
