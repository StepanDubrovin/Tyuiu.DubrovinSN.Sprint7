using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.DubrovinSN.Sprint7.Project.V6
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonInfo_DSN_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        private void buttonInfoRazrab_DSN_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonPatients_DSN_Click(object sender, EventArgs e)
        {
            FormPacient formPacient = new FormPacient();
            formPacient.ShowDialog();
        }

        private void buttonMedical_DSN_Click(object sender, EventArgs e)
        {
            FormMedical formMed = new FormMedical();
            formMed.ShowDialog();
        }
    }
}
