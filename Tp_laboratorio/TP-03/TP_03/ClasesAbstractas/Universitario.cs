using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Universitario: Persona
    {
        int _legajo;

        public Universitario()          
        {
        }

        public Universitario(int legajo,string nombre,string apellido, string dni,ENacionalidad nacionalidad) 
            : base(nombre,apellido,dni,nacionalidad)
        {
            this._legajo = legajo;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString() + "\n");
            sb.AppendLine("LEGAJO :" + this._legajo);
            return sb.ToString();
        }

        public static bool operator ==(Universitario un1, Universitario un2)
        {
            return (un1.GetType() == un2.GetType() &&  un1._legajo == un2._legajo || un1.DNI == un2.DNI);
        }

        public static bool operator !=(Universitario un1, Universitario un2)
        {
            return !(un1 == un2);
        }

        protected abstract string ParticipaEnClase();

        /// <summary>
        /// Se valida que el objeto sea del tipo Universitario y se reutiliza la igualdad entre dos Universitarios
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return (obj is Universitario && (Universitario)obj == this);
        }

    }
}
