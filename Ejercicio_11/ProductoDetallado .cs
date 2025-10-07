using System;
using System.Collections.Generic;

class ProductoDetallado : Producto
{
    // Diccionario para las características
    private Dictionary<string, string> caracteristicas = new();

    // Constructor que llama al de la clase base
    public ProductoDetallado(string nombre, string descripcion, double precio)
        : base(nombre, descripcion, precio) { }

    // Propiedad indexada SIN usar operador ternario
    public string this[string clave]
    {
        get
        {
            if (caracteristicas.ContainsKey(clave))
            {
                return caracteristicas[clave];
            }
            else
            {
                return "No definida";
            }
        }
        set
        {
            caracteristicas[clave] = value;
        }
    }

    // Método Datos() sobrescrito
    public override void Datos()
    {
        base.Datos();
        Console.WriteLine("Características:");

        if (caracteristicas.Count == 0)
        {
            Console.WriteLine(" - Sin características adicionales.");
        }
        else
        {
            foreach (var c in caracteristicas)
            {
                Console.WriteLine($" - {c.Key}: {c.Value}");
            }
        }

        Console.WriteLine();
    }
}
