using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Text.RegularExpressions;

namespace ClasesAbstractas
{
    public abstract class Persona
    {

        public enum ENacionalidad
        {
            Argentino, Extranjero
        }

        string _apellido;
        int _dni;
        ENacionalidad _nacionalidad;
        string _nombre;

        public string Apellido
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = ValidarNombreApellido(value);
            }
        }

        public int DNI {
            get
            {
                return this._dni;
            }
            set
            {
                this._dni = ValidarDNI(this.Nacionalidad, value);
            }
        }

        public ENacionalidad Nacionalidad { get; set; }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = ValidarNombreApellido(value);
            }
        }
        public string StringToDni
        {
            get
            {
                return this._dni.ToString();
            }
            set
            {
                this._dni = ValidarDNI(this._nacionalidad, value);
            }
        }


        public Persona() { }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;

        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE COMPLETO: " + this.Apellido + ", " + this.Nombre);
            sb.AppendLine("NACIONALIDAD: " + this.Nacionalidad);
            return sb.ToString();
        }

        int ValidarDNI(ENacionalidad nacionalidad, int dato)
        {
            bool dniValido = false;

            switch (nacionalidad)
            {
                case ENacionalidad.Argentino:
                    if (dato > 1 && dato < 89999999)
                        dniValido = true;
                    break;
                case ENacionalidad.Extranjero:
                    if (dato > 1 && dato < 89999999)
                        dniValido = true;
                    break;
                default:
                    throw new DniInvalidoException("No existe Dni");
             
            }
            if (!dniValido)
                throw new DniInvalidoException();
            return dato;
        }

        int ValidarDNI(ENacionalidad nacionalidad, string dato)
        {
            try
            {
                return ValidarDNI(nacionalidad, int.Parse(dato));
            }
            catch (DniInvalidoException)
            {

                throw;
            }
            catch (FormatException)
            {
                throw;
            }
        }

        string ValidarNombreApellido(string dato)
        {
            //Se establece una expresion regular para validar que el dato ingresado
            //sea coherente para un nombre y apellido (que contenga solo letras, sin numeros ni simbolos)
            Regex reg = new Regex("^[A-Za-z]+$");
            if (reg.IsMatch(dato))
                return dato;
            else
                return "";
        }

    }
}
