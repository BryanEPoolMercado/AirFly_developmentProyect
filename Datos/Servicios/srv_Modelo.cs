using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Servicios;
using Datos.Modelo;

namespace Datos.Servicios
{
    class srv_Modelo
    {
        //list
        public List<Modelo_avion> GetListAerolinea()
        {
            List<Modelo_avion> objModelo = new List<Modelo_avion>();
            using (var db = new AirFly_Modelo())
            {
                objModelo = db.Modelo_avion.ToList();
                return objModelo;
            }
        }
       
            
        
    }
}
