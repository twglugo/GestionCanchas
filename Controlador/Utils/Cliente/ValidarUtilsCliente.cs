using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;

namespace Controlador.Utils.Cliente
{
    public class ValidarUtilsCliente()
    {


        ///metodos validadores y parse
        ///
        public int  ParseTextTCedula(string Cedula)
        {
            if ((!int.TryParse(Cedula, out int cedula) ))
            {
                throw new Exception("La cedula debe ser númerica ");
                
            }else if ( cedula <= 0)
            {
                throw new Exception("Debe ser entero, mayor a cero el campo Cedula");
            }
            return cedula;
        
        }

        public string EmptyTextNombre(string Nombre) 
        
        {
            if (!string.IsNullOrWhiteSpace(Nombre))
            {
                return Nombre;
            }
            else
            {
                throw new Exception("No se puede dejar en blanco se debe llenar el campo Nombre");
            }
            
        }

        public int ParseTextTelefono(string Telefono)
        {
            if ((!int.TryParse(Telefono, out int telefono)))
            {
                throw new Exception("El telefono debe ser númerico ");

            }
            else if (telefono <= 0)
            {
                throw new Exception("Debe ser entero, mayor a cero el campo Telefono");
            }
            return telefono;


        }
    }
}
