using System;

class Program
{
    static int aprobados = 0;
    static int desaprobados = 0;

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu principal");
            Console.WriteLine("1. Cantidad fija de notas");
            Console.WriteLine("2. Cantidad indefinida de notas");
            Console.WriteLine("3. Cantidad de Aprobados/Desaprobados");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Seleccione una opción:");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    F1();
                    break;

                case "2":
                    F2();
                    break;

                case "3":
                    F3();
                    break;

                case "4":
                    Console.WriteLine("Gracias por utilizarnos");
                    return;

                default:
                    Console.Clear();
                    Console.WriteLine("Esta opción no es válida. Por favor, intente de nuevo.");
                    Console.WriteLine("Presione cualquier tecla para continuar.");
                    Console.ReadKey();
                    break;
            }
        }
    }
 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    static void F1()
    {
        int cantidad = ValidarCantidad();
        for (int i = 0; i < cantidad; i++)
        {
            float nota = ValidarNota(i);
            CalificarNota(nota);
        }
    }
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    static void F2()
    {
        while (true)
        {
            float nota = ValidarNota(-1); // No necesitamos un índice aquí
            CalificarNota(nota);

            if (!Advertencia("¿Desea ingresar otra nota? (S/N)"))
                break;
        }
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    static void F3()
    {
        if (aprobados == 0 && desaprobados == 0)
        {
            Console.WriteLine("No hay notas para mostrar.");
        }
        else
        {
            Console.WriteLine("--- Resumen de notas ---");
            Console.WriteLine("Total de aprobados: " + aprobados);
            Console.WriteLine("Total de reprobados: " + desaprobados);
        }

        Console.WriteLine("Presione cualquier tecla para continuar.");
        Console.ReadKey();
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    static void CalificarNota(float nota)
    {
        if (nota >= 7)
        {
            Console.WriteLine("Aprobado");
            aprobados++;
        }
        else
        {
            Console.WriteLine("Reprobado");
            desaprobados++;
        }
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    static int ValidarCantidad()
    {
        int cantidad;
        bool cantidadValidada;
        do
        {
            Console.Clear();
            Console.WriteLine("¿Cuántas notas desea ingresar?");
            cantidadValidada = int.TryParse(Console.ReadLine(), out cantidad) && cantidad > 0;

            if (!cantidadValidada)
            {
                Console.WriteLine("Ingrese una cantidad numérica mayor a cero.");
                Console.WriteLine("Presione cualquier tecla para intentar de nuevo.");
                Console.ReadKey();
            }

        } while (!cantidadValidada);

        return cantidad;
    }
 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    static float ValidarNota(int i)
    {
        float nota;
        bool notaValidada;
        do
        {
            Console.Clear();
            if (i >= 0)
                Console.WriteLine($"Ingrese la nota del estudiante {i + 1}:");
            else
                Console.WriteLine("Ingrese la nota del alumno que desea:");

            notaValidada = float.TryParse(Console.ReadLine(), out nota) & nota >= 0 & nota <= 10;

            if (!notaValidada)
            {
                Console.WriteLine("Ingrese una nota válida entre 0 y 10.");
                Console.WriteLine("Presione cualquier tecla para intentar de nuevo.");
                Console.ReadKey();
            }

        } while (!notaValidada);

        return nota;
    }
 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    static bool Advertencia(string mensaje)
    {
        Console.WriteLine(mensaje);
        string respuesta = Console.ReadLine()?.ToUpper();

        if (respuesta == "S")
        {
            return true;
        }
        else if (respuesta == "N")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Entrada no válida. Inténtelo de nuevo.");
            return Advertencia(mensaje);
        }
    }
}
