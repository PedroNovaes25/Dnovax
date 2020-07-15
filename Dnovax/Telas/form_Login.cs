using Aplicacao;
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
    public partial class form_Login : MetroFramework.Forms.MetroForm
    {
        public form_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            //Consultas app = new Consultas();

            //string email = txt_email.Text;
            //string senha = txt_senha.Text;

            //if (app.Login(email, senha) == true)
            //{
            //    MessageBox.Show("Login realizado com sucesso", "Login");
            //    form_AppHome form = new form_AppHome();
            //    form.Show();
            //}
            //else 
            //{
            //    MessageBox.Show("Não foi possível realizar o Login", "Erro Login");
            //}

            form_AppHome form = new form_AppHome();
            form.Show();
        }

        private void lbl_Link_cad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_Cadastro form = new form_Cadastro();
            form.Show();
        }
    }
}
