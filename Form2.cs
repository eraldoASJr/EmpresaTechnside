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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Comn = new SqlConnection("Data Source=DESKTOP-QPI8KBM\\SQLEXPRESS;Initial Catalog=TechInside;Integrated Security=True");

            string sql = "INSERT INTO Vendas (id_produto, nome_produto, preço, quatidade_vendas) VALUES  (@id_produto, @nome_produto, @preço, @quatidade_vendas)";

            Random numeroID = new Random();
            numeroID.Next();

            try
            {
                SqlCommand C = new SqlCommand(sql, Comn);

                C.Parameters.Add(new SqlParameter("id", numeroID.Next()));
                C.Parameters.Add(new SqlParameter("id_produto ", this.TxtIdProduto.Text));
                C.Parameters.Add(new SqlParameter("nome_produto", this.TxtNomeProduto.Text));
                C.Parameters.Add(new SqlParameter("preço", this.TxtPrecoPro.Text));
                C.Parameters.Add(new SqlParameter("quatidade_vendas ", this.TxtQuantVendas.Text));
                

                Comn.Open();
                C.ExecuteNonQuery();

                Comn.Close();

                MessageBox.Show("Enviado com sucesso ! ");
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
