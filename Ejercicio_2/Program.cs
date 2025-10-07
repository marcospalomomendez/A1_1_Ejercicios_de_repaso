using System;
/*
    Saludo personalizado
    Pide al usuario su nombre y muestra un mensaje: “Hola, [nombre], bienvenido al programa”.
 */
class Program
{
    static void Main(string[] args)
    {
        // Pedir al usuario su nombre
        Console.Write("Dime tu nombre: ");
        String nombre = Console.ReadLine();
        // Mostrar el nombre del usuario
        Console.WriteLine($"Hola, {nombre}, bienvenido al programa.");
    }
}
