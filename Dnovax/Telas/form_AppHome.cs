using Dnovax.Control;
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
            TesteProcessos();
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


        private void TesteProcessos()
        {
            ProcessosDoSistema proc = new ProcessosDoSistema();

            lbl_CPU.Text = Convert.ToString(proc.GetUsoCPU("Win32_Processor", "LoadPercentage") + " %");
            lbl_RAM.Text = Convert.ToString(proc.GetUsoRAM("Win32_PhysicalMemoryArray", "MaxCapacity") + " %") ;

            //lbl_RAM.Text = proc.GetUsoRAM("", "");
        }
    
    }
}
