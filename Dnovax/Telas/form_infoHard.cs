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
    public partial class form_infoHard : MetroFramework.Forms.MetroForm
    {
        delegate string Del1();
        public form_infoHard()
        {
            InitializeComponent();
            PreenchendoPanelDeInf();
        }

        private void PreenchendoPanelDeInf() 
        {
            InformacoesSistema infoSystem = new InformacoesSistema();
            lbl_SO.Text = infoSystem.GetSistemaOperaciona();

            lbl_Processador.Text = infoSystem.GetNomeCPU("Win32_Processor", "Name");

            lbl_Gpu.Text = infoSystem.GetNomeGPU("Win32_VideoController", "Name");

            lbl_Placa_Mae.Text = infoSystem.GetPlacaMae("win32_BaseBoard","Product");

            lbl_Bios.Text = infoSystem.GetBios("Win32_BIOS", "SMBIOSBIOSVersion");

            lbl_Largura_Ram.Text = infoSystem.GetTamanhoRAM("Win32_PhysicalMemoryArray", "MaxCapacity") + "GB";
            //infoSystem.GetVersaoBios();
        }
    }
}
