using System;

namespace Security_v20
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;


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
            this.BuscarEmp = new System.Windows.Forms.Button();
            this.lblelevacion = new System.Windows.Forms.Label();
            this.pictureBoxelevacion = new System.Windows.Forms.PictureBox();
            this.datetimepicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.btnRegistrarDesuso = new System.Windows.Forms.Button();
            this.securitybox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxelevacion)).BeginInit();
            this.SuspendLayout();
            // 
            // securitybox
            // 
            this.securitybox.Controls.Add(this.btnRegistrarDesuso);
            this.securitybox.Controls.Add(this.BuscarEmp);
            this.securitybox.Controls.Add(this.lblelevacion);
            this.securitybox.Controls.Add(this.pictureBoxelevacion);
            this.securitybox.Controls.Add(this.datetimepicker1);
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
            this.securitybox.Location = new System.Drawing.Point(24, 17);
            this.securitybox.Name = "securitybox";
            this.securitybox.Size = new System.Drawing.Size(640, 561);
            this.securitybox.TabIndex = 0;
            this.securitybox.TabStop = false;
            this.securitybox.Text = "Control de Seguridad";
            // 
            // BuscarEmp
            // 
            this.BuscarEmp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BuscarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuscarEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BuscarEmp.Location = new System.Drawing.Point(329, 30);
            this.BuscarEmp.Name = "BuscarEmp";
            this.BuscarEmp.Size = new System.Drawing.Size(131, 30);
            this.BuscarEmp.TabIndex = 17;
            this.BuscarEmp.Text = "Buscar";
            this.BuscarEmp.UseVisualStyleBackColor = false;
            this.BuscarEmp.Click += new System.EventHandler(this.BuscarEmp_Click);
            // 
            // lblelevacion
            // 
            this.lblelevacion.AutoSize = true;
            this.lblelevacion.Location = new System.Drawing.Point(370, 174);
            this.lblelevacion.Name = "lblelevacion";
            this.lblelevacion.Size = new System.Drawing.Size(180, 19);
            this.lblelevacion.TabIndex = 16;
            this.lblelevacion.Text = "Herramienta de elevacion:";
            // 
            // pictureBoxelevacion
            // 
            this.pictureBoxelevacion.Location = new System.Drawing.Point(362, 310);
            this.pictureBoxelevacion.Name = "pictureBoxelevacion";
            this.pictureBoxelevacion.Size = new System.Drawing.Size(188, 174);
            this.pictureBoxelevacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxelevacion.TabIndex = 15;
            this.pictureBoxelevacion.TabStop = false;
            // 
            // datetimepicker1
            // 
            this.datetimepicker1.Location = new System.Drawing.Point(77, 292);
            this.datetimepicker1.Name = "datetimepicker1";
            this.datetimepicker1.Size = new System.Drawing.Size(196, 27);
            this.datetimepicker1.TabIndex = 14;
            this.datetimepicker1.ValueChanged += new System.EventHandler(this.datetimepicker1_ValueChanged);
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
            this.listBoxelevacion.Location = new System.Drawing.Point(362, 205);
            this.listBoxelevacion.Name = "listBoxelevacion";
            this.listBoxelevacion.Size = new System.Drawing.Size(188, 99);
            this.listBoxelevacion.TabIndex = 13;
            this.listBoxelevacion.SelectedIndexChanged += new System.EventHandler(this.listBoxelevacion_SelectedIndexChanged);
            // 
            // lblnotanoche
            // 
            this.lblnotanoche.AutoSize = true;
            this.lblnotanoche.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotanoche.ForeColor = System.Drawing.Color.Red;
            this.lblnotanoche.Location = new System.Drawing.Point(30, 142);
            this.lblnotanoche.Name = "lblnotanoche";
            this.lblnotanoche.Size = new System.Drawing.Size(334, 19);
            this.lblnotanoche.TabIndex = 12;
            this.lblnotanoche.Text = "Turno noche no puede trabajar en alturas externas";
            this.lblnotanoche.Visible = false;
            this.lblnotanoche.Click += new System.EventHandler(this.lblnotanoche_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsalir.Location = new System.Drawing.Point(486, 503);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 33);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlimpiar.Location = new System.Drawing.Point(374, 503);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 36);
            this.btnlimpiar.TabIndex = 10;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnregistrar.Location = new System.Drawing.Point(77, 502);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(84, 35);
            this.btnregistrar.TabIndex = 9;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // chboxlineadevida
            // 
            this.chboxlineadevida.AutoSize = true;
            this.chboxlineadevida.Location = new System.Drawing.Point(105, 263);
            this.chboxlineadevida.Name = "chboxlineadevida";
            this.chboxlineadevida.Size = new System.Drawing.Size(114, 23);
            this.chboxlineadevida.TabIndex = 8;
            this.chboxlineadevida.Text = "Linea de vida";
            this.chboxlineadevida.UseVisualStyleBackColor = true;
            // 
            // chckboxarnes
            // 
            this.chckboxarnes.AutoSize = true;
            this.chckboxarnes.Location = new System.Drawing.Point(105, 234);
            this.chckboxarnes.Name = "chckboxarnes";
            this.chckboxarnes.Size = new System.Drawing.Size(65, 23);
            this.chckboxarnes.TabIndex = 7;
            this.chckboxarnes.Text = "Arnes";
            this.chckboxarnes.UseVisualStyleBackColor = true;
            // 
            // chckboxcasco
            // 
            this.chckboxcasco.AutoSize = true;
            this.chckboxcasco.Location = new System.Drawing.Point(105, 205);
            this.chckboxcasco.Name = "chckboxcasco";
            this.chckboxcasco.Size = new System.Drawing.Size(67, 23);
            this.chckboxcasco.TabIndex = 6;
            this.chckboxcasco.Text = "Casco";
            this.chckboxcasco.UseVisualStyleBackColor = true;
            // 
            // lblturno
            // 
            this.lblturno.AutoSize = true;
            this.lblturno.Location = new System.Drawing.Point(26, 120);
            this.lblturno.Name = "lblturno";
            this.lblturno.Size = new System.Drawing.Size(49, 19);
            this.lblturno.TabIndex = 0;
            this.lblturno.Text = "Turno:";
            // 
            // rbtnnoche
            // 
            this.rbtnnoche.AutoSize = true;
            this.rbtnnoche.Location = new System.Drawing.Point(162, 116);
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
            this.rbtndia.Location = new System.Drawing.Point(96, 116);
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
            this.lblequiposeg.Location = new System.Drawing.Point(73, 174);
            this.lblequiposeg.Name = "lblequiposeg";
            this.lblequiposeg.Size = new System.Drawing.Size(145, 19);
            this.lblequiposeg.TabIndex = 0;
            this.lblequiposeg.Text = "Equipo de seguridad:";
            // 
            // txtdepartamento
            // 
            this.txtdepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdepartamento.Location = new System.Drawing.Point(398, 112);
            this.txtdepartamento.Name = "txtdepartamento";
            this.txtdepartamento.Size = new System.Drawing.Size(190, 27);
            this.txtdepartamento.TabIndex = 3;
            // 
            // txtnumempleado
            // 
            this.txtnumempleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumempleado.Location = new System.Drawing.Point(163, 30);
            this.txtnumempleado.Name = "txtnumempleado";
            this.txtnumempleado.Size = new System.Drawing.Size(140, 27);
            this.txtnumempleado.TabIndex = 2;
            // 
            // txtempleado
            // 
            this.txtempleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtempleado.Location = new System.Drawing.Point(114, 71);
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.Size = new System.Drawing.Size(501, 27);
            this.txtempleado.TabIndex = 1;
            // 
            // lbldept
            // 
            this.lbldept.AutoSize = true;
            this.lbldept.Location = new System.Drawing.Point(286, 120);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(106, 19);
            this.lbldept.TabIndex = 0;
            this.lbldept.Text = "Departamento:";
            // 
            // lblnumemp
            // 
            this.lblnumemp.AutoSize = true;
            this.lblnumemp.Location = new System.Drawing.Point(26, 38);
            this.lblnumemp.Name = "lblnumemp";
            this.lblnumemp.Size = new System.Drawing.Size(123, 19);
            this.lblnumemp.TabIndex = 0;
            this.lblnumemp.Text = "No. de Empleado:";
            // 
            // lblemp
            // 
            this.lblemp.AutoSize = true;
            this.lblemp.Location = new System.Drawing.Point(26, 79);
            this.lblemp.Name = "lblemp";
            this.lblemp.Size = new System.Drawing.Size(77, 19);
            this.lblemp.TabIndex = 0;
            this.lblemp.Text = "Empleado:";
            // 
            // btnRegistrarDesuso
            // 
            this.btnRegistrarDesuso.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegistrarDesuso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarDesuso.Location = new System.Drawing.Point(182, 502);
            this.btnRegistrarDesuso.Name = "btnRegistrarDesuso";
            this.btnRegistrarDesuso.Size = new System.Drawing.Size(171, 37);
            this.btnRegistrarDesuso.TabIndex = 18;
            this.btnRegistrarDesuso.Text = "Registrar Des uso ";
            this.btnRegistrarDesuso.UseVisualStyleBackColor = false;
            this.btnRegistrarDesuso.Click += new System.EventHandler(this.btnRegistrarDesuso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(690, 604);
            this.Controls.Add(this.securitybox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguridad Industrial";
            this.securitybox.ResumeLayout(false);
            this.securitybox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxelevacion)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxelevacion;
        private System.Windows.Forms.Label lblelevacion;
        private System.Windows.Forms.Button BuscarEmp;
        private System.Windows.Forms.DateTimePicker datetimepicker1;
        private System.Windows.Forms.Button btnRegistrarDesuso;

        public EventHandler pictureBoxelevacion_Click { get; private set; }
    }
}