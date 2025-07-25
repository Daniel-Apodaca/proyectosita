using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encuesta.DataAccess.Models;
using Encuesta.DataAccess.Repositories;

namespace Encuesta.ApplicationLogic
{
    public class UsoEquipamientoService
    {
        private readonly UsoEquipamientoRepository _repo = new UsoEquipamientoRepository();

        public bool Validar(UsoEquipamiento uso, out string mensaje)
        {
            mensaje = "";
            if (string.IsNullOrWhiteSpace(uso.NombreEquipo))
                mensaje = "Nombre del equipo no puede estar vacío.";
            else if (string.IsNullOrWhiteSpace(uso.MotivoDesuso))
                mensaje = "Debes especificar un motivo del desuso.";
            else
                return true;

            return false;
        }

        public bool Registrar(UsoEquipamiento uso)
        {
            return _repo.Guardar(uso);
        }
    }
}
