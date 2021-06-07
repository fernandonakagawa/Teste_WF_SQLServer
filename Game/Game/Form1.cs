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
using System.Diagnostics;

namespace Game
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            SqlCommand sql = new SqlCommand();
            conexao.ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Game;Integrated Security=True";
            sql.Connection = conexao;
            /*sql.CommandText = "INSERT INTO Ranking (nome, pontos) VALUES " +
                "(@nome, @pontos) ";
            sql.Parameters.AddWithValue("@nome", tbNome.Text);
            sql.Parameters.AddWithValue("@pontos", (int)ndPontos.Value);*/
            
            //pode ser escrito dessa forma também
            sql.CommandText = $"INSERT INTO Ranking (nome, pontos) VALUES " +
                $"('{tbNome.Text}',{(int)ndPontos.Value})";

            int linhasAfetadas = 0;
            try
            {
                conexao.Open();
                linhasAfetadas = sql.ExecuteNonQuery();
            }
            catch(Exception exception)
            {
                MessageBox.Show($"A conexão com o banco falhou. Erro: {exception.ToString()}");
                Debug.WriteLine(exception.ToString());
            }
            finally
            {
                conexao.Close();
                MessageBox.Show($"Registro feito com sucesso.\n" +
                    $"Linhas afetadas: {linhasAfetadas} ");
            }

        }
    }
}
