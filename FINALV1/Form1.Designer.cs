namespace FINALV1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabALTA = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxSpaceXAlta = new System.Windows.Forms.GroupBox();
            this.buttonGuardarSpaceX = new System.Windows.Forms.Button();
            this.comboBoxModelosSpaceX = new System.Windows.Forms.ComboBox();
            this.textBoxEmpresaSpaceX = new System.Windows.Forms.TextBox();
            this.textBoxColorSpaceX = new System.Windows.Forms.TextBox();
            this.textBoxHsVueloSpaceX = new System.Windows.Forms.TextBox();
            this.textBoxAñoSpaceX = new System.Windows.Forms.TextBox();
            this.groupBoxTeslaAlta = new System.Windows.Forms.GroupBox();
            this.buttonGuardarTeslas = new System.Windows.Forms.Button();
            this.comboBoxModelosTesla = new System.Windows.Forms.ComboBox();
            this.textBoxDueñoTesla = new System.Windows.Forms.TextBox();
            this.textBoxColorTesla = new System.Windows.Forms.TextBox();
            this.textBoxKMtesla = new System.Windows.Forms.TextBox();
            this.textBoxAñoTesla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabELIMINAR = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewEliminar = new System.Windows.Forms.DataGridView();
            this.ColumnEliminarVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEliminarModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEliminarAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEliminarPropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMOSTRAR = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonActualizarMostrar = new System.Windows.Forms.Button();
            this.dataGridViewMostrarKm = new System.Windows.Forms.DataGridView();
            this.ColumnVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonMostrarKm = new System.Windows.Forms.Button();
            this.tabESCANEO = new System.Windows.Forms.TabPage();
            this.groupBoxEscaneo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonActualizarEscaneo = new System.Windows.Forms.Button();
            this.buttonEscanear = new System.Windows.Forms.Button();
            this.dataGridViewEscaneo = new System.Windows.Forms.DataGridView();
            this.tabBATERIA = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonActualizarBateria = new System.Windows.Forms.Button();
            this.dataGridViewCarga = new System.Windows.Forms.DataGridView();
            this.ColumnVehiculoBateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModeloBateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDueñoBateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHsVueloKmActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCargaBateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVehiculoEscaneo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModeloEscaneo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAñoEscaneo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPropietarioEscaneo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHsVueloKmescaneo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxMostrar = new System.Windows.Forms.GroupBox();
            this.groupBoxBateria = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabALTA.SuspendLayout();
            this.groupBoxSpaceXAlta.SuspendLayout();
            this.groupBoxTeslaAlta.SuspendLayout();
            this.tabELIMINAR.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEliminar)).BeginInit();
            this.tabMOSTRAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarKm)).BeginInit();
            this.tabESCANEO.SuspendLayout();
            this.groupBoxEscaneo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEscaneo)).BeginInit();
            this.tabBATERIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarga)).BeginInit();
            this.groupBoxMostrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabALTA);
            this.tabControl1.Controls.Add(this.tabELIMINAR);
            this.tabControl1.Controls.Add(this.tabMOSTRAR);
            this.tabControl1.Controls.Add(this.tabESCANEO);
            this.tabControl1.Controls.Add(this.tabBATERIA);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1111, 570);
            this.tabControl1.TabIndex = 0;
            // 
            // tabALTA
            // 
            this.tabALTA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabALTA.Controls.Add(this.label7);
            this.tabALTA.Controls.Add(this.label6);
            this.tabALTA.Controls.Add(this.label5);
            this.tabALTA.Controls.Add(this.groupBoxSpaceXAlta);
            this.tabALTA.Controls.Add(this.groupBoxTeslaAlta);
            this.tabALTA.Controls.Add(this.label2);
            this.tabALTA.Controls.Add(this.label1);
            this.tabALTA.Location = new System.Drawing.Point(4, 32);
            this.tabALTA.Name = "tabALTA";
            this.tabALTA.Padding = new System.Windows.Forms.Padding(3);
            this.tabALTA.Size = new System.Drawing.Size(1103, 534);
            this.tabALTA.TabIndex = 0;
            this.tabALTA.Text = "ALTA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(356, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(362, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ingrese un vehículo Tesla o SpaceX:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(728, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "*Colores disponibles: verde, azul, rojo, negro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(728, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "*Colores disponibles: verde, azul, rojo, negro";
            // 
            // groupBoxSpaceXAlta
            // 
            this.groupBoxSpaceXAlta.Controls.Add(this.buttonGuardarSpaceX);
            this.groupBoxSpaceXAlta.Controls.Add(this.comboBoxModelosSpaceX);
            this.groupBoxSpaceXAlta.Controls.Add(this.textBoxEmpresaSpaceX);
            this.groupBoxSpaceXAlta.Controls.Add(this.textBoxColorSpaceX);
            this.groupBoxSpaceXAlta.Controls.Add(this.textBoxHsVueloSpaceX);
            this.groupBoxSpaceXAlta.Controls.Add(this.textBoxAñoSpaceX);
            this.groupBoxSpaceXAlta.Location = new System.Drawing.Point(177, 333);
            this.groupBoxSpaceXAlta.Name = "groupBoxSpaceXAlta";
            this.groupBoxSpaceXAlta.Size = new System.Drawing.Size(847, 110);
            this.groupBoxSpaceXAlta.TabIndex = 6;
            this.groupBoxSpaceXAlta.TabStop = false;
            // 
            // buttonGuardarSpaceX
            // 
            this.buttonGuardarSpaceX.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonGuardarSpaceX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonGuardarSpaceX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonGuardarSpaceX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardarSpaceX.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarSpaceX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGuardarSpaceX.Location = new System.Drawing.Point(706, 60);
            this.buttonGuardarSpaceX.Name = "buttonGuardarSpaceX";
            this.buttonGuardarSpaceX.Size = new System.Drawing.Size(124, 35);
            this.buttonGuardarSpaceX.TabIndex = 5;
            this.buttonGuardarSpaceX.Text = "GUARDAR";
            this.buttonGuardarSpaceX.UseVisualStyleBackColor = false;
            this.buttonGuardarSpaceX.Click += new System.EventHandler(this.buttonGuardarSpaceX_Click);
            // 
            // comboBoxModelosSpaceX
            // 
            this.comboBoxModelosSpaceX.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModelosSpaceX.ForeColor = System.Drawing.Color.Black;
            this.comboBoxModelosSpaceX.FormattingEnabled = true;
            this.comboBoxModelosSpaceX.Items.AddRange(new object[] {
            "STARSHIP",
            "FALCON 9"});
            this.comboBoxModelosSpaceX.Location = new System.Drawing.Point(30, 30);
            this.comboBoxModelosSpaceX.Name = "comboBoxModelosSpaceX";
            this.comboBoxModelosSpaceX.Size = new System.Drawing.Size(121, 31);
            this.comboBoxModelosSpaceX.TabIndex = 4;
            this.comboBoxModelosSpaceX.Text = "Modelo";
            // 
            // textBoxEmpresaSpaceX
            // 
            this.textBoxEmpresaSpaceX.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmpresaSpaceX.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmpresaSpaceX.Location = new System.Drawing.Point(564, 30);
            this.textBoxEmpresaSpaceX.Name = "textBoxEmpresaSpaceX";
            this.textBoxEmpresaSpaceX.Size = new System.Drawing.Size(100, 31);
            this.textBoxEmpresaSpaceX.TabIndex = 3;
            this.textBoxEmpresaSpaceX.Text = "Empresa";
            this.textBoxEmpresaSpaceX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEmpresaSpaceX.Enter += new System.EventHandler(this.textBoxEmpresaSpaceX_Enter);
            this.textBoxEmpresaSpaceX.Leave += new System.EventHandler(this.textBoxEmpresaSpaceX_Leave);
            // 
            // textBoxColorSpaceX
            // 
            this.textBoxColorSpaceX.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxColorSpaceX.ForeColor = System.Drawing.Color.Gray;
            this.textBoxColorSpaceX.Location = new System.Drawing.Point(441, 30);
            this.textBoxColorSpaceX.Name = "textBoxColorSpaceX";
            this.textBoxColorSpaceX.Size = new System.Drawing.Size(100, 31);
            this.textBoxColorSpaceX.TabIndex = 2;
            this.textBoxColorSpaceX.Text = "Color";
            this.textBoxColorSpaceX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxColorSpaceX.Enter += new System.EventHandler(this.textBoxColorSpaceX_Enter);
            this.textBoxColorSpaceX.Leave += new System.EventHandler(this.textBoxColorSpaceX_Leave);
            // 
            // textBoxHsVueloSpaceX
            // 
            this.textBoxHsVueloSpaceX.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHsVueloSpaceX.ForeColor = System.Drawing.Color.Gray;
            this.textBoxHsVueloSpaceX.Location = new System.Drawing.Point(312, 30);
            this.textBoxHsVueloSpaceX.Name = "textBoxHsVueloSpaceX";
            this.textBoxHsVueloSpaceX.Size = new System.Drawing.Size(100, 31);
            this.textBoxHsVueloSpaceX.TabIndex = 1;
            this.textBoxHsVueloSpaceX.Text = "Hs Vuelo";
            this.textBoxHsVueloSpaceX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHsVueloSpaceX.Enter += new System.EventHandler(this.textBoxHsVueloSpaceX_Enter);
            this.textBoxHsVueloSpaceX.Leave += new System.EventHandler(this.textBoxHsVueloSpaceX_Leave);
            // 
            // textBoxAñoSpaceX
            // 
            this.textBoxAñoSpaceX.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAñoSpaceX.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAñoSpaceX.Location = new System.Drawing.Point(184, 30);
            this.textBoxAñoSpaceX.Name = "textBoxAñoSpaceX";
            this.textBoxAñoSpaceX.Size = new System.Drawing.Size(100, 31);
            this.textBoxAñoSpaceX.TabIndex = 0;
            this.textBoxAñoSpaceX.Text = "Año";
            this.textBoxAñoSpaceX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAñoSpaceX.Enter += new System.EventHandler(this.textBoxAñoSpaceX_Enter);
            this.textBoxAñoSpaceX.Leave += new System.EventHandler(this.textBoxAñoSpaceX_Leave);
            // 
            // groupBoxTeslaAlta
            // 
            this.groupBoxTeslaAlta.Controls.Add(this.buttonGuardarTeslas);
            this.groupBoxTeslaAlta.Controls.Add(this.comboBoxModelosTesla);
            this.groupBoxTeslaAlta.Controls.Add(this.textBoxDueñoTesla);
            this.groupBoxTeslaAlta.Controls.Add(this.textBoxColorTesla);
            this.groupBoxTeslaAlta.Controls.Add(this.textBoxKMtesla);
            this.groupBoxTeslaAlta.Controls.Add(this.textBoxAñoTesla);
            this.groupBoxTeslaAlta.Location = new System.Drawing.Point(174, 100);
            this.groupBoxTeslaAlta.Name = "groupBoxTeslaAlta";
            this.groupBoxTeslaAlta.Size = new System.Drawing.Size(850, 100);
            this.groupBoxTeslaAlta.TabIndex = 2;
            this.groupBoxTeslaAlta.TabStop = false;
            // 
            // buttonGuardarTeslas
            // 
            this.buttonGuardarTeslas.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonGuardarTeslas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonGuardarTeslas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonGuardarTeslas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardarTeslas.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarTeslas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGuardarTeslas.Location = new System.Drawing.Point(709, 49);
            this.buttonGuardarTeslas.Name = "buttonGuardarTeslas";
            this.buttonGuardarTeslas.Size = new System.Drawing.Size(124, 35);
            this.buttonGuardarTeslas.TabIndex = 5;
            this.buttonGuardarTeslas.Text = "GUARDAR";
            this.buttonGuardarTeslas.UseVisualStyleBackColor = false;
            this.buttonGuardarTeslas.Click += new System.EventHandler(this.buttonGuardarTeslas_Click);
            // 
            // comboBoxModelosTesla
            // 
            this.comboBoxModelosTesla.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxModelosTesla.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModelosTesla.ForeColor = System.Drawing.Color.Black;
            this.comboBoxModelosTesla.FormattingEnabled = true;
            this.comboBoxModelosTesla.Items.AddRange(new object[] {
            "X",
            "S",
            "CYBERTRUCK"});
            this.comboBoxModelosTesla.Location = new System.Drawing.Point(33, 30);
            this.comboBoxModelosTesla.Name = "comboBoxModelosTesla";
            this.comboBoxModelosTesla.Size = new System.Drawing.Size(121, 31);
            this.comboBoxModelosTesla.TabIndex = 4;
            this.comboBoxModelosTesla.Text = "Modelo";
            // 
            // textBoxDueñoTesla
            // 
            this.textBoxDueñoTesla.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDueñoTesla.ForeColor = System.Drawing.Color.Gray;
            this.textBoxDueñoTesla.Location = new System.Drawing.Point(567, 30);
            this.textBoxDueñoTesla.Name = "textBoxDueñoTesla";
            this.textBoxDueñoTesla.Size = new System.Drawing.Size(100, 31);
            this.textBoxDueñoTesla.TabIndex = 3;
            this.textBoxDueñoTesla.Text = "Dueño";
            this.textBoxDueñoTesla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDueñoTesla.Enter += new System.EventHandler(this.textBoxDueñoTesla_Enter);
            this.textBoxDueñoTesla.Leave += new System.EventHandler(this.textBoxDueñoTesla_Leave);
            // 
            // textBoxColorTesla
            // 
            this.textBoxColorTesla.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxColorTesla.ForeColor = System.Drawing.Color.Gray;
            this.textBoxColorTesla.Location = new System.Drawing.Point(444, 30);
            this.textBoxColorTesla.Name = "textBoxColorTesla";
            this.textBoxColorTesla.Size = new System.Drawing.Size(100, 31);
            this.textBoxColorTesla.TabIndex = 2;
            this.textBoxColorTesla.Text = "Color";
            this.textBoxColorTesla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxColorTesla.Enter += new System.EventHandler(this.textBoxColorTesla_Enter);
            this.textBoxColorTesla.Leave += new System.EventHandler(this.textBoxColorTesla_Leave);
            // 
            // textBoxKMtesla
            // 
            this.textBoxKMtesla.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKMtesla.ForeColor = System.Drawing.Color.Gray;
            this.textBoxKMtesla.Location = new System.Drawing.Point(315, 30);
            this.textBoxKMtesla.Name = "textBoxKMtesla";
            this.textBoxKMtesla.Size = new System.Drawing.Size(100, 31);
            this.textBoxKMtesla.TabIndex = 1;
            this.textBoxKMtesla.Text = "Km Actual";
            this.textBoxKMtesla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxKMtesla.Enter += new System.EventHandler(this.textBoxKMtesla_Enter);
            this.textBoxKMtesla.Leave += new System.EventHandler(this.textBoxKMtesla_Leave);
            // 
            // textBoxAñoTesla
            // 
            this.textBoxAñoTesla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAñoTesla.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAñoTesla.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAñoTesla.Location = new System.Drawing.Point(187, 30);
            this.textBoxAñoTesla.Name = "textBoxAñoTesla";
            this.textBoxAñoTesla.Size = new System.Drawing.Size(100, 31);
            this.textBoxAñoTesla.TabIndex = 0;
            this.textBoxAñoTesla.Text = "Año";
            this.textBoxAñoTesla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAñoTesla.Enter += new System.EventHandler(this.textBoxAñoTesla_Enter);
            this.textBoxAñoTesla.Leave += new System.EventHandler(this.textBoxAñoTesla_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(42, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "SPACEX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(42, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "TESLA";
            // 
            // tabELIMINAR
            // 
            this.tabELIMINAR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabELIMINAR.Controls.Add(this.groupBox3);
            this.tabELIMINAR.Location = new System.Drawing.Point(4, 32);
            this.tabELIMINAR.Name = "tabELIMINAR";
            this.tabELIMINAR.Padding = new System.Windows.Forms.Padding(3);
            this.tabELIMINAR.Size = new System.Drawing.Size(1103, 534);
            this.tabELIMINAR.TabIndex = 1;
            this.tabELIMINAR.Text = "ELIMINAR";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonEliminar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dataGridViewEliminar);
            this.groupBox3.Location = new System.Drawing.Point(155, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 488);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEliminar.Location = new System.Drawing.Point(580, 418);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(121, 48);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(255, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seleccione el vehículo:";
            // 
            // dataGridViewEliminar
            // 
            this.dataGridViewEliminar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEliminar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEliminarVehiculo,
            this.ColumnEliminarModelo,
            this.ColumnEliminarAño,
            this.ColumnEliminarPropietario});
            this.dataGridViewEliminar.GridColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewEliminar.Location = new System.Drawing.Point(58, 63);
            this.dataGridViewEliminar.Name = "dataGridViewEliminar";
            this.dataGridViewEliminar.ReadOnly = true;
            this.dataGridViewEliminar.RowTemplate.Height = 28;
            this.dataGridViewEliminar.Size = new System.Drawing.Size(643, 320);
            this.dataGridViewEliminar.TabIndex = 0;
            // 
            // ColumnEliminarVehiculo
            // 
            this.ColumnEliminarVehiculo.HeaderText = "VEHÍCULO";
            this.ColumnEliminarVehiculo.Name = "ColumnEliminarVehiculo";
            this.ColumnEliminarVehiculo.ReadOnly = true;
            this.ColumnEliminarVehiculo.Width = 150;
            // 
            // ColumnEliminarModelo
            // 
            this.ColumnEliminarModelo.HeaderText = "MODELO";
            this.ColumnEliminarModelo.Name = "ColumnEliminarModelo";
            this.ColumnEliminarModelo.ReadOnly = true;
            this.ColumnEliminarModelo.Width = 150;
            // 
            // ColumnEliminarAño
            // 
            this.ColumnEliminarAño.HeaderText = "AÑO";
            this.ColumnEliminarAño.Name = "ColumnEliminarAño";
            this.ColumnEliminarAño.ReadOnly = true;
            this.ColumnEliminarAño.Width = 150;
            // 
            // ColumnEliminarPropietario
            // 
            this.ColumnEliminarPropietario.HeaderText = "PROPIETARIO";
            this.ColumnEliminarPropietario.Name = "ColumnEliminarPropietario";
            this.ColumnEliminarPropietario.ReadOnly = true;
            this.ColumnEliminarPropietario.Width = 150;
            // 
            // tabMOSTRAR
            // 
            this.tabMOSTRAR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabMOSTRAR.Controls.Add(this.buttonActualizarMostrar);
            this.tabMOSTRAR.Controls.Add(this.buttonMostrarKm);
            this.tabMOSTRAR.Controls.Add(this.groupBoxMostrar);
            this.tabMOSTRAR.Location = new System.Drawing.Point(4, 32);
            this.tabMOSTRAR.Name = "tabMOSTRAR";
            this.tabMOSTRAR.Size = new System.Drawing.Size(1103, 534);
            this.tabMOSTRAR.TabIndex = 2;
            this.tabMOSTRAR.Text = "MOSTRAR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(189, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(393, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "Vehículo Tesla con mayor Kilometraje:";
            // 
            // buttonActualizarMostrar
            // 
            this.buttonActualizarMostrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonActualizarMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonActualizarMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonActualizarMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizarMostrar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizarMostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonActualizarMostrar.Location = new System.Drawing.Point(249, 333);
            this.buttonActualizarMostrar.Name = "buttonActualizarMostrar";
            this.buttonActualizarMostrar.Size = new System.Drawing.Size(132, 34);
            this.buttonActualizarMostrar.TabIndex = 2;
            this.buttonActualizarMostrar.Text = "ACTUALIZAR";
            this.buttonActualizarMostrar.UseVisualStyleBackColor = false;
            this.buttonActualizarMostrar.Click += new System.EventHandler(this.buttonActualizarMostrar_Click);
            // 
            // dataGridViewMostrarKm
            // 
            this.dataGridViewMostrarKm.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewMostrarKm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostrarKm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnVehiculo,
            this.ColumnKM,
            this.ColumnModelo,
            this.ColumnDueño});
            this.dataGridViewMostrarKm.Location = new System.Drawing.Point(99, 66);
            this.dataGridViewMostrarKm.Name = "dataGridViewMostrarKm";
            this.dataGridViewMostrarKm.ReadOnly = true;
            this.dataGridViewMostrarKm.RowTemplate.Height = 28;
            this.dataGridViewMostrarKm.Size = new System.Drawing.Size(595, 178);
            this.dataGridViewMostrarKm.TabIndex = 1;
            // 
            // ColumnVehiculo
            // 
            this.ColumnVehiculo.HeaderText = "VEHÍCULO";
            this.ColumnVehiculo.Name = "ColumnVehiculo";
            this.ColumnVehiculo.ReadOnly = true;
            this.ColumnVehiculo.Width = 150;
            // 
            // ColumnKM
            // 
            this.ColumnKM.HeaderText = "KM";
            this.ColumnKM.Name = "ColumnKM";
            this.ColumnKM.ReadOnly = true;
            // 
            // ColumnModelo
            // 
            this.ColumnModelo.HeaderText = "MODELO";
            this.ColumnModelo.Name = "ColumnModelo";
            this.ColumnModelo.ReadOnly = true;
            this.ColumnModelo.Width = 150;
            // 
            // ColumnDueño
            // 
            this.ColumnDueño.HeaderText = "DUEÑO";
            this.ColumnDueño.Name = "ColumnDueño";
            this.ColumnDueño.ReadOnly = true;
            this.ColumnDueño.Width = 150;
            // 
            // buttonMostrarKm
            // 
            this.buttonMostrarKm.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonMostrarKm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonMostrarKm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonMostrarKm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrarKm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrarKm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMostrarKm.Location = new System.Drawing.Point(712, 333);
            this.buttonMostrarKm.Name = "buttonMostrarKm";
            this.buttonMostrarKm.Size = new System.Drawing.Size(132, 34);
            this.buttonMostrarKm.TabIndex = 0;
            this.buttonMostrarKm.Text = "MOSTRAR";
            this.buttonMostrarKm.UseVisualStyleBackColor = false;
            this.buttonMostrarKm.Click += new System.EventHandler(this.buttonMostrarKm_Click);
            // 
            // tabESCANEO
            // 
            this.tabESCANEO.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabESCANEO.Controls.Add(this.groupBoxEscaneo);
            this.tabESCANEO.Location = new System.Drawing.Point(4, 32);
            this.tabESCANEO.Name = "tabESCANEO";
            this.tabESCANEO.Size = new System.Drawing.Size(1103, 534);
            this.tabESCANEO.TabIndex = 3;
            this.tabESCANEO.Text = "ESCANEO";
            // 
            // groupBoxEscaneo
            // 
            this.groupBoxEscaneo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxEscaneo.Controls.Add(this.label4);
            this.groupBoxEscaneo.Controls.Add(this.buttonActualizarEscaneo);
            this.groupBoxEscaneo.Controls.Add(this.buttonEscanear);
            this.groupBoxEscaneo.Controls.Add(this.dataGridViewEscaneo);
            this.groupBoxEscaneo.Location = new System.Drawing.Point(47, 47);
            this.groupBoxEscaneo.Name = "groupBoxEscaneo";
            this.groupBoxEscaneo.Size = new System.Drawing.Size(986, 420);
            this.groupBoxEscaneo.TabIndex = 5;
            this.groupBoxEscaneo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(385, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Elija un vehículo:";
            // 
            // buttonActualizarEscaneo
            // 
            this.buttonActualizarEscaneo.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonActualizarEscaneo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonActualizarEscaneo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonActualizarEscaneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizarEscaneo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizarEscaneo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonActualizarEscaneo.Location = new System.Drawing.Point(166, 355);
            this.buttonActualizarEscaneo.Name = "buttonActualizarEscaneo";
            this.buttonActualizarEscaneo.Size = new System.Drawing.Size(136, 37);
            this.buttonActualizarEscaneo.TabIndex = 7;
            this.buttonActualizarEscaneo.Text = "ACTUALIZAR";
            this.buttonActualizarEscaneo.UseVisualStyleBackColor = false;
            this.buttonActualizarEscaneo.Click += new System.EventHandler(this.buttonActualizarEscaneo_Click);
            // 
            // buttonEscanear
            // 
            this.buttonEscanear.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEscanear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonEscanear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonEscanear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEscanear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEscanear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEscanear.Location = new System.Drawing.Point(673, 355);
            this.buttonEscanear.Name = "buttonEscanear";
            this.buttonEscanear.Size = new System.Drawing.Size(136, 38);
            this.buttonEscanear.TabIndex = 2;
            this.buttonEscanear.Text = "ESCANEAR";
            this.buttonEscanear.UseVisualStyleBackColor = false;
            this.buttonEscanear.Click += new System.EventHandler(this.buttonEscanear_Click);
            // 
            // dataGridViewEscaneo
            // 
            this.dataGridViewEscaneo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewEscaneo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEscaneo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnVehiculoEscaneo,
            this.ColumnModeloEscaneo,
            this.ColumnAñoEscaneo,
            this.ColumnPropietarioEscaneo,
            this.columnHsVueloKmescaneo});
            this.dataGridViewEscaneo.Location = new System.Drawing.Point(86, 57);
            this.dataGridViewEscaneo.Name = "dataGridViewEscaneo";
            this.dataGridViewEscaneo.ReadOnly = true;
            this.dataGridViewEscaneo.RowTemplate.Height = 28;
            this.dataGridViewEscaneo.Size = new System.Drawing.Size(793, 259);
            this.dataGridViewEscaneo.TabIndex = 6;
            // 
            // tabBATERIA
            // 
            this.tabBATERIA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabBATERIA.Controls.Add(this.label9);
            this.tabBATERIA.Controls.Add(this.buttonActualizarBateria);
            this.tabBATERIA.Controls.Add(this.dataGridViewCarga);
            this.tabBATERIA.Controls.Add(this.groupBoxBateria);
            this.tabBATERIA.Location = new System.Drawing.Point(4, 32);
            this.tabBATERIA.Name = "tabBATERIA";
            this.tabBATERIA.Size = new System.Drawing.Size(1103, 534);
            this.tabBATERIA.TabIndex = 4;
            this.tabBATERIA.Text = "BATERIA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(342, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(438, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "Porcentaje de Batería/Combustible actual:";
            // 
            // buttonActualizarBateria
            // 
            this.buttonActualizarBateria.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonActualizarBateria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonActualizarBateria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonActualizarBateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizarBateria.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizarBateria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonActualizarBateria.Location = new System.Drawing.Point(862, 459);
            this.buttonActualizarBateria.Name = "buttonActualizarBateria";
            this.buttonActualizarBateria.Size = new System.Drawing.Size(142, 37);
            this.buttonActualizarBateria.TabIndex = 1;
            this.buttonActualizarBateria.Text = "ACTUALIZAR";
            this.buttonActualizarBateria.UseVisualStyleBackColor = false;
            this.buttonActualizarBateria.Click += new System.EventHandler(this.buttonActualizarBateria_Click);
            // 
            // dataGridViewCarga
            // 
            this.dataGridViewCarga.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewCarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnVehiculoBateria,
            this.ColumnModeloBateria,
            this.ColumnDueñoBateria,
            this.ColumnHsVueloKmActual,
            this.ColumnCargaBateria});
            this.dataGridViewCarga.Location = new System.Drawing.Point(110, 78);
            this.dataGridViewCarga.Name = "dataGridViewCarga";
            this.dataGridViewCarga.ReadOnly = true;
            this.dataGridViewCarga.RowTemplate.Height = 28;
            this.dataGridViewCarga.Size = new System.Drawing.Size(894, 341);
            this.dataGridViewCarga.TabIndex = 0;
            // 
            // ColumnVehiculoBateria
            // 
            this.ColumnVehiculoBateria.HeaderText = "VEHÍCULO";
            this.ColumnVehiculoBateria.Name = "ColumnVehiculoBateria";
            this.ColumnVehiculoBateria.ReadOnly = true;
            this.ColumnVehiculoBateria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnVehiculoBateria.Width = 150;
            // 
            // ColumnModeloBateria
            // 
            this.ColumnModeloBateria.HeaderText = "MODELO";
            this.ColumnModeloBateria.Name = "ColumnModeloBateria";
            this.ColumnModeloBateria.ReadOnly = true;
            this.ColumnModeloBateria.Width = 150;
            // 
            // ColumnDueñoBateria
            // 
            this.ColumnDueñoBateria.HeaderText = "DUEÑO";
            this.ColumnDueñoBateria.Name = "ColumnDueñoBateria";
            this.ColumnDueñoBateria.ReadOnly = true;
            this.ColumnDueñoBateria.Width = 150;
            // 
            // ColumnHsVueloKmActual
            // 
            this.ColumnHsVueloKmActual.HeaderText = "KM/HsVuelo ACTUAL";
            this.ColumnHsVueloKmActual.Name = "ColumnHsVueloKmActual";
            this.ColumnHsVueloKmActual.ReadOnly = true;
            this.ColumnHsVueloKmActual.Width = 150;
            // 
            // ColumnCargaBateria
            // 
            this.ColumnCargaBateria.HeaderText = "COMBUSTIBLE/BATERÍA";
            this.ColumnCargaBateria.Name = "ColumnCargaBateria";
            this.ColumnCargaBateria.ReadOnly = true;
            this.ColumnCargaBateria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnCargaBateria.Width = 250;
            // 
            // ColumnVehiculoEscaneo
            // 
            this.ColumnVehiculoEscaneo.HeaderText = "VEHÍCULO";
            this.ColumnVehiculoEscaneo.Name = "ColumnVehiculoEscaneo";
            this.ColumnVehiculoEscaneo.ReadOnly = true;
            this.ColumnVehiculoEscaneo.Width = 150;
            // 
            // ColumnModeloEscaneo
            // 
            this.ColumnModeloEscaneo.HeaderText = "MODELO";
            this.ColumnModeloEscaneo.Name = "ColumnModeloEscaneo";
            this.ColumnModeloEscaneo.ReadOnly = true;
            this.ColumnModeloEscaneo.Width = 150;
            // 
            // ColumnAñoEscaneo
            // 
            this.ColumnAñoEscaneo.HeaderText = "AÑO";
            this.ColumnAñoEscaneo.Name = "ColumnAñoEscaneo";
            this.ColumnAñoEscaneo.ReadOnly = true;
            this.ColumnAñoEscaneo.Width = 150;
            // 
            // ColumnPropietarioEscaneo
            // 
            this.ColumnPropietarioEscaneo.HeaderText = "PROPIETARIO";
            this.ColumnPropietarioEscaneo.Name = "ColumnPropietarioEscaneo";
            this.ColumnPropietarioEscaneo.ReadOnly = true;
            this.ColumnPropietarioEscaneo.Width = 150;
            // 
            // columnHsVueloKmescaneo
            // 
            this.columnHsVueloKmescaneo.HeaderText = "KM/HSVUELO";
            this.columnHsVueloKmescaneo.Name = "columnHsVueloKmescaneo";
            this.columnHsVueloKmescaneo.ReadOnly = true;
            this.columnHsVueloKmescaneo.Width = 150;
            // 
            // groupBoxMostrar
            // 
            this.groupBoxMostrar.Controls.Add(this.label8);
            this.groupBoxMostrar.Controls.Add(this.dataGridViewMostrarKm);
            this.groupBoxMostrar.Location = new System.Drawing.Point(150, 58);
            this.groupBoxMostrar.Name = "groupBoxMostrar";
            this.groupBoxMostrar.Size = new System.Drawing.Size(830, 330);
            this.groupBoxMostrar.TabIndex = 4;
            this.groupBoxMostrar.TabStop = false;
            // 
            // groupBoxBateria
            // 
            this.groupBoxBateria.Location = new System.Drawing.Point(47, 23);
            this.groupBoxBateria.Name = "groupBoxBateria";
            this.groupBoxBateria.Size = new System.Drawing.Size(1010, 486);
            this.groupBoxBateria.TabIndex = 3;
            this.groupBoxBateria.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1136, 595);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SG MUSK";
            this.tabControl1.ResumeLayout(false);
            this.tabALTA.ResumeLayout(false);
            this.tabALTA.PerformLayout();
            this.groupBoxSpaceXAlta.ResumeLayout(false);
            this.groupBoxSpaceXAlta.PerformLayout();
            this.groupBoxTeslaAlta.ResumeLayout(false);
            this.groupBoxTeslaAlta.PerformLayout();
            this.tabELIMINAR.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEliminar)).EndInit();
            this.tabMOSTRAR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarKm)).EndInit();
            this.tabESCANEO.ResumeLayout(false);
            this.groupBoxEscaneo.ResumeLayout(false);
            this.groupBoxEscaneo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEscaneo)).EndInit();
            this.tabBATERIA.ResumeLayout(false);
            this.tabBATERIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarga)).EndInit();
            this.groupBoxMostrar.ResumeLayout(false);
            this.groupBoxMostrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabALTA;
        private System.Windows.Forms.TabPage tabELIMINAR;
        private System.Windows.Forms.TabPage tabMOSTRAR;
        private System.Windows.Forms.TabPage tabESCANEO;
        private System.Windows.Forms.TabPage tabBATERIA;
        private System.Windows.Forms.GroupBox groupBoxSpaceXAlta;
        private System.Windows.Forms.Button buttonGuardarSpaceX;
        private System.Windows.Forms.ComboBox comboBoxModelosSpaceX;
        private System.Windows.Forms.TextBox textBoxEmpresaSpaceX;
        private System.Windows.Forms.TextBox textBoxColorSpaceX;
        private System.Windows.Forms.TextBox textBoxHsVueloSpaceX;
        private System.Windows.Forms.TextBox textBoxAñoSpaceX;
        private System.Windows.Forms.GroupBox groupBoxTeslaAlta;
        private System.Windows.Forms.Button buttonGuardarTeslas;
        private System.Windows.Forms.ComboBox comboBoxModelosTesla;
        private System.Windows.Forms.TextBox textBoxDueñoTesla;
        private System.Windows.Forms.TextBox textBoxColorTesla;
        private System.Windows.Forms.TextBox textBoxKMtesla;
        private System.Windows.Forms.TextBox textBoxAñoTesla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewEliminar;
        private System.Windows.Forms.Button buttonMostrarKm;
        private System.Windows.Forms.Button buttonEscanear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewCarga;
        private System.Windows.Forms.GroupBox groupBoxEscaneo;
        private System.Windows.Forms.DataGridView dataGridViewMostrarKm;
        private System.Windows.Forms.DataGridView dataGridViewEscaneo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonActualizarBateria;
        private System.Windows.Forms.Button buttonActualizarMostrar;
        private System.Windows.Forms.Button buttonActualizarEscaneo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEliminarVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEliminarModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEliminarAño;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEliminarPropietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVehiculoBateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModeloBateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDueñoBateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHsVueloKmActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCargaBateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVehiculoEscaneo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModeloEscaneo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAñoEscaneo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPropietarioEscaneo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnHsVueloKmescaneo;
        private System.Windows.Forms.GroupBox groupBoxMostrar;
        private System.Windows.Forms.GroupBox groupBoxBateria;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

