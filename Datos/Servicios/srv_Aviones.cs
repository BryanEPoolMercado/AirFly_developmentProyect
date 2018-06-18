using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;
using Datos.BO;

namespace Datos.Servicios
{
    public class srv_Aviones
    {
        //list
        private AirFly_Modelo modeloavion;

        public List<Avion_BO> GetListaAvion()
        {
            modeloavion = new AirFly_Modelo();
            var selectavion = (from avi in modeloavion.Avion
                               join aer in modeloavion.Aerolinea on avi.id_aerolinea equals aer.id_aerolinea join sec in modeloavion.Secciones on avi.id_secciones equals sec.id_secciones

                               select new Avion_BO
                               {
                                   id_avion = avi.id_avion,
                                   nombre_avion = avi.nombre_avion,
                                   numfila_avion = avi.numfila_avion,
                                   numcolumna_avion = avi.numcolumna_avion,
                                   nombre_aerolinea = aer.nombre_aerolinea,
                                   nombre_seccion = sec.nombre_seccion,
                               }).ToList();
            return selectavion;
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
