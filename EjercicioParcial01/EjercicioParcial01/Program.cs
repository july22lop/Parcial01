using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioParcial01
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre = Console.ReadLine();
            string contraseña = Convert.ToString(Console.ReadLine());

            Usuario cons = new Usuario(nombre, contraseña);
            ClsUsuario clsUsuario = new ClsUsuario();

            Console.WriteLine("Digite su nombre de usuario");
            cons.Nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine(clsUsuario.Acceso(Cons));

            if (clsUsuario.Y == 1) 
            {
                int x = 1;
                while (x == 1) 
                {
                    Console.WriteLine("Ingrese el ID del producto");
                    double id_producto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre del producto");
                    string nombre_producto = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Ingrese la descripcion del producto");
                    string descripcion_producto = Convert.ToString(Console.ReadLine());
                   
                
                }
            
            
            }
        }
    }
}
