using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolko_krzyzyk
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void btnOptionsOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnColorO_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnColorO.BackColor = colorDialog1.Color;
        }
        
        private void btnColorX_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnColorX.BackColor = colorDialog1.Color;
        }

        private void btnResultPlusO_Click(object sender, EventArgs e)
        {

            Variables.wynikO = Convert.ToInt32(lblResultO.Text);
            Variables.wynikO++;
            lblResultO.Text = Variables.wynikO.ToString();
        }

        private void btnResultMinusO_Click(object sender, EventArgs e)
        {
            if (Variables.wynikO > 0)
            {
                Variables.wynikO = Convert.ToInt32(lblResultO.Text);
                Variables.wynikO--;
                lblResultO.Text = Variables.wynikO.ToString();
            }
        }

        private void btnResultPlusX_Click(object sender, EventArgs e)
        {
            Variables.wynikX = Convert.ToInt32(lblResultX.Text);
            Variables.wynikX++;
            lblResultX.Text = Variables.wynikX.ToString();
        }

        private void btnResultMinusX_Click(object sender, EventArgs e)
        {
            if (Variables.wynikX > 0)
            {
                Variables.wynikX = Convert.ToInt32(lblResultX.Text);
                Variables.wynikX--;
                lblResultX.Text = Variables.wynikX.ToString();
            }
        }

        private void Options_Load(object sender, EventArgs e)
        {
            var frm1 = new Form1();
            lblResultO.Text = Variables.wynikO.ToString();
            lblResultX.Text = Variables.wynikX.ToString();
            btnColorO.BackColor = frm1.btnColorOmemory.BackColor;
            btnColorX.BackColor = frm1.btnColorXmemory.BackColor;
        }

        private void btnOptionsAnuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
