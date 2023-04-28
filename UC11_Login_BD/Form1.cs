using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UC11_Login_BD
{
    public partial class Form1 : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public Form1()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=login_bd;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            labelErro.Text = "";
            labelErro2.Text = "";
        }

        private void buttonENTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT usuario, senha FROM tbl_usuarios WHERE usuario = '" + textBoxUSUARIO.Text + "' AND senha = '" + textBoxSENHA.Text + "';";

                MySqlDataReader resultado = comando.ExecuteReader();
                if (textBoxSENHA.Text != "" && textBoxUSUARIO.Text == "")
                {


                    if (resultado.Read())
                    {
                        MessageBox.Show("Usuário e Senha corretos!");
                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou Senha incorretos!");
                    }

                }
                else
                {
                    labelErro.Text = "Por favor, preencha ambos os campos.";
                }
                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT usuario, senha FROM tbl_usuarios WHERE usuario = '" + textBoxUSUARIO.Text + "';";

                MySqlDataReader resultado = comando.ExecuteReader();
                if (textBoxSENHA.Text != "" && textBoxUSUARIO.Text == "")
                {

                    if (resultado.Read())
                    {
                        labelErro2.Text = "Usario já cadastrado!";
                    }
                    else
                    {
                        conexao.Close();
                        conexao.Open();
                        comando.CommandText = "INSERT INTO tbl_usuarios(usuario, senha) VALUES ('" + textBoxUSUARIO.Text + "', '" + textBoxSENHA.Text + "');";
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                    }
                }
                else
                {
                    labelErro2.Text = "Usuário já cadastrado!";
                }
                }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar novo usuário. Fale com o administrador do sistema.");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void buttonLIMPAR_Click(object sender, EventArgs e)
        {
            textBoxSENHA.Text = "";
            textBoxUSUARIO.Text = "";
            labelErro2.Text = "";
            labelErro.Text = "";
        }
    }
}
