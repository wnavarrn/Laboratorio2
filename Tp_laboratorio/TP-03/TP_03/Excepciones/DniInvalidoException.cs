using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException: Exception
    {
        const string mensajeBase = "La nacionalidad no se condice con el nro de DNI";

        public DniInvalidoException() 
            : base(mensajeBase)
        { }

        public DniInvalidoException(Exception e) 
            : base(mensajeBase , e)
        { }

        public DniInvalidoException(string message) 
            : base(mensajeBase + message)
        { }

        public DniInvalidoException(string message, Exception e) 
            : base(mensajeBase + mensajeBase, e)
        { }
    }
}
