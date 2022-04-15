using System;
using System.Globalization;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        private float valor1, valor2 = 0;
        private string operation = "";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void buttonzero_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "0";
        }

        private void buttonone_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "1";
        }

        private void buttontwo_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "2";
        }

        private void buttonthree_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "3";
        }

        private void buttonfour_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "4";
        }

        private void buttonfive_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "5";
        }

        private void buttonsix_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "6";
        }

        private void buttonseven_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "7";
        }

        private void buttoneight_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "8";
        }

        private void buttonnine_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "9";
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            if(TxtResultado.Text != "")
            {
                valor1 = float.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operation = "SOMA";
                LabelOperacao.Text = "+";
            }
            else
            {
               MessageBox.Show("Informe um valor para realizar a operação");
            }
        }
        private void buttonminus_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {
                valor1 = float.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operation = "SUB";
                LabelOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para realizar a operação");
            }
        }

        private void buttonasterisk_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {
                valor1 = float.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operation = "MULT";
                LabelOperacao.Text = "*";
            }
            else
            {
                MessageBox.Show("Informe um valor para realizar a operação");
            }
        }

        private void buttonbar_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {
                valor1 = float.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operation = "DIV";
                LabelOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para realizar a operação");
            }
        }

        private void buttonce_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "";
            LabelOperacao.Text = "";
        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "";
            LabelOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void buttondot_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + ".";
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            if(TxtResultado.Text != "")
            {
                valor2 = float.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                if (operation == "SOMA")
                {
                    TxtResultado.Text = Convert.ToString(valor1 + valor2);
                }
                else if (operation == "SUB")
                {
                    TxtResultado.Text = Convert.ToString(valor1 - valor2);
                }
                else if (operation == "MULT")
                {
                    TxtResultado.Text = Convert.ToString(valor1 * valor2);
                }
                else if (operation == "DIV")
                {
                    TxtResultado.Text = Convert.ToString(valor1 / valor2);
                }
            }
            
        }
    }
}