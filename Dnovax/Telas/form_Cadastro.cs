using Aplicacao;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dnovax
{
    public partial class form_Cadastro : MetroFramework.Forms.MetroForm
    {
        public form_Cadastro()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            form_Login form = new form_Login();
            form.Show();
        }

        private void btb_Cadastro_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text;
            string nome = txt_Nome.Text;
            char sexo = Convert.ToChar(cb_sexo.Text);
            string senha = txt_Senha.Text;
            string confirmarSenha = txt_ConfirmarSenha.Text;
            bool dataNascimento = DateTime.TryParse(mask_dataNascimento.Text, out DateTime result);
            

            if (senha == confirmarSenha && senha != null )
            {
                if (sexo == 'M' || sexo == 'F')
                {

                    Usuario user = new Usuario()
                    {
                        Email = email,
                        Nome = nome,
                        Senha = senha,
                        Sexo = sexo,
                        DataNascimento = dataNascimento == true ? result : DateTime.Parse("01/01/0001")
                    };

                    Consultas app = new Consultas();
                    var cadastro = app.Cadastrar(user);

                    if (cadastro == true)
                    {
                        form_AppHome form = new form_AppHome();
                        form.Show();
                    }
                    //else
                    //{
                    //    MessageBox.Show("Login inválido, Revise os dados", "Cadastro");
                    //}

                }
                else
                {
                    MessageBox.Show("Selecione o seu Sexo", "Cadastro");
                }

            }
            else
            {
                MessageBox.Show("As senhas devem ser iguais", "Cadastro");
            }
        }
    }
}
