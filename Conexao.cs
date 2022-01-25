/*
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esbocoProjeto2
{
    public class Conexao
    {
        SqlConection con = new SqlConection();

        // construtor
        
        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-QPI8KBM\SQLEXPRESS;Initial Catalog=TechInside;Integrated Security=True"; 
        }
        //metedo conectar
        public  SqlConection conectar ()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
           return;
        }
        //metodo desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
*/