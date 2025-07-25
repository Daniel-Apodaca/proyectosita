using System.Windows.Forms;
using Security_v20.DataAccess.Models;
using Security_v20.DataAccess.Repositories;

namespace Security_v20.ApplicationLogic
{
    public class RegistroEmpleadoService
    {
        private readonly RegistroEmpleadoRepository _repo = new RegistroEmpleadoRepository();

        public bool ValidarEquipo(RegistroEmpleado reg, out string mensaje)
        {
            mensaje = "";
            if (reg.Casco && reg.Arnes && reg.LineaVida)
                mensaje = "Apto para trabajar en alturas.";
            else if (reg.Casco && reg.Arnes)
                mensaje = "No apto para trabajar en alturas.";
            else if (reg.Casco)
                mensaje = "Solo puede trabajar en piso.";
            else
            {
                mensaje = "No cuenta con equipo de seguridad suficiente.";
                return false;
            }

            return true;
        }

        public void RegistrarEmpleado(RegistroEmpleado registro)
        {
            string mensajeEquipo;
            if (!ValidarEquipo(registro, out mensajeEquipo))
            {
                MessageBox.Show(mensajeEquipo, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existente = _repo.BuscarPorNumeroYFecha(registro.NumeroEmpleado, registro.Fecha);
            if (existente != null)
            {
                var reemplazar = MessageBox.Show(
                    "Ya existe un registro para ese número de empleado en la fecha seleccionada. ¿Deseas reemplazarlo?",
                    "Registro existente",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (reemplazar == DialogResult.No) return;

                _repo.EliminarPorNumeroYFecha(registro.NumeroEmpleado, registro.Fecha);
            }

            bool guardado = _repo.GuardarRegistro(registro);
            if (guardado)
            {
                var imprimir = MessageBox.Show("¿Deseas imprimir el registro?", "Registro exitoso", MessageBoxButtons.YesNo);
                if (imprimir == DialogResult.Yes)
                {
                    MessageBox.Show($"Registro de {registro.NombreEmpleado}:\n{mensajeEquipo}\nElevación: {registro.EquipoElevacion}", "Impresión simulada");
                }
            }
            else
            {
                MessageBox.Show("Error al guardar el registro.", "Error");
            }
        }

        public RegistroEmpleado BuscarRegistro(string numeroEmpleado, string fecha)
        {
            return _repo.BuscarPorNumeroYFecha(numeroEmpleado, fecha);
        }
    }
}
