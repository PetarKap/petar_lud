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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "azil123")
            {
                this.Hide();
                Form f = new frm_Gl_Izbornk();
                f.ShowDialog();


            }
            else
            {
                MessageBox.Show("Neispravno korisničko ime ili lozinka. Pokušajte ponovo.");
            }
        }
    }
}
