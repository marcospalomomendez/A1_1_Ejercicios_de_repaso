using System;
using System.Collections.Generic;

// Programa principal
class Program
{
    static void Main()
    {
        // Crear objetos de tipo ProductoDetallado
        ProductoDetallado p1 = new ProductoDetallado("Portátil", "Laptop de 15 pulgadas", 899.99);
        p1["Peso"] = "1.8 Kg";
        p1["RAM"] = "16 GB";
        p1["Procesador"] = "Intel Core i7";

        ProductoDetallado p2 = new ProductoDetallado("Teléfono", "Smartphone gama alta", 699.50);
        p2["Peso"] = "180 g";
        p2["Pantalla"] = "6.5 pulgadas";
        p2["Batería"] = "4500 mAh";

        ProductoDetallado p3 = new ProductoDetallado("Auriculares", "Bluetooth con cancelación de ruido", 129.99);
        p3["Peso"] = "250 g";
        p3["Autonomía"] = "30 h";

        // Mostrar los datos
        p1.Datos();
        p2.Datos();
        p3.Datos();
    }
}