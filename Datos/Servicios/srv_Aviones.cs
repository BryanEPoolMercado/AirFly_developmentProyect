using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;

namespace Datos.Servicios
{
    public class srv_Aviones
    {
        //list
        public List<Avion> GetListAvion()
        {
            List<Avion> objAvion = new List<Avion>();
            using (var db = new AirFly_Modelo())
            {
                objAvion = db.Avion.ToList();
                return objAvion;
            }
        }
        //add
        public void AgregarAvion(Avion item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    db.Avion.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifique que los datos sean correctos");
            }
        }
        //delete
        public void EliminarAvion(Avion item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    Avion obj = db.Avion.Where(x => x.id_avion == item.id_avion).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Avion.Remove(obj);
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
        public void ActualizarAvion(Avion item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    Avion obj = db.Avion.Where(x => x.id_avion == item.id_avion).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.nombre_avion = item.nombre_avion;
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
