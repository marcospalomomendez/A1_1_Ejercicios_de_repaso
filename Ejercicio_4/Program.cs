using System;
/*
    Mayor de dos números
    Pide dos números y muestra cuál es mayor.
    Si son iguales, muestra un mensaje “Los números son iguales”.
 */
class Program
{
    static void Main(string[] args)
    {
        // Pedir al usuario dos números
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Comparar los dos números y decir cual es mayor y en el caso que sean iguales dice      //que son iguales
        if (num1 > num2)
        {
            Console.WriteLine($"El número mayor es: {num1}.");
        }
        else if (num2 > num1)
        {
            Console.WriteLine($"El número mayor es: {num2}.");

        }
        else
        {
            Console.WriteLine("Los números son iguales.");
        }
    }
}
