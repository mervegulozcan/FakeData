using System;
using System.Collections.Generic;
using System.Text;

namespace Veriler
{
   public class Ulke
    {
        Random rnd;
        public Ulke()
        {
            rnd = new Random();
        }
        public  string Gonder()
        {
            string[] udizi = { "Türkiye", "Fransa", "Amerika", "İngiltere", "Rusya","İtalya","Finlandiya","Norveç","Brezilya" };
            //Random rnd = new Random();
            string tur = udizi[rnd.Next(udizi.Length)];
            return tur;
        }
    }
}
