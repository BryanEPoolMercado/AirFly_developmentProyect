using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;
using Datos.BO;

namespace Datos.Servicios
{
    public class srv_Ruta
    {
        //list
        private AirFly_Modelo modeloRuta;
        public List<Rutas_BO> GetListaRuta()
        {
            modeloRuta = new AirFly_Modelo();
            var selectRuta = (from rut in modeloRuta.Ruta
                              join aeropuer in modeloRuta.Aeropuerto on rut.aeropuerto_origen equals aeropuer.id_aeropuerto

                              select new Rutas_BO
                              {
                                  id_ruta = rut.id_ruta,
                                  nombre_ruta = rut.nombre_ruta,
                                  distancia = rut.distancia,
                                  tiempo = rut.tiempo,
                                  aeropuerto_origen = aeropuer.nombre_aeropuerto,
                                  aeropuerto_destino=aeropuer.nombre_aeropuerto,

                              }).ToList();
            return selectRuta;
        }
        //add
        public void AgregarRuta(Ruta item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    db.Ruta.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifique que los datos sean correctos");
            }
        }
        //delete
        public void EliminarRuta(Ruta item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    Ruta obj = db.Ruta.Where(x => x.id_ruta == item.id_ruta).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Ruta.Remove(obj);
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
        public void ActualizarRuta(Ruta item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    Ruta obj = db.Ruta.Where(x => x.id_ruta == item.id_ruta).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.nombre_ruta = item.nombre_ruta;
                        obj.tiempo = item.tiempo;
                        obj.distancia = item.distancia;
                        obj.aeropuerto_origen = item.aeropuerto_origen;
                        obj.aeropuerto_destino = item.aeropuerto_destino;
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
