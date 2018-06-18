using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;
using Datos.BO;

namespace Datos.Servicios
{
    public class srv_Ciudad
    {       
        //Listar
        private AirFly_Modelo modeloCiudad;
        public List<Ciudad_BO> GetListaCiudad()
        {
            modeloCiudad = new AirFly_Modelo();
            var selectPais = (from ciu in modeloCiudad.Ciudad
                              join pai in modeloCiudad.Pais on ciu.id_pais equals pai.id_pais

                              select new Ciudad_BO
                              {
                                  id_ciudad = ciu.id_ciudad,
                                  nombre_ciudad = ciu.nombre_ciudad,
                                  nombre_pais = pai.nombre_pais,

                              }).ToList();
            return selectPais;
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
