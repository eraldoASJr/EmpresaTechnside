using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esbocoProjeto2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            SqlConnection Comn = new SqlConnection("Data Source=DESKTOP-QPI8KBM\\SQLEXPRESS;Initial Catalog=TechInside;Integrated Security=True");

            string sql = "INSERT INTO Contas (arquivo_remessa, id_produto, cnpj_cliente) VALUES  (@arquivo_remessa, @id_produto, @cnpj_cliente)";

            Random numeroID = new Random();

            numeroID.Next();

            try
            {
                SqlCommand C = new SqlCommand(sql, Comn);

                C.Parameters.Add(new SqlParameter("id", numeroID.Next()));
                C.Parameters.Add(new SqlParameter("arquivo_remessa ", this.TxtArquiRemessa.Text));
                C.Parameters.Add(new SqlParameter("id_produto ", this.TxtIdProduto.Text));
                C.Parameters.Add(new SqlParameter("cnpj_cliente ", this.TxtCNPJCliente.Text));
                
                

                Comn.Open();
                C.ExecuteNonQuery();

                Comn.Close();

                MessageBox.Show("Enviado com sucesso ! ");

                TxtArquiRemessa.Text = " ";
                TxtIdProduto.Text = " ";
                TxtCNPJCliente.Text = " ";
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex);
            }
            finally
            {
                Comn.Close();

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
