using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            string result;
            result ="nazwisko: "+ textBoxNazwisko.Text +"\nimie " + textBoxImie.Text + "\nData Urodzenia: " + dateTimePicker1.Text + "\nAdres: " + textBoxAdres.Text + "\nKod Pocztowy: " +
             "\nNumer Telefonu: " + maskedTextBoxNR.Text;
            show.Text = result;
            picture.ImageLocation = zdjecie.Text;
        }
    }
}
