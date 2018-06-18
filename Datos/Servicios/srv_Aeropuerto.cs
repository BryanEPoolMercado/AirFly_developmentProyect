using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;

namespace Datos.Servicios
{
    public class srv_Aeropuerto
    {
        //list
        public List<Aeropuerto> GetListAeropuerto()
        {
            List<Aeropuerto> objAeropuerto = new List<Aeropuerto>();
            using (var db = new AirFly_Modelo())
            {
                objAeropuerto = db.Aeropuerto.ToList();
                return objAeropuerto;
            }
        }
        //add
        public void AgregarAeropuerto(Aeropuerto item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    db.Aeropuerto.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifique que los datos sean correctos");
            }
        }
        //delete
        public void EliminarAeropuerto(Aeropuerto item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    Aeropuerto obj = db.Aeropuerto.Where(x => x.id_aeropuerto == item.id_aeropuerto).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Aeropuerto.Remove(obj);
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
        public void ActualizarAeropuerto(Aeropuerto item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    Aeropuerto obj = db.Aeropuerto.Where(x => x.id_aeropuerto == item.id_aeropuerto).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.nombre_aeropuerto = item.nombre_aeropuerto;
                        obj.id_ciudad = item.id_ciudad;
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
