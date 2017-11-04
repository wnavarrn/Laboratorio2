using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    sealed class Profesor : Universitario
    {
        Queue<Alumno.ECLases> _clasesDelDia;
        Random _ramdom;

        private Profesor()
        {

        }

        protected override string ParticipaEnClase()
        {
            throw new NotImplementedException();
        }

        void _ramdomClase()
        {
            Random r = new Random();
        }
    }
}
