using System;
using System.Collections.Generic;
using System.Text;

namespace beratIdeal_15_FaustinaPuspamurti
{
    public class beratPriaWanita
    {
        public double beratIdealWanita(double tb)
        {
            double hasil = (tb - 100) - (tb - 100) * 0.15;
            Console.WriteLine("Berat Ideal Mu (Untuk Wanita) :" + hasil);
            return hasil;
        }
        public double beratIdealPria(double tb)
        {
            double hasil = (tb - 100) - (tb - 100) * 0.10;
            Console.WriteLine("Berat Ideal Mu (Untuk Pria) :" + hasil);
            return hasil;
        }

    }
}