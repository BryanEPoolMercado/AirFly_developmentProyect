using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;

namespace Datos.Servicios
{
    public class srv_Aerolinea
    {
        //list
        public List<Aerolinea> GetListAerolinea()
        {
            List<Aerolinea> objAerolinea = new List<Aerolinea>();
            using (var db = new AirFly_Modelo())
            {
                objAerolinea = db.Aerolinea.ToList();
                return objAerolinea;
            }
        }
        //add
        public void AgregarAerolinea(Aerolinea item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    db.Aerolinea.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifique que los datos sean correctos");
            }
        }
        //delete
        public void EliminarAerolinea(Aerolinea item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    Aerolinea obj = db.Aerolinea.Where(x => x.id_aerolinea == item.id_aerolinea).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Aerolinea.Remove(obj);
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
        public void ActualizarAerolinea(Aerolinea item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    Aerolinea obj = db.Aerolinea.Where(x => x.id_aerolinea == item.id_aerolinea).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.nombre_aerolinea = item.nombre_aerolinea;
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
