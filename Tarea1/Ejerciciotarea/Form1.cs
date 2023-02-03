using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejerciciotarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private int parimpar(int numero)
        {
            if (numero % 2 == 0)
            {
                MessageBox.Show("El numero es par", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (numero % 2 > 0)
            {
                MessageBox.Show("El numero es impar", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            return numero;
        }

        private decimal posneg(decimal numero)
        {
            if (numero > 0)
            {
                MessageBox.Show("El numero es positivo", "Resultado 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (numero < 0) 
            {
                MessageBox.Show("El numero es negativo", "Resultado 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return numero;
        }
        

        private void CalcularButton_Click(object sender, EventArgs e)
        {

            int total = parimpar(Convert.ToInt32(numeroTextBox.Text));
            decimal total2 = posneg(Convert.ToDecimal(numeroTextBox.Text));
        }
    }
}
