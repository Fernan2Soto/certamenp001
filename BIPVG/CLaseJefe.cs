using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIPVG
{
    public class CLaseJefe
    {
        public string rut { get; set; }
        public string nombre { get; set; }
        public ClaseDepartamento departamento { get; set; }

        public CLaseJefe()
        {
            rut = "15234643-2";
            nombre = "Juan Perez";
            departamento = new ClaseDepartamento();
        }

    }
}
