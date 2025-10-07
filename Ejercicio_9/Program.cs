using System;
/*
    Compra
    En Main(), pide al usuario 3 productos con sus precios.
    Calcula el total de la compra.
    Bonus: hazlo sin duplicar la clase Producto, es decir, reutilizando el código de esta clase que has desarrollado para el ejercicio 8. 
*/

class Program
{
    static void Main(string[] args)
    {
        double total = 0;
        Producto[] productos = new Producto[3];

        // Bucle para pedir datos de los 3 productos
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Ingrese los datos del producto #{i + 1}:");

            // Leer nombre
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            // Leer descripción
            Console.Write("Descripción: ");
            string descripcion = Console.ReadLine();

            // Leer y validar precio
            Console.Write("Precio: ");
            double precio;
            while (!double.TryParse(Console.ReadLine(), out precio) || precio < 0)
            {
                Console.Write("Por favor, ingrese un precio válido: ");
            }
            Console.WriteLine();

            // Crear el producto y guardarlo en el arreglo
            productos[i] = new Producto(nombre, descripcion, precio);

            // Sumar el precio al total
            total += precio;
        }
        // Mostrar todos los productos ingresados
        Console.WriteLine("Productos ingresados:\n");

        foreach (Producto producto in productos)
        {
            producto.Datos();
            Console.WriteLine();
        }

        // Mostrar el total de la compra
        Console.WriteLine($"Total de la compra: {total}");
    }
}
