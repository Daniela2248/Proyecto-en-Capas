using System;
using Capa_Logica;
using System.Windows.Forms;

namespace Capa_Diseño
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
        public void funcion()
        {
            Proceso objtraer = new Proceso();
            objtraer.d1 = Convert.ToDouble(Txtd1.Text);
            objtraer.d2 = Convert.ToDouble(Txtd2.Text);
        }
         private void Btnsuma_Click(object sender, EventArgs e)
        {
            Proceso objtraer = new Proceso();
            objtraer.d1 = Convert.ToDouble(Txtd1.Text);
            objtraer.d2 = Convert.ToDouble(Txtd2.Text);
            objtraer.prosuma();
            TxtTotal.Text = Convert.ToString(objtraer.d3);
        }

        private void Btnresta_Click(object sender, EventArgs e)
        {
            Proceso objtraer = new Proceso();
            objtraer.d1 = Convert.ToDouble(Txtd1.Text);
            objtraer.d2 = Convert.ToDouble(Txtd2.Text);
            objtraer.proresta();
            TxtTotal.Text = Convert.ToString(objtraer.d3);
        }

        private void Btnmult_Click(object sender, EventArgs e)
        {
            Proceso objtraer = new Proceso();
            objtraer.d1 = Convert.ToDouble(Txtd1.Text);
            objtraer.d2 = Convert.ToDouble(Txtd2.Text);
            objtraer.promult();
            TxtTotal.Text = Convert.ToString(objtraer.d3);
        }

        private void Btndiv_Click(object sender, EventArgs e)
        {
            Proceso objtraer = new Proceso();
            objtraer.d1 = Convert.ToDouble(Txtd1.Text);
            objtraer.d2 = Convert.ToDouble(Txtd2.Text);
            if (objtraer.d2 == 0)
            {
                MessageBox.Show("Division entre cero es indefinida");
            }
            else
            {
                objtraer.prodiv();
                TxtTotal.Text = Convert.ToString(objtraer.d3);
            }
        }
    }
}
