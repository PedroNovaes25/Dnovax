using Domain;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacao
{
    public class Consultas
    {
        public bool Login(string email, string senha) 
        {
            var conexao = new DnovaxContext();
            try
            {
                var usuario = conexao.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
                if (usuario != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {

                throw ;
            }


            
        }

        public bool Cadastrar(Usuario usuario) 
        {
            var conexao = new DnovaxContext();

            try
            {
                var consultaEmail = conexao.Usuarios.Where(x => x.Email.Contains(usuario.Email)).ToList();

                if (consultaEmail.Count > 0)
                {
                    MessageBox.Show("Email já cadastrado", "Cadastro");
                    return false; 
                }
                else 
                {
                    conexao.Usuarios.Add(usuario);
                    conexao.SaveChanges();

                    MessageBox.Show("Email cadastrado com sucesso", "Cadastro");

                    return true;
                }

            }
            catch (Exception e)
            {
                
                 MessageBox.Show("Cadastro inválido");
                throw;
            }




        }

        //public validarDados(Usuario usuario) 
        //{
        //}

    }
}
