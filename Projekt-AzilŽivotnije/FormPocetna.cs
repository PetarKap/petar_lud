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
    public partial class frm_Gl_Izbornk : Form
    {
        public frm_Gl_Izbornk()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new FormFiltriranje();
            f.ShowDialog();
        }

        private void btn_Izlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
             
        }

        private void btn_Statistika_Click(object sender, EventArgs e)
        {
            Form f = new FormStatistika();
            f.ShowDialog();
        }

        private void btn_Udomljavanje_Click(object sender, EventArgs e)
        {
            Form f = new FormUdomi();
            f.ShowDialog();

        }

        private void btn_Unos_Click(object sender, EventArgs e)
        {
            Form f = new FormUnos();
            f.ShowDialog();
        }

        private void btn_Pregled_Click(object sender, EventArgs e)
        {
            Form f = new FormPregled();
            f.ShowDialog();
        }
    }
}
