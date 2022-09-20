using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void autocarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autocars a = new Autocars();
            bool MarquesOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Autocars")
                {
                    MarquesOpen = true;
                }

            }
            if (!MarquesOpen)
            {
                a.MdiParent = this;
                a.Show();
            }
        }

        private void lignesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lignes L = new Lignes();
            bool MarquesOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Lignes")
                {
                    MarquesOpen = true;
                }

            }
            if (!MarquesOpen)
            {
                L.MdiParent = this;
                L.Show();
            }
        }

        private void voyagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Voyages V = new Voyages();
            bool MarquesOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Voyages")
                {
                    MarquesOpen = true;
                }

            }
            if (!MarquesOpen)
            {
                V.MdiParent = this;
                V.Show();
            }
        }
    }
}
