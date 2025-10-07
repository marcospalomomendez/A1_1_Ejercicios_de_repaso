using System;
/*
        Pide al usuario el nombre de un corredor.
        Pide al usuario los tiempos de tres carreras en segundos.
        Crea un método llamado CalcularPromedio que reciba esos tres tiempos y devuelva el tiempo medio.
        Muestra un mensaje en pantalla con el siguiente formato:
        Hola, [nombre], tu tiempo medio es: [promedio] segundos
*/
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el nombre del corredor: ");
        string nombre = Console.ReadLine();

        // Pedir los tres tiempos
        Console.Write("Ingrese el tiempo de la carrera 1 (segundos): ");
        double tiempo1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tiempo de la carrera 2 (segundos): ");
        double tiempo2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tiempo de la carrera 3 (segundos): ");
        double tiempo3 = Convert.ToDouble(Console.ReadLine());

        // Calcular promedio
        double promedio = CalcularPromedio(tiempo1, tiempo2, tiempo3);

        // Mostrar resultado
        Console.WriteLine($"Hola, {nombre}, tu tiempo medio es: {promedio} segundos");
    }
    static double CalcularPromedio(double t1, double t2, double t3)
    {
        return (t1 + t2 + t3) / 3;
    }
}
