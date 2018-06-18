using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;
using Datos.BO;

namespace Datos.Servicios
{
    public class srv_Usuarios
    {
        //list
        private AirFly_Modelo modeloUsuario;
        public List<Usuarios_BO> GetListaUsuario()
        {
            modeloUsuario = new AirFly_Modelo();
            var selecUsuario = (from us in modeloUsuario.Usuario
                                join per in modeloUsuario.Perfil on us.id_perfil equals per.id_perfil

                                select new Usuarios_BO
                                {
                                    id_usuario = us.id_usuario,
                                    nombre_usuario = us.nombre_usuario,
                                    apellidopat_usuario = us.apellidopat_usuario,
                                    apellidomat_usuario = us.apellidomat_usuario,
                                    correo_usuario = us.correo_usuario,
                                    contraseña_usuario = us.contraseña_usuario,
                                    nombre_perfil = per.nombre_perfil,
                              }).ToList();
            return selecUsuario;
        }
        //add
        public void AgregarUsuario(Usuario item)
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
