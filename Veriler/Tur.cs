using System;
using System.Collections.Generic;
using System.Text;

namespace Veriler
{
  public  class Tur
    {
        Random rnd;
        public Tur()
        {
            rnd = new Random();
        }

        public  string Gonder()
        {
            string[] tdizi = { "Pop", "Rock", "Jaz", "klasik", "Rap","Enstrüman","Metal","Slow","R&B" };
            //Random rnd = new Random();
            string tur = tdizi[rnd.Next(tdizi.Length )];
            return tur;
        }
    }
}
