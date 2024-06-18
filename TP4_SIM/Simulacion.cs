﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TP4_SIM.Clases;
using TP4_SIM.Clases.EventosLlegadas;

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

            string[] nombresEventos = {"llegada_envio", "llegada_reclamo", "llegada_venta", "llegada_AE", "llegada_postales", "fin_envio1",
                        "fin_envio1", "fin_envio3", "fin_reclamo1", "fin_reclamo2", "fin_venta1", "fin_venta2", "fin_venta3", "fin_AE1", "fin_AE2", "fin_postales" };

            Random random = new Random();

            // Se completa la primera fila 
            FilaVector fila1 = new FilaVector();
            fila1.NroFila = 1;
            fila1.Evento = "inicialización";
            fila1.Reloj = 0;

            fila1.LlegadaEnvio.Rnd = generarRandom(random);
            fila1.LlegadaEnvio.TiempoEntreLlegadas = calcularTiempo(mediaLlegadaPaquete, fila1.LlegadaEnvio.Rnd);
            fila1.LlegadaEnvio.ProxLlegada = fila1.Reloj + fila1.LlegadaEnvio.TiempoEntreLlegadas;

            fila1.LlegadaReclamo.Rnd = generarRandom(random);
            fila1.LlegadaReclamo.TiempoEntreLlegadas = calcularTiempo(mediaLlegadaReclamo, fila1.LlegadaReclamo.Rnd);
            fila1.LlegadaReclamo.ProxLlegada = fila1.Reloj + fila1.LlegadaReclamo.TiempoEntreLlegadas;

            fila1.LlegadaVenta.Rnd = generarRandom(random);
            fila1.LlegadaVenta.TiempoEntreLlegadas = calcularTiempo(mediaLlegadaVenta, fila1.LlegadaVenta.Rnd);
            fila1.LlegadaVenta.ProxLlegada = fila1.Reloj + fila1.LlegadaVenta.TiempoEntreLlegadas;

            fila1.LlegadaAE.Rnd = generarRandom(random);
            fila1.LlegadaAE.TiempoEntreLlegadas = calcularTiempo(mediaLlegadaAE, fila1.LlegadaAE.Rnd);
            fila1.LlegadaAE.ProxLlegada = fila1.Reloj + fila1.LlegadaAE.TiempoEntreLlegadas;

            fila1.LlegadaPostales.Rnd = generarRandom(random);
            fila1.LlegadaPostales.TiempoEntreLlegadas = calcularTiempo(mediaLlegadaPostales, fila1.LlegadaPostales.Rnd);
            fila1.LlegadaPostales.ProxLlegada = fila1.Reloj + fila1.LlegadaPostales.TiempoEntreLlegadas;


            List<FilaVector> filas = new List<FilaVector>();
            filas.Add(fila1);

            /*grdSimulacion.Rows.Add(fila1.Evento, fila1.Reloj, fila1.Llegada_cliente_envio[0], fila1.Llegada_cliente_envio[1], fila1.Llegada_cliente_envio[2],
            fila1.Llegada_cliente_reclamo[0], fila1.Llegada_cliente_reclamo[1], fila1.Llegada_cliente_reclamo[2],
            fila1.Llegada_cliente_venta[0], fila1.Llegada_cliente_venta[1], fila1.Llegada_cliente_venta[2],
            fila1.Llegada_cliente_AE[0], fila1.Llegada_cliente_AE[1], fila1.Llegada_cliente_AE[2],
            fila1.Llegada_cliente_postales[0], fila1.Llegada_cliente_postales[1], fila1.Llegada_cliente_postales[2]);
            */

            // pone todos los tiempos de los prox eventos en una lista para madarlos al método que busca al siguiente
            List<double> posiblesProxEventos = new List<double>();
            posiblesProxEventos.Add(fila1.LlegadaEnvio.ProxLlegada); // 0 
            posiblesProxEventos.Add(fila1.LlegadaReclamo.ProxLlegada); // 1
            posiblesProxEventos.Add(fila1.LlegadaVenta.ProxLlegada); // 2
            posiblesProxEventos.Add(fila1.LlegadaAE.ProxLlegada); // 3
            posiblesProxEventos.Add(fila1.LlegadaPostales.ProxLlegada); //4

            List<double> proxEvento = buscarProxEvento(posiblesProxEventos);

            FilaVector fila2 = new FilaVector();
            fila2.Reloj = (double)proxEvento[0];
            fila2.Evento = nombresEventos[Convert.ToInt32(proxEvento[1])];

            List<FilaVector> filasMostrar = new List<FilaVector>();

            /*
            grdSimulacion.Rows.Add(fila1.Evento, fila1.Reloj, fila1.Llegada_cliente_envio[0], fila1.Llegada_cliente_envio[1], fila1.Llegada_cliente_envio[2],
            fila1.Llegada_cliente_reclamo[0], fila1.Llegada_cliente_reclamo[1], fila1.Llegada_cliente_reclamo[2],
            fila1.Llegada_cliente_venta[0], fila1.Llegada_cliente_venta[1], fila1.Llegada_cliente_venta[2],
            fila1.Llegada_cliente_AE[0], fila1.Llegada_cliente_AE[1], fila1.Llegada_cliente_AE[2],
            fila1.Llegada_cliente_postales[0], fila1.Llegada_cliente_postales[1], fila1.Llegada_cliente_postales[2], fila1.Fin_envio.Rnd, fila1.Fin_envio.TiempoAtencion,
            fila1.Fin_envio.FinAtencion[0], fila1.Fin_envio.FinAtencion[1], fila1.Fin_envio.FinAtencion[2], fila1.Fin_reclamo.Rnd, fila1.Fin_reclamo.TiempoAtencion, fila1.Fin_reclamo.FinAtencion[0],
            fila1.Fin_reclamo.FinAtencion[1], fila1.Fin_venta.Rnd, fila1.Fin_venta.TiempoAtencion, fila1.Fin_venta.FinAtencion[0], fila1.Fin_venta.FinAtencion[1], fila1.Fin_venta.FinAtencion[2],
            fila1.Fin_AE.Rnd, fila1.Fin_AE.TiempoAtencion, fila1.Fin_AE.FinAtencion[0], fila1.Fin_AE.FinAtencion[1], fila1.Fin_postales.Rnd, fila1.Fin_postales.TiempoAtencion, fila1.Fin_postales.FinAtencion,
            fila1.EnvioPaquetes[0].Cola, fila1.EnvioPaquetes[0].Estado, fila1.EnvioPaquetes[1].Cola, fila1.EnvioPaquetes[1].Estado, fila1.EnvioPaquetes[2].Cola, fila1.EnvioPaquetes[2].Estado,
            fila1.Reclamos[0].Cola, fila1.Reclamos[0].Estado, fila1.Reclamos[1].Cola, fila1.Reclamos[1].Estado, fila1.Ventas[0].Cola, fila1.Ventas[0].Estado, fila1.Ventas[1].Cola, fila1.Ventas[1].Estado,
            fila1.Ventas[2].Cola, fila1.Ventas[2].Estado, fila1.AtencionEmp[0].Cola, fila1.AtencionEmp[0].Estado, fila1.AtencionEmp[1].Cola, fila1.AtencionEmp[1].Estado, fila1.Postales[0].Cola, fila1.Postales[0].Estado
            );
            */



            // For que genera las filas
            for (int i = 0; i < cantFilas; i++)
            {
                fila2.NroFila = i + 2; //tiene que empezar desde el 2

                filasMostrar.Add(fila1);


                grdSimulacion.Rows.Add(fila1.Evento, fila1.Reloj, fila1.LlegadaEnvio.Rnd, fila1.LlegadaEnvio.TiempoEntreLlegadas, fila1.LlegadaEnvio.ProxLlegada,
          fila1.LlegadaReclamo.Rnd, fila1.LlegadaReclamo.TiempoEntreLlegadas, fila1.LlegadaReclamo.ProxLlegada,
          fila1.LlegadaVenta.Rnd, fila1.LlegadaVenta.TiempoEntreLlegadas, fila1.LlegadaVenta.ProxLlegada,
          fila1.LlegadaAE.Rnd, fila1.LlegadaAE.TiempoEntreLlegadas, fila1.LlegadaAE.ProxLlegada,
          fila1.LlegadaPostales.Rnd, fila1.LlegadaPostales.TiempoEntreLlegadas, fila1.LlegadaPostales.ProxLlegada, fila1.Fin_envio.Rnd, fila1.Fin_envio.TiempoAtencion,
          fila1.Fin_envio.FinAtencion[0], fila1.Fin_envio.FinAtencion[1], fila1.Fin_envio.FinAtencion[2], fila1.Fin_reclamo.Rnd, fila1.Fin_reclamo.TiempoAtencion, fila1.Fin_reclamo.FinAtencion[0],
          fila1.Fin_reclamo.FinAtencion[1], fila1.Fin_venta.Rnd, fila1.Fin_venta.TiempoAtencion, fila1.Fin_venta.FinAtencion[0], fila1.Fin_venta.FinAtencion[1], fila1.Fin_venta.FinAtencion[2],
          fila1.Fin_AE.Rnd, fila1.Fin_AE.TiempoAtencion, fila1.Fin_AE.FinAtencion[0], fila1.Fin_AE.FinAtencion[1], fila1.Fin_postales.Rnd, fila1.Fin_postales.TiempoAtencion, fila1.Fin_postales.FinAtencion,
          fila1.EnvioPaquetes[0].Cola, fila1.EnvioPaquetes[0].Estado, fila1.EnvioPaquetes[1].Cola, fila1.EnvioPaquetes[1].Estado, fila1.EnvioPaquetes[2].Cola, fila1.EnvioPaquetes[2].Estado,
          fila1.Reclamos[0].Cola, fila1.Reclamos[0].Estado, fila1.Reclamos[1].Cola, fila1.Reclamos[1].Estado, fila1.Ventas[0].Cola, fila1.Ventas[0].Estado, fila1.Ventas[1].Cola, fila1.Ventas[1].Estado,
          fila1.Ventas[2].Cola, fila1.Ventas[2].Estado, fila1.AtencionEmp[0].Cola, fila1.AtencionEmp[0].Estado, fila1.AtencionEmp[1].Cola, fila1.AtencionEmp[1].Estado, fila1.Postales[0].Cola, fila1.Postales[0].Estado
          );




                // ----------------------------------------- LLEGADAS -----------------------------------------------------------------------------
                //LLEGADA ENVIO
                if (fila2.Evento == "llegada_envio")
                {   
                    copiarProximasLlegadas(fila1, fila2);
                    // Genero la prox. llegada_envio
                    fila2.LlegadaEnvio.Rnd = generarRandom(random);
                    fila2.LlegadaEnvio.TiempoEntreLlegadas = calcularTiempo(mediaLlegadaPaquete, fila2.LlegadaEnvio.Rnd);
                    fila2.LlegadaEnvio.ProxLlegada = fila2.Reloj + fila2.LlegadaEnvio.TiempoEntreLlegadas;

                    copiarObjetosFilaAnterior(fila1, fila2);
                    copiarFinesAtencion(fila1, fila2);
                    copiarEstadisticas(fila1, fila2);

                    Cliente cliente = new Cliente();   //Al ser una llegada tengo que crear al cliente

                    int cantColumnas = grdSimulacion.ColumnCount;
                    DataGridViewColumn columnaEstado = new DataGridViewTextBoxColumn(); 
                    columnaEstado.HeaderText = "Estado" + (fila2.Clientes.Count + 1) ;
                    DataGridViewColumn columnaHoraInicioEspera = new DataGridViewTextBoxColumn();
                    columnaHoraInicioEspera.HeaderText = "HIEspera" + (fila2.Clientes.Count + 1);
                    grdSimulacion.Columns.Add(columnaEstado);
                    grdSimulacion.Columns.Add(columnaHoraInicioEspera);


                    // Reviso las colas y los estados de los objetos ENVIO (en este caso son 3)
                    bool empleadoLibre = false;
                    for (int j = 0; j < fila1.EnvioPaquetes.Count; j++)
                    {
                        if (fila1.EnvioPaquetes[j].Estado == "Libre")
                        {
                            // Hay un objeto libre: le asigno al nuevo cliente el estado siendo atendido, e indico horaInicioAtención, cambio el estado del objeto donde se
                            // atiende, y genero el fin de atención para ese mismo objeto.
                            cliente.Estado = "SE" + (j + 1);
                            cliente.HoraInicioAtencion = fila2.Reloj;
                            fila2.EnvioPaquetes[j].Estado = "Ocupado";

                            fila2.Fin_envio.Rnd = generarRandom(random);
                            fila2.Fin_envio.TiempoAtencion = calcularTiempo(mediaFinPaquete, fila2.Fin_envio.Rnd);
                            fila2.Fin_envio.FinAtencion[j] = fila2.Reloj + fila2.Fin_envio.TiempoAtencion;

                            empleadoLibre = true;
                            break;

                        }
                    }
                    if (!empleadoLibre)
                    {
                            // No hay un objeto libre, entonces tengo que buscar el de menor cola y esperar
                            cliente.HoraInicioEspera = fila2.Reloj;
                            if (fila1.EnvioPaquetes[0].Cola == fila1.EnvioPaquetes[1].Cola && fila1.EnvioPaquetes[0].Cola == fila1.EnvioPaquetes[2].Cola)
                            {
                                // Si todos los objetos tienen la misma cola, espera en el objeto 1:
                                cliente.Estado = "EE1";
                                fila2.EnvioPaquetes[0].Cola = fila1.EnvioPaquetes[0].Cola + 1;
                            }

                            else if (fila1.EnvioPaquetes[0].Cola < fila1.EnvioPaquetes[1].Cola && fila1.EnvioPaquetes[0].Cola < fila1.EnvioPaquetes[2].Cola)
                            {
                                cliente.Estado = "EE1";
                                fila2.EnvioPaquetes[0].Cola = fila1.EnvioPaquetes[0].Cola + 1;
                            }
                            else if (fila1.EnvioPaquetes[1].Cola < fila1.EnvioPaquetes[0].Cola && fila1.EnvioPaquetes[1].Cola < fila1.EnvioPaquetes[2].Cola)
                            {
                                cliente.Estado = "EE2";
                                fila2.EnvioPaquetes[1].Cola = fila1.EnvioPaquetes[1].Cola + 1;
                            }
                            else if (fila1.EnvioPaquetes[2].Cola < fila1.EnvioPaquetes[0].Cola && fila1.EnvioPaquetes[2].Cola < fila1.EnvioPaquetes[1].Cola)
                            {
                                cliente.Estado = "EE3";
                                fila2.EnvioPaquetes[2].Cola = fila1.EnvioPaquetes[2].Cola + 1;
                            }
                            else
                            {
                                // Si dos colas son iguales y una diferente
                                if (fila1.EnvioPaquetes[0].Cola == fila1.EnvioPaquetes[1].Cola && fila1.EnvioPaquetes[0].Cola < fila1.EnvioPaquetes[2].Cola)
                                {
                                    // Las colas 1 y 2  son iguales y menores que la 3
                                    cliente.Estado = "EE1";
                                    fila2.EnvioPaquetes[0].Cola = fila1.EnvioPaquetes[0].Cola + 1;
                                }
                                if (fila1.EnvioPaquetes[0].Cola == fila1.EnvioPaquetes[2].Cola && fila1.EnvioPaquetes[0].Cola < fila1.EnvioPaquetes[1].Cola)
                                {
                                    // Las colas del 1 y 3 son iguales y menores que la 2
                                    cliente.Estado = "EE1";
                                    fila2.EnvioPaquetes[0].Cola = fila1.EnvioPaquetes[0].Cola + 1;
                                }
                                else
                                {
                                    // Las colas 2 y 3 son iguales y menores que la 1
                                    cliente.Estado = "EE2";
                                    fila2.EnvioPaquetes[1].Cola = fila1.EnvioPaquetes[1].Cola + 1;
                                }
                            }
                        
                    }
                    // Como es una llegada tengo que agregar el cliente
                    fila2.Clientes.Add(cliente);
                    grdSimulacion.Rows[i + 1].Cells[columnaEstado.Index].Value = cliente.Estado.ToString();
                    grdSimulacion.Rows[i + 1].Cells[columnaHoraInicioEspera.Index].Value = cliente.HoraInicioEspera.ToString();
                }

                // LLEGADA VENTA
                if (fila2.Evento == "llegada_venta")
                {
                    copiarProximasLlegadas(fila1, fila2);

                    // Genero la prox. llegada_venta
                    fila2.LlegadaVenta.Rnd = generarRandom(random);
                    fila2.LlegadaVenta.TiempoEntreLlegadas = calcularTiempo(mediaLlegadaVenta, fila2.LlegadaVenta.Rnd);
                    fila2.LlegadaVenta.ProxLlegada = fila2.Reloj + fila2.LlegadaVenta.TiempoEntreLlegadas;

                    copiarObjetosFilaAnterior(fila1, fila2);
                    copiarFinesAtencion(fila1, fila2);
                    copiarEstadisticas(fila1, fila2);

                    // Tengo que revisar las colas y los estados de VENTAS con el for
                    Cliente cliente = new Cliente();

                    int cantColumnas = grdSimulacion.ColumnCount;
                    DataGridViewColumn columnaEstado = new DataGridViewTextBoxColumn();
                    columnaEstado.HeaderText = "Estado" + (fila2.Clientes.Count + 1);
                    DataGridViewColumn columnaHoraInicioEspera = new DataGridViewTextBoxColumn();
                    columnaHoraInicioEspera.HeaderText = "HIEspera" + (fila2.Clientes.Count + 1);
                    grdSimulacion.Columns.Add(columnaEstado);
                    grdSimulacion.Columns.Add(columnaHoraInicioEspera);

                    bool empleadoLibre = false;
                    for (int j = 0; j < fila1.Ventas.Count; j++)
                    {
                        if (fila1.Ventas[j].Estado == "Libre")
                        {
                            // Si es atendido se cambiam los estado correspondientes, y se genera el fin de atención
                            cliente.Estado = "SV" + (j+1);
                            cliente.HoraInicioAtencion = fila2.Reloj;
                            fila2.Ventas[j].Estado = "Ocupado";

                            fila2.Fin_venta.Rnd = generarRandom(random);
                            fila2.Fin_venta.TiempoAtencion = calcularTiempo(mediaFinVenta, fila2.Fin_venta.Rnd);
                            fila2.Fin_venta.FinAtencion[j] = fila2.Reloj + fila2.Fin_venta.TiempoAtencion;
                            empleadoLibre = true;
                            break;
                        }                  
                    }

                    if (!empleadoLibre)
                    {
                        cliente.HoraInicioEspera = fila2.Reloj;
                        if (fila1.Ventas[0].Cola == fila1.Ventas[1].Cola && fila1.Ventas[0].Cola == fila1.Ventas[2].Cola)
                        {
                            // Si todos los objetos tienen la misma cola, espera en el objeto 1:
                            cliente.Estado = "EV1";
                            fila2.Ventas[0].Cola = fila1.Ventas[0].Cola + 1;
                        }

                        else if (fila1.Ventas[0].Cola < fila1.Ventas[1].Cola && fila1.Ventas[0].Cola < fila1.Ventas[2].Cola)
                        {
                            cliente.Estado = "EV1";
                            fila2.Ventas[0].Cola = fila1.Ventas[0].Cola + 1;
                        }
                        else if (fila1.Ventas[1].Cola < fila1.Ventas[0].Cola && fila1.Ventas[1].Cola < fila1.Ventas[2].Cola)
                        {
                            cliente.Estado = "EV2";
                            fila2.Ventas[1].Cola = fila1.Ventas[1].Cola + 1;
                        }
                        else if (fila1.Ventas[2].Cola < fila1.Ventas[0].Cola && fila1.Ventas[2].Cola < fila1.Ventas[1].Cola)
                        {
                            cliente.Estado = "EV3";
                            fila2.Ventas[2].Cola = fila1.Ventas[2].Cola + 1;
                        }
                        else
                        {
                            // Si dos colas son iguales y una diferente
                            if (fila1.Ventas[0].Cola == fila1.Ventas[1].Cola && fila1.Ventas[0].Cola < fila1.Ventas[2].Cola)
                            {
                                // Las colas 1 y 2 son iguales y menores que la 3
                                cliente.Estado = "EV1";
                                fila2.Ventas[0].Cola = fila1.Ventas[0].Cola + 1;
                            }
                            if (fila1.Ventas[0].Cola == fila1.Ventas[2].Cola && fila1.Ventas[0].Cola < fila1.Ventas[1].Cola)
                            {
                                // Las colas  1 y 3 son iguales y menores que la 2
                                cliente.Estado = "EV1";
                                fila2.Ventas[0].Cola = fila1.Ventas[0].Cola + 1;
                            }
                            else
                            {
                                // Las colas 2 y 3 son iguales y menores que la 1
                                cliente.Estado = "EV2";
                                fila2.Ventas[1].Cola = fila1.Ventas[1].Cola + 1;
                            }
                        }
                    }

                    // Como es una llegada tengo que agregar el cliente
                    fila2.Clientes.Add(cliente);
                    grdSimulacion.Rows[i + 1].Cells[columnaEstado.Index].Value = cliente.Estado.ToString();

                    grdSimulacion.Rows[i + 1].Cells[columnaHoraInicioEspera.Index].Value = cliente.HoraInicioEspera.ToString();

                }

                // LLEGADA RECLAMO
                if (fila2.Evento == "llegada_reclamo")
                {
                    copiarProximasLlegadas(fila1, fila2);

                    // Genero la prox. llegada_reclamo
                    fila2.LlegadaReclamo.Rnd = generarRandom(random);
                    fila2.LlegadaReclamo.TiempoEntreLlegadas = calcularTiempo(mediaLlegadaReclamo, fila2.LlegadaReclamo.Rnd);
                    fila2.LlegadaReclamo.ProxLlegada = fila2.Reloj + fila2.LlegadaReclamo.TiempoEntreLlegadas;

                    copiarObjetosFilaAnterior(fila1, fila2);
                    copiarFinesAtencion(fila1, fila2);
                    copiarEstadisticas(fila1, fila2);

                    // Tengo que revisar las colas y los estados de VENTAS con el for
                    Cliente cliente = new Cliente();

                    int cantColumnas = grdSimulacion.ColumnCount;
                    DataGridViewColumn columnaEstado = new DataGridViewTextBoxColumn();
                    columnaEstado.HeaderText = "Estado" + (fila2.Clientes.Count + 1);
                    DataGridViewColumn columnaHoraInicioEspera = new DataGridViewTextBoxColumn();
                    columnaHoraInicioEspera.HeaderText = "HIEspera" + (fila2.Clientes.Count + 1);
                    grdSimulacion.Columns.Add(columnaEstado);
                    grdSimulacion.Columns.Add(columnaHoraInicioEspera);

                    bool empleadoLibre = false;
                    for (int j = 0; j < fila1.Reclamos.Count; j++)
                    {
                        if (fila1.Reclamos[j].Estado == "Libre")
                        {
                            // Si es atendido se cambiam los estado correspondientes, y se genera el fin de atención
                            cliente.Estado = "SR" + (j + 1);
                            cliente.HoraInicioAtencion = fila2.Reloj;
                            fila2.Reclamos[j].Estado = "Ocupado";

                            fila2.Fin_reclamo.Rnd = generarRandom(random);
                            fila2.Fin_reclamo.TiempoAtencion = calcularTiempo(mediaFinReclamo, fila2.Fin_reclamo.Rnd);
                            fila2.Fin_reclamo.FinAtencion[j] = fila2.Reloj + fila2.Fin_reclamo.TiempoAtencion;
                            empleadoLibre = true;
                            break;
                        }
                    }
                    if (!empleadoLibre)
                    {
                        cliente.HoraInicioEspera = fila2.Reloj;
                        // Si ninguna está libre, deberá esperar en la cola más corta
                        if (fila1.Reclamos[0].Cola == fila1.Reclamos[1].Cola)
                        {
                            cliente.Estado = "ER1";
                            fila2.Reclamos[0].Cola = fila1.Reclamos[0].Cola + 1;
                        }
                        else if (fila1.Reclamos[0].Cola < fila1.Reclamos[1].Cola)
                        {
                            cliente.Estado = "ER1";
                            fila2.Reclamos[0].Cola = fila1.Reclamos[0].Cola + 1;
                        }
                        else
                        {
                            cliente.Estado = "ER2";
                            fila2.Reclamos[1].Cola = fila1.Reclamos[1].Cola + 1;
                        }
                    }
                           
                    // Como es una llegada tengo que agregar el cliente
                    fila2.Clientes.Add(cliente);
                    grdSimulacion.Rows[i+1].Cells[columnaEstado.Index].Value = cliente.Estado.ToString();

                    grdSimulacion.Rows[i+1].Cells[columnaHoraInicioEspera.Index].Value = cliente.HoraInicioEspera.ToString();
                }

                // LLEGADA ATENCIÓN EMPRESARIAL
                if (fila2.Evento == "llegada_AE")
                {
                    copiarProximasLlegadas(fila1, fila2);

                    // Genero la prox. llegada_AE
                    fila2.LlegadaAE.Rnd = generarRandom(random);
                    fila2.LlegadaAE.TiempoEntreLlegadas = calcularTiempo(mediaLlegadaAE, fila2.LlegadaAE.Rnd);
                    fila2.LlegadaAE.ProxLlegada = fila2.Reloj + fila2.LlegadaAE.TiempoEntreLlegadas;

                    copiarObjetosFilaAnterior(fila1, fila2);
                    copiarFinesAtencion(fila1, fila2);
                    copiarEstadisticas(fila1, fila2);

                    // Tengo que revisar las colas y los estados de VENTAS con el for

                    Cliente cliente = new Cliente();

                    int cantColumnas = grdSimulacion.ColumnCount;
                    DataGridViewColumn columnaEstado = new DataGridViewTextBoxColumn();
                    columnaEstado.HeaderText = "Estado" + (fila2.Clientes.Count + 1);
                    DataGridViewColumn columnaHoraInicioEspera = new DataGridViewTextBoxColumn();
                    columnaHoraInicioEspera.HeaderText = "HIEspera" + (fila2.Clientes.Count + 1);
                    grdSimulacion.Columns.Add(columnaEstado);
                    grdSimulacion.Columns.Add(columnaHoraInicioEspera);


                    bool empleadoLibre = false;
                    for (int j = 0; j < fila1.AtencionEmp.Count; j++)
                    {
                        if (fila1.AtencionEmp[j].Cola == 0 && fila1.AtencionEmp[j].Estado == "Libre")
                        {
                            // Si es atendido se cambiam los estado correspondientes, y se genera el fin de atención
                            cliente.Estado = "SAE" + (j + 1);
                            cliente.HoraInicioAtencion = fila2.Reloj;
                            fila2.AtencionEmp[j].Estado = "Ocupado";

                            fila2.Fin_AE.Rnd = generarRandom(random);
                            fila2.Fin_AE.TiempoAtencion = calcularTiempo(mediaFinAE, fila2.Fin_AE.Rnd);
                            fila2.Fin_AE.FinAtencion[j] = fila2.Reloj + fila2.Fin_AE.TiempoAtencion;

                            empleadoLibre = true;
                            break;
                        }
                    }
                    if (!empleadoLibre){
                            cliente.HoraInicioEspera = fila2.Reloj;
                            // Si ninguna está libre, deberá esperar en la cola más corta
                            if (fila1.AtencionEmp[0].Cola == fila1.AtencionEmp[1].Cola)
                            {
                                cliente.Estado = "EAE1";
                                fila2.AtencionEmp[0].Cola = fila1.AtencionEmp[0].Cola + 1;
                            }
                            else if (fila1.AtencionEmp[0].Cola < fila1.AtencionEmp[1].Cola)
                            {
                                cliente.Estado = "EAE1";
                                fila2.AtencionEmp[0].Cola = fila1.AtencionEmp[0].Cola + 1;
                            }
                            else
                            {
                                cliente.Estado = "EAE2";
                                fila2.AtencionEmp[1].Cola = fila1.AtencionEmp[1].Cola + 1;
                            }
                    }
                    // Como es una llegada tengo que agregar el cliente
                    fila2.Clientes.Add(cliente);

                    grdSimulacion.Rows[i+1].Cells[columnaEstado.Index].Value = cliente.Estado.ToString();

                    grdSimulacion.Rows[i+1].Cells[columnaHoraInicioEspera.Index].Value = cliente.HoraInicioEspera.ToString();
                }

                // LLEGADA POSTALES
                if (fila2.Evento == "llegada_postales")
                {
                    copiarProximasLlegadas(fila1, fila2);
                    Cliente cliente = new Cliente();

                    int cantColumnas = grdSimulacion.ColumnCount;
                    DataGridViewColumn columnaEstado = new DataGridViewTextBoxColumn();
                    columnaEstado.HeaderText = "Estado" + (fila2.Clientes.Count + 1);
                    DataGridViewColumn columnaHoraInicioEspera = new DataGridViewTextBoxColumn();
                    columnaHoraInicioEspera.HeaderText = "HIEspera" + (fila2.Clientes.Count + 1);
                    grdSimulacion.Columns.Add(columnaEstado);
                    grdSimulacion.Columns.Add(columnaHoraInicioEspera);

                    // Genero la prox. llegada_AE
                    fila2.LlegadaPostales.Rnd = generarRandom(random);
                    fila2.LlegadaPostales.TiempoEntreLlegadas = calcularTiempo(mediaLlegadaPostales, fila2.LlegadaPostales.Rnd);
                    fila2.LlegadaPostales.ProxLlegada = fila2.Reloj + fila2.LlegadaPostales.TiempoEntreLlegadas;

                    copiarObjetosFilaAnterior(fila1, fila2);
                    copiarFinesAtencion(fila1, fila2);
                    copiarEstadisticas(fila1, fila2);

                    if (fila1.Postales[0].Cola == 0 && fila1.Postales[0].Estado == "Libre")
                    {
                        // Si es atendido se cambiam los estado correspondientes, y se genera el fin de atención

                        cliente.Estado = "SP";
                        cliente.HoraInicioAtencion = fila2.Reloj;
                        fila2.Postales[0].Estado = "Ocupado";

                        //Calculo fin_atención
                        fila2.Fin_postales.Rnd = generarRandom(random);
                        fila2.Fin_postales.TiempoAtencion = calcularTiempo(mediaFinPostales, fila2.Fin_postales.Rnd);
                        fila2.Fin_postales.FinAtencion = fila2.Reloj + fila2.Fin_postales.TiempoAtencion;

                    }
                    else
                    {
                        cliente.Estado = "EP";
                        cliente.HoraInicioEspera = fila2.Reloj;
                        fila2.Postales[0].Cola = fila1.Postales[0].Cola + 1;
                    }
                    // Como es una llegada tengo que agregar el cliente
                    fila2.Clientes.Add(cliente);
                    grdSimulacion.Rows[i+1].Cells[columnaEstado.Index].Value = cliente.Estado.ToString();

                    grdSimulacion.Rows[i+1].Cells[columnaHoraInicioEspera.Index].Value = cliente.HoraInicioEspera.ToString();

                }

                // --------------------------------------------FINES DE ATENCIÓN---------------------------------------------------------------------------------------
                // FIN ENVIO PAQUETES

                if (fila2.Evento == "fin_envio1")
                {
                    copiarProximasLlegadas(fila1, fila2);
                    copiarFinesAtencion(fila1, fila2);
                    copiarObjetosFilaAnterior(fila1, fila2);  // incluye los clientes, y los objetos (servidores)
                    copiarEstadisticas(fila1, fila2);  // copio los acumuladores y contadores

                    calcularFinAtencionEnvio(1, fila1, fila2, random, mediaFinPaquete);
                }

                if (fila2.Evento == "fin_envio2")
                {
                    copiarProximasLlegadas(fila1, fila2);
                    copiarFinesAtencion(fila1, fila2);
                    copiarObjetosFilaAnterior(fila1, fila2);  // incluye los clientes, y los objetos (servidores)
                    copiarEstadisticas(fila1, fila2);  // copio los acumuladores y contadores

                    calcularFinAtencionEnvio(2, fila1, fila2, random, mediaFinPaquete);
                }
                if (fila2.Evento == "fin_envio3")
                {
                    copiarProximasLlegadas(fila1, fila2);
                    copiarFinesAtencion(fila1, fila2);
                    copiarObjetosFilaAnterior(fila1, fila2);  // incluye los clientes, y los objetos (servidores)
                    copiarEstadisticas(fila1, fila2);  // copio los acumuladores y contadores

                    calcularFinAtencionEnvio(3, fila1, fila2, random, mediaFinPaquete);
                }

                // FIN RECLAMO
                if (fila2.Evento == "fin_reclamo1")
                {
                    copiarProximasLlegadas(fila1, fila2);
                    copiarFinesAtencion(fila1, fila2);
                    copiarObjetosFilaAnterior(fila1, fila2);
                    copiarEstadisticas(fila1, fila2);

                    calcularFinAtencionReclamo(1, fila1, fila2, random, mediaFinReclamo);
                }

                if (fila2.Evento == "fin_reclamo2")
                {
                    copiarProximasLlegadas(fila1, fila2);
                    copiarFinesAtencion(fila1, fila2);
                    copiarObjetosFilaAnterior(fila1, fila2);
                    copiarEstadisticas(fila1, fila2);

                    calcularFinAtencionReclamo(2, fila1, fila2, random, mediaFinReclamo);
                }

                // FIN VENTAS 
                if (fila2.Evento == "fin_venta1")
                {
                    copiarProximasLlegadas(fila1, fila2);
                    copiarFinesAtencion(fila1, fila2);
                    copiarObjetosFilaAnterior(fila1, fila2);
                    copiarEstadisticas(fila1, fila2);

                    calcularFinAtencionVenta(1, fila1, fila2, random, mediaFinVenta);
                }


                if (fila2.Evento == "fin_venta2")
                {
                    copiarProximasLlegadas(fila1, fila2);
                    copiarFinesAtencion(fila1, fila2);
                    copiarObjetosFilaAnterior(fila1, fila2);
                    copiarEstadisticas(fila1, fila2);

                    calcularFinAtencionVenta(2, fila1, fila2, random, mediaFinVenta);
                }
                if (fila2.Evento == "fin_venta3")
                {
                    copiarProximasLlegadas(fila1, fila2);
                    copiarFinesAtencion(fila1, fila2);
                    copiarObjetosFilaAnterior(fila1, fila2);
                    copiarEstadisticas(fila1, fila2);

                    calcularFinAtencionVenta(3, fila1, fila2, random, mediaFinVenta);
                }

                // FIN ATENCIÓN EMPRESARIAL

                if (fila2.Evento == "fin_AE1")
                {
                    copiarProximasLlegadas(fila1, fila2);
                    copiarFinesAtencion(fila1, fila2);
                    copiarObjetosFilaAnterior(fila1, fila2);
                    copiarEstadisticas(fila1, fila2);

                    calcularFinAtencionEmp(1, fila1, fila2, random, mediaFinAE);
                }
                if (fila2.Evento == "fin_AE2")
                {
                    copiarProximasLlegadas(fila1, fila2);
                    copiarFinesAtencion(fila1, fila2);
                    copiarObjetosFilaAnterior(fila1, fila2);
                    copiarEstadisticas(fila1, fila2);

                    calcularFinAtencionEmp(2, fila1, fila2, random, mediaFinAE);
                }

                // FIN POSTALES
                if (fila2.Evento == "fin_postales")
                {
                    copiarProximasLlegadas(fila1, fila2);
                    copiarFinesAtencion(fila1, fila2);
                    copiarObjetosFilaAnterior(fila1, fila2);
                    copiarEstadisticas(fila1, fila2);

                    calcularFinAtencionPostales( fila1, fila2, random, mediaFinPostales);
                }

                List<double> posiblesProximosEventos = new List<double>();
                posiblesProximosEventos.Add(fila2.LlegadaEnvio.ProxLlegada); // 0 
                posiblesProximosEventos.Add(fila2.LlegadaReclamo.ProxLlegada); // 1
                posiblesProximosEventos.Add(fila2.LlegadaVenta.ProxLlegada); // 2
                posiblesProximosEventos.Add(fila2.LlegadaAE.ProxLlegada); // 3
                posiblesProximosEventos.Add(fila2.LlegadaPostales.ProxLlegada); //4
                posiblesProximosEventos.Add((double)fila2.Fin_envio.FinAtencion[0]);
                posiblesProximosEventos.Add((double)fila2.Fin_envio.FinAtencion[1]);
                posiblesProximosEventos.Add((double)fila2.Fin_envio.FinAtencion[2]);
                posiblesProximosEventos.Add((double)fila2.Fin_reclamo.FinAtencion[0]);
                posiblesProximosEventos.Add((double)fila2.Fin_reclamo.FinAtencion[1]);
                posiblesProximosEventos.Add((double)fila2.Fin_venta.FinAtencion[0]);
                posiblesProximosEventos.Add((double)fila2.Fin_venta.FinAtencion[1]);
                posiblesProximosEventos.Add((double)fila2.Fin_venta.FinAtencion[2]);
                posiblesProximosEventos.Add((double)fila2.Fin_AE.FinAtencion[0]);
                posiblesProximosEventos.Add((double)fila2.Fin_AE.FinAtencion[1]);
                posiblesProximosEventos.Add((double)fila2.Fin_postales.FinAtencion);


                List<double> proximoEvento = buscarProxEvento(posiblesProximosEventos);
           
                //filasMostrar.Add(fila1);
                fila1 = fila2;
                
                fila2 = new FilaVector();
                fila2.Reloj = (double)proximoEvento[0];
                fila2.Evento = nombresEventos[(int)proximoEvento[1]];

                
            } 

        
        }

        private List<double> buscarProxEvento(List<double> tiempos)
        {
            double proxReloj = double.MaxValue;
            int indice = -1;

            for (int i = 0; i < tiempos.Count; i++)
            {
                if (tiempos[i] != 0 && tiempos[i] < proxReloj)
                {
                    proxReloj = tiempos[i];
                    indice = i;
                }
                // RESOLVER PARA EL CASO DE QUE SEAN IGUALES
            }
            List<double> res = new List<double>();
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

        private int buscarClientePorEstado(string estado, List<Cliente> clientes)
        {
            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].Estado == estado)
                {
                    return i;
                }
            }
            throw new InvalidOperationException($"No se encontró un cliente con el estado: {estado}");
        }

        private void copiarObjetosFilaAnterior(FilaVector fila1, FilaVector fila2)
        {
            fila2.EnvioPaquetes = fila1.EnvioPaquetes;
            fila2.Reclamos = fila1.Reclamos;
            fila2.Ventas = fila1.Ventas;
            fila2.AtencionEmp = fila1.AtencionEmp;
            fila2.Postales = fila1.Postales;

            fila2.Clientes = fila1.Clientes;
        }

        private  void copiarFinesAtencion(FilaVector fila1, FilaVector fila2)
        {
            fila2.Fin_envio.FinAtencion = fila1.Fin_envio.FinAtencion;
            fila2.Fin_reclamo.FinAtencion = fila1.Fin_reclamo.FinAtencion;
            fila2.Fin_venta.FinAtencion = fila1.Fin_venta.FinAtencion;
            fila2.Fin_AE.FinAtencion = fila1.Fin_AE.FinAtencion;
            fila2.Fin_postales.FinAtencion = fila1.Fin_postales.FinAtencion;
        }

        private void copiarProximasLlegadas( FilaVector fila1, FilaVector fila2)
        {
            fila2.LlegadaReclamo.ProxLlegada = fila1.LlegadaReclamo.ProxLlegada;
            fila2.LlegadaVenta.ProxLlegada = fila1.LlegadaVenta.ProxLlegada;
            fila2.LlegadaAE.ProxLlegada = fila1.LlegadaAE.ProxLlegada;
            fila2.LlegadaPostales.ProxLlegada = fila1.LlegadaPostales.ProxLlegada;
            fila2.LlegadaEnvio.ProxLlegada = fila1.LlegadaEnvio.ProxLlegada;
        }

        private void copiarEstadisticas(FilaVector fila1, FilaVector fila2)
        {
            fila2.EstadisticasEnvio = fila1.EstadisticasEnvio;
            fila2.EstadisticasReclamo = fila1.EstadisticasReclamo;
            fila2.EstadisticasVenta = fila1.EstadisticasVenta;
            fila2.EstadisticasAE = fila1.EstadisticasAE;
            fila2.EstadisticasPostales = fila1.EstadisticasPostales;
        }

        private void calcularFinAtencionEnvio(int nroObjetoEnvio, FilaVector fila1, FilaVector fila2, Random random, double media)
        {
            string estadoSiendoAtendido = "SE" + nroObjetoEnvio;
            string estadoEsperando = "EE" + nroObjetoEnvio;
            int indice = nroObjetoEnvio - 1;

            // Busco al cliente que estaba siendo atendido en ese objeto y lo elimino.
            int indexClienteAtendido = buscarClientePorEstado(estadoSiendoAtendido, fila2.Clientes);
           
            fila2.EstadisticasEnvio.CantClientesAtendidos += 1;

            fila2.EstadisticasEnvio.AcumuladorOcupacion += (fila2.Reloj - fila2.Clientes[indexClienteAtendido].HoraInicioAtencion);
            fila2.Clientes[indexClienteAtendido].Estado = "Eliminado";
            if (fila1.EnvioPaquetes[indice].Cola == 0) 
            {
                fila2.EnvioPaquetes[indice].Estado = "Libre";
                fila2.Fin_envio.FinAtencion[indice] = 0;
            }
            else
            {
                fila2.EnvioPaquetes[indice].Cola = fila1.EnvioPaquetes[0].Cola - 1;
                fila2.EnvioPaquetes[indice].Estado = "Ocupado";
                int indexClientePorAtender = buscarClientePorEstado(estadoEsperando, fila2.Clientes);
                fila2.Clientes[indexClientePorAtender].Estado = estadoSiendoAtendido;
                fila2.Clientes[indexClientePorAtender].HoraInicioAtencion = fila2.Reloj;


                fila2.Fin_envio.Rnd = generarRandom(random);
                fila2.Fin_envio.TiempoAtencion = calcularTiempo(media, fila2.Fin_envio.Rnd);
                fila2.Fin_envio.FinAtencion[indice] = fila2.Fin_envio.TiempoAtencion + fila2.Reloj;

                fila2.EstadisticasEnvio.AcumuladorEspera = (fila2.Reloj - fila2.Clientes[indexClientePorAtender].HoraInicioEspera) + fila1.EstadisticasEnvio.AcumuladorEspera;
            }
        }

        private void calcularFinAtencionReclamo(int nroObjetoReclamo, FilaVector fila1, FilaVector fila2, Random random, double media)
        {
            string estadoSiendoAtendido = "SR" + nroObjetoReclamo;
            string estadoEsperando = "ER" + nroObjetoReclamo;
            int indice = nroObjetoReclamo - 1;

            int indexClienteAtendido = buscarClientePorEstado(estadoSiendoAtendido, fila1.Clientes);
           
            fila2.EstadisticasReclamo.CantClientesAtendidos += 1;
            fila2.EstadisticasReclamo.AcumuladorOcupacion = (fila2.Reloj - fila2.Clientes[indexClienteAtendido].HoraInicioAtencion) + fila1.EstadisticasReclamo.AcumuladorOcupacion;
            fila2.Clientes[indexClienteAtendido].Estado = "Eliminado";

            if (fila1.Reclamos[indice].Cola == 0)
            {
                fila2.Reclamos[indice].Estado = "Libre";
                fila2.Fin_reclamo.FinAtencion[indice] = 0;
            }
            else
            {
                fila2.Reclamos[indice].Cola = fila1.Reclamos[indice].Cola - 1;
                fila2.Reclamos[indice].Estado = "Ocupado";
                int indexClientePorAtender = buscarClientePorEstado(estadoEsperando, fila1.Clientes);
                fila2.Clientes[indexClientePorAtender].Estado = estadoSiendoAtendido;
                fila2.Clientes[indexClientePorAtender].HoraInicioAtencion = fila2.Reloj;

                fila2.Fin_reclamo.Rnd = generarRandom(random);
                fila2.Fin_reclamo.TiempoAtencion = calcularTiempo(media, fila2.Fin_reclamo.Rnd);
                fila2.Fin_reclamo.FinAtencion[indice] = fila2.Fin_reclamo.TiempoAtencion + fila2.Reloj;

                fila2.EstadisticasReclamo.AcumuladorEspera = (fila2.Reloj - fila2.Clientes[indexClientePorAtender].HoraInicioEspera) + fila1.EstadisticasReclamo.AcumuladorEspera;
            }
        }

        private void calcularFinAtencionVenta(int nroObjetoVenta, FilaVector fila1, FilaVector fila2, Random random, double media)
        {
            string estadoSiendoAtendido = "SV" + nroObjetoVenta;
            string estadoEsperando = "EV" + nroObjetoVenta;
            int indice = nroObjetoVenta - 1;

            int indexClienteAtendido = buscarClientePorEstado(estadoSiendoAtendido, fila1.Clientes);
            
            fila2.EstadisticasVenta.CantClientesAtendidos += 1;

            fila2.EstadisticasVenta.AcumuladorOcupacion = (fila2.Reloj - fila2.Clientes[indexClienteAtendido].HoraInicioAtencion) + fila1.EstadisticasVenta.AcumuladorOcupacion;
            fila2.Clientes[indexClienteAtendido].Estado = "Eliminado";

            if (fila1.Ventas[indice].Cola == 0)
            {
                fila2.Ventas[indice].Estado = "Libre";
                fila2.Fin_venta.FinAtencion[indice] = 0;
            }
            else
            {
                fila2.Ventas[indice].Cola = fila1.Ventas[indice].Cola - 1;
                fila2.Ventas[indice].Estado = "Ocupado";
                int indexClientePorAtender = buscarClientePorEstado(estadoEsperando, fila1.Clientes);
                fila2.Clientes[indexClientePorAtender].Estado = estadoSiendoAtendido;
                fila2.Clientes[indexClientePorAtender].HoraInicioAtencion = fila2.Reloj;

                fila2.Fin_venta.Rnd = generarRandom(random);
                fila2.Fin_venta.TiempoAtencion = calcularTiempo(media, fila2.Fin_venta.Rnd);
                fila2.Fin_venta.FinAtencion[indice] = fila2.Fin_venta.TiempoAtencion + fila2.Reloj;

                fila2.EstadisticasVenta.AcumuladorEspera = (fila2.Reloj - fila2.Clientes[indexClientePorAtender].HoraInicioEspera) + fila1.EstadisticasVenta.AcumuladorEspera;
            }
        }

        private void calcularFinAtencionEmp(int nroObjetoAE, FilaVector fila1, FilaVector fila2, Random random, double media)
        {

            string estadoSiendoAtendido = "SAE" + nroObjetoAE;
            string estadoEsperando = "EAE" + nroObjetoAE;
            int indice = nroObjetoAE - 1;

            int indexClienteAtendido = buscarClientePorEstado(estadoSiendoAtendido, fila1.Clientes);
            
            fila2.EstadisticasAE.CantClientesAtendidos += 1;

            fila2.EstadisticasAE.AcumuladorOcupacion = (fila2.Reloj - fila2.Clientes[indexClienteAtendido].HoraInicioAtencion) + fila1.EstadisticasAE.AcumuladorOcupacion;
            fila2.Clientes[indexClienteAtendido].Estado = "Eliminado";

            if (fila1.AtencionEmp[indice].Cola == 0)
            {
                fila2.AtencionEmp[indice].Estado = "Libre";
                fila2.Fin_AE.FinAtencion[indice] = 0;
            }
            else
            {
                fila2.AtencionEmp[indice].Cola = fila1.AtencionEmp[indice].Cola - 1;
                fila2.AtencionEmp[indice].Estado = "Ocupado";
                int indexClientePorAtender = buscarClientePorEstado(estadoEsperando, fila1.Clientes);
                fila2.Clientes[indexClientePorAtender].Estado = estadoSiendoAtendido;
                fila2.Clientes[indexClientePorAtender].HoraInicioAtencion = fila2.Reloj;

                fila2.Fin_AE.Rnd = generarRandom(random);
                fila2.Fin_AE.TiempoAtencion = calcularTiempo(media, fila2.Fin_AE.Rnd);
                fila2.Fin_AE.FinAtencion[indice] = fila2.Fin_AE.TiempoAtencion + fila2.Reloj;

                fila2.EstadisticasAE.AcumuladorEspera = (fila2.Reloj - fila2.Clientes[indexClientePorAtender].HoraInicioEspera) + fila1.EstadisticasAE.AcumuladorEspera;
            }
        }
        private void calcularFinAtencionPostales(FilaVector fila1, FilaVector fila2, Random random, double media)
        {

            int indexClienteAtendido = buscarClientePorEstado("SP", fila1.Clientes);
            
            fila2.EstadisticasPostales.CantClientesAtendidos += 1;

            fila2.EstadisticasPostales.AcumuladorOcupacion = (fila2.Reloj - fila2.Clientes[indexClienteAtendido].HoraInicioAtencion) + fila1.EstadisticasPostales.AcumuladorOcupacion;
            fila2.Clientes[indexClienteAtendido].Estado = "Eliminado";

            if (fila1.Postales[0].Cola == 0)
            {
                fila2.Postales[0].Estado = "Libre";
                fila2.Fin_postales.FinAtencion = 0;
            }
            else
            {
                fila2.Postales[0].Cola = fila1.Postales[0].Cola - 1;
                fila2.Postales[0].Estado = "Ocupado";
                int indiceClientePorAtender = buscarClientePorEstado("EP", fila1.Clientes);
                fila2.Clientes[indiceClientePorAtender].Estado = "SP";
                fila2.Clientes[indiceClientePorAtender].HoraInicioAtencion = fila2.Reloj;
                fila2.Fin_postales.Rnd = generarRandom(random);
                fila2.Fin_postales.TiempoAtencion = calcularTiempo(media, fila2.Fin_postales.Rnd);
                fila2.Fin_postales.FinAtencion = fila2.Fin_postales.TiempoAtencion + fila2.Reloj;

                fila2.EstadisticasPostales.AcumuladorEspera = (fila2.Reloj - fila2.Clientes[indiceClientePorAtender].HoraInicioEspera) + fila1.EstadisticasPostales.AcumuladorEspera;
            }
        }
    }
} 
