using Dnovax.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dnovax
{
    public partial class form_AppHome : MetroFramework.Forms.MetroForm
    {
        public form_AppHome()
        {
            InitializeComponent();
            //TesteProcessos()
            TesteTimer();
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

        private static System.Timers.Timer aTimer;
        private async Task<> TesteProcessos()
        {

            ProcessosDoSistema proc = new ProcessosDoSistema();

            //for (int i = 0; i < 20; i++)
            //{
                //Thread.Sleep(1000);
                lbl_CPU.Text = Convert.ToString(proc.GetUsoCPU("Win32_Processor", "LoadPercentage") + " %");
                lbl_RAM.Text = Convert.ToString(proc.GetUsoRAM("Win32_PhysicalMemoryArray", "MaxCapacity") + " %");
                proc.GetDiscoEmUsoMB();
            //}
            //lbl_RAM.Text = proc.GetUsoRAM("", "");
        }


        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void TesteTimer() 
        {
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new System.EventHandler(TesteTarefa);
        }

        private void TesteTarefa(Object sender, System.EventArgs e) 
        {
            TesteProcessos();
        }



    
    }
}
