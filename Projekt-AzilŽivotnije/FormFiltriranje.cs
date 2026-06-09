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
    public partial class FormFiltriranje : Form
    {
        public FormFiltriranje()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            listBox1.Items.Clear();
        }

        private void FormFiltriranje_Load(object sender, EventArgs e)
        {
            List<string> sveVrste = Admin.Vrste();
            comboBox1.Items.Clear();
            foreach (string v in sveVrste)
            {
                comboBox1.Items.Add(v);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                return;
            string odabranaVrsta = comboBox1.SelectedItem.ToString();
            List <string> filtrirano = Admin.PronadiPoVrsti(odabranaVrsta);
            listBox1.Items.Clear();
            foreach (string redak in filtrirano)
            {
                string[] d = redak.Split('|');
                listBox1.Items.Add($"Ime: {d[1]}, Pasmina: {d[3]}");
            }
        }
    }
}
