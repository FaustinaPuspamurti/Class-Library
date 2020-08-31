using beratIdeal_15_FaustinaPuspamurti;
using System;

namespace hitungBerat_15_FaustinaPuspamurti
{
    class Program
    {
        static void Main(string[] args)
        {
            beratPriaWanita beratw = new beratPriaWanita();
            Console.Write("Masukan Tinggi Badanmu (Wanita) :");
            double a = Convert.ToDouble(Console.ReadLine());
            beratw.beratIdealWanita(a);
            Console.ReadLine();

            beratPriaWanita beratp = new beratPriaWanita();
            Console.Write("Masukan Tinggi Badanmu (Pria) :");
            double b = Convert.ToDouble(Console.ReadLine());
            beratp.beratIdealPria(b);
            Console.ReadLine();
        }
    }
}