using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class Cliente
    {
        public String Dni { set; get; }
        public String nombres { set; get; }
        public String apellidos { set; get; }
        public String telf_contacto { set; get; }
        public String correo { set; get; }
        public String direccion { set; get; }

        public Cliente(String dni, String nombres, String apellidos, String telf_contacto,String correo,String direccion){
            this.Dni = dni;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.telf_contacto = telf_contacto;
            this.correo = correo;
            this.direccion = direccion;
        }
    }
}
