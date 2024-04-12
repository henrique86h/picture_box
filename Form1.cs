using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picture_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureBoxMostrar.Visible = true;
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            this.pictureBoxMostrar.Visible = false;
        }

        private void btn2Mostrar_Click(object sender, EventArgs e)
        {
            this.pictureBoxMostrar2.Visible = true;
        }

        private void btn2Ocultar_Click(object sender, EventArgs e)
        {
            this.pictureBoxMostrar2.Visible = false;
        }

        private void btnOcultarTodas_Click(object sender, EventArgs e)
        {
            this.pictureBoxMostrar.Visible = false;
            this.pictureBoxMostrar2.Visible = false;
        }
    }
}
