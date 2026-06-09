using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_AzilŽivotnije
{
    public partial class FormUdomi : Form
    {
        public FormUdomi()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Odaberite životinju za udomljavanje.");
                return;
            }
            List<string>sve = Admin.Ucitaj();
            string stariRedak = sve[listBox1.SelectedIndex];
            string[] d = stariRedak.Split('|');
            string imeUdomitelja = textBoxImePrezime.Text;
            string adresa = textBoxAdresa.Text;
            string telefon = textBoxTelefon.Text;
            string oib = textBoxOIB.Text;
            string datumUdomljavanja = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string udomiteljInfo = $"{imeUdomitelja},{adresa},{oib}";
            string noviZapis = $"{d[0]}|{d[1]}|{d[2]}|{d[3]}|{d[4]}|{d[5]}|Udomljen|{d[7]}|{d[8]}|{datumUdomljavanja}|{d[10]}|{d[11]}|d{12}|{udomiteljInfo}|{telefon}";
            Admin.UdomiZivotinju(listBox1.SelectedIndex, noviZapis);
            string zapisUdomitelj = $"{imeUdomitelja}|{oib}|{telefon}|Životinja: {d[1]}";
            Admin.UnosUdomitelja(zapisUdomitelj);
            MessageBox.Show("Životinja je uspješno udomljena!");
            this.Close();
        }

        private void FormUdomi_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> sveZivotinje = Admin.Ucitaj();
            foreach (string redak in sveZivotinje)
            {
                string[] d = redak.Split('|');
                if (d.Length > 6 && d[6] == "Azil")
                {
                    listBox1.Items.Add($"Ime: {d[1]}, Vrsta: {d[2]}");
                }
            }
            if (listBox1.Items.Count == 0)
            {
                listBox1.Items.Add("Nema životinja trenutno u azilu.");
            }
        }
    }
}
