using System;

namespace Tarea2Progra2
{
    internal class Estudiante
    {
        static string[] nombre = new string[3];  // variable global
        static float[] notas = new float[3];     // variabl global
        static byte indice = 0;                 // variable global para la posicion del arreglo
        static string continuar = "s";

        private static void CrearEstudiantes()
        {

            do
            {
                Console.WriteLine("Digite el nombre del estudiante ({0}):", (indice + 1));
                nombre[indice] = Console.ReadLine();
                indice++;

                if (indice < Estudiante.nombre.Length)
                {
                    Console.WriteLine("Desea continuar(s/n): ");
                    continuar = Console.ReadLine();
                }
                else
                {
                    continuar = "n";
                }
            } while (!continuar.Equals("n"));
        }

        private static void BuscarEstudiante()
        {
            Console.WriteLine("Digite el nombre:");
            string nombre = Console.ReadLine();

            for (int i = 0; i < Estudiante.nombre.Length; i++)
            {
                if (nombre.Equals(Estudiante.nombre[i]))
                {
                    Console.WriteLine("Estudiante Existe");
                }
            }
        }

        private static void AsignarNota()
        {
            indice = 0;
            do
            {
                Console.WriteLine("Digite la nota del estudiante estudiante ({0}):", (indice + 1));
                notas[indice] = int.Parse(Console.ReadLine());
                indice++;

                if (indice < Estudiante.notas.Length)
                {
                    Console.WriteLine("Desea continuar(s/n): ");
                    continuar = Console.ReadLine();
                }
                else
                {
                    continuar = "n";
                }

            } while (!continuar.Equals("n"));

        }

        private static void Imprimir()
        {
            for (int i = 0; i < Estudiante.nombre.Length; i++)
            {
                Console.WriteLine($"Nombre: {(nombre[i])} / Nota: {(notas[i])}");
            }

        }

        private static void Modificar()
        {
            indice = 0;
            Console.WriteLine("Digite el nombre del estudiante que desea modificar:");
            string nombre = Console.ReadLine();
            Boolean modify = false;

            for (int i = 0; i < Estudiante.nombre.Length; i++)
            {
                if (nombre.Equals(Estudiante.nombre[i]))
                {
                    Console.WriteLine("Escriba el nuevo nombre");
                    string modificado = Console.ReadLine();
                    Estudiante.nombre[i] = modificado;
                    modify = true;
                }

            }
            if (modify == true)
            {
                Console.WriteLine("Se ha modificado el estudiante");
            }
            else
            {
                Console.WriteLine("No se ha encontrado el estudiante");
            }

        }
        private static void Borrar()
        {
            indice = 0;
            Console.WriteLine("Digite el nombre del estudiante que desea borrar:");
            string nombre = Console.ReadLine();
            Boolean delete = false;

            for (int i = 0; i < Estudiante.nombre.Length; i++)
            {
                if (nombre.Equals(Estudiante.nombre[i]))
                {
                    Console.WriteLine($"Se ha borrado la informacion del estudiante {(i + 1)}");
                    Estudiante.nombre[i] = null;
                    Estudiante.notas[i] = 0;
                    delete= true;
                }
            }
            if (delete == false)
            {
                Console.WriteLine("No se ha encontrado el estudiante");
            }
        }
        public static void menu()
        {
            byte opcion = 0;
            do
            {
                Console.WriteLine("1 - Agregar Estudiantes");
                Console.WriteLine("2 - Buscar Estudiante");
                Console.WriteLine("3 - Asignar nota al estudiante");
                Console.WriteLine("4 - Imprimir Estudiante con sus notas");
                Console.WriteLine("5 - Modificar Estudiantes");
                Console.WriteLine("6 - Borrar Estudiante");
                Console.WriteLine("7 - salir");
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CrearEstudiantes();
                        break;
                    case 2:
                        BuscarEstudiante();
                        break;
                    case 3:
                        AsignarNota();
                        break;
                    case 4:
                        Imprimir();
                        break;
                    case 5:
                        Modificar();
                        break;
                    case 6:
                        Borrar();
                        break;
                    default:
                        Console.WriteLine("opcion incorrecta");
                        break;
                }

            } while (opcion != 7); // true

        }


    }
}
