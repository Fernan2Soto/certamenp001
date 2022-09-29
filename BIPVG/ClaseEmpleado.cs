using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIPVG
{
    public class ClaseEmpleado
    {
        public string rut { get; set; }
        public string nombre { get; set; }
        public CLaseJefe jefe { get; set; }


        public ClaseEmpleado(string rut, string nombre)
        {
            this.rut = rut;
            this.nombre = nombre;
            jefe = new CLaseJefe();
        }

        public ClaseEmpleado()
        {
        }
    }
}
