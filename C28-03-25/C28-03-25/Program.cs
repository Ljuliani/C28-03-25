
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
//Integrantes: Medina Melina, Puerta Nicolás, ♥Juliani Luciano♥
Console.WriteLine("Menu principal");
Console.WriteLine("1. Cantidad fija de notas");
Console.WriteLine("2. Cantidad indefinida de notas");
Console.WriteLine("3. Cantidad de Aprobados/Desaprobados");
Console.WriteLine("4. Salir");
Console.WriteLine("Seleccione una opcion");
int aprobados = 0;
int desaprobados = 0;
int cantidad;
float nota;

string opcion=Console.ReadLine();

switch (opcion)
{
	case "1":
		F1();
	break;

	case "2":
		F2();

    break;

	case "3":
		
	break;

	case "4":
		Console.WriteLine("Gracias por utilizarnos");
	break;

	default:
		Console.WriteLine("Esta opcion es invalida, porque va en silla de ruedas.");
	break;
}

void  F1()
{


	Console.WriteLine("Cuantas ntoas desea ingresar?");
	cantidad = int.Parse(Console.ReadLine());

	for (int i = 0; i < cantidad; i++)
	{
		Console.WriteLine($"Ingrese la nota del estudiante {i + 1}");
		nota = float.Parse(Console.ReadLine());

		if (nota >= 7)
		{
			Console.WriteLine("Aprobado");
			aprobados++;

		}
		else
		{
			Console.WriteLine("Desaprobados");
			desaprobados++;
		}
	}
}
void F2()
{

	   int cantidad = 0;
	   bool Verificacion = true;

		while (Verificacion)
		{
            
            
            Console.WriteLine("Por favor, digite la nota");
			int nota = int.Parse(Console.ReadLine());
            if (nota >= 7)
            {
            Console.WriteLine("Aprobado");
            aprobados++;
            }
        else
        {
            Console.WriteLine("Desaprobados");
            desaprobados++;
        }
        Console.WriteLine("¿Desea ingresar otra nota? s/n");
			string opcion = Console.ReadLine();
			switch(opcion)
			{
				case "s":
                
				break;
                
				case "n":
				Verificacion = false;
				break;
               
                default:
                    Console.WriteLine("opcion invalida");
                 break;

            }

            
}
        }
    


