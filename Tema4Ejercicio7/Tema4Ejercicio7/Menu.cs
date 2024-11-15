using System;
using static Ejercicio2Tema3.ClassRoom;

namespace Ejercicio2Tema3
{
    internal class Program
    {
        static ClassRoom aula20;

        // Método para pintar el menú
        public static void MostrarMediaAlumno(int indiceAlumno)
        {
            Console.WriteLine($"La media del alumno {aula20.StudentsNames[indiceAlumno]} es: {aula20.MediaStudent(indiceAlumno):F2}");
        }
        public static void MostrarMediaAsignatura(int indiceAsignatura)
        {
            Console.WriteLine($"La media de la asignatura {(ClassRoom.Subjects)indiceAsignatura} es de {aula20.MediaSubject(indiceAsignatura):F2}");
        }
        public static void MostrarAsignatura(int indiceAsignatura)
        {
            Console.WriteLine(new string('+', 1) + new string('-', 15) + "+" + new string('-', 15) + "+");
            Console.WriteLine($"|               |{(Subjects)indiceAsignatura,-15}|");
            Console.WriteLine(new string('+', 1) + new string('-', 15) + "+" + new string('-', 15) + "+");
            for (int i = 0; i < aula20.grades.GetLength(0); i++)
            {
                Console.Write($"|{aula20.StudentsNames[i],-15}|");
                Console.Write($"{aula20.grades[i, indiceAsignatura],-15}|\n");
                Console.WriteLine(new string('+', 1) + new string('-', 15) + "+" + new string('-', 15) + "+");


            }

        }
        public static void MostrarAlumno(int indiceAlumno)
        {
            GuionTabla();
            Console.WriteLine("|               |    Pociones   |   Quidditch   |   Criaturas   | Artes Oscuras |");
            GuionTabla();
            Console.Write($"|{aula20.StudentsNames[indiceAlumno],-15}|");
            for (int i = 0; i < aula20.grades.GetLength(1); i++)
            {
                Console.Write($"{aula20.grades[indiceAlumno, i],-15}|");
            }
            Console.WriteLine();
            GuionTabla();
        }

        public static void MostrarTablaCompleta()
        {

            // Cabecera de la tabla
            GuionTabla();
            Console.WriteLine("|               |    Pociones   |   Quidditch   |   Criaturas   | Artes Oscuras |");
            GuionTabla();

            // nombres de los alumnos, cn notas
            for (int i = 0; i < aula20.StudentsNames.Length; i++)
            {

                Console.WriteLine($"| {aula20.StudentsNames[i],-13} " +
                    $"| {aula20.grades[i, 0],-13} | {aula20.grades[i, 1],-13} | {aula20.grades[i, 2],-13} | {aula20.grades[i, 3],-13} |");

                // separador
                GuionTabla();
            }

            Console.WriteLine();
        }
        public static void MostrarMinMaxAlumno(int indiceAlumno)
        {
            int max;
            int min;
            aula20.MaxMinStudent(indiceAlumno, out max, out min);
            Console.WriteLine($"La nota mas alta es {max,-1} y la mas baja {min,-1} de {aula20.StudentsNames[indiceAlumno]}\n");
        }
        public static void MostrarMediaNotas()
        {
            Console.WriteLine($"La media de notas de los alumnos es: {aula20.MediaGrades():F2}");
            //controlo F, la cantidad de decimales .
        }
        private static void GuionTabla()
        {
            //creo un string y indicop la cnatida ais ahorto hacer el bucle
            Console.WriteLine(new string('+', 1) + new string('-', 15) + "+" + new string('-', 15) + "+" + new string('-', 15) + "+" + new string('-', 15) + "+" + new string('-', 15) + "+");

        }

        static void pintaMenu(string[] opciones, int opcion)
        {
            string titulo = "---------------------+AULA 20+---------------------";
            Console.Clear();
            Console.WriteLine(titulo);
            for (int i = 0; i < opciones.Length; i++)
            {
                if (i == opcion) // Pinta la opción seleccionada en Video Inverso
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.WriteLine(opciones[i]);
                Console.ResetColor();
            }
        }

        // Método principal para manejar el menú
       //static void Main(string[] args)
       // {
       //     string[] nombreAlumnos = { "Nicole", "Marcos", "Manu", "Adrian", "Cris", "Javi", "Alex", "Ana", "Adrian" };
       //     aula20 = new ClassRoom(nombreAlumnos);

       //     int opcion = 0;
       //     int seleccion = -1;
       //     string[] opciones = {
       //         "1.- Calcular la media de las notas de toda la tabla",
       //         "2.- Media de un alumno",
       //         "3.- Media de una asignatura",
       //         "4.- Nota máxima y mínima de un alumno",
       //         "5.- Visualizar tabla completa",
       //         "6.- Salir"
       //     };

       //     Console.CursorVisible = false;
       //     pintaMenu(opciones, opcion);

       //     do
       //     {
       //         ConsoleKeyInfo tecla = Console.ReadKey(true);
       //         switch (tecla.Key)
       //         {
       //             case ConsoleKey.DownArrow:
       //                 /** se verifica que opcioon sea menor que el valor de opciones.length-1
       //                  * Si esta condición es verdadera --> todavía no has alcanzado el último elemento de la lista, 
       //                  * entonces se ejecutará la parte después del ?
       //                  * si la condicion es verdadera --> opcion es menor que el último índice, entonces incrementas opcion en 1. 
       //                  * Esto significa que te mueves a la siguiente opción del menú.
       //                  * 
       //                  * 
       //                 */
       //                 opcion = opcion < opciones.Length - 1 ? opcion + 1 : opcion;
       //                 break;
       //             case ConsoleKey.UpArrow:
       //                 opcion = opcion > 0 ? opcion - 1 : opcion;
       //                 break;
       //             case ConsoleKey.Enter:
       //                 seleccion = opcion;
       //                 EjecutarSeleccion(seleccion);
       //                 break;
       //         }

       //         pintaMenu(opciones, opcion);
       //     } while (seleccion != opciones.Length - 1);
       // }
       
        // Método para ejecutar la opción seleccionada
        public static void EjecutarSeleccion(int opcion)
        {
            switch (opcion)
            {
                case 0:
                    Console.Clear();
                    MostrarMediaNotas();
                    EsperaTecla();
                    break;
                case 1:
                    Console.Clear();
                    int indiceAlumno = SeleccionAlumno();
                    MostrarMediaAlumno(indiceAlumno);
                    EsperaTecla();
                    break;
                case 2:
                    Console.Clear();
                    //dar elegir la asignatura falta 
                    int indiceAsignatura = SeleccionAsignatura();
                    MostrarMediaAsignatura(indiceAsignatura);
                    EsperaTecla();
                    break;
                case 3:
                    Console.Clear();
                    int alumnoMaxMin = SeleccionAlumno();
                    MostrarMinMaxAlumno(alumnoMaxMin);
                    EsperaTecla();
                    break;
                case 4:
                    Console.Clear();
                    MostrarTablaCompleta();
                    EsperaTecla();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Saliendo...");
                    break;
            }
        }
        public static int SeleccionAlumno()
        {
            int opcionAlumno = 0;
            ConsoleKeyInfo tecla;
            do
            {
                PintarListaAlumno(opcionAlumno);
                tecla = Console.ReadKey(true);
                switch (tecla.Key)
                {
                    case ConsoleKey.DownArrow:
                        opcionAlumno = opcionAlumno < aula20.StudentsNames.Length - 1 ? opcionAlumno + 1 : opcionAlumno;
                        break;
                    case ConsoleKey.UpArrow:
                        opcionAlumno = opcionAlumno > 0 ? opcionAlumno - 1 : opcionAlumno;
                        break;
                    case ConsoleKey.Enter:
                        return opcionAlumno;
                }
            } while (tecla.Key != ConsoleKey.Enter);
            return opcionAlumno;

        }
        public static int SeleccionAsignatura()
        {
            int opcionAsignatura = 0;
            ConsoleKeyInfo tecla;
            do
            {
                PintarListaAsignaturas(opcionAsignatura);
                tecla = Console.ReadKey(true);
                switch (tecla.Key)
                {
                    case ConsoleKey.DownArrow:
                        opcionAsignatura = opcionAsignatura < 3 ? opcionAsignatura + 1 : opcionAsignatura;

                        break;
                    case ConsoleKey.UpArrow:
                        opcionAsignatura = opcionAsignatura > 0 ? opcionAsignatura - 1 : opcionAsignatura;
                        break;
                    case ConsoleKey.Enter:
                        return opcionAsignatura;

                }
            }
            while (tecla.Key != ConsoleKey.Enter);
            return opcionAsignatura;
        }
        public static void PintarListaAsignaturas(int opcionAsignatura)
        {
            String titulo = "Seleccione una asignatura";
            Console.Clear();
            Console.WriteLine(titulo);
            for (int i = 0; i < 4; i++)
            {
                if (i == opcionAsignatura)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Yellow;

                }
                Console.WriteLine((ClassRoom.Subjects)i);
                Console.WriteLine();
                Console.ResetColor();
            }
        }
        // Método para pintar la lista de alumnos y seleccionar uno
        static void PintarListaAlumno(int opcionAlumno)
        {
            string titulo = "Selecciona un Alumno";
            Console.Clear();
            Console.WriteLine(titulo);
            for (int i = 0; i < aula20.StudentsNames.Length; i++)
            {
                if (i == opcionAlumno)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.WriteLine(aula20.StudentsNames[i]);
                Console.ResetColor();



            }
        }

        //para pausar y esperar hasta que se presione una tecla
        static void EsperaTecla()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey(true);
        }
    }
}
