using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;

namespace Datos.Servicios
{
    public class srv_Vuelos
    {
        //list
        public List<Vuelos> GetListVuelos()
        {
            List<Vuelos> objVuelos = new List<Vuelos>();
            using (var db = new AirFly_Modelo())
            {
                objVuelos = db.Vuelos.ToList();
                return objVuelos;
            }
        }
        //add
        public void AgregarVuelos(Vuelos item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    db.Vuelos.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifique que los datos sean correctos");
            }
        }
        //delete
        public void EliminarVuelos(Vuelos item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    Vuelos obj = db.Vuelos.Where(x => x.id_vuelo == item.id_vuelo).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Vuelos.Remove(obj);
                        db.SaveChanges();
                    }
                }
            }
            catch
            {
                throw new Exception("Verifique que los datos sean correctos");
            }
        }
        //update
        public void ActualizarVuelos(Vuelos item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    Vuelos obj = db.Vuelos.Where(x => x.id_vuelo == item.id_vuelo).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.fecha_vuelo = item.fecha_vuelo;
                        obj.hora_vuelo = item.hora_vuelo;
                        obj.tiempo_vuelo = item.tiempo_vuelo;
                        obj.distancia_vuelo = item.distancia_vuelo;
                        obj.id_avion = item.id_avion;
                        obj.id_ruta = item.id_ruta;
                        db.SaveChanges();
                    }
                }

            }
            catch
            {
                throw new Exception("Verifique que los datos sean correctos");
            }
        }
    }
}
