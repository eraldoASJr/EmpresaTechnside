using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esbocoProjeto2
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
            
                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FrmClientes>();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form2>();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form3>();
        }

        private void btnContas_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form4>();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
           
           // AbrirFormNoPanel<loginesenha>();
        }

        private void panelConteudo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
