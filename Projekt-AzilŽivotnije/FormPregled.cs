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
    public partial class FormPregled : Form
    {
        public FormPregled()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }
            List<string> sveZivotinje = Admin.Ucitaj();
            string odabraniRedak = sveZivotinje[listBox1.SelectedIndex];
            string[] d = odabraniRedak.Split('|');
            lblIme.Text = "Ime: " + d[1];
            lblVrsta.Text = "Vrsta: " + d[2];   
            lblPasmina.Text = "Pasmina: " + d[3];
            lblSpol.Text = "Spol: " + d[4];
            lblDob.Text = "Dob: " + d[5];
            lblStatus.Text = "Status: " + d[6];
            if (System.IO.File.Exists(d[7]))
            {
                pbSlika.ImageLocation = d[7];
                pbSlika.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else 
            {
                pbSlika.Image = null;
            }
            lblDatumDolaska.Text = "Datum dolaska: " + d[8];
            lblCijepljen.Text = "Cijepljen: " + (d[9] == "True" ? "Da" : "Ne");
            lblKastriran.Text = "Kastriran: " + (d[10] == "True" ? "Da" : "Ne");
            lblNapomena.Text = "Napomena: " + d[11];

        }

        private void FormPregled_Load(object sender, EventArgs e)
        {
            List<string> sveZivotinje = Admin.Ucitaj();
            listBox1.Items.Clear();
            foreach (string redak in sveZivotinje)
            {
                string[] d = redak.Split('|');
                if(d.Length > 1)
                {
                    listBox1.Items.Add($"{d[1]} ({d[2]})");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Jeste li sigurni da želite obrisati ovu životinju?", "Potvrda brisanja", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Admin.Obrisi(listBox1.SelectedIndex);
                    FormPregled_Load(sender, e);
                    pbSlika.Image = null;
                    MessageBox.Show("Životinja je uspješno obrisana!");
                }
                else
                {
                    MessageBox.Show("Molimo odaberite životinju iz liste.");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
