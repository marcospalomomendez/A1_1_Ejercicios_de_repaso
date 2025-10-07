using System;
/*
    Suma de dos números
    Crea un programa que pida dos números por consola y muestre su suma.
    Bonus: muestra también la resta, multiplicación y división
*/
class Program
{
    static void Main(string[] args)
    {
        // Pedir al usuario su dos números
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        // Calcular la suma, resta y multiplicación
        double suma = num1 + num2;
        double resta = num1 - num2;
        double multiplicacion = num1 * num2;

        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Multiplicación: {multiplicacion}");
        // Comprobar si el número 2 es diferente de 0 para poder hacer la división
        if (num2 != 0)
        {
            double division = num1 / num2;
            Console.WriteLine("División: " + division);
        }
        else
        {
            Console.WriteLine("No se puede dividir por cero.");
        }
    }
}
