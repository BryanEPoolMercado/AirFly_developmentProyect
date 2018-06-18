using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.BO
{
    public class Vuelos_BO
    {
        public int id_vuelo { get; set; }
        public Nullable<System.DateTime> fecha_vuelo { get; set; }
        public string hora_vuelo { get; set; }
        public string tiempo_vuelo { get; set; }
        public string distancia_vuelo { get; set; }
        public string nombre_avion { get; set; }
        public string nombre_ruta { get; set; }
    }
}
