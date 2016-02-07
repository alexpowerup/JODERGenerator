using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JODERGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CopyBTN_Click(object sender, EventArgs e)
        {
            //If there is no text to copy, just don't do anything.
            //If there is, copy to clipboard.
            if(TextGenerated.Text != "")
            {
                Clipboard.SetText(TextGenerated.Text);
            }
        }

        private void MaxSize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GenerateBTN_Click(object sender, EventArgs e)
        {
            string gen = JODER.Generate((int)MinSize.Value, (int)MaxSize.Value);
            if (gen == "")
            {
                MessageBox.Show("Los parámetros no son válidos. Compruébalos e inténtalo de nuevo.");
            }
            else
            {
                TextGenerated.Text = gen;
            }
        }
    }
}
