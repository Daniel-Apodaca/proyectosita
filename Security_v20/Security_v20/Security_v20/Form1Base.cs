namespace RegistroSeguridad.RegistroSeguridad.RegistroSeguridad
{
    internal class Form1Base
    {
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.CheckBox chboxlineadevida;
        private System.Windows.Forms.CheckBox chckboxarnes;
        private System.Windows.Forms.CheckBox chckboxcasco;
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.Label lblemp;
        private System.Windows.Forms.Label lblequiposeg;
        private System.Windows.Forms.Label lblnumemp;
        private System.Windows.Forms.Label lblturno;
        private System.Windows.Forms.RadioButton rbtndia;
        private System.Windows.Forms.RadioButton rbtnnoche;


        private System.Windows.Forms.GroupBox securitybox;
        private object securitybox;
        private System.Windows.Forms.TextBox txtdepartamento;
        private System.Windows.Forms.TextBox txtempleado;
        private System.Windows.Forms.TextBox txtnumempleado;

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


        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.securitybox = new System.Windows.Forms.GroupBox();
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
            this.securitybox.SuspendLayout();
            this.SuspendLayout();
            // 
            // securitybox
            // 
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
            this.securitybox.Size = new System.Drawing.Size(634, 414);
            this.securitybox.TabIndex = 0;
            this.securitybox.TabStop = false;
            this.securitybox.Text = "Control de Seguridad";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(486, 346);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 33);
            this.btnsalir.TabIndex = 15;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(289, 344);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 36);
            this.btnlimpiar.TabIndex = 14;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(77, 345);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(84, 35);
            this.btnregistrar.TabIndex = 13;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // chboxlineadevida
            // 
            this.chboxlineadevida.AutoSize = true;
            this.chboxlineadevida.Location = new System.Drawing.Point(316, 251);
            this.chboxlineadevida.Name = "chboxlineadevida";
            this.chboxlineadevida.Size = new System.Drawing.Size(114, 23);
            this.chboxlineadevida.TabIndex = 12;
            this.chboxlineadevida.Text = "Linea de vida";
            this.chboxlineadevida.UseVisualStyleBackColor = true;
            this.chboxlineadevida.CheckedChanged += new System.EventHandler(this.chboxlineadevida_CheckedChanged);
            // 
            // chckboxarnes
            // 
            this.chckboxarnes.AutoSize = true;
            this.chckboxarnes.Location = new System.Drawing.Point(188, 251);
            this.chckboxarnes.Name = "chckboxarnes";
            this.chckboxarnes.Size = new System.Drawing.Size(65, 23);
            this.chckboxarnes.TabIndex = 11;
            this.chckboxarnes.Text = "Arnes";
            this.chckboxarnes.UseVisualStyleBackColor = true;
            this.chckboxarnes.CheckedChanged += new System.EventHandler(this.chckboxarnes_CheckedChanged);
            // 
            // chckboxcasco
            // 
            this.chckboxcasco.AutoSize = true;
            this.chckboxcasco.Location = new System.Drawing.Point(60, 251);
            this.chckboxcasco.Name = "chckboxcasco";
            this.chckboxcasco.Size = new System.Drawing.Size(67, 23);
            this.chckboxcasco.TabIndex = 10;
            this.chckboxcasco.Text = "Casco";
            this.chckboxcasco.UseVisualStyleBackColor = true;
            this.chckboxcasco.CheckedChanged += new System.EventHandler(this.chckboxcasco_CheckedChanged);
            // 
            // lblturno
            // 
            this.lblturno.AutoSize = true;
            this.lblturno.Location = new System.Drawing.Point(184, 147);
            this.lblturno.Name = "lblturno";
            this.lblturno.Size = new System.Drawing.Size(49, 19);
            this.lblturno.TabIndex = 9;
            this.lblturno.Text = "Turno:";
            // 
            // rbtnnoche
            // 
            this.rbtnnoche.AutoSize = true;
            this.rbtnnoche.Location = new System.Drawing.Point(350, 145);
            this.rbtnnoche.Name = "rbtnnoche";
            this.rbtnnoche.Size = new System.Drawing.Size(68, 23);
            this.rbtnnoche.TabIndex = 8;
            this.rbtnnoche.TabStop = true;
            this.rbtnnoche.Text = "Noche";
            this.rbtnnoche.UseVisualStyleBackColor = true;
            this.rbtnnoche.CheckedChanged += new System.EventHandler(this.rbtnnoche_CheckedChanged);
            // 
            // rbtndia
            // 
            this.rbtndia.AutoSize = true;
            this.rbtndia.Location = new System.Drawing.Point(268, 145);
            this.rbtndia.Name = "rbtndia";
            this.rbtndia.Size = new System.Drawing.Size(49, 23);
            this.rbtndia.TabIndex = 7;
            this.rbtndia.TabStop = true;
            this.rbtndia.Text = "Dia";
            this.rbtndia.UseVisualStyleBackColor = true;
            this.rbtndia.CheckedChanged += new System.EventHandler(this.rbtndia_CheckedChanged);
            // 
            // lblequiposeg
            // 
            this.lblequiposeg.AutoSize = true;
            this.lblequiposeg.Location = new System.Drawing.Point(25, 202);
            this.lblequiposeg.Name = "lblequiposeg";
            this.lblequiposeg.Size = new System.Drawing.Size(145, 19);
            this.lblequiposeg.TabIndex = 6;
            this.lblequiposeg.Text = "Equipo de seguridad:";
            // 
            // txtdepartamento
            // 
            this.txtdepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdepartamento.Location = new System.Drawing.Point(424, 83);
            this.txtdepartamento.Name = "txtdepartamento";
            this.txtdepartamento.Size = new System.Drawing.Size(190, 27);
            this.txtdepartamento.TabIndex = 5;
            this.txtdepartamento.TextChanged += new System.EventHandler(this.txtdepartamento_TextChanged);
            // 
            // txtnumempleado
            // 
            this.txtnumempleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumempleado.Location = new System.Drawing.Point(162, 83);
            this.txtnumempleado.Name = "txtnumempleado";
            this.txtnumempleado.Size = new System.Drawing.Size(140, 27);
            this.txtnumempleado.TabIndex = 4;
            this.txtnumempleado.TextChanged += new System.EventHandler(this.txtnumempleado_TextChanged);
            // 
            // txtempleado
            // 
            this.txtempleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtempleado.Location = new System.Drawing.Point(113, 30);
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.Size = new System.Drawing.Size(501, 27);
            this.txtempleado.TabIndex = 3;
            this.txtempleado.TextChanged += new System.EventHandler(this.txtempleado_TextChanged);
            // 
            // lbldept
            // 
            this.lbldept.AutoSize = true;
            this.lbldept.Location = new System.Drawing.Point(312, 91);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(106, 19);
            this.lbldept.TabIndex = 2;
            this.lbldept.Text = "Departamento:";
            // 
            // lblnumemp
            // 
            this.lblnumemp.AutoSize = true;
            this.lblnumemp.Location = new System.Drawing.Point(25, 91);
            this.lblnumemp.Name = "lblnumemp";
            this.lblnumemp.Size = new System.Drawing.Size(123, 19);
            this.lblnumemp.TabIndex = 1;
            this.lblnumemp.Text = "No. de Empleado:";
            // 
            // lblemp
            // 
            this.lblemp.AutoSize = true;
            this.lblemp.Location = new System.Drawing.Point(25, 38);
            this.lblemp.Name = "lblemp";
            this.lblemp.Size = new System.Drawing.Size(77, 19);
            this.lblemp.TabIndex = 0;
            this.lblemp.Text = "Empleado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.securitybox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguridad Industrial";
            this.securitybox.ResumeLayout(false);
            this.securitybox.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}