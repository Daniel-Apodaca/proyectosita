using System;

namespace Security_v20
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
            this.securitybox = new System.Windows.Forms.GroupBox();
            this.lblelevacion = new System.Windows.Forms.Label();
            this.pictureBoxelevacion = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBoxelevacion = new System.Windows.Forms.ListBox();
            this.lblnotanoche = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.chboxlineadevida = new System.Windows.Forms.CheckBox();
            this.chckboxarnes = new System.Windows.Forms.CheckBox();
            this.chckboxcasco = new System.Windows.Forms.CheckBox();
            this.lblturno = new System.Windows.Forms.Label();
            this.rbtnnoche = new System.Windows.Forms.RadioButton();
            this.rbtndia = new System.Windows.Forms.RadioButton();
            this.lblequiposeg = new System.Windows.Forms.Label();
            this.txtdepartamento = new System.Windows.Forms.TextBox();
            this.txtnumempleado = new System.Windows.Forms.TextBox();
            this.txtempleado = new System.Windows.Forms.TextBox();
            this.lbldept = new System.Windows.Forms.Label();
            this.lblnumemp = new System.Windows.Forms.Label();
            this.lblemp = new System.Windows.Forms.Label();
            this.dtgvEmpleado = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elevacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.securitybox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxelevacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // securitybox
            // 
            this.securitybox.Controls.Add(this.button1);
            this.securitybox.Controls.Add(this.Actualizar);
            this.securitybox.Controls.Add(this.dtgvEmpleado);
            this.securitybox.Controls.Add(this.lblelevacion);
            this.securitybox.Controls.Add(this.pictureBoxelevacion);
            this.securitybox.Controls.Add(this.dateTimePicker1);
            this.securitybox.Controls.Add(this.listBoxelevacion);
            this.securitybox.Controls.Add(this.lblnotanoche);
            this.securitybox.Controls.Add(this.btnsalir);
            this.securitybox.Controls.Add(this.btnlimpiar);
            this.securitybox.Controls.Add(this.btnregistrar);
            this.securitybox.Controls.Add(this.chboxlineadevida);
            this.securitybox.Controls.Add(this.chckboxarnes);
            this.securitybox.Controls.Add(this.chckboxcasco);
            this.securitybox.Controls.Add(this.lblturno);
            this.securitybox.Controls.Add(this.rbtnnoche);
            this.securitybox.Controls.Add(this.rbtndia);
            this.securitybox.Controls.Add(this.lblequiposeg);
            this.securitybox.Controls.Add(this.txtdepartamento);
            this.securitybox.Controls.Add(this.txtnumempleado);
            this.securitybox.Controls.Add(this.txtempleado);
            this.securitybox.Controls.Add(this.lbldept);
            this.securitybox.Controls.Add(this.lblnumemp);
            this.securitybox.Controls.Add(this.lblemp);
            this.securitybox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securitybox.Location = new System.Drawing.Point(30, 17);
            this.securitybox.Name = "securitybox";
            this.securitybox.Size = new System.Drawing.Size(1003, 832);
            this.securitybox.TabIndex = 0;
            this.securitybox.TabStop = false;
            this.securitybox.Text = "Control de Seguridad";
            // 
            // lblelevacion
            // 
            this.lblelevacion.AutoSize = true;
            this.lblelevacion.Location = new System.Drawing.Point(108, 355);
            this.lblelevacion.Name = "lblelevacion";
            this.lblelevacion.Size = new System.Drawing.Size(180, 19);
            this.lblelevacion.TabIndex = 16;
            this.lblelevacion.Text = "Herramienta de elevacion:";
            // 
            // pictureBoxelevacion
            // 
            this.pictureBoxelevacion.Location = new System.Drawing.Point(408, 271);
            this.pictureBoxelevacion.Name = "pictureBoxelevacion";
            this.pictureBoxelevacion.Size = new System.Drawing.Size(221, 219);
            this.pictureBoxelevacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxelevacion.TabIndex = 15;
            this.pictureBoxelevacion.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(733, 249);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 27);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // listBoxelevacion
            // 
            this.listBoxelevacion.FormattingEnabled = true;
            this.listBoxelevacion.ItemHeight = 19;
            this.listBoxelevacion.Items.AddRange(new object[] {
            "Montacargas con canasta",
            "Plataforma elevadora de brazo",
            "Plataforma elevadora tijera",
            "Escalera de extension",
            "Escalera de tijera"});
            this.listBoxelevacion.Location = new System.Drawing.Point(97, 377);
            this.listBoxelevacion.Name = "listBoxelevacion";
            this.listBoxelevacion.Size = new System.Drawing.Size(217, 99);
            this.listBoxelevacion.TabIndex = 13;
            this.listBoxelevacion.SelectedIndexChanged += new System.EventHandler(this.listBoxelevacion_SelectedIndexChanged);
            // 
            // lblnotanoche
            // 
            this.lblnotanoche.AutoSize = true;
            this.lblnotanoche.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotanoche.ForeColor = System.Drawing.Color.Red;
            this.lblnotanoche.Location = new System.Drawing.Point(387, 159);
            this.lblnotanoche.Name = "lblnotanoche";
            this.lblnotanoche.Size = new System.Drawing.Size(334, 19);
            this.lblnotanoche.TabIndex = 12;
            this.lblnotanoche.Text = "Turno noche no puede trabajar en alturas externas";
            this.lblnotanoche.Visible = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(821, 522);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 33);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(433, 522);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 33);
            this.btnlimpiar.TabIndex = 10;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(97, 522);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(84, 33);
            this.btnregistrar.TabIndex = 9;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // chboxlineadevida
            // 
            this.chboxlineadevida.AutoSize = true;
            this.chboxlineadevida.Location = new System.Drawing.Point(112, 283);
            this.chboxlineadevida.Name = "chboxlineadevida";
            this.chboxlineadevida.Size = new System.Drawing.Size(114, 23);
            this.chboxlineadevida.TabIndex = 8;
            this.chboxlineadevida.Text = "Linea de vida";
            this.chboxlineadevida.UseVisualStyleBackColor = true;
            // 
            // chckboxarnes
            // 
            this.chckboxarnes.AutoSize = true;
            this.chckboxarnes.Location = new System.Drawing.Point(112, 254);
            this.chckboxarnes.Name = "chckboxarnes";
            this.chckboxarnes.Size = new System.Drawing.Size(65, 23);
            this.chckboxarnes.TabIndex = 7;
            this.chckboxarnes.Text = "Arnes";
            this.chckboxarnes.UseVisualStyleBackColor = true;
            // 
            // chckboxcasco
            // 
            this.chckboxcasco.AutoSize = true;
            this.chckboxcasco.Location = new System.Drawing.Point(112, 225);
            this.chckboxcasco.Name = "chckboxcasco";
            this.chckboxcasco.Size = new System.Drawing.Size(67, 23);
            this.chckboxcasco.TabIndex = 6;
            this.chckboxcasco.Text = "Casco";
            this.chckboxcasco.UseVisualStyleBackColor = true;
            // 
            // lblturno
            // 
            this.lblturno.AutoSize = true;
            this.lblturno.Location = new System.Drawing.Point(351, 131);
            this.lblturno.Name = "lblturno";
            this.lblturno.Size = new System.Drawing.Size(49, 19);
            this.lblturno.TabIndex = 0;
            this.lblturno.Text = "Turno:";
            // 
            // rbtnnoche
            // 
            this.rbtnnoche.AutoSize = true;
            this.rbtnnoche.Location = new System.Drawing.Point(467, 131);
            this.rbtnnoche.Name = "rbtnnoche";
            this.rbtnnoche.Size = new System.Drawing.Size(68, 23);
            this.rbtnnoche.TabIndex = 5;
            this.rbtnnoche.TabStop = true;
            this.rbtnnoche.Text = "Noche";
            this.rbtnnoche.UseVisualStyleBackColor = true;
            this.rbtnnoche.CheckedChanged += new System.EventHandler(this.rbtnnoche_CheckedChanged);
            // 
            // rbtndia
            // 
            this.rbtndia.AutoSize = true;
            this.rbtndia.Location = new System.Drawing.Point(406, 131);
            this.rbtndia.Name = "rbtndia";
            this.rbtndia.Size = new System.Drawing.Size(49, 23);
            this.rbtndia.TabIndex = 4;
            this.rbtndia.TabStop = true;
            this.rbtndia.Text = "Dia";
            this.rbtndia.UseVisualStyleBackColor = true;
            // 
            // lblequiposeg
            // 
            this.lblequiposeg.AutoSize = true;
            this.lblequiposeg.Location = new System.Drawing.Point(108, 185);
            this.lblequiposeg.Name = "lblequiposeg";
            this.lblequiposeg.Size = new System.Drawing.Size(145, 19);
            this.lblequiposeg.TabIndex = 0;
            this.lblequiposeg.Text = "Equipo de seguridad:";
            // 
            // txtdepartamento
            // 
            this.txtdepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdepartamento.Location = new System.Drawing.Point(597, 79);
            this.txtdepartamento.Name = "txtdepartamento";
            this.txtdepartamento.Size = new System.Drawing.Size(190, 27);
            this.txtdepartamento.TabIndex = 3;
            // 
            // txtnumempleado
            // 
            this.txtnumempleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumempleado.Location = new System.Drawing.Point(335, 79);
            this.txtnumempleado.Name = "txtnumempleado";
            this.txtnumempleado.Size = new System.Drawing.Size(140, 27);
            this.txtnumempleado.TabIndex = 2;
            // 
            // txtempleado
            // 
            this.txtempleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtempleado.Location = new System.Drawing.Point(286, 26);
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.Size = new System.Drawing.Size(501, 27);
            this.txtempleado.TabIndex = 1;
            // 
            // lbldept
            // 
            this.lbldept.AutoSize = true;
            this.lbldept.Location = new System.Drawing.Point(485, 87);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(106, 19);
            this.lbldept.TabIndex = 0;
            this.lbldept.Text = "Departamento:";
            // 
            // lblnumemp
            // 
            this.lblnumemp.AutoSize = true;
            this.lblnumemp.Location = new System.Drawing.Point(198, 87);
            this.lblnumemp.Name = "lblnumemp";
            this.lblnumemp.Size = new System.Drawing.Size(123, 19);
            this.lblnumemp.TabIndex = 0;
            this.lblnumemp.Text = "No. de Empleado:";
            // 
            // lblemp
            // 
            this.lblemp.AutoSize = true;
            this.lblemp.Location = new System.Drawing.Point(198, 34);
            this.lblemp.Name = "lblemp";
            this.lblemp.Size = new System.Drawing.Size(77, 19);
            this.lblemp.TabIndex = 0;
            this.lblemp.Text = "Empleado:";
            // 
            // dtgvEmpleado
            // 
            this.dtgvEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.empleado,
            this.Departamento,
            this.Turno,
            this.Equipo,
            this.Fecha,
            this.Elevacion});
            this.dtgvEmpleado.Location = new System.Drawing.Point(20, 578);
            this.dtgvEmpleado.Name = "dtgvEmpleado";
            this.dtgvEmpleado.Size = new System.Drawing.Size(964, 232);
            this.dtgvEmpleado.TabIndex = 17;
            this.dtgvEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEmpleado_CellClick);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero de empleado";
            this.Numero.Name = "Numero";
            // 
            // empleado
            // 
            this.empleado.HeaderText = "Nombre Empleado";
            this.empleado.Name = "empleado";
            this.empleado.Width = 140;
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.Width = 127;
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            this.Turno.Width = 70;
            // 
            // Equipo
            // 
            this.Equipo.HeaderText = "Equipo Seguridad";
            this.Equipo.Name = "Equipo";
            this.Equipo.Width = 133;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha Asignada";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 124;
            // 
            // Elevacion
            // 
            this.Elevacion.HeaderText = "Herramienta Elevacion";
            this.Elevacion.Name = "Elevacion";
            this.Elevacion.Width = 165;
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(259, 522);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(84, 33);
            this.Actualizar.TabIndex = 18;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "Eliminar Registro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1063, 861);
            this.Controls.Add(this.securitybox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguridad Industrial";
            this.securitybox.ResumeLayout(false);
            this.securitybox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxelevacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox securitybox;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.CheckBox chboxlineadevida;
        private System.Windows.Forms.CheckBox chckboxarnes;
        private System.Windows.Forms.CheckBox chckboxcasco;
        private System.Windows.Forms.Label lblturno;
        private System.Windows.Forms.RadioButton rbtnnoche;
        private System.Windows.Forms.RadioButton rbtndia;
        private System.Windows.Forms.Label lblequiposeg;
        private System.Windows.Forms.TextBox txtdepartamento;
        private System.Windows.Forms.TextBox txtnumempleado;
        private System.Windows.Forms.TextBox txtempleado;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.Label lblnumemp;
        private System.Windows.Forms.Label lblemp;
        private System.Windows.Forms.Label lblnotanoche;
        private System.Windows.Forms.ListBox listBoxelevacion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBoxelevacion;
        private System.Windows.Forms.Label lblelevacion;
        private System.Windows.Forms.DataGridView dtgvEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipo;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Elevacion;
        private System.Windows.Forms.Button button1;

        public EventHandler pictureBoxelevacion_Click { get; private set; }
    }
}