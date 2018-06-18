using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;

namespace Datos.Servicios
{
    public class srv_Moneda
    {
        //list
        public List<Moneda> GetListMoneda()
        {
            List<Moneda> objMoneda = new List<Moneda>();
            using (var db = new AirFly_Modelo())
            {
                objMoneda = db.Moneda.ToList();
                return objMoneda;
            }
        }
        //add
        public void AgregarMoneda(Moneda item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    db.Moneda.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifique que los datos sean correctos");
            }
        }
        //delete
        public void EliminarMoneda(Moneda item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    Moneda obj = db.Moneda.Where(x => x.id_moneda == item.id_moneda).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Moneda.Remove(obj);
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
        public void ActualizarMoneda(Moneda item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    Moneda obj = db.Moneda.Where(x => x.id_moneda == item.id_moneda).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.nombre_moneda = item.nombre_moneda;
                        obj.valor_moneda = item.valor_moneda;
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
