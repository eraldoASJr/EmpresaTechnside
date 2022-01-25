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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            SqlConnection Comn = new SqlConnection("Data Source=DESKTOP-QPI8KBM\\SQLEXPRESS;Initial Catalog=TechInside;Integrated Security=True");

            string sql = "INSERT INTO Compras (quantidade, nome_produto, preco, total) VALUES  (@quantidade, @nome_produto, @preco, @total)";

            Random numeroID = new Random();
            numeroID.Next();

            try
            {
                SqlCommand C = new SqlCommand(sql, Comn);

                C.Parameters.Add(new SqlParameter("id", numeroID.Next()));
                C.Parameters.Add(new SqlParameter("quantidade ", this.TxtQuantidade.Text));
                C.Parameters.Add(new SqlParameter("nome_produto ", this.TxtNomeProduto.Text));
                C.Parameters.Add(new SqlParameter("preco ", this.TxtPreco.Text));
                C.Parameters.Add(new SqlParameter("total ", this.TxtTotal.Text));
                //C.Parameters.Add(new SqlParameter("cnpj_cliente ", this.TxtNomEmpre.Text));

                Comn.Open();
                C.ExecuteNonQuery();

                Comn.Close();

                MessageBox.Show("Enviado com sucesso ! ");

                TxtQuantidade.Text = " ";
                TxtNomeProduto.Text = " ";
                TxtPreco.Text = " ";
                TxtTotal.Text = " ";
                
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
    }
}
