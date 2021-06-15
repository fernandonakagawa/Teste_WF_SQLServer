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
            if (tbNome.Text.Trim().Length > 0)
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
                    $"('{tbNome.Text.Trim()}',{(int)ndPontos.Value})";

                int linhasAfetadas = 0;
                try
                {
                    conexao.Open();
                    linhasAfetadas = sql.ExecuteNonQuery();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"A conexão com o banco falhou. Erro: {exception.ToString()}");
                    Debug.WriteLine(exception.ToString());
                }
                finally
                {
                    conexao.Close();
                    MessageBox.Show($"Registro feito com sucesso.\n" +
                        $"Linhas afetadas: {linhasAfetadas} ");
                    tbNome.Text = "";
                    ndPontos.Value = 0;
                    AtualizarRanking();
                }
            }
            else
            {
                MessageBox.Show("Preencha o nome!");
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarRanking();
        }

        private void AtualizarRanking()
        {
            SqlConnection conexao = new SqlConnection();
            SqlCommand sql = new SqlCommand();
            conexao.ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Game;Integrated Security=True";
            sql.Connection = conexao;
            sql.CommandText = $"SELECT TOP 10 * FROM Ranking " +
                $"ORDER BY pontos DESC; ";

            SqlDataAdapter adaptador = new SqlDataAdapter(sql);

            try
            {
                conexao.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A conexão com o banco falhou. Erro: {ex.ToString()}");
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                conexao.Close();
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dgvRanking.DataSource = tabela;
                dgvRanking.Columns["idRanking"].Visible = false;
                /*
                 * Explicação sobre TryParse
                 * float x = 0;
                if (!float.TryParse(tbNome.Text, out x)) MessageBox.Show("Impossível converter.");
                else MessageBox.Show("Conversão feita com sucesso!");
                */
            }

        }

        private void dgvRanking_SelectionChanged(object sender, EventArgs e)
        {
            //int celulasSelecionadas = dgvRanking.SelectedCells.Count;
            //MessageBox.Show($"Selection Changed {celulasSelecionadas}");
        }

        private void dgvRanking_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //int celulasSelecionadas = dgvRanking.SelectedCells.Count;
            //MessageBox.Show($"Cell Enter {celulasSelecionadas}");

            if(dgvRanking.SelectedCells.Count > 0)
            {
                gbEditar.Enabled = true;
                btDeletar.Enabled = true;
                int linhaSelecionada = dgvRanking.SelectedCells[0].RowIndex;
                if (linhaSelecionada < dgvRanking.Rows.Count - 1)
                {
                    string nome = dgvRanking.Rows[linhaSelecionada].Cells[1].Value.ToString();
                    int pontos;
                    int.TryParse(
                        dgvRanking.Rows[linhaSelecionada].Cells[2].Value.ToString(),
                        out pontos);
                    tbNomeEditar.Text = nome;
                    ndPontosEditar.Value = pontos;
                    lbEditando.Text = $"Editando registro de {nome} pontos: {pontos}";
                }
                else
                {
                    gbEditar.Enabled = false;
                    btDeletar.Enabled = false;
                }
            }
            else
            {
                gbEditar.Enabled = false;
                btDeletar.Enabled = false;
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvRanking.SelectedCells[0].RowIndex;
            int id = int.Parse(
                dgvRanking.Rows[linhaSelecionada].Cells[0].Value.ToString());
            string nome = tbNomeEditar.Text.Trim();
            int pontos = (int)ndPontosEditar.Value;

            if(nome.Length == 0 || pontos < 0)
            {
                MessageBox.Show("Erro ao editar!");
            }
            else
            {
                SqlConnection conexao = new SqlConnection();
                SqlCommand sql = new SqlCommand();
                conexao.ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Game;Integrated Security=True";
                sql.Connection = conexao;
                sql.CommandText = $"UPDATE Ranking " +
                    $"SET nome = '{nome}', pontos = {pontos} " +
                    $"WHERE idRanking = {id}; ";

                int linhasAfetadas = 0;
                try
                {
                    conexao.Open();
                    linhasAfetadas = sql.ExecuteNonQuery();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"A conexão com o banco falhou. Erro: {exception.ToString()}");
                    Debug.WriteLine(exception.ToString());
                }
                finally
                {
                    conexao.Close();
                    MessageBox.Show($"Edição feita com sucesso.\n" +
                        $"Linhas afetadas: {linhasAfetadas} ");
                    tbNomeEditar.Text = "";
                    ndPontosEditar.Value = 0;
                    lbEditando.Text = "";
                    AtualizarRanking();
                    gbEditar.Enabled = false;
                    btDeletar.Enabled = false;
                }
            }

        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if (dgvRanking.SelectedCells.Count > 0)
            {
                
                int linhaSelecionada = dgvRanking.SelectedCells[0].RowIndex;
                int id = int.Parse(
                    dgvRanking.Rows[linhaSelecionada].Cells[0].Value.ToString());
                string nome = dgvRanking.Rows[linhaSelecionada].Cells[1].Value.ToString();

                MessageBoxButtons botoes = MessageBoxButtons.YesNo;
                DialogResult resposta = MessageBox.Show(
                    $"Deseja apagar o registro de {nome}?", "Confirmação", botoes);
                if (resposta == DialogResult.Yes)
                {


                    SqlConnection conexao = new SqlConnection();
                    SqlCommand sql = new SqlCommand();
                    conexao.ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Game;Integrated Security=True";
                    sql.Connection = conexao;
                    sql.CommandText = $"DELETE FROM Ranking WHERE idRanking = {id};";

                    int linhasAfetadas = 0;
                    try
                    {
                        conexao.Open();
                        linhasAfetadas = sql.ExecuteNonQuery();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"A conexão com o banco falhou. Erro: {exception.ToString()}");
                        Debug.WriteLine(exception.ToString());
                    }
                    finally
                    {
                        conexao.Close();
                        MessageBox.Show($"Registro apagado com sucesso.\n" +
                            $"Linhas afetadas: {linhasAfetadas} ");
                        AtualizarRanking();
                        gbEditar.Enabled = false;
                        btDeletar.Enabled = false;
                    }
                }
            }
        }
    }
}
