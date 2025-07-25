using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Security_v20.Properties;
using Security_v20.DataAccess.Models;
using Security_v20.DataAccess.Repositories;
using Security_v20.ApplicationLogic;


namespace Security_v20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            //al terminar de registrar de registrar preguntara si desea imprimir registro en un msgbox
            //si el registro ya esta ocupado preguntara en msgbox si desea reemplazar
            // si el registro no cumple las condiciones lanzara msgbox indicando por que no puede registrar
            // Obtener valores
            RegistroEmpleado registro = new RegistroEmpleado
            {
                NombreEmpleado = txtempleado.Text,
                NumeroEmpleado = txtnumempleado.Text,
                Departamento = txtdepartamento.Text,
                Turno = rbtndia.Checked ? "Día" : (rbtnnoche.Checked ? "Noche" : "No seleccionado"),
                Casco = chckboxcasco.Checked,
                Arnes = chckboxarnes.Checked,
                LineaVida = chboxlineadevida.Checked,
                EquipoElevacion = listBoxelevacion.SelectedItem != null ? listBoxelevacion.SelectedItem.ToString() : "No Usara elevacion",
                Fecha = datetimepicker1.Value.ToShortDateString()
            };

            RegistroEmpleadoService servicio = new RegistroEmpleadoService();
            servicio.RegistrarEmpleado(registro);
        }


        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar texto
            txtempleado.Clear();
            txtnumempleado.Clear();
            txtdepartamento.Clear();
            // Desmarcar radio buttons
            rbtndia.Checked = false;
            rbtnnoche.Checked = false;
            // Desmarcar checkboxes
            chckboxcasco.Checked = false;
            chckboxarnes.Checked = false;
            chboxlineadevida.Checked = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //sale de aplicacion
        }

        private void rbtnnoche_CheckedChanged(object sender, EventArgs e)
        {
            {
                // Mostrar u ocultar el Label según el estado del RadioButton
                if (rbtnnoche.Checked)
                {
                    lblnotanoche.Visible = true; // Mostrar el Label
                }
                else
                {
                    lblnotanoche.Visible = false; // Ocultar el Label
                }
            }
        }

        private void listBoxelevacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Asegurar que haya una selección en el ListBox
            if (listBoxelevacion.SelectedItem != null)
            {
                string opcion = listBoxelevacion.SelectedItem.ToString();

                // Comparaciones con if-else para cambiar la imagen desde Resources
                if (opcion == "Montacargas con canasta")
                {
                    pictureBoxelevacion.Image = Resources.canastillas_montacarga;
                }
                else if (opcion == "Plataforma elevadora de brazo")
                {
                    pictureBoxelevacion.Image = Resources.Brazo_articulado;
                }
                else if (opcion == "Plataforma elevadora tijera")
                {
                    pictureBoxelevacion.Image = Resources.elevacion_tijera;
                }
                else if (opcion == "Escalera de extension")
                {
                    pictureBoxelevacion.Image = Resources.escalera_extension;
                }
                else if (opcion == "Escalera de tijera")
                {
                    pictureBoxelevacion.Image = Resources.escalera_tijera;
                }
                else
                {
                    pictureBoxelevacion.Image = null; // Si no hay coincidencia, limpiar la imagen
                }
                
            }
        }

        private void datetimepicker1_ValueChanged(object sender, EventArgs e)
        {
            //mostrar calendario completo?
        }

        private void BuscarEmp_Click(object sender, EventArgs e)
        {
            //al ingresar solo numero de empleado buscara en la bd y traera en automatico los demas registros
            string numEmpleado = txtnumempleado.Text;
            string fechaSeleccionada = datetimepicker1.Value.ToShortDateString();

            if (string.IsNullOrWhiteSpace(numEmpleado))
            {
                MessageBox.Show("Ingrese el número de empleado para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RegistroEmpleadoService servicio = new RegistroEmpleadoService();
            var registro = servicio.BuscarRegistro(numEmpleado, fechaSeleccionada);

            if (registro != null)
            {
                txtempleado.Text = registro.NombreEmpleado;
                txtdepartamento.Text = registro.Departamento;

                // Turno
                rbtndia.Checked = registro.Turno == "Día";
                rbtnnoche.Checked = registro.Turno == "Noche";

                // Seguridad
                chckboxcasco.Checked = registro.Casco;
                chckboxarnes.Checked = registro.Arnes;
                chboxlineadevida.Checked = registro.LineaVida;

                // Elevación
                listBoxelevacion.SelectedItem = registro.EquipoElevacion;

                MessageBox.Show("Registro encontrado y cargado.", "Éxito");
            }
            else
            {
                MessageBox.Show("No se encontró un registro para ese número y fecha.", "Sin resultados");
            }
        }

        private void lblnotanoche_Click(object sender, EventArgs e)
        {

        }
    }
}
