using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;
        private double resultado;
        private int operacion;
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_0_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "9";
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            Display.Text = "";
        }

        private void btn_coma_Click(object sender, EventArgs e)
        {
            Display.Text= Display.Text + ",";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(Display.Text);

            switch (operacion)
            {
                case 1: resultado = valor1 + valor2;
                        break;
                case 2: resultado = valor1 - valor2;
                        break;
                case 3: resultado = valor1 * valor2;
                        break;
                case 4: resultado = valor1 / valor2;
                        break;
            }

            Display.Text = resultado.ToString();
        }

        private void btn_mas_Click(object sender, EventArgs e)
        {
            operacion = 1;
            valor1 = Convert.ToDouble(Display.Text);
            Display.Text = "";
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            operacion = 2;
            valor1 = Convert.ToDouble(Display.Text);
            Display.Text = "";
        }

        private void btn_por_Click(object sender, EventArgs e)
        {
            operacion = 3;
            valor1 = Convert.ToDouble(Display.Text);
            Display.Text = "";
        }

        private void btn_dividido_Click(object sender, EventArgs e)
        {
            operacion = 4;
            valor1 = Convert.ToDouble(Display.Text);
            Display.Text = "";
        }
    }
}
