﻿namespace TP4_SIM
{
    partial class Simulacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulacion));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFinPaquete = new System.Windows.Forms.TextBox();
            this.txtLlegadaPaquete = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFinReclamo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLlegadaReclamo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFinVenta = new System.Windows.Forms.TextBox();
            this.txtLlegadaVenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFinAtencion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLlegadaAtencion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtFinPostales = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLlegadaPostales = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantFilas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnIniciarSimulacion = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrimeraFila = new System.Windows.Forms.TextBox();
            this.btnNuevoServicio = new System.Windows.Forms.Button();
            this.btnAusencia = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtOcupacionP = new System.Windows.Forms.TextBox();
            this.txtOcupacionAE = new System.Windows.Forms.TextBox();
            this.txtOcupacionV = new System.Windows.Forms.TextBox();
            this.txtOcupacionR = new System.Windows.Forms.TextBox();
            this.txtOcupacionE = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEsperaP = new System.Windows.Forms.TextBox();
            this.txtEsperaAE = new System.Windows.Forms.TextBox();
            this.txtEsperaV = new System.Windows.Forms.TextBox();
            this.txtEsperaR = new System.Windows.Forms.TextBox();
            this.txtEsperaE = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "OFICINA DE CORREOS MOCASA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFinPaquete);
            this.groupBox1.Controls.Add(this.txtLlegadaPaquete);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(431, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Envío de Paquetes";
            // 
            // txtFinPaquete
            // 
            this.txtFinPaquete.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinPaquete.Location = new System.Drawing.Point(222, 84);
            this.txtFinPaquete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFinPaquete.Name = "txtFinPaquete";
            this.txtFinPaquete.Size = new System.Drawing.Size(180, 28);
            this.txtFinPaquete.TabIndex = 3;
            this.txtFinPaquete.Text = "6";
            // 
            // txtLlegadaPaquete
            // 
            this.txtLlegadaPaquete.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLlegadaPaquete.Location = new System.Drawing.Point(222, 35);
            this.txtLlegadaPaquete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtLlegadaPaquete.Name = "txtLlegadaPaquete";
            this.txtLlegadaPaquete.Size = new System.Drawing.Size(180, 28);
            this.txtLlegadaPaquete.TabIndex = 2;
            this.txtLlegadaPaquete.Text = "2,4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fin atención:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Llegada cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFinReclamo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtLlegadaReclamo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 186);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size(431, 130);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reclamaciones y Devoluciones";
            // 
            // txtFinReclamo
            // 
            this.txtFinReclamo.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinReclamo.Location = new System.Drawing.Point(222, 92);
            this.txtFinReclamo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFinReclamo.Name = "txtFinReclamo";
            this.txtFinReclamo.Size = new System.Drawing.Size(180, 28);
            this.txtFinReclamo.TabIndex = 7;
            this.txtFinReclamo.Text = "8,57";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Llegada cliente:";
            // 
            // txtLlegadaReclamo
            // 
            this.txtLlegadaReclamo.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLlegadaReclamo.Location = new System.Drawing.Point(222, 42);
            this.txtLlegadaReclamo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtLlegadaReclamo.Name = "txtLlegadaReclamo";
            this.txtLlegadaReclamo.Size = new System.Drawing.Size(180, 28);
            this.txtLlegadaReclamo.TabIndex = 6;
            this.txtLlegadaReclamo.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fin atención:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFinVenta);
            this.groupBox3.Controls.Add(this.txtLlegadaVenta);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(34, 326);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox3.Size = new System.Drawing.Size(431, 130);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Venta de Sellos y Sobres";
            // 
            // txtFinVenta
            // 
            this.txtFinVenta.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinVenta.Location = new System.Drawing.Point(222, 93);
            this.txtFinVenta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFinVenta.Name = "txtFinVenta";
            this.txtFinVenta.Size = new System.Drawing.Size(180, 28);
            this.txtFinVenta.TabIndex = 7;
            this.txtFinVenta.Text = "3,33";
            // 
            // txtLlegadaVenta
            // 
            this.txtLlegadaVenta.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLlegadaVenta.Location = new System.Drawing.Point(222, 43);
            this.txtLlegadaVenta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtLlegadaVenta.Name = "txtLlegadaVenta";
            this.txtLlegadaVenta.Size = new System.Drawing.Size(180, 28);
            this.txtLlegadaVenta.TabIndex = 6;
            this.txtLlegadaVenta.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fin atención:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Llegada cliente:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtFinAtencion);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtLlegadaAtencion);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(34, 466);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox4.Size = new System.Drawing.Size(431, 126);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Atención Empresarial";
            // 
            // txtFinAtencion
            // 
            this.txtFinAtencion.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinAtencion.Location = new System.Drawing.Point(222, 89);
            this.txtFinAtencion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFinAtencion.Name = "txtFinAtencion";
            this.txtFinAtencion.Size = new System.Drawing.Size(180, 28);
            this.txtFinAtencion.TabIndex = 11;
            this.txtFinAtencion.Text = "12";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Llegada cliente:";
            // 
            // txtLlegadaAtencion
            // 
            this.txtLlegadaAtencion.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLlegadaAtencion.Location = new System.Drawing.Point(222, 40);
            this.txtLlegadaAtencion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtLlegadaAtencion.Name = "txtLlegadaAtencion";
            this.txtLlegadaAtencion.Size = new System.Drawing.Size(180, 28);
            this.txtLlegadaAtencion.TabIndex = 10;
            this.txtLlegadaAtencion.Text = "6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Fin atención:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtFinPostales);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtLlegadaPostales);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(34, 602);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox5.Size = new System.Drawing.Size(431, 132);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Postales y Envíos Especiales";
            // 
            // txtFinPostales
            // 
            this.txtFinPostales.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinPostales.Location = new System.Drawing.Point(222, 93);
            this.txtFinPostales.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFinPostales.Name = "txtFinPostales";
            this.txtFinPostales.Size = new System.Drawing.Size(180, 28);
            this.txtFinPostales.TabIndex = 15;
            this.txtFinPostales.Text = "20";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 49);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "Llegada cliente:";
            // 
            // txtLlegadaPostales
            // 
            this.txtLlegadaPostales.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLlegadaPostales.Location = new System.Drawing.Point(222, 43);
            this.txtLlegadaPostales.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtLlegadaPostales.Name = "txtLlegadaPostales";
            this.txtLlegadaPostales.Size = new System.Drawing.Size(180, 28);
            this.txtLlegadaPostales.TabIndex = 14;
            this.txtLlegadaPostales.Text = "7,5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(79, 93);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "Fin atención:";
            // 
            // txtCantFilas
            // 
            this.txtCantFilas.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantFilas.Location = new System.Drawing.Point(720, 92);
            this.txtCantFilas.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCantFilas.Name = "txtCantFilas";
            this.txtCantFilas.Size = new System.Drawing.Size(180, 28);
            this.txtCantFilas.TabIndex = 5;
            this.txtCantFilas.Text = "300";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(482, 92);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(228, 24);
            this.label12.TabIndex = 4;
            this.label12.Text = "Cant. de líneas a simular:";
            // 
            // btnIniciarSimulacion
            // 
            this.btnIniciarSimulacion.Location = new System.Drawing.Point(521, 457);
            this.btnIniciarSimulacion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnIniciarSimulacion.Name = "btnIniciarSimulacion";
            this.btnIniciarSimulacion.Size = new System.Drawing.Size(329, 66);
            this.btnIniciarSimulacion.TabIndex = 6;
            this.btnIniciarSimulacion.Text = "INICIAR SIMULACIÓN";
            this.btnIniciarSimulacion.UseVisualStyleBackColor = true;
            this.btnIniciarSimulacion.Click += new System.EventHandler(this.btnIniciarSimulacion_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(482, 137);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 24);
            this.label13.TabIndex = 7;
            this.label13.Text = "Mostrar desde la fila:";
            // 
            // txtPrimeraFila
            // 
            this.txtPrimeraFila.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimeraFila.Location = new System.Drawing.Point(720, 137);
            this.txtPrimeraFila.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPrimeraFila.Name = "txtPrimeraFila";
            this.txtPrimeraFila.Size = new System.Drawing.Size(180, 28);
            this.txtPrimeraFila.TabIndex = 8;
            this.txtPrimeraFila.Text = "1";
            // 
            // btnNuevoServicio
            // 
            this.btnNuevoServicio.Location = new System.Drawing.Point(521, 553);
            this.btnNuevoServicio.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNuevoServicio.Name = "btnNuevoServicio";
            this.btnNuevoServicio.Size = new System.Drawing.Size(329, 66);
            this.btnNuevoServicio.TabIndex = 9;
            this.btnNuevoServicio.Text = "Simular con nuevo servicio";
            this.btnNuevoServicio.UseVisualStyleBackColor = true;
            this.btnNuevoServicio.Click += new System.EventHandler(this.btnNuevoServicio_Click);
            // 
            // btnAusencia
            // 
            this.btnAusencia.Location = new System.Drawing.Point(525, 643);
            this.btnAusencia.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAusencia.Name = "btnAusencia";
            this.btnAusencia.Size = new System.Drawing.Size(327, 66);
            this.btnAusencia.TabIndex = 10;
            this.btnAusencia.Text = "Simular con ausencia en AE";
            this.btnAusencia.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.txtOcupacionP);
            this.groupBox6.Controls.Add(this.txtOcupacionAE);
            this.groupBox6.Controls.Add(this.txtOcupacionV);
            this.groupBox6.Controls.Add(this.txtOcupacionR);
            this.groupBox6.Controls.Add(this.txtOcupacionE);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.txtEsperaP);
            this.groupBox6.Controls.Add(this.txtEsperaAE);
            this.groupBox6.Controls.Add(this.txtEsperaV);
            this.groupBox6.Controls.Add(this.txtEsperaR);
            this.groupBox6.Controls.Add(this.txtEsperaE);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(921, 50);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(385, 584);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Resultados";
            // 
            // txtOcupacionP
            // 
            this.txtOcupacionP.Enabled = false;
            this.txtOcupacionP.Location = new System.Drawing.Point(230, 514);
            this.txtOcupacionP.Name = "txtOcupacionP";
            this.txtOcupacionP.Size = new System.Drawing.Size(124, 28);
            this.txtOcupacionP.TabIndex = 15;
            // 
            // txtOcupacionAE
            // 
            this.txtOcupacionAE.Enabled = false;
            this.txtOcupacionAE.Location = new System.Drawing.Point(230, 480);
            this.txtOcupacionAE.Name = "txtOcupacionAE";
            this.txtOcupacionAE.Size = new System.Drawing.Size(124, 28);
            this.txtOcupacionAE.TabIndex = 14;
            // 
            // txtOcupacionV
            // 
            this.txtOcupacionV.Enabled = false;
            this.txtOcupacionV.Location = new System.Drawing.Point(230, 450);
            this.txtOcupacionV.Name = "txtOcupacionV";
            this.txtOcupacionV.Size = new System.Drawing.Size(124, 28);
            this.txtOcupacionV.TabIndex = 13;
            // 
            // txtOcupacionR
            // 
            this.txtOcupacionR.Enabled = false;
            this.txtOcupacionR.Location = new System.Drawing.Point(230, 416);
            this.txtOcupacionR.Name = "txtOcupacionR";
            this.txtOcupacionR.Size = new System.Drawing.Size(124, 28);
            this.txtOcupacionR.TabIndex = 12;
            // 
            // txtOcupacionE
            // 
            this.txtOcupacionE.Enabled = false;
            this.txtOcupacionE.Location = new System.Drawing.Point(230, 370);
            this.txtOcupacionE.Name = "txtOcupacionE";
            this.txtOcupacionE.Size = new System.Drawing.Size(124, 28);
            this.txtOcupacionE.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(229, 24);
            this.label14.TabIndex = 10;
            this.label14.Text = "Porcentaje de ocupación";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(265, 24);
            this.label15.TabIndex = 9;
            this.label15.Text = "Tiempos de espera promedio";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(34, 237);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 24);
            this.label16.TabIndex = 4;
            this.label16.Text = "Postales";
            // 
            // txtEsperaP
            // 
            this.txtEsperaP.Enabled = false;
            this.txtEsperaP.Location = new System.Drawing.Point(230, 237);
            this.txtEsperaP.Name = "txtEsperaP";
            this.txtEsperaP.Size = new System.Drawing.Size(100, 28);
            this.txtEsperaP.TabIndex = 8;
            // 
            // txtEsperaAE
            // 
            this.txtEsperaAE.Enabled = false;
            this.txtEsperaAE.Location = new System.Drawing.Point(230, 203);
            this.txtEsperaAE.Name = "txtEsperaAE";
            this.txtEsperaAE.Size = new System.Drawing.Size(100, 28);
            this.txtEsperaAE.TabIndex = 7;
            // 
            // txtEsperaV
            // 
            this.txtEsperaV.Enabled = false;
            this.txtEsperaV.Location = new System.Drawing.Point(230, 168);
            this.txtEsperaV.Name = "txtEsperaV";
            this.txtEsperaV.Size = new System.Drawing.Size(100, 28);
            this.txtEsperaV.TabIndex = 6;
            // 
            // txtEsperaR
            // 
            this.txtEsperaR.Enabled = false;
            this.txtEsperaR.Location = new System.Drawing.Point(230, 134);
            this.txtEsperaR.Name = "txtEsperaR";
            this.txtEsperaR.Size = new System.Drawing.Size(100, 28);
            this.txtEsperaR.TabIndex = 5;
            // 
            // txtEsperaE
            // 
            this.txtEsperaE.Enabled = false;
            this.txtEsperaE.Location = new System.Drawing.Point(230, 93);
            this.txtEsperaE.Name = "txtEsperaE";
            this.txtEsperaE.Size = new System.Drawing.Size(100, 28);
            this.txtEsperaE.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(34, 203);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 24);
            this.label17.TabIndex = 3;
            this.label17.Text = "Atención emp.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(34, 168);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 24);
            this.label18.TabIndex = 2;
            this.label18.Text = "Ventas";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(34, 134);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 24);
            this.label19.TabIndex = 1;
            this.label19.Text = "Reclamos";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(34, 93);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(173, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "Envío de paquetes";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(34, 514);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 24);
            this.label21.TabIndex = 20;
            this.label21.Text = "Postales";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(34, 480);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(138, 24);
            this.label22.TabIndex = 19;
            this.label22.Text = "Atención emp.";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(34, 445);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(69, 24);
            this.label23.TabIndex = 18;
            this.label23.Text = "Ventas";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(34, 411);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(95, 24);
            this.label24.TabIndex = 17;
            this.label24.Text = "Reclamos";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(34, 370);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(173, 24);
            this.label25.TabIndex = 16;
            this.label25.Text = "Envío de paquetes";
            // 
            // Simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1737, 747);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnAusencia);
            this.Controls.Add(this.btnNuevoServicio);
            this.Controls.Add(this.txtPrimeraFila);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnIniciarSimulacion);
            this.Controls.Add(this.txtCantFilas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Simulacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulación";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFinPaquete;
        private System.Windows.Forms.TextBox txtLlegadaPaquete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFinReclamo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLlegadaReclamo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFinVenta;
        private System.Windows.Forms.TextBox txtLlegadaVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtFinAtencion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLlegadaAtencion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtFinPostales;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLlegadaPostales;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCantFilas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnIniciarSimulacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPrimeraFila;
        private System.Windows.Forms.Button btnNuevoServicio;
        private System.Windows.Forms.Button btnAusencia;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtOcupacionP;
        private System.Windows.Forms.TextBox txtOcupacionAE;
        private System.Windows.Forms.TextBox txtOcupacionV;
        private System.Windows.Forms.TextBox txtOcupacionR;
        private System.Windows.Forms.TextBox txtOcupacionE;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEsperaP;
        private System.Windows.Forms.TextBox txtEsperaAE;
        private System.Windows.Forms.TextBox txtEsperaV;
        private System.Windows.Forms.TextBox txtEsperaR;
        private System.Windows.Forms.TextBox txtEsperaE;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}

