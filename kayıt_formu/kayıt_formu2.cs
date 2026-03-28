using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kayıtformu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad=textBox1.Text;
            string soyad=textBox2.Text;
            string dogumTarihi = dateTimePicker1.Value.ToShortDateString();
            int yas=(int)numericUpDown1.Value;
            string cinsiyet = radioButton1.Checked ? "erkek" : "kadın";

            List<string> hobiler = new List<string>();

            if (checkBox1.Checked) hobiler.Add("sinema");
            if (checkBox2.Checked) hobiler.Add("müzik");
            if (checkBox3.Checked) hobiler.Add("spor");

            string sehir = comboBox1.SelectedItem?.ToString() ?? "-";

            string kisi = $"{ad} {soyad} | yas:{yas} | dogum:{dogumTarihi} | cinsiyet:{cinsiyet} | sehir:{sehir} | hobiler:{string.Join(",", hobiler)}  ";

            listBox1.Items.Add(kisi);
        }
    }
}
