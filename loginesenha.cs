using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace esbocoProjeto2
{
    public partial class loginesenha : Form
    {
        Thread nt;
        public loginesenha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && TxtSenha.Text == "admin")
            {
                this.Close();
                nt = new Thread(novologinesenha);

                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else if(string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Usuário está em branco! ");
                txtUsuario.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(TxtSenha.Text))
            {
                MessageBox.Show("Senha está em branco! ");
                TxtSenha.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Login ou Senha Inválidos!");
            }
            //DialogResult = DialogResult.OK;
        }

        private void novologinesenha()
        {
            Application.Run(new FrmMenu());
        }

        private void loginesenha_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
