using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD5Cracker
{
    public partial class Form1 : Form
    {
        Core core;
        public Form1()
        {
            InitializeComponent();
            core = new Core();
        }

        private void bNacistSoubor_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.Filter = "txt files (*.txt)|*.txt";
            fileDlg.Title = "Načíst soubor s prolamovanými hesly";
            DialogResult result = fileDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                core.NacistSoubory(fileDlg.FileName);
                tbHeslaCesta.Text = core.HeslaCesta;                
            }
        }

        private void bNacistSlovnik_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.Filter = "txt files (*.txt)|*.txt";
            fileDlg.Title = "Načíst slovník";
            DialogResult result = fileDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
               core.SlovnikCesta = fileDlg.FileName;
               tbSlovnikCesta.Text = core.SlovnikCesta;
            }
        }

        private void bSpustitLamani_Click(object sender, EventArgs e)
        {
            core.SpustitLamani(rbSlovnik.Checked, tbPasswordMask.Text);
        }

        private void bUlozitDo_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDlg = new SaveFileDialog();
            fileDlg.Filter = "txt files (*.txt)|*.txt";
            fileDlg.Title = "Uložit výsledky";
            DialogResult result = fileDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                core.VystupniCesta = fileDlg.FileName;
                tbVystupniCesta.Text = core.VystupniCesta;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbSlovnik_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSlovnik.Checked)
            {
                tbSlovnikCesta.Enabled = true;
                bNacistSlovnik.Enabled = true;
            }
            else
            {
                tbSlovnikCesta.Enabled = false;
                bNacistSlovnik.Enabled = false;
            }
        }

        private void rbBruteForce_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBruteForce.Checked)
            {
                tbPasswordMask.Enabled = true;
            }
            else
            {
                tbPasswordMask.Enabled = false;
            }
        }
    }
}
