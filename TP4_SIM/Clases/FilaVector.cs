using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4_SIM.Clases;
using TP4_SIM.Clases.Estadisticas;
using TP4_SIM.Clases.EventosFinAtencion;

namespace TP4_SIM
{
    public class FilaVector
    {
        private string evento;
        private double reloj;
        private double[] llegada_cliente_envio;
        private double[] llegada_cliente_reclamo;
        private double[] llegada_cliente_venta;
        private double[] llegada_cliente_AE;
        private double[] llegada_cliente_postales;
        private FinAtencionEnvio fin_envio;
        private FinAtencionReclamo fin_reclamo;
        private FinAtencionVenta fin_venta;
        private FinAtencionEmpresarial fin_AE;
        private FinAtencionPostales fin_postales;
        private List<EnvioPaquete> envioPaquetes;
        private List<Reclamo> reclamos;
        private List<Venta> ventas;
        private List<AtencionEmpresarial> atencionEmp;
        private List<Postales> postales;

        private EstadisticaEnvio estadisticasEnvio;
        private EstadisticaReclamo estadisticasReclamo;
        private EstadisticaVenta estadisticasVenta;
        private EstadisticaAE estadisticasAE;
        private EstadisticaPostales estadisticasPostales;
        private List<Cliente> clientes;

        public string Evento { get => evento; set => evento = value; }
        public double Reloj { get => reloj; set => reloj = value; }
        public double[] Llegada_cliente_envio { get => llegada_cliente_envio; set => llegada_cliente_envio = value; }
        public double[] Llegada_cliente_reclamo { get => llegada_cliente_reclamo; set => llegada_cliente_reclamo = value; }
        public double[] Llegada_cliente_venta { get => llegada_cliente_venta; set => llegada_cliente_venta = value; }
        public double[] Llegada_cliente_AE { get => llegada_cliente_AE; set => llegada_cliente_AE = value; }
        public double[] Llegada_cliente_postales { get => llegada_cliente_postales; set => llegada_cliente_postales = value; }


        public List<Cliente> Clientes { get => clientes; set => clientes = value; }
        public List<EnvioPaquete> EnvioPaquetes { get => envioPaquetes; set => envioPaquetes = value; }
        public List<Reclamo> Reclamos { get => reclamos; set => reclamos = value; }
        public List<Venta> Ventas { get => ventas; set => ventas = value; }
        public List<Postales> Postales { get => postales; set => postales = value; }
        public EstadisticaEnvio EstadisticasEnvio { get => estadisticasEnvio; set => estadisticasEnvio = value; }
        public EstadisticaReclamo EstadisticasReclamo { get => estadisticasReclamo; set => estadisticasReclamo = value; }
        public EstadisticaVenta EstadisticasVenta { get => estadisticasVenta; set => estadisticasVenta = value; }
        public EstadisticaAE EstadisticasAE { get => estadisticasAE; set => estadisticasAE = value; }
        public EstadisticaPostales EstadisticasPostales { get => estadisticasPostales; set => estadisticasPostales = value; }
        public FinAtencionEnvio Fin_envio { get => fin_envio; set => fin_envio = value; }
        public FinAtencionReclamo Fin_reclamo { get => fin_reclamo; set => fin_reclamo = value; }
        public FinAtencionVenta Fin_venta { get => fin_venta; set => fin_venta = value; }
        public FinAtencionEmpresarial Fin_AE { get => fin_AE; set => fin_AE = value; }
        public FinAtencionPostales Fin_postales { get => fin_postales; set => fin_postales = value; }
        internal List<AtencionEmpresarial> AtencionEmp { get => atencionEmp; set => atencionEmp = value; }
    }
}
