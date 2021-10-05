using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuario
    {
        List<Usuario> usuarios;
 
    public RepositorioUsuario()
        {
            usuarios= new List<Usuario>()
            {
                new Usuario{id=1,nombre="Mario",apellido= "Sánchez",direccion= "Carrera 27",telefono= "8945412121"},
                new Usuario{id=2,nombre="Camila",apellido= "Rodriguez",direccion= "Calle 96",telefono= "895656562"},
                new Usuario{id=3,nombre="Maria Carolina",apellido= "Perez",direccion= "Avenida Sur con 14",telefono= "12145454"} 
            };
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return usuarios;
        }
 
        public Usuario GetUsuarioWithId(int id){
            return usuarios.SingleOrDefault(b => b.id == id);
        }

        public Usuario Update(Usuario newUsuario){
            var usuario= usuarios.SingleOrDefault(b => b.id == newUsuario.id);
            if(usuario != null){
                usuario.nombre = newUsuario.nombre;
                usuario.apellido = newUsuario.apellido;
                usuario.direccion = newUsuario.direccion;
                usuario.telefono = newUsuario.telefono;
            }
        return usuario;
        }

        public Usuario Create(Usuario newUsuario)
        {
            if(usuarios.Count > 0){
                newUsuario.id=usuarios.Max(r => r.id) +1; 
            }
            else{
                newUsuario.id = 1; 
            }
           usuarios.Add(newUsuario);
           return newUsuario;
        }

        public Usuario Delete(int id)
        {
            var usuario= usuarios.SingleOrDefault(b => b.id == id);
            usuarios.Remove(usuario);
            return usuario;
        }

    }
}