using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;

namespace Datos.Servicios
{
    public class srv_Tarjeta
    {
        //list
        public List<Tarjeta> GetListTarjeta()
        {
            List<Tarjeta> objTarjeta = new List<Tarjeta>();
            using (var db = new AirFly_Modelo())
            {
                objTarjeta = db.Tarjeta.ToList();
                return objTarjeta;
            }
        }
        //add
        public void AgregarTarjeta(Tarjeta item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    db.Tarjeta.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifique que los datos sean correctos");
            }
        }
        //delete
        public void EliminarTarjeta(Tarjeta item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    Tarjeta obj = db.Tarjeta.Where(x => x.id_tarjeta == item.id_tarjeta).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Tarjeta.Remove(obj);
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
        public void ActualizarTarjeta(Tarjeta item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    Tarjeta obj = db.Tarjeta.Where(x => x.id_tarjeta == item.id_tarjeta).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.nombre_tarjeta = item.nombre_tarjeta;
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
