using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigortaDurum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //List<Hasta> hastalar = new List<Hasta>();
        BindingList<Hasta> hastalar = new BindingList<Hasta>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Hasta hasta1 = new Hasta { id = 1, AdSoyad =  "Furkan", Birim = "Dahiliye", Tarih = DateTime.Now, yas = 21  };
            Hasta hasta2 = new Hasta { id = 2, AdSoyad = "Yasin", Birim = "Dahiliye", Tarih = DateTime.Now, yas = 24 };
            Hasta hasta3 = new Hasta { id = 3, AdSoyad = "Buğra", Birim = "Cildiye", Tarih = DateTime.Now, yas = 25 };
            Hasta hasta4 = new Hasta { id = 4, AdSoyad = "Eren", Birim = "Hariciye", Tarih = DateTime.Now, yas = 25 };
            hastalar.Add(hasta1);
            hastalar.Add(hasta2);
            hastalar.Add(hasta3);
            hastalar.Add(hasta4);
            dataGridView1.DataSource = hastalar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt16( textBox1.Text);
            string AdSoyad = textBox2.Text;
            DateTime Tarih = dateTimePicker1.Value.Date;
            string Birim = comboBox1.Text;
            int yas =Convert.ToInt32(numericUpDown1.Value);
            Hasta hastam =new Hasta { id = id,AdSoyad = AdSoyad,Birim = Birim, Tarih = Tarih , yas = yas };
            hastalar.Add(hastam);
            MessageBox.Show("Kayıt Eklendi");
            dataGridView1.DataSource = hastalar;
        }
    }
}
