using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randevu_formu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad= textBox2.Text;
            string hizmet= comboBox1.SelectedItem?.ToString() ?? "-";
            string tarih = dateTimePicker1.Value.ToString("dd.MM.yyyy");
            string saat = dateTimePicker2.Value.ToString("HH:mm");

            string randevu= $"{ad} {soyad}\n | Hizmet:{hizmet} | Tarih:{tarih} {saat}";

            listBox1.Items.Add(randevu);
        }
    }
}
