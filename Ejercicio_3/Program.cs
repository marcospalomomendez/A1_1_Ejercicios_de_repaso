using System;
/*
    Edad en meses
    Pide la edad del usuario y calcula cuántos meses ha vivido.
    Muestra el resultado en consola.
 */
class Program
{
    static void Main(string[] args)
    {
        // Pedir al usuario su edad en años
        Console.Write("Dime tu edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());
        // Calcular y mostrar su edad en meses
        int edadEnMeses = edad * 12;
        Console.WriteLine($"Has vivido aproximadamente {edadEnMeses} meses.");
    }
}
