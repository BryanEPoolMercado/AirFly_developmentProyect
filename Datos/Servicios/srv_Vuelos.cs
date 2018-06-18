using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;
using Datos.BO;

namespace Datos.Servicios
{
    public class srv_Vuelos
    {
        //list
        private AirFly_Modelo modeloVuelo;

        public List<Vuelos_BO> GetListaVuelos()
        {
            modeloVuelo = new AirFly_Modelo();
            var selectavion = (from vue in modeloVuelo.Vuelos
                               join avi in modeloVuelo.Avion on vue.id_avion equals avi.id_avion
                               join rut in modeloVuelo.Ruta on vue.id_ruta equals rut.id_ruta

                               select new Vuelos_BO
                               {
                                   id_vuelo = vue.id_vuelo,
                                   distancia_vuelo = vue.distancia_vuelo,
                                   fecha_vuelo = vue.fecha_vuelo,
                                   hora_vuelo = vue.hora_vuelo,
                                   tiempo_vuelo = vue.tiempo_vuelo,
                                   nombre_avion = avi.nombre_avion,
                                   nombre_ruta = rut.nombre_ruta,
                               }).ToList();
            return selectavion;
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
