using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoCiclo3.App.Dominio{

    public class Usuario{
        public int id { get; set; }
        [Required, StringLength(50)]
        public string nombre { get; set; }
        public string apellido { get; set;}
        public string direccion { get; set; }
        public string telefono { get; set; }
    }
}