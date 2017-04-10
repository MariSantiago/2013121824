using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class Plan
    {
        public TipoPlan tipoplan { set; get; }
        public String restricciones { set; get; }

        public Plan(TipoPlan tipoplan, String restricciones)
        {
            this.tipoplan = tipoplan;
            this.restricciones = restricciones;
        }
    }
}
