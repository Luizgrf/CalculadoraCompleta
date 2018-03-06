using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraCompleta
{
    public partial class frmCalc : Form
    {
        int operacao;
        double result, valor1, valor2;
        int cont = 0;

        public frmCalc()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + "0";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + ",";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                valor1 = System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = " ";
                lblSalvar.Text += valor1 + " ";
                cont++;
            }
            else{
                valor2 = System.Convert.ToDouble(txbResult.Text);
                result = valor1 + valor2;
                txbResult.Text = " ";
                lblSalvar.Text += result + " ";
                valor1 = result;
            }
            
            operacao = 1;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (operacao)
            {
                case 1:
                    valor2 = System.Convert.ToDouble(txbResult.Text);
                    result = valor1 + valor2;
                    txbResult.Text = result + " ";
                    lblSalvar.Text = " ";
                    valor1 = result;
                    break;
                case 2:
                    valor2 = System.Convert.ToDouble(txbResult.Text);
                    result = valor1 - valor2;
                    txbResult.Text = result + " ";
                    lblSalvar.Text = " ";
                    valor1 = result;
                    break;
                case 3:
                    valor2 = System.Convert.ToDouble(txbResult.Text);
                    result = valor1 / valor2;
                    txbResult.Text = result + " ";
                    lblSalvar.Text = " ";
                    valor1 = result;
                    break;
                case 4:
                    valor2 = System.Convert.ToDouble(txbResult.Text);
                    result = valor1 * valor2;
                    txbResult.Text = result + " ";
                    lblSalvar.Text = " ";
                    valor1 = result;
                    break;
                case 5:
                    valor2 = System.Convert.ToDouble(txbResult.Text);
                    result = Math.Pow(valor1, valor2);
                    txbResult.Text = result + " ";
                    lblSalvar.Text = " ";
                    valor1 = result;
                    break;
                case 6:
                    valor2 = System.Convert.ToDouble(txbResult.Text);
                    result = Math.Pow(valor1, 1/valor2);
                    txbResult.Text = result + " ";
                    lblSalvar.Text = " ";
                    valor1 = result;
                    break;
            }
         }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                valor1 = System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = " ";
                lblSalvar.Text += valor1 + " ";
                cont++;
            }
            else
            {
                valor2 = System.Convert.ToDouble(txbResult.Text);
                result = valor1 - valor2;
                txbResult.Text = " ";
                lblSalvar.Text += result + " ";
                valor1 = result;
            }

            operacao = 2;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                valor1 = System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = " ";
                lblSalvar.Text += valor1 + " ";
                cont++;
            }
            else
            {
                valor2 = System.Convert.ToDouble(txbResult.Text);
                result = valor1 / valor2;
                txbResult.Text = " ";
                lblSalvar.Text += result + " ";
                valor1 = result;
            }

            operacao = 3;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                valor1 = System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = " ";
                lblSalvar.Text += valor1 + " ";
                cont++;
            }
            else
            {
                valor2 = System.Convert.ToDouble(txbResult.Text);
                result = valor1 * valor2;
                txbResult.Text = " ";
                lblSalvar.Text += result + " ";
                valor1 = result;
            }

            operacao = 4;
        }

        private void btnTroca_Click(object sender, EventArgs e)
        {
                valor1 = System.Convert.ToDouble(txbResult.Text);
                valor1 *= -1;
                txbResult.Text = valor1 + " ";
                lblSalvar.Text = " ";
        }

        private void btnExpo_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                valor1 = System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = " ";
                lblSalvar.Text += valor1 + " ";
                cont++;
            }
            else
            {
                valor2 = System.Convert.ToDouble(txbResult.Text);
                result = Math.Pow(valor1, valor2);
                txbResult.Text = " ";
                lblSalvar.Text += result + " ";
                valor1 = result;
            }

            operacao = 5;
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                valor1 = System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = " ";
                lblSalvar.Text += valor1 + " ";
                cont++;
            }
            else
            {
                valor2 = System.Convert.ToDouble(txbResult.Text);
                result = Math.Pow(valor1, 1/valor2);
                txbResult.Text = " ";
                lblSalvar.Text += result + " ";
                valor1 = result;
            }

            operacao = 6;
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txbResult.Text = " ";
            lblSalvar.Text = " ";
            valor1 = 0;
            valor2 = 0;
            cont = 0;
        }

        private void btnPorcent_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                valor1 = System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = " ";
                lblSalvar.Text += valor1 + " ";
                cont++;
            }
            else
            {
                valor2 = System.Convert.ToDouble(txbResult.Text);
                result = valor2/100;
                txbResult.Text = " ";
                lblSalvar.Text += result + " ";
                valor1 = result;
            }

            operacao = 7;
        }

      }


    }
