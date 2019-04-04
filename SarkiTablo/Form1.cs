using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veriler;

namespace SarkiTablo
{
    public partial class Form1 : Form
    {
        List<Class1> olist = new List<Class1>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SarkiciAdi sr = new SarkiciAdi();

            Tur tr = new Tur();


            Ulke ul = new Ulke();
            for (int i = 1; i < 101; i++)
            {
                
               Class1 cs = new Class1();
                cs.Id = i;
               cs.SAdi =sr.Gonder();
  
                cs.STur = tr.Gonder();
                
                cs.SUlke = ul.Gonder();
                
                olist.Add(cs);
              

            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            doldur();
        }
        public void doldur()
        {
            dataGridView1.DataSource = null;
           dataGridView1.DataSource = olist;
            dataGridView1.Refresh();

        }
    }
}
