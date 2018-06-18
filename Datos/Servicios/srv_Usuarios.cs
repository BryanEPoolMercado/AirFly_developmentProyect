using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;

namespace Datos.Servicios
{
    public class srv_Usuarios
    {
        //list
        public List<Usuario> GetListUsuario()
        {
            List<Usuario> objusuario = new List<Usuario>();
            using (var db = new AirFly_Modelo())
            {
                objusuario = db.Usuario.ToList();
                return objusuario;
            }
        }
        //add
        public void AddUsuario(Usuario item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    db.Usuario.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifique que los datos sean correctos");
            }
        }
        //delete
        public void EliminarAerolinea(Usuario item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    Usuario obj = db.Usuario.Where(x => x.id_usuario == item.id_usuario).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Usuario.Remove(obj);
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
        public void ActualizUsuario(Usuario item)
        {
            try
            {
                using (var db = new AirFly_Modelo())
                {
                    Usuario obj = db.Usuario.Where(x => x.id_usuario == item.id_usuario).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.nombre_usuario = item.nombre_usuario;
                        obj.apellidopat_usuario = item.apellidopat_usuario;
                        obj.apellidomat_usuario = item.apellidomat_usuario;
                        obj.correo_usuario = item.correo_usuario;
                        obj.contraseña_usuario = item.contraseña_usuario;
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
