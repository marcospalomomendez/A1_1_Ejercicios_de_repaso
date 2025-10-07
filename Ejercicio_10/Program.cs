using System;
/*
Lista de productos
Guarda varios objetos Productos en un array o en una  lista.
Usa un bucle foreach para mostrar la presentación de todos los productos.
Muestra el precio total de los productos.
Añade el poder meter un descuento del 15%.
Bonus: hazlo sin duplicar la clase Producto, es decir, reutilizando el código de esta clase que has desarrollado para el ejercicio 8.
 */

class Program
{
    static void Main(string[] args)
    {

        List<Producto> productos = new List<Producto>()
        {
            new Producto("Camiseta", "Camiseta de algodón", 15.99),
            new Producto("Pantalón", "Pantalón vaquero azul", 35.50),
            new Producto("Zapatillas", "Deportivas blancas", 49.90)
        };
        foreach (Producto p in productos)
        {
            p.Datos();
        }
        double total = 0;
        foreach (Producto p in productos)
        {
            total += p.Precio;
        }

        Console.WriteLine($"\nPrecio total sin descuento: {total:F2}");

        double descuento = total * 0.15;
        double totalConDescuento = total - descuento;

        Console.WriteLine($"Precio total con 15% de descuento: {totalConDescuento:F2}");
    }
}
