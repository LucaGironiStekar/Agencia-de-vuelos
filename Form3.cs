using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agencia_de_viajes
{
    public partial class Consultas : Form
    {

        public Pais Pap = new Pais();
        

        public Consultas()
        {
            InitializeComponent();

            dtSugerencias.DataSource = Pap.ListaPaises;

        }


        private void Consultas_Load(object sender, EventArgs e)
        {

        }

        private void btDesear_Click(object sender, EventArgs e)
        {
            Pap.GuardarPais(txtPaises.Text);
            dtSugerencias.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}
