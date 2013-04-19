using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica_6
{
    public partial class sub : Form
    {
        public sub()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void producto_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void fac_Click(object sender, EventArgs e)
        {
            double  producto = double.Parse(this.producto.Text);
            double  producto2= double.Parse(this.producto2.Text);
            double  producto3= double.Parse(this.producto3.Text);
            double sub = producto + producto2 + producto3;

            double iva = sub * .16;

            double total = sub + iva;

            this.s.Text = sub.ToString();

            this.i.Text = iva.ToString();

            this.t.Text = total.ToString();
        }

        private void lim_Click(object sender, EventArgs e)
        {
            this.producto.Text = "";
            this.producto2.Text = "";
            this.producto3.Text = "";
            this.s.Text = "";
            this.i.Text = "";
            this.t.Text = "";
        }
    }
}
