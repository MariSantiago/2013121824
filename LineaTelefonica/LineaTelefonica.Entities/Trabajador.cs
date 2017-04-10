using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class Trabajador
    {
        public TipoTrabajador tipotrabajador { set; get; }
        public String nombres { set; get; }
        public String apellidos { set; get; }
        public String login { set; get; }
        public String password { set; get; }

        public Trabajador(TipoTrabajador tipotrabajador, String nombres, String apellidos, String login, String password)
        {
            this.tipotrabajador = tipotrabajador;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.login = login;
            this.password = password;
        }

    }
}
