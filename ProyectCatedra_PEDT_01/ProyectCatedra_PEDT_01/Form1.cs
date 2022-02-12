using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectCatedra_PEDT_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picboxexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picboxmaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized; //Esto hará que la ventana se maximize
            picboxmaximizar.Visible = false; //Ocultamos el boton cuando ya esté maximizado
        }

        private void picboxminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //Esto hace que cuando se presione el icono, la ventana se minimize
            picboxmaximizar.Visible = true;
        }
    }
}
