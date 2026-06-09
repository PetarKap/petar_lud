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
    public partial class FormUnos : Form
    {
        public FormUnos()
        {
            InitializeComponent();
        }

        private void lbl_Ime_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ime = textBox1.Text;
            string vrsta = textBox2.Text;
            string pasmina = textBox3.Text;
            string spol = radioButton1.Checked ? "M" : "Ž";
            int dob = (int)numericUpDown1.Value;
            string status = "Azil";
            string putanjaSlike = pictureBox2.ImageLocation;
            string datumDolaska = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            bool cijepljen = checkBox1.Checked;
            bool kastriran = checkBox2.Checked;
            string napomena = textBox4.Text;
            string id = DateTime.Now.Ticks.ToString().Substring(10);
            string zapis = $"{id}|{ime}|{vrsta}|{pasmina}|{spol}|{dob}|{status}|{putanjaSlike}|{datumDolaska}||{cijepljen}|{kastriran}|{napomena}||";
            Admin.Unos(zapis);
            MessageBox.Show("Životinja je uspješno unesena!");
            this.Close();
        }    

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Slike|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog1.Title = "Odaberi sliku životinje";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = openFileDialog1.FileName;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
