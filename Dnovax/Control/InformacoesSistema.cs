using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Dnovax.Control
{
    public class InformacoesSistema
    {
        private string SO;
        private string Bios;
        private string Processador;
        private string RamTamanho;
        private string GPUNome;
        private string PlacaMae;
        //public List<InformacoesSistema> Vou colocar os objetos dentro da lista para serem usados

        public string GetSistemaOperaciona()
        {
            SO = Environment.MachineName;
            return SO;
        }

        public string GetNomeCPU(string hwclass, string systax) 
        {
            ManagementObjectSearcher teste = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementBaseObject mj in teste.Get()) 
            {
                Processador = Convert.ToString(mj[systax]);
            }
            return Processador;
        }
        public string GetNomeGPU(string hwclass, string systax)
        {
            ManagementObjectSearcher teste = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementBaseObject mj in teste.Get())
            {
                GPUNome = Convert.ToString(mj[systax]);
            }
            return GPUNome;
        }
        public string GetPlacaMae(string hwclass, string systax)
        {
            ManagementObjectSearcher teste = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementBaseObject mj in teste.Get())
            {
                PlacaMae = Convert.ToString(mj[systax]);
            }
            return PlacaMae;
        }
        public string GetBios(string hwclass, string systax)
        {
            ManagementObjectSearcher teste = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementBaseObject mj in teste.Get())
            {
                Bios = Convert.ToString(mj[systax]);
            }
            return Bios;
        }
        public string GetTamanhoRAM(string hwclass, string systax)
        {
            ManagementObjectSearcher teste = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementBaseObject mj in teste.Get())
            {
                int testando = Convert.ToInt32(mj[systax]);
                int teste1 = testando / 1024 ;

                //testando = testando / 24;
                RamTamanho = Convert.ToString(mj[systax]);
            }
            return RamTamanho;
        }

        //public void GetVersaoBios() 
        //{
        //    var teste = Environment.Version;
        //    Console.WriteLine(teste.ToString());
        //}
    }
}
