using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4_SIM
{
    public partial class Resultados : Form
    {
        public Resultados(double[] vector)
        {
            InitializeComponent();

            // Falta verificar cuando la cantidad es 0 -> no se puede calcular (da NaN)
            txtEsperaE.Text = (Math.Truncate((vector[0] / vector[1]) *100) / 100).ToString();
            txtEsperaR.Text = (Math.Truncate((vector[2] / vector[3]) * 100) / 100).ToString();
            txtEsperaV.Text = (Math.Truncate((vector[4] / vector[5]) * 100) / 100).ToString();
            txtEsperaAE.Text = (Math.Truncate((vector[6] / vector[7]) * 100) / 100).ToString();
            txtEsperaP.Text = (Math.Truncate((vector[8] / vector[9]) * 100) / 100).ToString();
        }

        private void Resultados_Load(object sender, EventArgs e)
        {
        }
    }
}
