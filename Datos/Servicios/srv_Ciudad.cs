using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;

namespace Datos.Servicios
{
    public class srv_Ciudad
    {
        //listar
        public List<Ciudad> GetListCiudad()
        {
            List<Ciudad> objCiudad = new List<Ciudad>();
            using (var db = new AirFly_Modelo())
            {
                objCiudad = db.Ciudad.ToList();
                return objCiudad;
            }
        }
        //agregar
        public void AgregarCiudad(Ciudad item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    db.Ciudad.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifique que los datos sean correctos");
            }
        }
        //actualizar
        public void ActualizarCiudad(Ciudad item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    Ciudad obj = db.Ciudad.Where(x => x.id_ciudad == item.id_ciudad).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.nombre_ciudad = item.nombre_ciudad;
                        db.SaveChanges();
                    }
                }

            }
            catch
            {
                throw new Exception("Verifique que los datos sean correctos");
            }
        }
        //eliminar
        public void EliminarCiudad(Ciudad item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    Ciudad obj = db.Ciudad.Where(x => x.id_ciudad == item.id_ciudad).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Ciudad.Remove(obj);
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
