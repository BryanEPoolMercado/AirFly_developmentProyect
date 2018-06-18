using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;

namespace Datos.Servicios
{
    public class srv_Pais
    {
        //listar
        public List<Pais> GetListPaises()
        {
            List<Pais> objPais = new List<Pais>();
            using (var db = new AirFly_Modelo())
            {
                objPais = db.Pais.ToList();
                return objPais;
            }
        }
        //agregar
        public void AgregarPais(Pais item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    db.Pais.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifique que los datos sean correctos");
            }
        }
        //actualizar
        public void ActualizarPais(Pais item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    Pais obj = db.Pais.Where(x => x.id_pais == item.id_pais).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.nombre_pais = item.nombre_pais;
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
        public void EliminarPais(Pais item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    Pais obj = db.Pais.Where(x => x.id_pais == item.id_pais).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Pais.Remove(obj);
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
