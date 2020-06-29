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
    public partial class form_AppHome : MetroFramework.Forms.MetroForm
    {
        public form_AppHome()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_perfil form = new form_perfil();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_infoHard form = new form_infoHard();
            form.Show();
        }
    }
}
