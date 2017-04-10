using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class Evaluacion
    {
        public LineaTelefonica lineaTelefonica { set; get; }
        public EquipoCelular equipo{set;get;}
        public Plan plan { set; get; }
        public Trabajador trabajador { set;get; }
        public TipoEvaluacion tipoevaluacion { set; get; }
        public EstadoEvaluacion estado{set;get;}
        public Cliente cliente{set;get;}
        public DateTime fechaEvaluacion { set; get; }

        public void imprimir()
        {

        }

    }
}
