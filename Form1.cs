using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace biletuygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //int id = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Bilet b = new Bilet();  //sınıfta instance almanın  yolu budur.
            b.FilmAdi = txtFilmAdi.Text;
            b.KoltukNo = int.Parse( txtKoltukNo.Text); //int parse string degeri int yaptık
            b.Fiyat = int.Parse( txtFiyat.Text);
          //  id++;
           // b.Id = id;
            listBox1.Items.Add(b.Id + "" + b.FilmAdi + "" + b.KoltukNo + "" + b.Fiyat);
            txtFilmAdi.Clear();
            txtKoltukNo.Clear();
            txtFiyat.Clear();
        }
    }
}
