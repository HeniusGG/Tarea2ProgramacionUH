using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Clase2Programacion2
{
    internal class Program
    {

        static string[] nombre = new string[5]; // variable global
        static float[] notas = new float[5]; // variable global
        static byte indice = 0; // 


        // Esta clase sera sobre los metodos y los procedimientos <3

        // para ordenar el codigo CTRL A Y LUEGO CTRL K+F 

        static void Main(string[] args)
        {

            menu(); // para llamar al procedimiento como el menu etc
            Console.Read();

            Console.Clear();// sirve para limpiar la consola antes de mostrar el menu de nuevo 


        } //end main
          // los procedimientos van fuera del main

        static void estudiantes()
        {
            string continuar = "S";

            do
            {

                Console.WriteLine(" Digite el nombre del estudiante " + (indice + 1));
                nombre[indice] = Console.ReadLine();
                indice++;

                Console.WriteLine("Desea continuar(s/n): ");
                continuar = Console.ReadLine();



            } while (!continuar.Equals("n"));
        }

        static void BuscarEstudiante()
        {
            Console.WriteLine("Digite el nombre:");
            String nombre = Console.ReadLine();

            for (int i = 0; i < Program.nombre.Length; i++)
            {

                if (nombre.Equals(Program.nombre[i])) ;
                {
                    Console.WriteLine("Estudiante Existe ");
                    break;
                }//end if


            }//end for



        }//end BuscarEstudiante


        static void AsignarNotas()
        {
            for (int i = 0; i < indice; i++)
            {
                Console.WriteLine("Digite la nota del estudiante " + nombre[i] + ": ");
                notas[i] = float.Parse(Console.ReadLine());
            }
        }

        static void ImprimirNotas()
        {
            Console.WriteLine("Listado de Estudiantes y sus Notas: ");
            for (int i = 0; i < indice; i++)
            {
                Console.WriteLine("Estudiante: " + nombre[i] + " Nota: " + notas[i]);
            }
        }










        static void menu()
        {
            byte opcion = 0;

            do
            {
                Console.WriteLine("1 - Agregar Estudiantes");
                Console.WriteLine("2 - Buscar Estudiante");

                Console.WriteLine("3 - Asignar otas al estudiante");
                Console.WriteLine("4 - Imprimir Estudiante con sus notas");
                Console.WriteLine("5 -  Salir ");
                Console.WriteLine(" Digite una opcion ");
                opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Agregar Estudiantes");
                        estudiantes();
                        break;
                    case 2:
                        Console.WriteLine("Buscar Estudiante");
                        BuscarEstudiante();
                        break;
                    case 3:
                        Console.WriteLine("Asignar Notas");
                        AsignarNotas();
                        break;
                    case 4:
                        Console.WriteLine("Imprimir Notas");
                        ImprimirNotas();
                        break;
                    case 5:

                        Console.WriteLine("Gracias por utilizar el programa ");
                        break;

                    default:

                        Console.WriteLine("Opcion incorrecta. Digite otra opcion");
                        break;
                }

            } while (opcion != 5);  //FALSE Cuando la opcion sea igual a 4






        }//end menu





    } //end class
} //end namespace
