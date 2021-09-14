using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioParcial01.Entidades
{
    class ClsUsuario
    {
        public String Acceso(Usuario usuario)
        {
            if (usuario.Nombre == "") 
            {
                return "Ingrese aca su nombre: ";
            
            
            }
            else if (usuario.Contraseña == "") 
            {
                return "Ingrese aca su contrasela: ";
                       
            }
            else 
            {
                return "Se inicio secion correctamente puede continuar con el proceso";
            
            
            }


        }

    }
}
