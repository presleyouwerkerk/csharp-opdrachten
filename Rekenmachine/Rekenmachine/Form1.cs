using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekenmachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Bereken('+');
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            Bereken('-');
        }

        private void btnKeer_Click(object sender, EventArgs e)
        {
            Bereken('*');
        }

        private void btnDelen_Click(object sender, EventArgs e)
        {
            if (tbGetal2.Text == "0")
            {
                MessageBox.Show("Kan niet delen door nul.");
                return;
            }
            Bereken('/');
        }

        private void btnWortelTrekken_Click(object sender, EventArgs e)
        {
            Bereken('√');
        }

        private void btnMachtsVerheffen_Click(object sender, EventArgs e)
        {
            Bereken('^');
        }

        private void Bereken(char operatie)
        {
            try
            {
                double getal1 = Convert.ToDouble(tbGetal1.Text);
                double getal2 = Convert.ToDouble(tbGetal2.Text);
                double resultaat = 0;

                switch (operatie)
                {
                    case '+':
                        resultaat = getal1 + getal2;
                        break;
                    case '-':
                        resultaat = getal1 - getal2;
                        break;
                    case '*':
                        resultaat = getal1 * getal2;
                        break;
                    case '/':
                        resultaat = getal1 / getal2;
                        break;
                    case '√':
                        resultaat = Math.Sqrt(getal1);
                        break;
                    case '^':
                        resultaat = Math.Pow(getal1, getal2);
                        break;
                }

                tbResultaat.Text = resultaat.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ongeldige invoer. Voer geldige getallen in.");
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deze rekenmachine is gemaakt door Presley Ouwerkerk.");
        }
    }
}
