using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Dnovax.Control
{
    class ProcessosDoSistema
    {
        private int CPU;
        private double Memoria;
        private string Disco;

        public int GetUsoCPU(string hwclass, string systax)
        {
            ManagementObjectSearcher teste = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementBaseObject mj in teste.Get())
            {
                 CPU = Convert.ToInt32(mj[systax]);
            }
            return CPU;
        }
        public double GetUsoRAM(string hwclass, string systax)
        {
            ManagementObjectSearcher teste = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementBaseObject mj in teste.Get())
            {

                int ramTotal = Convert.ToInt32(mj[systax]);
                double ramDisponivel = GetMemoriaEmUsoMB();

                double emUso = ramTotal - ramDisponivel;
                double porcentagemEmDouble = Math.Round((emUso * 100) / ramTotal, 0);

                Memoria = porcentagemEmDouble;
            }
            return Memoria;
        }
        public string GetUsoDisco(string hwclass, string systax)
        {
            ManagementObjectSearcher teste = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementBaseObject mj in teste.Get())
            {
                Disco = Convert.ToString(mj[systax]);
            }
            return Disco;
        }
        public double GetMemoriaEmUsoMB() 
        {
            PerformanceCounter ramCounter;
            ramCounter = new PerformanceCounter("Memory", "Available KBytes");

            return ramCounter.NextValue();
        }
        public string GetDiscoEmUsoMB()
        {
            PerformanceCounter discoCounter;
            discoCounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
            Int32 j = 0;
            j = Convert.ToInt32(discoCounter.NextValue());

            return Convert.ToString(j);
        }

    }
}
