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
            form_AppHome form = new form_AppHome();
            form.Show();
        }
    }
}
