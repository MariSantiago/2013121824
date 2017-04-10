using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class CentroAtencion
    {
        public int nroCentro { set; get; }
        public String nombreCentro { set; get; }
        public Direccion direccion { set; get; }
        
    }
}
