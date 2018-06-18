using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.BO
{
    public class Avion_BO
    {
        public int id_avion { get; set; }
        public Nullable<int> numfila_avion { get; set; }
        public Nullable<int> numcolumna_avion { get; set; }
        public string nombre_avion { get; set; }
        public string nombre_aerolinea { get; set; }
        public string nombre_seccion { get; set; }
    }
}
