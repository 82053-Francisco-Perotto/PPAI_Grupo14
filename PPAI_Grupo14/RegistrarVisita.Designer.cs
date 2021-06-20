
namespace PPAI_Grupo14
{
    partial class btn_confirmar_seleccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grillaEscuelas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEscuelaSeleccionada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grillaSede = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSedeSeleccionada = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grillaTipoVisitas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTipoVisitaSeleccionada = new System.Windows.Forms.TextBox();
            this.grilla_expo = new System.Windows.Forms.DataGridView();
            this.NombreExposicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePublicoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_get_expo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btn_calcular_duracion = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_confirmar_expos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEscuelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSede)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTipoVisitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_expo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elegir una escuela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresar la cantidad de visitantes";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(15, 281);
            this.txt_cantidad.Mask = "99999";
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 4;
            this.txt_cantidad.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Elegir una sede";
            // 
            // grillaEscuelas
            // 
            this.grillaEscuelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaEscuelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.grillaEscuelas.Location = new System.Drawing.Point(15, 35);
            this.grillaEscuelas.Name = "grillaEscuelas";
            this.grillaEscuelas.Size = new System.Drawing.Size(457, 150);
            this.grillaEscuelas.TabIndex = 7;
            this.grillaEscuelas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaEscuelas_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // txtEscuelaSeleccionada
            // 
            this.txtEscuelaSeleccionada.Location = new System.Drawing.Point(132, 206);
            this.txtEscuelaSeleccionada.Name = "txtEscuelaSeleccionada";
            this.txtEscuelaSeleccionada.Size = new System.Drawing.Size(167, 20);
            this.txtEscuelaSeleccionada.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Escuela seleccionada:";
            // 
            // grillaSede
            // 
            this.grillaSede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaSede.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.grillaSede.Location = new System.Drawing.Point(15, 344);
            this.grillaSede.Name = "grillaSede";
            this.grillaSede.Size = new System.Drawing.Size(457, 150);
            this.grillaSede.TabIndex = 10;
            this.grillaSede.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaSede_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sede seleccionada:";
            // 
            // txtSedeSeleccionada
            // 
            this.txtSedeSeleccionada.Location = new System.Drawing.Point(119, 516);
            this.txtSedeSeleccionada.Name = "txtSedeSeleccionada";
            this.txtSedeSeleccionada.Size = new System.Drawing.Size(167, 20);
            this.txtSedeSeleccionada.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Elegir tipo de visita";
            // 
            // grillaTipoVisitas
            // 
            this.grillaTipoVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTipoVisitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.grillaTipoVisitas.Location = new System.Drawing.Point(15, 602);
            this.grillaTipoVisitas.Name = "grillaTipoVisitas";
            this.grillaTipoVisitas.Size = new System.Drawing.Size(457, 150);
            this.grillaTipoVisitas.TabIndex = 14;
            this.grillaTipoVisitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaTipoVisitas_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 782);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tipo visita  seleccionada:";
            // 
            // txtTipoVisitaSeleccionada
            // 
            this.txtTipoVisitaSeleccionada.Location = new System.Drawing.Point(145, 779);
            this.txtTipoVisitaSeleccionada.Name = "txtTipoVisitaSeleccionada";
            this.txtTipoVisitaSeleccionada.Size = new System.Drawing.Size(167, 20);
            this.txtTipoVisitaSeleccionada.TabIndex = 15;
            // 
            // grilla_expo
            // 
            this.grilla_expo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_expo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreExposicion,
            this.NombrePublicoDestino,
            this.HoraApertura,
            this.HoraCierre,
            this.Agregada});
            this.grilla_expo.Location = new System.Drawing.Point(529, 38);
            this.grilla_expo.Name = "grilla_expo";
            this.grilla_expo.Size = new System.Drawing.Size(546, 174);
            this.grilla_expo.TabIndex = 17;
            // 
            // NombreExposicion
            // 
            this.NombreExposicion.HeaderText = "Nombre de exposicion";
            this.NombreExposicion.Name = "NombreExposicion";
            // 
            // NombrePublicoDestino
            // 
            this.NombrePublicoDestino.HeaderText = "Publico destino";
            this.NombrePublicoDestino.Name = "NombrePublicoDestino";
            // 
            // HoraApertura
            // 
            this.HoraApertura.HeaderText = "Hora de apertura";
            this.HoraApertura.Name = "HoraApertura";
            // 
            // HoraCierre
            // 
            this.HoraCierre.HeaderText = "Hora de cierre";
            this.HoraCierre.Name = "HoraCierre";
            // 
            // Agregada
            // 
            this.Agregada.HeaderText = "Agregada";
            this.Agregada.Name = "Agregada";
            // 
            // btn_get_expo
            // 
            this.btn_get_expo.Location = new System.Drawing.Point(529, 9);
            this.btn_get_expo.Name = "btn_get_expo";
            this.btn_get_expo.Size = new System.Drawing.Size(110, 23);
            this.btn_get_expo.TabIndex = 18;
            this.btn_get_expo.Text = "Buscar exposicion";
            this.btn_get_expo.UseVisualStyleBackColor = true;
            this.btn_get_expo.Click += new System.EventHandler(this.btn_get_expo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fecha y hora de la reserva:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(679, 324);
            this.maskedTextBox1.Mask = "00/00/0000 00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 20;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // btn_calcular_duracion
            // 
            this.btn_calcular_duracion.Location = new System.Drawing.Point(813, 322);
            this.btn_calcular_duracion.Name = "btn_calcular_duracion";
            this.btn_calcular_duracion.Size = new System.Drawing.Size(170, 23);
            this.btn_calcular_duracion.TabIndex = 21;
            this.btn_calcular_duracion.Text = "Calcular duracion de la reserva";
            this.btn_calcular_duracion.UseVisualStyleBackColor = true;
            this.btn_calcular_duracion.Click += new System.EventHandler(this.btn_calcular_duracion_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(679, 361);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(609, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Duracion:";
            // 
            // btn_confirmar_expos
            // 
            this.btn_confirmar_expos.Location = new System.Drawing.Point(950, 228);
            this.btn_confirmar_expos.Name = "btn_confirmar_expos";
            this.btn_confirmar_expos.Size = new System.Drawing.Size(125, 23);
            this.btn_confirmar_expos.TabIndex = 24;
            this.btn_confirmar_expos.Text = "Confirmar Seleccion";
            this.btn_confirmar_expos.UseVisualStyleBackColor = true;
            this.btn_confirmar_expos.Click += new System.EventHandler(this.btn_confirmar_expos_Click);
            // 
            // btn_confirmar_seleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 814);
            this.Controls.Add(this.btn_confirmar_expos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_calcular_duracion);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_get_expo);
            this.Controls.Add(this.grilla_expo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTipoVisitaSeleccionada);
            this.Controls.Add(this.grillaTipoVisitas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSedeSeleccionada);
            this.Controls.Add(this.grillaSede);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEscuelaSeleccionada);
            this.Controls.Add(this.grillaEscuelas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "btn_confirmar_seleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Visita";
            this.Load += new System.EventHandler(this.RegistrarVisita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaEscuelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSede)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTipoVisitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_expo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grillaEscuelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.TextBox txtEscuelaSeleccionada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grillaSede;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSedeSeleccionada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grillaTipoVisitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTipoVisitaSeleccionada;
        private System.Windows.Forms.DataGridView grilla_expo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreExposicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePublicoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraCierre;
        private System.Windows.Forms.Button btn_get_expo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agregada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btn_calcular_duracion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_confirmar_expos;
    }
}