using System;
/*
    Número par o impar
    Pide un número y muestra si es par o impar usando el operador módulo %.
 */
class Program
{
    static void Main(string[] args)
    {
        // Pedir un número
        Console.Write("Ingrese un número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        // Calcular y mostrar si es par o impar con el operado %
        if (num1 % 2 == 0)
        {
            Console.WriteLine($"El número {num1} es par.");
        }
        else
        {
            Console.WriteLine($"El número {num1} es impar.");
        }
    }
}
