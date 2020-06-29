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
    public partial class form_perfil : MetroFramework.Forms.MetroForm
    {
        public form_perfil()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            form_AppHome form = new form_AppHome();
            form.Show();
        }

        private void btn_Info_Hard_Click(object sender, EventArgs e)
        {
            form_infoHard form = new form_infoHard();
            form.Show();
        }
    }
}
