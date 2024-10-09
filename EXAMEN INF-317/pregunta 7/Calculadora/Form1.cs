using System;
using System.Data;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private string es = string.Empty;
        private bool operacion = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (operacion)
            {
                es = string.Empty;
                operacion = false;
            }
            es += btn.Text;
            pantalla();

        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!string.IsNullOrEmpty(es) && !operacion)
            {
                es += " " + btn.Text + " ";
                pantalla();
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(es))
            {
                try
                {
                    double res = Evaluar(es);
                    es += "=" + res.ToString();
                }

                catch(Exception)
                {
                    es = "Error";
                }
                pantalla();
                operacion = true;

            }

        }

        private double Evaluar(string exp)
        {
            var table = new DataTable();
            return Convert.ToDouble(table.Compute(exp, string.Empty));
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            es = string.Empty;
            pantalla();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if(!es.EndsWith("."))
            {
                es += ".";
                pantalla();
            }
        }

        private void btnParentesis_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            es += btn.Text;
            pantalla();
        }

        private void pantalla()
        {
            result.Text = es;
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
