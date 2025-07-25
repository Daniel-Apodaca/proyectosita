using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Security_v20.ApplicationLogic;
using Security_v20.DataAccess.Models;
using System.Windows.Forms;

namespace Encuesta.ApplicationLogic.Managers
{
    public class EmpleadoManager
    {
        private readonly RegistroEmpleadoService _servicio = new RegistroEmpleadoService();

        public bool RegistrarEmpleado(RegistroEmpleado registro)
        {
            if (!_servicio.ValidarEquipo(registro, out string mensajeEquipo))
            {
                MessageBox.Show(mensajeEquipo, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var existente = _servicio.BuscarRegistro(registro.NumeroEmpleado, registro.Fecha);
            if (existente != null)
            {
                var reemplazar = MessageBox.Show(
                    "Ya existe un registro para ese número de empleado en la fecha seleccionada. ¿Deseas reemplazarlo?",
                    "Registro existente",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (reemplazar == DialogResult.No)
                    return false;
            }

            _servicio.RegistrarEmpleado(registro);

            var imprimir = MessageBox.Show("¿Deseas imprimir el registro?", "Registro exitoso", MessageBoxButtons.YesNo);
            if (imprimir == DialogResult.Yes)
            {
                MessageBox.Show($"Registro de {registro.NombreEmpleado}:\n{mensajeEquipo}\nElevación: {registro.EquipoElevacion}", "Impresión simulada");
            }

            return true;
        }

        public RegistroEmpleado BuscarEmpleado(string numeroEmpleado, string fecha)
        {
            return _servicio.BuscarRegistro(numeroEmpleado, fecha);
        }

        public string ObtenerMensajeEquipo(RegistroEmpleado registro)
        {
            _servicio.ValidarEquipo(registro, out string mensaje);
            return mensaje;
        }
    }
}
