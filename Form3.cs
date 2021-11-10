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
        //public System.Data.DataTable dtSugerencias = new DataTable();

        public Consultas()
        {
            InitializeComponent();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }

        private void btDesear_Click(object sender, EventArgs e)
        {
            int n = dtSugerencias.Rows.Add();
            dtSugerencias.Rows[n].Cells[0].Value = txtPaises;
            txtPaises.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}
