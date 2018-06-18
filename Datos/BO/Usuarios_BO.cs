using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.BO
{
    public class Usuarios_BO
    {
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string apellidopat_usuario { get; set; }
        public string apellidomat_usuario { get; set; }
        public string correo_usuario { get; set; }
        public string contraseña_usuario { get; set; }
        public string nombre_perfil { get; set; }
    }
}
