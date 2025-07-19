using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_v20.DataAccess.Models
{
    public class RegistroEmpleado
    {
        public string NombreEmpleado { get; set; }
        public string NumeroEmpleado { get; set; }
        public string Departamento { get; set; }
        public string Turno { get; set; }
        public bool Casco { get; set; }
        public bool Arnes { get; set; }
        public bool LineaVida { get; set; }
        public string EquipoElevacion { get; set; }
        public string Fecha { get; set; }
    }
}
