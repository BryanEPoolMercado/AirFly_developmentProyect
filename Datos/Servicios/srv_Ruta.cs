using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;

namespace Datos.Servicios
{
    public class srv_Ruta
    {
        //list
        public List<Ruta> GetListAerolinea()
        {
            List<Ruta> objRuta = new List<Ruta>();
            using (var db = new AirFly_Modelo())
            {
                objRuta = db.Ruta.ToList();
                return objRuta;
            }
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
