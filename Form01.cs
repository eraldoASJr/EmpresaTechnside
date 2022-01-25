using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;


namespace esbocoProjeto2
{
    public partial class FrmClientes : Form
    {
        private SqlDataAdapter da;
        private SqlCommand comando;

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*começa aqi ||||||

               string strConn = "Data Source=DESKTOP-QPI8KBM\\SQLEXPRESS;Initial Catalog=TechInside;Integrated Security=True";
               SqlConnection conn = new SqlConnection(strConn);
               SqlCommand cmm = new SqlCommand("INSERT INTO Clientes (cnpj_cliente, nome_cliente, email, endereco, nomme_empresa) VALUES  " +
                   "(@cnpj_cliente, @nome_cliente, @email, @endereco, @nomme_empresa)",conn); 

               //termina aqui o codigo prof leo

               */

            SqlConnection Comn = new SqlConnection("Data Source=DESKTOP-QPI8KBM\\SQLEXPRESS;Initial Catalog=TechInside;Integrated Security=True");

            string sql = "INSERT INTO Clientes (cnpj_cliente, nome_cliente, email, endereco, nomme_empresa) VALUES  (@cnpj_cliente, @nome_cliente, @email, @endereco, @nomme_empresa)";

            Random numeroID = new Random();
            numeroID.Next();

            try
            {
                SqlCommand C = new SqlCommand(sql, Comn);

                C.Parameters.Add(new SqlParameter("id", numeroID.Next()));
                if (string.IsNullOrEmpty(txtCnpj.Text))
                {
                    MessageBox.Show("CNPJ está em branco! ");
                    txtCnpj.Focus();
                    return;
                }
                C.Parameters.Add(new SqlParameter("cnpj_cliente", this.txtCnpj.Text));
                C.Parameters.Add(new SqlParameter("nome_cliente", this.TxtNomeCliente.Text));
                C.Parameters.Add(new SqlParameter("email", this.TxtEmail.Text));
                C.Parameters.Add(new SqlParameter("endereco", this.TxtEndereco.Text));
                C.Parameters.Add(new SqlParameter("nomme_empresa", this.TxtNomEmpre.Text));

                Comn.Open();
                C.ExecuteNonQuery();

                Comn.Close();

                MessageBox.Show("Enviado com sucesso ! ");
                txtCnpj.Text = " ";
                TxtNomeCliente.Text = " ";
                TxtEmail.Text = " ";
                TxtEndereco.Text = " ";
                TxtNomEmpre.Text = " ";
            }
            catch (SqlException ex)
            {
                if (string.IsNullOrEmpty(txtCnpj.Text))
                {
                    MessageBox.Show("CNPJ está em branco! ");
                    txtCnpj.Focus();
                    return;

                }

                MessageBox.Show("Ocorreu o erro: " + ex);
            }
            finally
            {
                Comn.Close();

            }


        }

        private void carregarlista()
        {
            SqlConnection Comn = new SqlConnection("Data Source=DESKTOP-QPI8KBM\\SQLEXPRESS;Initial Catalog=TechInside;Integrated Security=True");

            //LsbCNPJ.Items.Clear();
            //LsbNomeCliente.Items.Clear();

            string StrSql = "SELECT * FROM Clientes";

            DataSet ds = new DataSet();

            da = new SqlDataAdapter(StrSql, Comn);

            Comn.Open();

            da.Fill(ds);

            DtvDados.DataSource = ds.Tables[0];

            SqlCommand comand, Comando = new SqlCommand(StrSql);

            //dr = Comando.ExecuteReader();

            // if (dr.HasRows)
            //{
            //while(dr.Read())
            // {
            //   LsbCNPJ.Items.Add(dr [0].ToString());
            // LsbNomeCliente.Items.Add(dr [1].ToString());
            //  //   }
            // }
            Comn.Close();


        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsultar_Click_1(object sender, EventArgs e)
        {
            carregarlista();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            carregarlista();
        }

        private void LsbCNPJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                // LsbCNPJ.SelectedIndex = l.SelectedIndex;
                // LsbNomeCliente.SelectedIndex = l.SelectedIndex;

                //  txtCnpj.Text = LsbCNPJ.SelectedItem.ToString();
                //TxtNomeCliente.Text = LsbNomeCliente.SelectedItem.ToString();
            }

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

               string connectionString = ("Data Source=DESKTOP-QPI8KBM\\SQLEXPRESS;Initial Catalog=TechInside;Integrated Security=True");

                string commandString = "DELETE FROM clientes WHERE cnpj_cliente = "+txtCnpj.Text;

                SqlConnection ligacao = new SqlConnection(connectionString);
                ligacao.Open();

                SqlCommand comando = new SqlCommand(commandString, ligacao);

                comando.ExecuteNonQuery();


                ligacao.Close();

                MessageBox.Show("Excluido com sucesso.");
            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Adicione o Número do CNPJ no campo em Branco!!");

            
            }
           

            
        }

        private void DtvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCnpj_TextChanged(object sender, EventArgs e)
        {

        }
    }  

    }
