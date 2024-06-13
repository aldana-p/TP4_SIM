using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TP4_SIM.Clases;

namespace TP4_SIM
{
    public partial class Simulacion : Form
    {
        public Simulacion()
        {
            InitializeComponent();
        }

        private void btnIniciarSimulacion_Click(object sender, EventArgs e)
        {
            grdSimulacion.Rows.Clear();
            int cantFilas = int.Parse(txtCantFilas.Text);
            // Valores de media (dist. exponencial) de los eventos 
            double mediaLlegadaPaquete = double.Parse(txtLlegadaPaquete.Text);
            double mediaFinPaquete = double.Parse(txtFinPaquete.Text);
            double mediaLlegadaReclamo = double.Parse(txtLlegadaReclamo.Text);
            double mediaFinReclamo = double.Parse(txtFinReclamo.Text);
            double mediaLlegadaVenta = double.Parse(txtLlegadaVenta.Text);
            double mediaFinVenta = double.Parse(txtFinVenta.Text);
            double mediaLlegadaAE = double.Parse(txtLlegadaAtencion.Text);
            double mediaFinAE = double.Parse(txtFinAtencion.Text);
            double mediaLlegadaPostales = double.Parse(txtLlegadaPostales.Text);
            double mediaFinPostales = double.Parse(txtFinPostales.Text);

            // Nro de fila a partir de la que sea desea visualizar
            int nroFila = int.Parse(txtPrimeraFila.Text);

            // DataTable donde se van a a guardar las filas a mostrar
            DataTable tablaVisualizacionFilas = new DataTable();

            string[] nombresEventos = {"llegada_envio", "llegada_reclamo", "llegada_venta", "llegada_AE", "llegada_postales", "fin_envio1",
                        "fin_envio1", "fin_envio3", "fin_reclamo1", "fin_reclamo2", "fin_venta1", "fin_venta3", "fin_AE1", "fin_AE2", "fin_postales" };

            Random random = new Random();

            // Se completa la primera fila 
            FilaVector fila1 = new FilaVector();
            fila1.Reloj = 0;
            fila1.Evento = "inicialización";
            fila1.Llegada_cliente_envio = new double[3];
            fila1.Llegada_cliente_envio[0] = generarRandom(random);
            fila1.Llegada_cliente_envio[1] = calcularTiempo(mediaLlegadaPaquete, fila1.Llegada_cliente_envio[0]);
            fila1.Llegada_cliente_envio[2] = fila1.Reloj + fila1.Llegada_cliente_envio[1];

            fila1.Llegada_cliente_reclamo = new double[3];
            fila1.Llegada_cliente_reclamo[0] = generarRandom(random);
            fila1.Llegada_cliente_reclamo[1] = calcularTiempo(mediaLlegadaReclamo, fila1.Llegada_cliente_reclamo[0]);
            fila1.Llegada_cliente_reclamo[2] = fila1.Reloj + fila1.Llegada_cliente_reclamo[1];

            fila1.Llegada_cliente_venta = new double[3];
            fila1.Llegada_cliente_venta[0] = generarRandom(random);
            fila1.Llegada_cliente_venta[1] = calcularTiempo(mediaLlegadaVenta, fila1.Llegada_cliente_venta[0]);
            fila1.Llegada_cliente_venta[2] = fila1.Reloj + fila1.Llegada_cliente_venta[1];

            fila1.Llegada_cliente_AE = new double[3];
            fila1.Llegada_cliente_AE[0] = generarRandom(random);
            fila1.Llegada_cliente_AE[1] = calcularTiempo(mediaLlegadaAE, fila1.Llegada_cliente_AE[0]);
            fila1.Llegada_cliente_AE[2] = fila1.Reloj + fila1.Llegada_cliente_AE[1];

            fila1.Llegada_cliente_postales = new double[3];
            fila1.Llegada_cliente_postales[0] = generarRandom(random);
            fila1.Llegada_cliente_postales[1] = calcularTiempo(mediaLlegadaPostales, fila1.Llegada_cliente_postales[0]);
            fila1.Llegada_cliente_postales[2] = fila1.Reloj + fila1.Llegada_cliente_postales[1];


            grdSimulacion.Rows.Add(fila1.Evento, fila1.Reloj, fila1.Llegada_cliente_envio[0], fila1.Llegada_cliente_envio[1], fila1.Llegada_cliente_envio[2],
            fila1.Llegada_cliente_reclamo[0], fila1.Llegada_cliente_reclamo[1], fila1.Llegada_cliente_reclamo[2],
            fila1.Llegada_cliente_venta[0], fila1.Llegada_cliente_venta[1], fila1.Llegada_cliente_venta[2],
            fila1.Llegada_cliente_AE[0], fila1.Llegada_cliente_AE[1], fila1.Llegada_cliente_AE[2],
            fila1.Llegada_cliente_postales[0], fila1.Llegada_cliente_postales[1], fila1.Llegada_cliente_postales[2]);


            // pone todos los tiempos de los prox eventos en una lista para madarlos al método que busca al siguiente
            List<double?> posiblesProxEventos = new List<double?>();
            posiblesProxEventos.Add(fila1.Llegada_cliente_envio[2]); // 0 
            posiblesProxEventos.Add(fila1.Llegada_cliente_reclamo[2]); // 1
            posiblesProxEventos.Add(fila1.Llegada_cliente_venta[2]); // 2
            posiblesProxEventos.Add(fila1.Llegada_cliente_AE[2]); // 3
            posiblesProxEventos.Add(fila1.Llegada_cliente_postales[2]); //4



            List<double?> proxEvento = buscarProxEvento(posiblesProxEventos);


            FilaVector fila2 = new FilaVector();
            fila2.Reloj = (double)proxEvento[0];
            fila2.Evento = nombresEventos[Convert.ToInt32(proxEvento[1])];

            // For que genera las filas
            for (int i = 0; i < cantFilas; i++)
            {
                if (fila2.Evento == "llegada_envio")
                {
                    // Genero la prox. llegada_envio
                    fila2.Llegada_cliente_envio[0] = generarRandom(random);
                    fila2.Llegada_cliente_envio[1] = calcularTiempo(mediaLlegadaPaquete, fila2.Llegada_cliente_envio[0]);
                    fila2.Llegada_cliente_envio[2] = fila2.Reloj + fila2.Llegada_cliente_envio[1];

                    // Tengo que revisar las colas y los estados de ENVIOS con el for
                    Cliente cliente = new Cliente();
                    for (int j = 0; j < fila1.EnvioPaquetes.Count; j++)
                    {
                        if (fila1.EnvioPaquetes[i].Cola == 0 && fila1.EnvioPaquetes[i].Estado == "Libre")
                        {
                            // Si es atendido se cambiam los estado correspondientes, y se genera el fin de atención
                            cliente.Estado = "SE" + i;
                            cliente.HoraInicioAtencion = fila2.Reloj;
                            fila2.EnvioPaquetes[i].Estado = "Ocupado";
                            fila2.Fin_envio.FinAtencion[i] = fila2.Reloj;
                        }
                        else
                        {
                            cliente.HoraInicioEspera = fila2.Reloj;
                            // Si ninguna está libre, deberá esperar en la cola más corta
                            if (fila1.EnvioPaquetes[0].Cola < fila1.EnvioPaquetes[1].Cola && fila1.EnvioPaquetes[0].Cola < fila1.EnvioPaquetes[2].Cola)
                            {
                                cliente.Estado = "EE1";
                            }
                            else if (fila1.EnvioPaquetes[1].Cola < fila1.EnvioPaquetes[0].Cola && fila1.EnvioPaquetes[1].Cola < fila1.EnvioPaquetes[2].Cola)
                            {
                                cliente.Estado = "EE2";
                            }
                            else
                            {
                                cliente.Estado = "EE3";
                            }
                        }

                    }
                    // Como es una llegada tengo que agregar el cliente
                    fila2.Clientes.Add(cliente);

                }
                if (fila2.Evento == "llegada_venta")
                {
                    // Genero la prox. llegada_venta
                    fila2.Llegada_cliente_venta[0] = generarRandom(random);
                    fila2.Llegada_cliente_venta[1] = calcularTiempo(mediaLlegadaVenta, fila2.Llegada_cliente_venta[0]);
                    fila2.Llegada_cliente_venta[2] = fila2.Reloj + fila2.Llegada_cliente_venta[1];

                    // Tengo que revisar las colas y los estados de VENTAS con el for
                    Cliente cliente = new Cliente();
                    for (int j = 0; j < fila1.Ventas.Count; j++)
                    {
                        if (fila1.Ventas[i].Cola == 0 && fila1.Ventas[i].Estado == "Libre")
                        {
                            // Si es atendido se cambiam los estado correspondientes, y se genera el fin de atención
                            cliente.Estado = "SV" + i;
                            cliente.HoraInicioAtencion = fila2.Reloj;
                            fila2.Ventas[i].Estado = "Ocupado";
                            fila2.Fin_venta.FinAtencion[i] = fila2.Reloj;
                        }
                        else
                        {
                            cliente.HoraInicioEspera = fila2.Reloj;
                            // Si ninguna está libre, deberá esperar en la cola más corta
                            if (fila1.Ventas[0].Cola < fila1.Ventas[1].Cola && fila1.Ventas[0].Cola < fila1.Ventas[2].Cola)
                            {
                                //Hace fila en VENTA1
                                cliente.Estado = "EV1";
                            }
                            else if (fila1.Ventas[1].Cola < fila1.Ventas[0].Cola && fila1.Ventas[1].Cola < fila1.Ventas[2].Cola)
                            {
                                cliente.Estado = "EV2";
                            }
                            else
                            {
                                cliente.Estado = "EV3";
                            }
                        }

                    }
                    // Como es una llegada tengo que agregar el cliente
                    fila2.Clientes.Add(cliente);

                }
                if (fila2.Evento == "llegada_reclamo")
                {
                    // Genero la prox. llegada_reclamo
                    fila2.Llegada_cliente_reclamo[0] = generarRandom(random);
                    fila2.Llegada_cliente_reclamo[1] = calcularTiempo(mediaLlegadaReclamo, fila2.Llegada_cliente_reclamo[0]);
                    fila2.Llegada_cliente_reclamo[2] = fila2.Reloj + fila2.Llegada_cliente_reclamo[1];

                    // Tengo que revisar las colas y los estados de VENTAS con el for
                    Cliente cliente = new Cliente();
                    for (int j = 0; j < fila1.Reclamos.Count; j++)
                    {
                        if (fila1.Reclamos[i].Cola == 0 && fila1.Reclamos[i].Estado == "Libre")
                        {
                            // Si es atendido se cambiam los estado correspondientes, y se genera el fin de atención
                            cliente.Estado = "SR" + i;
                            cliente.HoraInicioAtencion = fila2.Reloj;
                            fila2.Reclamos[i].Estado = "Ocupado";
                            fila2.Fin_reclamo.FinAtencion[i] = fila2.Reloj;
                        }
                        else
                        {
                            cliente.HoraInicioEspera = fila2.Reloj;
                            // Si ninguna está libre, deberá esperar en la cola más corta
                            if (fila1.Reclamos[0].Cola < fila1.Reclamos[1].Cola)
                            {
                                //Hace fila en VENTA1
                                cliente.Estado = "ER1";
                            }
                            else
                            {
                                cliente.Estado = "ER2";
                            }
                        }

                    }
                    // Como es una llegada tengo que agregar el cliente
                    fila2.Clientes.Add(cliente);
                }
                if (fila2.Evento == "llegada_AE")
                {
                    // Genero la prox. llegada_AE
                    fila2.Llegada_cliente_AE[0] = generarRandom(random);
                    fila2.Llegada_cliente_AE[1] = calcularTiempo(mediaLlegadaAE, fila2.Llegada_cliente_AE[0]);
                    fila2.Llegada_cliente_AE[2] = fila2.Reloj + fila2.Llegada_cliente_AE[1];

                    // Tengo que revisar las colas y los estados de VENTAS con el for

                    Cliente cliente = new Cliente();
                    for (int j = 0; j < fila1.AtencionEmp.Count; j++)
                    {
                        if (fila1.AtencionEmp[i].Cola == 0 && fila1.AtencionEmp[i].Estado == "Libre")
                        {
                            // Si es atendido se cambiam los estado correspondientes, y se genera el fin de atención
                            cliente.Estado = "SAE" + i;
                            cliente.HoraInicioAtencion = fila2.Reloj;
                            fila2.Reclamos[i].Estado = "Ocupado";
                            fila2.Fin_AE.FinAtencion[i] = fila2.Reloj;
                        }
                        else
                        {
                            cliente.HoraInicioEspera = fila2.Reloj;
                            // Si ninguna está libre, deberá esperar en la cola más corta
                            if (fila1.AtencionEmp[0].Cola < fila1.AtencionEmp[1].Cola)
                            {
                                //Hace fila en VENTA1
                                cliente.Estado = "EAE1";
                            }
                            else
                            {
                                cliente.Estado = "EAE2";
                            }
                        }

                    }
                    // Como es una llegada tengo que agregar el cliente
                    fila2.Clientes.Add(cliente);
                }
                if (fila2.Evento == "llegada_postales")
                {
                    Cliente cliente = new Cliente();
                    // Genero la prox. llegada_AE
                    fila2.Llegada_cliente_postales[0] = generarRandom(random);
                    fila2.Llegada_cliente_postales[1] = calcularTiempo(mediaLlegadaPostales, fila2.Llegada_cliente_postales[0]);
                    fila2.Llegada_cliente_postales[2] = fila2.Reloj + fila2.Llegada_cliente_postales[1];
                    if (fila1.Postales[0].Cola == 0 && fila1.Postales[0].Estado == "Libre")
                    {
                        // Si es atendido se cambiam los estado correspondientes, y se genera el fin de atención

                        cliente.Estado = "SP" + i;
                        cliente.HoraInicioAtencion = fila2.Reloj;
                        fila2.Postales[0].Estado = "Ocupado";
                        fila2.Fin_postales.FinAtencion = fila2.Reloj;
                    }
                    else
                    {
                        cliente.HoraInicioEspera = fila2.Reloj;
                    }

                }

                if (fila2.Evento == "fin_envio1")
                {
                    Cliente atendido = buscarClientePorEstado("SE1", fila1.Clientes);
                    fila2.EstadisticasEnvio.AcumuladorOcupacion = (fila2.Reloj - atendido.HoraInicioAtencion) + fila1.EstadisticasEnvio.AcumuladorOcupacion;
                    fila2.EstadisticasEnvio.CantClientesAtendidos = fila1.EstadisticasEnvio.CantClientesAtendidos + 1;
                    fila1.Clientes.Remove(atendido);
                    fila2.Clientes = fila1.Clientes;

                    if (fila2.EnvioPaquetes[0].Cola == 0)
                    {
                        fila2.EnvioPaquetes[0].Estado = "Libre";
                    }
                    else
                    {
                        fila2.EnvioPaquetes[0].Cola = fila1.EnvioPaquetes[0].Cola - 1;
                        fila2.EnvioPaquetes[0].Estado = "Ocupado";
                        Cliente porAtender = buscarClientePorEstado("EE2", fila1.Clientes);
                        porAtender.Estado = "SE1";
                        porAtender.HoraInicioAtencion = fila2.Reloj;
                        fila2.Fin_envio.Rnd = generarRandom(random);
                        fila2.Fin_envio.TiempoAtencion = calcularTiempo(mediaFinPaquete, fila2.Fin_envio.Rnd);
                        fila2.Fin_envio.FinAtencion[0] = fila2.Fin_envio.TiempoAtencion + fila2.Reloj;

                        fila2.EstadisticasEnvio.AcumuladorEspera = (fila2.Reloj - atendido.HoraInicioEspera) + fila1.EstadisticasEnvio.AcumuladorEspera;
                    }
                }
                if (fila2.Evento == "fin_envio2")
                {
                    Cliente atendido = buscarClientePorEstado("SE2", fila1.Clientes);
                    fila2.EstadisticasEnvio.AcumuladorOcupacion = (fila2.Reloj - atendido.HoraInicioAtencion) + fila1.EstadisticasEnvio.AcumuladorOcupacion;
                    fila2.EstadisticasEnvio.CantClientesAtendidos = fila1.EstadisticasEnvio.CantClientesAtendidos + 1;
                    fila1.Clientes.Remove(atendido);
                    fila2.Clientes = fila1.Clientes;

                    if (fila2.EnvioPaquetes[1].Cola == 0)
                    {
                        fila2.EnvioPaquetes[1].Estado = "Libre";
                    }
                    else
                    {
                        fila2.EnvioPaquetes[1].Cola = fila1.EnvioPaquetes[0].Cola - 1;
                        fila2.EnvioPaquetes[1].Estado = "Ocupado";
                        Cliente porAtender = buscarClientePorEstado("EE2", fila1.Clientes);
                        porAtender.Estado = "SE2";
                        porAtender.HoraInicioAtencion = fila2.Reloj;
                        fila2.Fin_envio.Rnd = generarRandom(random);
                        fila2.Fin_envio.TiempoAtencion = calcularTiempo(mediaFinPaquete, fila2.Fin_envio.Rnd);
                        fila2.Fin_envio.FinAtencion[1] = fila2.Fin_envio.TiempoAtencion + fila2.Reloj;

                        fila2.EstadisticasEnvio.AcumuladorEspera = (fila2.Reloj - atendido.HoraInicioEspera) + fila1.EstadisticasEnvio.AcumuladorEspera;

                    }
                }
                if (fila2.Evento == "fin_envio3")
                {
                    Cliente atendido = buscarClientePorEstado("SE3", fila1.Clientes);
                    fila2.EstadisticasEnvio.AcumuladorOcupacion = (fila2.Reloj - atendido.HoraInicioAtencion) + fila1.EstadisticasEnvio.AcumuladorOcupacion;
                    fila2.EstadisticasEnvio.CantClientesAtendidos = fila1.EstadisticasEnvio.CantClientesAtendidos + 1;
                    fila1.Clientes.Remove(atendido);
                    fila2.Clientes = fila1.Clientes;

                    if (fila2.EnvioPaquetes[2].Cola == 0)
                    {
                        fila2.EnvioPaquetes[2].Estado = "Libre";
                    }
                    else
                    {
                        fila2.EnvioPaquetes[2].Cola = fila1.EnvioPaquetes[0].Cola - 1;
                        fila2.EnvioPaquetes[2].Estado = "Ocupado";
                        Cliente porAtender = buscarClientePorEstado("EE3", fila1.Clientes);
                        porAtender.Estado = "SE3";
                        porAtender.HoraInicioAtencion = fila2.Reloj;
                        fila2.Fin_envio.Rnd = generarRandom(random);
                        fila2.Fin_envio.TiempoAtencion = calcularTiempo(mediaFinPaquete, fila2.Fin_envio.Rnd);
                        fila2.Fin_envio.FinAtencion[1] = fila2.Fin_envio.TiempoAtencion + fila2.Reloj;

                        fila2.EstadisticasEnvio.AcumuladorEspera = (fila2.Reloj - atendido.HoraInicioEspera) + fila1.EstadisticasEnvio.AcumuladorEspera;
                    }
                }


                
                // Condicional para guardar las filas que se tiene que mostrar.

                if (i >= nroFila + 1 && i <= nroFila + 300)  //coregir condición por si se acaba el for antes de mostrar las 300 filas
                {
                    //grdSimulación.Rows.Add(  contenido de la fila 2)
                }

                // después de guardar la fila1 va a pasar a ser igual que la 2, y la fila 2 le tengo que asignar el nuevo reloj y evento para completarla con los nuevos datos
                // pone todos los tiempos de los prox eventos en una lista para madarlos al método que busca al siguiente

                // ME FALTA COPIAR LOS TIEMPOS DE LOS EVENTOS QUE PERMANECEN IGUALES !!!!!!!!!!!!
                List<double> posiblesProximosEventos = new List<double>();
                posiblesProximosEventos.Add(fila2.Llegada_cliente_envio[2]); // 0 
                posiblesProximosEventos.Add(fila2.Llegada_cliente_reclamo[2]); // 1
                posiblesProximosEventos.Add(fila2.Llegada_cliente_venta[2]); // 2
                posiblesProximosEventos.Add(fila2.Llegada_cliente_AE[2]); // 3
                posiblesProximosEventos.Add(fila2.Llegada_cliente_postales[2]); //4
                posiblesProximosEventos.Add((double)fila2.Fin_envio.FinAtencion[0]);
                posiblesProximosEventos.Add((double)fila2.Fin_envio.FinAtencion[1]);
                posiblesProximosEventos.Add((double)fila2.Fin_envio.FinAtencion[2]);
                posiblesProximosEventos.Add((double)fila2.Fin_venta.FinAtencion[0]);
                posiblesProximosEventos.Add((double)fila2.Fin_venta.FinAtencion[1]);
                posiblesProximosEventos.Add((double)fila2.Fin_venta.FinAtencion[2]);
                posiblesProximosEventos.Add((double)fila2.Fin_reclamo.FinAtencion[0]);
                posiblesProximosEventos.Add((double)fila2.Fin_reclamo.FinAtencion[1]);
                posiblesProximosEventos.Add((double)fila2.Fin_AE.FinAtencion[0]);
                posiblesProximosEventos.Add((double)fila2.Fin_AE.FinAtencion[1]);
                posiblesProximosEventos.Add((double)fila2.Fin_postales.FinAtencion);


                List<double?> proximoEvento = buscarProxEvento(posiblesProxEventos);


                fila1 = fila2;
                fila2 = new FilaVector();
                fila2.Reloj = (double)proximoEvento[0];
                fila2.Evento = nombresEventos[(int)proximoEvento[1]];




            } // fin del for





        }

            private List<double?> buscarProxEvento(List<double?> tiempos)
            {
                double? proxReloj = tiempos.Min();
                double? indice = tiempos.IndexOf(proxReloj);
                List<double?> res = new List<double?>();
                res.Add(proxReloj);
                res.Add(indice);
                return res;

            }


            private double calcularTiempo(double media, double rnd)
            {
                double tiempo = truncarNumero(-media * Math.Log(1 - rnd));
                return tiempo;

            }


            private double truncarNumero(double numero)
            {
                double factor = Math.Pow(10, 2);
                return Math.Truncate(numero * factor) / factor;
            }


            private double generarRandom(Random random)
            {
                double numero = random.NextDouble();
                return truncarNumero(numero);
            }

            private string definirEstadoServicio(double estado)
            {
                if (estado == 0) { return "Libre"; }
                else return "Ocupado";
            }



            private Cliente buscarClientePorEstado(string estado, List<Cliente> clientes)
            {
                for (int i = 0; i < clientes.Count; i++)
                {
                    if (clientes[i].Estado == estado)
                    {
                        return clientes[i];
                    }
                }
                throw new InvalidOperationException($"No se encontró un cliente con el estado: {estado}");
            }


        }
    } 
