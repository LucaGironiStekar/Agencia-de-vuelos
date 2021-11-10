using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_de_viajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtDestinos_Click(object sender, EventArgs e)
        {
            Mapa Mapamundi = new Mapa();
            Mapamundi.Show();
            this.Hide();
        }

        private void btConsultas_Click(object sender, EventArgs e)
        {
            Consultas Consultass = new Consultas();
            Consultass.Show();
            this.Hide();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Environment.Exit(1);
        }

        private void btOfertas_Click(object sender, EventArgs e)
        {
            Form4 Ofertas = new Form4();
            Ofertas.Show();
            this.Hide();
        }
    }
}
