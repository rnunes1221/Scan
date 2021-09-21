using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scan {
    public class Cadastro {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public Cadastro(String ip, String host, String status, String lastUp) {
            //Comando SQL - INSERT, UPDATE, DELETE

            cmd.CommandText = "insert into Historico (Ip, Host, Status, LastUP) values (@ip, @host, @status, @lastUp)";

            //Parametros
            cmd.Parameters.AddWithValue("@ip", ip);
            cmd.Parameters.AddWithValue("@host", host);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@lastUP", lastUp);


            try {
                //Conectar com Banco
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
               //desconectar
                conexao.desconectar();
                //Mostrar mensagem de erro ou sucesso
                this.mensagem = "Cadastrado com Sucesso";
            }
            catch (SqlException e) {
                this.mensagem = "Erro ao se conectar com o banco da Dados " +e.ToString() ;

            }
            


            
         

        }
    }
}
