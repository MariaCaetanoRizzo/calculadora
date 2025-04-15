using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAtividadePoo
{
    public partial class frmdivisao : Form
    {
        public frmdivisao()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, result;

            num1 = Convert.ToDouble(txtsoma1.Text);
            num2 = Convert.ToDouble(txtsoma2.Text);

            result = (num1 / num2);
            txtresultado.Text = result.ToString();
           
            
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtsoma1.Clear();
            txtsoma2.Clear();
            txtresultado.Clear();
            txtsoma1.Focus();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, result;

            num1 = Convert.ToDouble(txtsoma1.Text);
            num2 = Convert.ToDouble(txtsoma2.Text);

            result = (num1 + num2);
            txtresultado.Text = result.ToString();
        }

        private void btnsubtrair_Click(object sender, EventArgs e)
        {
            double num1, num2, result;

            num1 = Convert.ToDouble(txtsoma1.Text);
            num2 = Convert.ToDouble(txtsoma2.Text);

            result = (num1 - num2);
            txtresultado.Text = result.ToString();
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            double num1, num2, result;

            num1 = Convert.ToDouble(txtsoma1.Text);
            num2 = Convert.ToDouble(txtsoma2.Text);

            result = (num1 * num2);
            txtresultado.Text = result.ToString();
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            double num1, num2, result;

            num1 = Convert.ToDouble(txtsoma1.Text);
            num2 = Convert.ToDouble(txtsoma2.Text);

            result = Math.Sqrt(num1);
            txtresultado.Text = result.ToString();
        }
    }
}
