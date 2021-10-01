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


namespace Scan {
    public partial class Historico : MetroFramework.Forms.MetroForm {
        public Historico() {
            InitializeComponent();
        }

        private void ListViewHistorico_Enter(object sender, EventArgs e) {

        }

        private void Historico_Load(object sender, EventArgs e) {
          

            string sql = "SELECT * FROM HISTORICO  WHERE Ip='"+Program.ipgrid+"'";
            Conexao conexao = new Conexao();
            SqlConnection cnn = conexao.conectar();
         //   MessageBox.Show(sql);
            SqlCommand cmd = new SqlCommand(sql, cnn);
           
            SqlDataReader retornoConsulta = cmd.ExecuteReader();

            // Limpa os itens do ListView
            ListViewHistorico.Items.Clear();

            // Se houver retorno de dados com a consulta SQL,
            // o bloco abaixo será executado.

            while (retornoConsulta.Read()) {
                ListViewItem lvItem = new ListViewItem(retornoConsulta["Ip"].ToString());



                // Esse componente recebe os itens do Reader 
                // para adicionar no ListView.

                
                lvItem.SubItems.Add(retornoConsulta["Host"].ToString());
                lvItem.SubItems.Add(retornoConsulta["Status"].ToString());
                lvItem.SubItems.Add(retornoConsulta["LastUP"].ToString());
               


                //    Adicionando os itens do ListViewItem no ListView.
                ListViewHistorico.Items.Add(lvItem);

            }

            retornoConsulta.Close();
            cnn.Close();
        }

        private void ListViewHistorico_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
