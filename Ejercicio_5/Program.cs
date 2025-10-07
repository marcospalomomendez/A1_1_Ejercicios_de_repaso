using System;
/*
    Aprobado o suspendido
    Pide una nota y muestra “Aprobado” si es ≥ 5 o “Suspendido” si es < 5.
 */
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Dime tu nota: ");
        double nota = Convert.ToDouble(Console.ReadLine());
        // Calcular y mostrar si ha aprobado (nota >= 5) o suspendido (nota < 5)
        if (nota >= 5)
        {
            Console.WriteLine($"Has aprobado con un: {nota}.");
        }
        else
        {
            Console.WriteLine($"Has suspendido con un: {nota}.");
        }
    }
}
