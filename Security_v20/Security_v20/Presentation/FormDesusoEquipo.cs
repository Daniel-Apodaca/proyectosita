using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encuesta.ApplicationLogic.Managers;
using Encuesta.DataAccess.Models;

namespace Encuesta.Presentation
{
    public partial class FormDesusoEquipo : Form
    {
        public FormDesusoEquipo()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var uso = new UsoEquipamiento
            {
                NumeroEmpleado = txtNumero.Text,
                NombreEmpleado = txtNombre.Text,
                NombreEquipo = txtEquipo.Text,
                MotivoDesuso = txtMotivo.Text,
                Fecha = dtpFecha.Value.ToShortDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            var manager = new EquipamientoManager();
            manager.RegistrarDesuso(uso);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
