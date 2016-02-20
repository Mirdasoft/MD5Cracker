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
            if (bSpustitLamani.BackColor == Color.Red)
            {
                core.ZastavitLamani();
                bSpustitLamani.BackColor = Color.Green;
                bSpustitLamani.Text = "Spustit lámání";
            }
            else
            {
            bSpustitLamani.BackColor = Color.Red;
            bSpustitLamani.Text = "Zastavit lámání";
            
            if (rbSlovnik.Checked)
                core.SpustitLamani();
            else if (rbBruteForce.Checked)
                core.SpustitLamani(tbPasswordMask.Text);
            else if (rbBruteForce2.Checked)
                core.SpustitLamani(Convert.ToInt32(tbMin.Value), Convert.ToInt32(tbMax.Value), formatCombo.SelectedValue.ToString());

            }                      
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
            List<KeyValuePair<string,string>> comboBoxData = new List<KeyValuePair<string,string>>();
            comboBoxData.Add(new KeyValuePair<string,string>("Malá písmena", "c"));
            comboBoxData.Add(new KeyValuePair<string,string>("Velká písmena", "C"));
            comboBoxData.Add(new KeyValuePair<string,string>("Číslice", "d"));
            comboBoxData.Add(new KeyValuePair<string,string>("Speciální znaky", "s"));
            comboBoxData.Add(new KeyValuePair<string,string>("Vše", "?"));
            formatCombo.DisplayMember = "Key";
            formatCombo.ValueMember = "Value";
            formatCombo.DataSource = comboBoxData;
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

        private void rbBruteForce2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBruteForce2.Checked)
            {
                formatCombo.Enabled = true;
                tbMin.Enabled = true;
                tbMax.Enabled = true;
            }
            else
            {
                formatCombo.Enabled = false;
                tbMin.Enabled = false;
                tbMax.Enabled = false;
            }
        }
    }
}
