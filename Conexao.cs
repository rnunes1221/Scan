using System.Data.SqlClient;

namespace Scan {
    public class Conexao {
        SqlConnection con = new SqlConnection();
        
        
        //Construtor

        public Conexao() {

            con.ConnectionString = @"Data Source=ABHU-TI05\SQLEXPRESS;Initial Catalog=Dados;Integrated Security=True"; 

        
        }
        
        
        //MetodoConectar
        public SqlConnection conectar() {
            if (con.State == System.Data.ConnectionState.Closed) {
                con.Open();
            }
            return con;
        }
        //Metodo Desconectar
        public void desconectar() {
            if (con.State == System.Data.ConnectionState.Open) {
                con.Close();
            }
            }
    }
}