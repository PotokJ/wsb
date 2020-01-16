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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void colorChange()
        {
            var options = new Options();
            btnColorOmemory.BackColor = options.btnColorO.BackColor;
            btnColorXmemory.BackColor = options.btnColorX.BackColor;
        }

        private void ktoWygra()
        {

            if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") || (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") ||
                (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") || (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") ||
                (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") || (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") || (button3.Text == "X" && button5.Text == "X" && button7.Text == "X"))
            {
                Variables.wynikX++;
                lblWynikX.Text = Variables.wynikX.ToString();

                MessageBox.Show("Wygrywa gracz X", "Wynik", MessageBoxButtons.OK);
                buttonClear();
            }

            if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") ||
                (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") || (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") ||
                (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") || (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "O"))
            {
                Variables.wynikO++;
                lblWynikO.Text = Variables.wynikO.ToString();

                MessageBox.Show("Wygrywa gracz O", "Wynik", MessageBoxButtons.OK);
                buttonClear();
            }

            if (Variables.gracz == "O")
            {
                lblGracz.Text = "Ruch gracza O";
            }
            if (Variables.gracz == "X")
            {
                lblGracz.Text = "Ruch gracza X";
            }
        }

        private void remis()
        {
            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" &&
                button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("Remis", "Wynik", MessageBoxButtons.OK);
                buttonClear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (Variables.gracz == "O")
            {
                button1.Text = "O";
                button1.BackColor = btnColorOmemory.BackColor;
                Variables.gracz = "X";
                ktoWygra();
                remis();
                lblGracz.Focus();
            }
            else
            {
                button1.Text = "X";
                button1.BackColor = btnColorXmemory.BackColor;
                Variables.gracz = "O";
                ktoWygra();
                remis();
                lblGracz.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (Variables.gracz == "O")
            {
                button2.Text = "O";
                button2.BackColor = btnColorOmemory.BackColor;
                Variables.gracz = "X";
                ktoWygra();
                remis();
                lblGracz.Focus();
            }
            else
            {
                button2.Text = "X";
                button2.BackColor = btnColorXmemory.BackColor;
                Variables.gracz = "O";
                ktoWygra();
                remis();
                lblGracz.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            if (Variables.gracz == "O")
            {
                button3.Text = "O";
                button3.BackColor = btnColorOmemory.BackColor;
                Variables.gracz = "X";
                ktoWygra();
                remis();
                lblGracz.Focus();
            }
            else
            {
                button3.Text = "X";
                button3.BackColor = btnColorXmemory.BackColor;
                Variables.gracz = "O";
                ktoWygra();
                remis();
                lblGracz.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            if (Variables.gracz == "O")
            {
                button4.Text = "O";
                button4.BackColor = btnColorOmemory.BackColor;
                Variables.gracz = "X";
                ktoWygra();
                remis();
                lblGracz.Focus();
            }
            else
            {
                button4.Text = "X";
                button4.BackColor = btnColorXmemory.BackColor;
                Variables.gracz = "O";
                ktoWygra();
                remis();
                lblGracz.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            if (Variables.gracz == "O")
            {
                button5.Text = "O";
                button5.BackColor = btnColorOmemory.BackColor;
                Variables.gracz = "X";
                ktoWygra();
                remis();
                lblGracz.Focus();
            }
            else
            {
                button5.Text = "X";
                button5.BackColor = btnColorXmemory.BackColor;
                Variables.gracz = "O";
                ktoWygra();
                remis();
                lblGracz.Focus();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            if (Variables.gracz == "O")
            {
                button6.Text = "O";
                button6.BackColor = btnColorOmemory.BackColor;
                Variables.gracz = "X";
                ktoWygra();
                remis();
                lblGracz.Focus();
            }
            else
            {
                button6.Text = "X";
                button6.BackColor = btnColorXmemory.BackColor;
                Variables.gracz = "O";
                ktoWygra();
                remis();
                lblGracz.Focus();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            if (Variables.gracz == "O")
            {
                button7.Text = "O";
                button7.BackColor = btnColorOmemory.BackColor;
                Variables.gracz = "X";
                ktoWygra();
                remis();
                lblGracz.Focus();
            }
            else
            {
                button7.Text = "X";
                button7.BackColor = btnColorXmemory.BackColor;
                Variables.gracz = "O";
                ktoWygra();
                remis();
                lblGracz.Focus();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            if (Variables.gracz == "O")
            {
                button8.Text = "O";
                button8.BackColor = btnColorOmemory.BackColor;
                Variables.gracz = "X";
                ktoWygra();
                remis();
                lblGracz.Focus();
            }
            else
            {
                button8.Text = "X";
                button8.BackColor = btnColorXmemory.BackColor;
                Variables.gracz = "O";
                ktoWygra();
                remis();
                lblGracz.Focus();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            if (Variables.gracz == "O")
            {
                button9.Text = "O";
                button9.BackColor = btnColorOmemory.BackColor;
                Variables.gracz = "X";
                ktoWygra();
                remis();
                lblGracz.Focus();
            }
            else
            {
                button9.Text = "X";
                button9.BackColor = btnColorXmemory.BackColor;
                Variables.gracz = "O";
                ktoWygra();
                remis();
                lblGracz.Focus();
            }
        }

        private void buttonClear()
        {
            button1.Text = "";
            button1.Enabled = true;
            button2.Text = "";
            button2.Enabled = true;
            button3.Text = "";
            button3.Enabled = true;
            button4.Text = "";
            button4.Enabled = true;
            button5.Text = "";
            button5.Enabled = true;
            button6.Text = "";
            button6.Enabled = true;
            button7.Text = "";
            button7.Enabled = true;
            button8.Text = "";
            button8.Enabled = true;
            button9.Text = "";
            button9.Enabled = true;
            button1.BackColor = SystemColors.ButtonFace;
            button2.BackColor = SystemColors.ButtonFace;
            button3.BackColor = SystemColors.ButtonFace;
            button4.BackColor = SystemColors.ButtonFace;
            button5.BackColor = SystemColors.ButtonFace;
            button6.BackColor = SystemColors.ButtonFace;
            button7.BackColor = SystemColors.ButtonFace;
            button8.BackColor = SystemColors.ButtonFace;
            button9.BackColor = SystemColors.ButtonFace;
        }
        private void btnWyczysc_Click(object sender, EventArgs e)
        {
            buttonClear();
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            buttonClear();
            btnColorOmemory.BackColor = SystemColors.ButtonFace;
            btnColorXmemory.BackColor = SystemColors.ButtonFace;
            lblWynikO.Text = "0";
            lblWynikX.Text = "0";
            Variables.wynikO = 0;
            Variables.wynikX = 0;
        }

        private void opcjęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var options = new Options();
            if (options.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                btnColorOmemory.BackColor = options.btnColorO.BackColor;
                btnColorXmemory.BackColor = options.btnColorX.BackColor;
                lblWynikO.Text = Variables.wynikO.ToString();
                lblWynikX.Text = Variables.wynikX.ToString();
                if (Variables.wynikX != 0 || Variables.wynikO != 0)
                {
                    btnResetAll.Enabled = true;
                }
                options.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWynikO.Text = Variables.wynikO.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var frm2 = new Options();
        }
    }
}
