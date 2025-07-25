using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encuesta.DataAccess.Models;
using System.Windows.Forms;

namespace Encuesta.ApplicationLogic.Managers
{
    public class EquipamientoManager
    {
        private readonly UsoEquipamientoService _servicio = new UsoEquipamientoService();

        public bool RegistrarDesuso(UsoEquipamiento uso)
        {
            if (!_servicio.Validar(uso, out string mensaje))
            {
                MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool guardado = _servicio.Registrar(uso);

            if (guardado)
            {
                MessageBox.Show($"Registro de desuso exitoso:\nEquipo: {uso.NombreEquipo}\nMotivo: {uso.MotivoDesuso}", "Registro completado");
                return true;
            }
            else
            {
                MessageBox.Show("Error al guardar el registro de desuso.", "Error");
                return false;
            }
        }
    }
}
