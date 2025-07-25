using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuesta.DataAccess.Models
{
    public class UsoEquipamiento
    {
        public string NumeroEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string NombreEquipo { get; set; }
        public string MotivoDesuso { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
    }
}
