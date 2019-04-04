using System;
using System.Collections.Generic;
using System.Text;

namespace Veriler
{
    public class SarkiciAdi
    {

         Random rnd;
        public SarkiciAdi()
        {
           rnd = new Random();
        }
        public  string Gonder()
        {

            string[] sdizi = { "Tarkan", "Hadise", "Shakira", "Zaz", "Justin Bieber","Deep Purple","Led Zeppelin" };

            //Random rnd = new Random();
            string isim = sdizi[rnd.Next( sdizi.Length)];
            return isim;


        }
    }
}
