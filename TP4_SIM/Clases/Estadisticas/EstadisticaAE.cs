using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_SIM.Clases.Estadisticas
{
    public class EstadisticaAE
    {
        private double acumuladorEspera;
        private double acumuladorOcupacion;
        private int cantClientesAtendidos;

        public double AcumuladorEspera { get => acumuladorEspera; set => acumuladorEspera = value; }
        public double AcumuladorOcupacion { get => acumuladorOcupacion; set => acumuladorOcupacion = value; }
        public int CantClientesAtendidos { get => cantClientesAtendidos; set => cantClientesAtendidos = value; }
    }
}
