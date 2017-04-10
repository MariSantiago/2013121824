using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class Provincia
    {
        public String nombreProvincia { set; get; }
        public Departamento departamento { set; get; }
    }
}
