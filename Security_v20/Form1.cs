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



namespace Security_v20
{
    public partial class Form1 : Form
    {
        private int n = 0; //declaras variable int
        private int filaSeleccionada = -1;
        public Form1()
        {
            InitializeComponent();
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
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            string turno = rbtndia.Checked ? "Día" : (rbtnnoche.Checked ? "Noche" : "No seleccionado");

            // Declarar variable para el renglón
            int n = dtgvEmpleado.Rows.Add();

            // Equipo de seguridad
            bool casco = chckboxcasco.Checked;
            bool arnes = chckboxarnes.Checked;
            bool lineaVida = chboxlineadevida.Checked;

            string mensaje = "";

            if (casco && arnes && lineaVida)
            {
                mensaje = "Apto para trabajar en alturas.";
            }
            else if (casco && arnes)
            {
                mensaje = "No apto para trabajar en alturas.";
            }
            else if (casco)
            {
                mensaje = "Solo puede trabajar en piso.";
            }
            else
            {
                mensaje = "No cuenta con equipo de seguridad suficiente.";
            }

            // Obtener fecha y elevación
            string fecha = dateTimePicker1.Value.ToShortDateString();

            string opcion = listBoxelevacion.SelectedItem != null
                ? listBoxelevacion.SelectedItem.ToString()
                : "Sin selección";

            // Agregar información a DataGridView
            dtgvEmpleado.Rows[n].Cells[0].Value = txtnumempleado.Text;
            dtgvEmpleado.Rows[n].Cells[1].Value = txtempleado.Text;
            dtgvEmpleado.Rows[n].Cells[2].Value = txtdepartamento.Text;
            dtgvEmpleado.Rows[n].Cells[3].Value = turno;
            dtgvEmpleado.Rows[n].Cells[4].Value = mensaje;
            dtgvEmpleado.Rows[n].Cells[5].Value = fecha;
            dtgvEmpleado.Rows[n].Cells[6].Value = opcion;

            // Limpiar campos
            txtempleado.Clear();
            txtnumempleado.Clear();
            txtdepartamento.Clear();
            rbtndia.Checked = false;
            rbtnnoche.Checked = false;
            chckboxcasco.Checked = false;
            chckboxarnes.Checked = false;
            chboxlineadevida.Checked = false;
            listBoxelevacion.ClearSelected(); // Limpia selección del ListBox
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
            Application.Exit(); //cierra aplicacion por completo
        }

        

        private void Actualizar_Click(object sender, EventArgs e)
        {
            //actualiza los datos del datagrid

            if (filaSeleccionada >= 0 && filaSeleccionada < dtgvEmpleado.Rows.Count)
            {
                DataGridViewRow row = dtgvEmpleado.Rows[filaSeleccionada];

                row.Cells[0].Value = txtnumempleado.Text;
                row.Cells[1].Value = txtempleado.Text;
                row.Cells[2].Value = txtdepartamento.Text;
                row.Cells[3].Value = rbtndia.Checked ? "Día" : (rbtnnoche.Checked ? "Noche" : "No seleccionado");

                bool casco = chckboxcasco.Checked;
                bool arnes = chckboxarnes.Checked;
                bool lineaVida = chboxlineadevida.Checked;

                string mensaje = "";
                if (casco && arnes && lineaVida)
                    mensaje = "Apto para trabajar en alturas.";
                else if (casco && arnes)
                    mensaje = "No apto para trabajar en alturas.";
                else if (casco)
                    mensaje = "Solo puede trabajar en piso.";
                else
                    mensaje = "No cuenta con equipo de seguridad suficiente.";

                row.Cells[4].Value = mensaje;
                row.Cells[5].Value = dateTimePicker1.Value.ToShortDateString();
                row.Cells[6].Value = listBoxelevacion.SelectedItem?.ToString() ?? "Sin selección";

                MessageBox.Show("Registro actualizado correctamente.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecciona un registro para actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //regresa datos del empleado a sus lugares de origen

            // Verificar que el clic sea válido (no encabezado ni fuera de rango)
            if (e.RowIndex >= 0)
            {
                filaSeleccionada = e.RowIndex;

                DataGridViewRow row = dtgvEmpleado.Rows[e.RowIndex];

                txtnumempleado.Text = row.Cells[0].Value?.ToString();
                txtempleado.Text = row.Cells[1].Value?.ToString();
                txtdepartamento.Text = row.Cells[2].Value?.ToString();

                // Turno
                string turno = row.Cells[3].Value?.ToString();
                if (turno == "Día")
                    rbtndia.Checked = true;
                else if (turno == "Noche")
                    rbtnnoche.Checked = true;
                else
                {
                    rbtndia.Checked = false;
                    rbtnnoche.Checked = false;
                }

                // Mensaje de equipo de seguridad
                string mensaje = row.Cells[4].Value?.ToString();

                // Asignar los checkboxes según el mensaje (si quieres algo más exacto, guarda los valores de los checkboxes en el DataGridView también)
                chckboxcasco.Checked = mensaje.Contains("casco") || mensaje.Contains("trabajar");
                chckboxarnes.Checked = mensaje.Contains("arnes") || mensaje.Contains("trabajar");
                chboxlineadevida.Checked = mensaje.Contains("alturas");

                // Fecha
                if (DateTime.TryParse(row.Cells[5].Value?.ToString(), out DateTime fecha))
                {
                    dateTimePicker1.Value = fecha;
                }

                // Elevación
                string elevacion = row.Cells[6].Value?.ToString();
                int index = listBoxelevacion.Items.IndexOf(elevacion);
                if (index != -1)
                    listBoxelevacion.SelectedIndex = index;
                else
                    listBoxelevacion.ClearSelected();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Elimina la celda seleccionada (registro cancelado)
            if (filaSeleccionada >= 0 && filaSeleccionada < dtgvEmpleado.Rows.Count)
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este registro?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    dtgvEmpleado.Rows.RemoveAt(filaSeleccionada);
                    filaSeleccionada = -1; // resetear índice después de eliminar

                    // Limpiar controles
                    txtempleado.Clear();
                    txtnumempleado.Clear();
                    txtdepartamento.Clear();
                    rbtndia.Checked = false;
                    rbtnnoche.Checked = false;
                    chckboxcasco.Checked = false;
                    chckboxarnes.Checked = false;
                    chboxlineadevida.Checked = false;
                    listBoxelevacion.ClearSelected();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un registro para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
