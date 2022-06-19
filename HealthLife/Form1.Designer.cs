namespace HealthLife
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.rtbHealthLife = new System.Windows.Forms.RichTextBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtprecio = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cobMedico = new System.Windows.Forms.ComboBox();
            this.cobEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtNumeroHistoria = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBusquedaH = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtbNutricion = new System.Windows.Forms.RichTextBox();
            this.rtbMedicina = new System.Windows.Forms.RichTextBox();
            this.btnNutricion = new System.Windows.Forms.Button();
            this.btnMedicinaGeneral = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rtbOrdenAlfabetico = new System.Windows.Forms.RichTextBox();
            this.btnOrdenAlfabetico = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnConteoIngresoNutricion = new System.Windows.Forms.Button();
            this.btnConteoIngresoMedicinaGeneral = new System.Windows.Forms.Button();
            this.btnConteoIngresoGeneral = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConteoNutricion = new System.Windows.Forms.Button();
            this.btnConteoMedicinaGeneral = new System.Windows.Forms.Button();
            this.btnConteoGeneral = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControlPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "HealthLife";
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabPage1);
            this.tabControlPrincipal.Controls.Add(this.tabPage2);
            this.tabControlPrincipal.Controls.Add(this.tabPage3);
            this.tabControlPrincipal.Controls.Add(this.tabPage4);
            this.tabControlPrincipal.Controls.Add(this.tabPage5);
            this.tabControlPrincipal.Location = new System.Drawing.Point(0, 62);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(561, 470);
            this.tabControlPrincipal.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.rtbHealthLife);
            this.tabPage1.Controls.Add(this.btnRegistro);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(553, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbHealthLife
            // 
            this.rtbHealthLife.Location = new System.Drawing.Point(8, 255);
            this.rtbHealthLife.Name = "rtbHealthLife";
            this.rtbHealthLife.Size = new System.Drawing.Size(537, 174);
            this.rtbHealthLife.TabIndex = 8;
            this.rtbHealthLife.Text = "";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(365, 13);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(170, 29);
            this.btnRegistro.TabIndex = 7;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.cobMedico);
            this.groupBox1.Controls.Add(this.cobEspecialidad);
            this.groupBox1.Controls.Add(this.txtNumeroHistoria);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 250);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos:";
            // 
            // txtprecio
            // 
            this.txtprecio.FormattingEnabled = true;
            this.txtprecio.Items.AddRange(new object[] {
            "30"});
            this.txtprecio.Location = new System.Drawing.Point(104, 223);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(215, 23);
            this.txtprecio.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Precio";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(104, 194);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(215, 23);
            this.dtpFecha.TabIndex = 3;
            // 
            // cobMedico
            // 
            this.cobMedico.FormattingEnabled = true;
            this.cobMedico.Items.AddRange(new object[] {
            "Dr. Juan Carlos Torres (Nutr.)",
            "Dra. Jessica Sánches (Med.G)",
            "Dr. Ruslan Golovliov Balbin (Med.G)",
            "Dr. Marco Antonio Mejía Vargas Machuca(Nutr.)",
            "Dra. Jenny Vargas Bravo (Med.G)",
            "Dra. Elisabet Gentile Carrera(Nutr.)"});
            this.cobMedico.Location = new System.Drawing.Point(104, 165);
            this.cobMedico.Name = "cobMedico";
            this.cobMedico.Size = new System.Drawing.Size(215, 23);
            this.cobMedico.TabIndex = 2;
            // 
            // cobEspecialidad
            // 
            this.cobEspecialidad.FormattingEnabled = true;
            this.cobEspecialidad.Items.AddRange(new object[] {
            "Medicina General",
            "Nutricion"});
            this.cobEspecialidad.Location = new System.Drawing.Point(104, 136);
            this.cobEspecialidad.Name = "cobEspecialidad";
            this.cobEspecialidad.Size = new System.Drawing.Size(215, 23);
            this.cobEspecialidad.TabIndex = 2;
            // 
            // txtNumeroHistoria
            // 
            this.txtNumeroHistoria.Location = new System.Drawing.Point(104, 107);
            this.txtNumeroHistoria.Name = "txtNumeroHistoria";
            this.txtNumeroHistoria.Size = new System.Drawing.Size(215, 23);
            this.txtNumeroHistoria.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(104, 81);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(215, 23);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(215, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(104, 25);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(215, 23);
            this.txtDNI.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Médico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Especialidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Num. Historia ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "DNI:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtBuscar);
            this.tabPage2.Controls.Add(this.btnBusquedaH);
            this.tabPage2.Controls.Add(this.btnBusqueda);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(553, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Busqueda";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(34, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(99, 47);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(215, 23);
            this.txtBuscar.TabIndex = 13;
            // 
            // btnBusquedaH
            // 
            this.btnBusquedaH.Location = new System.Drawing.Point(359, 76);
            this.btnBusquedaH.Name = "btnBusquedaH";
            this.btnBusquedaH.Size = new System.Drawing.Size(170, 29);
            this.btnBusquedaH.TabIndex = 12;
            this.btnBusquedaH.Text = "Buscar-NumH";
            this.btnBusquedaH.UseVisualStyleBackColor = true;
            this.btnBusquedaH.Click += new System.EventHandler(this.btnBusquedaH_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(359, 38);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(170, 32);
            this.btnBusqueda.TabIndex = 11;
            this.btnBusqueda.Text = "Buscar-DNI";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtbNutricion);
            this.tabPage3.Controls.Add(this.rtbMedicina);
            this.tabPage3.Controls.Add(this.btnNutricion);
            this.tabPage3.Controls.Add(this.btnMedicinaGeneral);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(553, 442);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Clasificacion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtbNutricion
            // 
            this.rtbNutricion.Location = new System.Drawing.Point(5, 216);
            this.rtbNutricion.Name = "rtbNutricion";
            this.rtbNutricion.Size = new System.Drawing.Size(536, 132);
            this.rtbNutricion.TabIndex = 1;
            this.rtbNutricion.Text = "";
            // 
            // rtbMedicina
            // 
            this.rtbMedicina.Location = new System.Drawing.Point(6, 41);
            this.rtbMedicina.Name = "rtbMedicina";
            this.rtbMedicina.Size = new System.Drawing.Size(536, 125);
            this.rtbMedicina.TabIndex = 1;
            this.rtbMedicina.Text = "";
            // 
            // btnNutricion
            // 
            this.btnNutricion.Location = new System.Drawing.Point(6, 186);
            this.btnNutricion.Name = "btnNutricion";
            this.btnNutricion.Size = new System.Drawing.Size(536, 24);
            this.btnNutricion.TabIndex = 0;
            this.btnNutricion.Text = "Nutricion";
            this.btnNutricion.UseVisualStyleBackColor = true;
            this.btnNutricion.Click += new System.EventHandler(this.btnNutricion_Click);
            // 
            // btnMedicinaGeneral
            // 
            this.btnMedicinaGeneral.Location = new System.Drawing.Point(5, 10);
            this.btnMedicinaGeneral.Name = "btnMedicinaGeneral";
            this.btnMedicinaGeneral.Size = new System.Drawing.Size(536, 24);
            this.btnMedicinaGeneral.TabIndex = 0;
            this.btnMedicinaGeneral.Text = "Medicina General";
            this.btnMedicinaGeneral.UseVisualStyleBackColor = true;
            this.btnMedicinaGeneral.Click += new System.EventHandler(this.btnMedicinaGeneral_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rtbOrdenAlfabetico);
            this.tabPage4.Controls.Add(this.btnOrdenAlfabetico);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(553, 442);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Orden";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rtbOrdenAlfabetico
            // 
            this.rtbOrdenAlfabetico.Location = new System.Drawing.Point(11, 55);
            this.rtbOrdenAlfabetico.Name = "rtbOrdenAlfabetico";
            this.rtbOrdenAlfabetico.Size = new System.Drawing.Size(527, 232);
            this.rtbOrdenAlfabetico.TabIndex = 1;
            this.rtbOrdenAlfabetico.Text = "";
            // 
            // btnOrdenAlfabetico
            // 
            this.btnOrdenAlfabetico.Location = new System.Drawing.Point(8, 16);
            this.btnOrdenAlfabetico.Name = "btnOrdenAlfabetico";
            this.btnOrdenAlfabetico.Size = new System.Drawing.Size(532, 25);
            this.btnOrdenAlfabetico.TabIndex = 0;
            this.btnOrdenAlfabetico.Text = "Orden Ascendente";
            this.btnOrdenAlfabetico.UseVisualStyleBackColor = true;
            this.btnOrdenAlfabetico.Click += new System.EventHandler(this.btnOrdenAlfabetico_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(553, 442);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Conteo";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnConteoIngresoNutricion);
            this.groupBox3.Controls.Add(this.btnConteoIngresoMedicinaGeneral);
            this.groupBox3.Controls.Add(this.btnConteoIngresoGeneral);
            this.groupBox3.Location = new System.Drawing.Point(14, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 152);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conteo de ingreso de Dinero";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnConteoIngresoNutricion
            // 
            this.btnConteoIngresoNutricion.Location = new System.Drawing.Point(10, 95);
            this.btnConteoIngresoNutricion.Name = "btnConteoIngresoNutricion";
            this.btnConteoIngresoNutricion.Size = new System.Drawing.Size(495, 28);
            this.btnConteoIngresoNutricion.TabIndex = 0;
            this.btnConteoIngresoNutricion.Text = "Conteo Ingreso Nutricion";
            this.btnConteoIngresoNutricion.UseVisualStyleBackColor = true;
            this.btnConteoIngresoNutricion.Click += new System.EventHandler(this.btnConteoIngresoNutricion_Click);
            // 
            // btnConteoIngresoMedicinaGeneral
            // 
            this.btnConteoIngresoMedicinaGeneral.Location = new System.Drawing.Point(10, 61);
            this.btnConteoIngresoMedicinaGeneral.Name = "btnConteoIngresoMedicinaGeneral";
            this.btnConteoIngresoMedicinaGeneral.Size = new System.Drawing.Size(495, 28);
            this.btnConteoIngresoMedicinaGeneral.TabIndex = 0;
            this.btnConteoIngresoMedicinaGeneral.Text = "Conteo Ingreso Medicina General";
            this.btnConteoIngresoMedicinaGeneral.UseVisualStyleBackColor = true;
            this.btnConteoIngresoMedicinaGeneral.Click += new System.EventHandler(this.btnConteoIngresoMedicinaGeneral_Click);
            // 
            // btnConteoIngresoGeneral
            // 
            this.btnConteoIngresoGeneral.Location = new System.Drawing.Point(11, 27);
            this.btnConteoIngresoGeneral.Name = "btnConteoIngresoGeneral";
            this.btnConteoIngresoGeneral.Size = new System.Drawing.Size(495, 28);
            this.btnConteoIngresoGeneral.TabIndex = 0;
            this.btnConteoIngresoGeneral.Text = "Conteo Ingreso General";
            this.btnConteoIngresoGeneral.UseVisualStyleBackColor = true;
            this.btnConteoIngresoGeneral.Click += new System.EventHandler(this.btnConteoIngresoGeneral_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConteoNutricion);
            this.groupBox2.Controls.Add(this.btnConteoMedicinaGeneral);
            this.groupBox2.Controls.Add(this.btnConteoGeneral);
            this.groupBox2.Location = new System.Drawing.Point(12, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 129);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conteo de Pacientes";
            // 
            // btnConteoNutricion
            // 
            this.btnConteoNutricion.Location = new System.Drawing.Point(15, 88);
            this.btnConteoNutricion.Name = "btnConteoNutricion";
            this.btnConteoNutricion.Size = new System.Drawing.Size(492, 26);
            this.btnConteoNutricion.TabIndex = 0;
            this.btnConteoNutricion.Text = "Conteo de Nutricion";
            this.btnConteoNutricion.UseVisualStyleBackColor = true;
            this.btnConteoNutricion.Click += new System.EventHandler(this.btnConteoNutricion_Click);
            // 
            // btnConteoMedicinaGeneral
            // 
            this.btnConteoMedicinaGeneral.Location = new System.Drawing.Point(15, 56);
            this.btnConteoMedicinaGeneral.Name = "btnConteoMedicinaGeneral";
            this.btnConteoMedicinaGeneral.Size = new System.Drawing.Size(492, 26);
            this.btnConteoMedicinaGeneral.TabIndex = 0;
            this.btnConteoMedicinaGeneral.Text = "Conteo de Medicina General";
            this.btnConteoMedicinaGeneral.UseVisualStyleBackColor = true;
            this.btnConteoMedicinaGeneral.Click += new System.EventHandler(this.btnConteoMedicinaGeneral_Click);
            // 
            // btnConteoGeneral
            // 
            this.btnConteoGeneral.Location = new System.Drawing.Point(15, 24);
            this.btnConteoGeneral.Name = "btnConteoGeneral";
            this.btnConteoGeneral.Size = new System.Drawing.Size(492, 26);
            this.btnConteoGeneral.TabIndex = 0;
            this.btnConteoGeneral.Text = "Conteo General";
            this.btnConteoGeneral.UseVisualStyleBackColor = true;
            this.btnConteoGeneral.Click += new System.EventHandler(this.btnConteoGeneral_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 518);
            this.Controls.Add(this.tabControlPrincipal);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HealthLife";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControlPrincipal;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RichTextBox rtbHealthLife;
        private Button btnRegistro;
        private GroupBox groupBox1;
        private Label label9;
        private DateTimePicker dtpFecha;
        private ComboBox cobMedico;
        private ComboBox cobEspecialidad;
        private TextBox txtNumeroHistoria;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnBusquedaH;
        private Button btnBusqueda;
        private TextBox txtBuscar;
        private Button button1;
        private Label label10;
        private TabPage tabPage3;
        private RichTextBox rtbNutricion;
        private RichTextBox rtbMedicina;
        private Button btnNutricion;
        private Button btnMedicinaGeneral;
        private TabPage tabPage4;
        private RichTextBox rtbOrdenAlfabetico;
        private Button btnOrdenAlfabetico;
        private TabPage tabPage5;
        private GroupBox groupBox2;
        private Button btnConteoNutricion;
        private Button btnConteoMedicinaGeneral;
        private Button btnConteoGeneral;
        private GroupBox groupBox3;
        private ComboBox txtprecio;
        private Button btnConteoIngresoNutricion;
        private Button btnConteoIngresoMedicinaGeneral;
        private Button btnConteoIngresoGeneral;
    }
}