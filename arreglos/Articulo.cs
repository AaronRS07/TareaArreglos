using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace arreglos
{
    internal class Articulo
    {

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string Bodega { get; set; }

        public Articulo(string codigo, string nombre, decimal precio, int cantidad, string bodega)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
            Bodega = bodega;
        }

        public override string ToString()
        {
            return $"Código: {Codigo}, Nombre: {Nombre}, Precio: {Precio}, Cantidad: {Cantidad}, Bodega: {Bodega}";
        }
    }

    class Inventario
    {
        private List<Articulo> articulos = new List<Articulo>();

        public void IngresarArticulo()
        {
            Console.Write("Código: ");
            string codigo = Console.ReadLine();
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Precio: ");
            decimal precio = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Cantidad: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bodega: ");
            string bodega = Console.ReadLine();

            Articulo articulo = new Articulo(codigo, nombre, precio, cantidad, bodega);
            articulos.Add(articulo);
            Console.WriteLine("Artículo ingresado correctamente.");
        }

        public void ModificarArticulo()
        {
            Console.Write("Ingrese el código del artículo a modificar: ");
            string codigo = Console.ReadLine();

            Articulo articulo = articulos.Find(a => a.Codigo == codigo);

            if (articulo != null)
            {
                Console.Write("Nuevo nombre: ");
                articulo.Nombre = Console.ReadLine();
                Console.Write("Nuevo precio: ");
                articulo.Precio = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Nueva cantidad: ");
                articulo.Cantidad = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nueva bodega: ");
                articulo.Bodega = Console.ReadLine();

                Console.WriteLine("Artículo modificado correctamente.");
            }
            else
            {
                Console.WriteLine("Artículo no encontrado.");
            }
        }

        public void BorrarArticulo()
        {
            Console.Write("Ingrese el código del artículo a borrar: ");
            string codigo = Console.ReadLine();

            Articulo articulo = articulos.Find(a => a.Codigo == codigo);

            if (articulo != null)
            {
                articulos.Remove(articulo);
                Console.WriteLine("Artículo eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Artículo no encontrado.");
            }
        }

        public void ConsultarArticulo()
        {
            Console.WriteLine("Lista de artículos:");
            foreach (var articulo in articulos)
            {
                Console.WriteLine(articulo);
            }
        }

        public void BuscarArticulo()
        {
            Console.WriteLine("Buscar por:");
            Console.WriteLine("1. Código");
            Console.WriteLine("2. Nombre");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese el código: ");
                string codigo = Console.ReadLine();
                Articulo articulo = articulos.Find(a => a.Codigo == codigo);

                if (articulo != null)
                {
                    Console.WriteLine(articulo);
                }
                else
                {
                    Console.WriteLine("Artículo no encontrado.");
                }
            }
            else if (opcion == 2)
            {
                Console.Write("Ingrese el nombre: ");
                string nombre = Console.ReadLine();
                Articulo articulo = articulos.Find(a => a.Nombre == nombre);

                if (articulo != null)
                {
                    Console.WriteLine(articulo);
                }
                else
                {
                    Console.WriteLine("Artículo no encontrado.");
                }
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }
        }
    }

  

}
