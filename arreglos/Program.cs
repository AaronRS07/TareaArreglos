using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();
            int opcion;

            do
            {
                Console.WriteLine("\nSistema de Gestión de Inventarios");
                Console.WriteLine("1. Ingresar artículo");
                Console.WriteLine("2. Modificar artículo");
                Console.WriteLine("3. Borrar artículo");
                Console.WriteLine("4. Consultar artículos");
                Console.WriteLine("5. Buscar artículo");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        inventario.IngresarArticulo();
                        break;
                    case 2:
                        inventario.ModificarArticulo();
                        break;
                    case 3:
                        inventario.BorrarArticulo();
                        break;
                    case 4:
                        inventario.ConsultarArticulo();
                        break;
                    case 5:
                        inventario.BuscarArticulo();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            } while (opcion != 6);
        }
    }
}

