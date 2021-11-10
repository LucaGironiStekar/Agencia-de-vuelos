using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agencia_de_viajes
{
    public partial class Mapa : Form
    {
        public Mapa()
        {
            InitializeComponent();
        }

        private void BtVolverdeMapa_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void btAustralia_Click(object sender, EventArgs e)
        {
            pAustralia.Show();
            pJapon.Hide();
            pIndia.Hide();
            pEgipto.Hide();
            pEspaña.Hide();
            pColombia.Hide();
            pEstadosUnidos.Hide();
        }

        private void btJapon_Click(object sender, EventArgs e)
        {
            pJapon.Show();
            pAustralia.Hide();
            pIndia.Hide();
            pEgipto.Hide();
            pEspaña.Hide();
            pColombia.Hide();
            pEstadosUnidos.Hide();
        }

        private void btIndia_Click(object sender, EventArgs e)
        {
            pIndia.Show();
            pAustralia.Hide();
            pJapon.Hide();
            pEgipto.Hide();
            pEspaña.Hide();
            pColombia.Hide();
            pEstadosUnidos.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pEgipto.Show();
            pAustralia.Hide();
            pJapon.Hide();
            pIndia.Hide();
            pEspaña.Hide();
            pColombia.Hide();
            pEstadosUnidos.Hide();
        }

        private void btEspaña_Click(object sender, EventArgs e)
        {
            pEspaña.Show();
            pAustralia.Hide();
            pJapon.Hide();
            pIndia.Hide();
            pEgipto.Hide();
            pColombia.Hide();
            pEstadosUnidos.Hide();
        }

        private void btColombia_Click(object sender, EventArgs e)
        {
            pColombia.Show();
            pAustralia.Hide();
            pJapon.Hide();
            pIndia.Hide();
            pEgipto.Hide();
            pEspaña.Hide();
            pEstadosUnidos.Hide();
        }

        private void btEstadosUnidos_Click(object sender, EventArgs e)
        {
            pEstadosUnidos.Show();
            pAustralia.Hide();
            pJapon.Hide();
            pIndia.Hide();
            pEgipto.Hide();
            pEspaña.Hide();
            pColombia.Hide();
        }
    }
}
