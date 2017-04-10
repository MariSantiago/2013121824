using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class AdministradorLinea
    {
        public LineaTelefonica lineatelefonica{set;get;}
        public String DNI;
        public String nombres;
        public String apellidos;
        public Direccion direccion;
        public String correo;
        public String telf_contacto;
    }
}
