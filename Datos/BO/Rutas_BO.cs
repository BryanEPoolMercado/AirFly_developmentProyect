using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.BO
{
    public class Rutas_BO
    {
        public int id_ruta { get; set; }
        public Nullable<decimal> distancia { get; set; }
        public string tiempo { get; set; }
        public string aeropuerto_origen { get; set; }
        public string aeropuerto_destino { get; set; }
        public string nombre_ruta { get; set; }
    }
}
