using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    sealed class Alumno : Universitario
    {

        public enum ECLases
        {
            Programacion,Laboratorio,Legislacion,SPD
        }

        public enum EEstadoCuenta
        {
            AlDia,Deudor,Becado
        }

        ECLases _claseQueToma;
        EEstadoCuenta _estadoCuenta;

        public Alumno() { }

        public Alumno(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad, ECLases claseQueToma)
            :base(legajo,nombre,apellido,dni,nacionalidad)
        {
            this._claseQueToma = claseQueToma;
        }

        public Alumno(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad, ECLases claseQueToma, EEstadoCuenta estadoCuenta)
          : base(legajo, nombre, apellido, dni, nacionalidad)
        {
            this._claseQueToma = claseQueToma;
            this._estadoCuenta = estadoCuenta;
        }

        
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos() + "\n");
            sb.AppendLine("ESTADO DE CUENTA " + this._estadoCuenta);
            return sb.ToString();
        }

        protected override string ParticipaEnClase()
        {
            return "TOMA CLASES DE " + this._claseQueToma;
        }

        public static bool operator ==(Alumno a , ECLases clase)
        {
            return (a._claseQueToma == clase && a._estadoCuenta != EEstadoCuenta.Deudor);
        }

        public static bool operator !=(Alumno a, ECLases clase)
        {
            return !(a._claseQueToma == clase);
        }

    }
}
