using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Función principal

            // Solicita al usuario que introduzca el primer número y lo guarda en 'a'
            Console.WriteLine("CALCULADORA Introduzca el primer número: ");
            double a = Convert.ToDouble(Console.ReadLine());

            // Solicita al usuario que introduzca el segundo número y lo guarda en 'b'
            Console.WriteLine("Introduzca el segundo número: ");
            double b = Convert.ToDouble(Console.ReadLine());

            // Presenta al usuario las opciones disponibles para la operación
            Console.WriteLine("Elija una opción:");
            Console.WriteLine("1 - Sumar\n2 - Restar\n3 - Multiplicar\n4 - Dividir");
            int opcion = Convert.ToInt32(Console.ReadLine());

            // Define un delegado 'operacion' que toma dos números y realiza la operación seleccionada por el usuario
            Action<double, double> operacion = opcion switch
            {
                // Para la opción 1, realiza una suma
                1 => (x, y) => Console.WriteLine($"La suma de {x} y {y} es: {x + y}"),
                // Para la opción 2, realiza una resta
                2 => (x, y) => Console.WriteLine($"La resta de {x} y {y} es: {x - y}"),
                // Para la opción 3, realiza una multiplicación
                3 => (x, y) => Console.WriteLine($"La multiplicación de {x} y {y} es: {x * y}"),
                // Para la opción 4, realiza una división
                4 => (x, y) =>
                {
                    if (y == 0)
                    {
                        // Si el segundo número es cero, muestra un mensaje de error
                        Console.WriteLine("No se puede dividir entre cero");
                    }
                    else
                    {
                        // De lo contrario, realiza la división
                        Console.WriteLine($"La división de {x} y {y} es: {x / y}");
                    }
                }
                ,
                // Para cualquier otra opción, muestra un mensaje de error
                _ => (x, y) => Console.WriteLine("Opción inválida.")
            };

            // Llama a la función 'operacion' con los números introducidos por el usuario
            operacion(a, b);

            // Espera a que el usuario presione Enter antes de cerrar la aplicación
            Console.ReadLine();
        }
    }
}
