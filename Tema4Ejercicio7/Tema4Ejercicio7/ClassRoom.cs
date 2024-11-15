using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Tema3
{
    // NO PUEDE EXISTIR NINGUN CONSOLE AQUÍ
    internal class ClassRoom
    {
        public int[,] grades;
        public string[] StudentsNames;
        Random generador = new Random();
        public enum Subjects
        {
            Pociones,
            Quidditch,
            Criaturas,
            ArtesOscuras
        }
        public int[,] Notas
        {
            get
            {
                return grades;
            }
            set
            {
                this.grades = value;
            }
        }
        public ClassRoom(string[] nombreAlumnos)
        {

            //4-->asignaturas
            for (int i = 0; i < nombreAlumnos.Length; i++)
            {
                nombreAlumnos[i] = nombreAlumnos[i].Trim().ToUpper();
            }

            this.StudentsNames = nombreAlumnos;
            this.Notas = new int[nombreAlumnos.Length, 4];
            FillGrades();


        }
        public ClassRoom(string nombres)
        {
            nombres = nombres.Trim().ToUpper();
            string[] nombresAlumnado = nombres.Split(',');

        }
        // Indexador para poder usarlo como lista /array 
        public int this[int indiceAlumno, int indiceAsignatura]
        {
            get
            {
                return grades[indiceAlumno, indiceAsignatura];
            }
            set
            {
                grades[indiceAlumno, indiceAsignatura] = value;
            }
        }

        private void FillGrades()
        {
            for (int i = 0; i < grades.GetLength(0); i++)
            {
                for (int j = 0; j < grades.GetLength(1); j++)
                {
                    grades[i, j] = RandomGrade();
                }
            }
        }
        private int RandomGrade()
        {
            return generador.Next(0, 11);
        }
        /**ref--> lectura/escritura, ante la duda referencia
         * out-->escritura
         */
        public void MaxMinStudent(int indiceAlumno, out int max, out int min)
        {
            max = grades[indiceAlumno, 0];
            min = grades[indiceAlumno, 0];
            int indiceAsignaturaMax = 0;
            int indiceAsignaturaMin = 0;

            //le ponemos uno ya que iniciamos ya con la primera nota que es en indice 0
            for (int j = 1; j < grades.GetLength(1); j++)
            {

                if (max < grades[indiceAlumno, j])
                {
                    max = grades[indiceAlumno, j];
                    indiceAsignaturaMax = j;
                }
                if (min > grades[indiceAlumno, j])
                {
                    indiceAsignaturaMin = j;

                    min = grades[indiceAlumno, j];
                }

            }

            //muestro la tabla
            //Console.WriteLine($"Las notas máximas y mínimas de {nombreAlumnos[indiceAlumno],-13}");
            //Console.WriteLine(new string('+', 1) + new string('-', 15) + "+" + new string('-', 15) + "+" + new string('-', 15) + "+");
            //Console.WriteLine($"|               |{(Asignaturas)indiceAsignaturaMax,-15}|{(Asignaturas)indiceAsignaturaMin,-15}|");
            //Console.WriteLine(new string('+', 1) + new string('-', 15) + "+" + new string('-', 15) + "+" + new string('-', 15) + "+");
            //Console.Write($"|{nombreAlumnos[indiceAlumno],-15}|");
            //Console.Write($"{notas[indiceAlumno, indiceAsignaturaMax],-15}|{notas[indiceAlumno, indiceAsignaturaMin],-15}|\n");
            //Console.WriteLine(new string('+', 1) + new string('-', 15) + "+" + new string('-', 15) + "+" + new string('-', 15) + "+");



        }


        public double MediaGrades()
        {
            double suma = 0;
           

            //el length devuelve numero total elementos q tienen array
            for (int i = 0; i < grades.GetLength(0); i++) //filas alumnos
            {
                for (int j = 0; j < grades.GetLength(1); j++) //columnas asignaturas
                {
                    suma += grades[i, j]; // Sumo notas de cada asignatura d x alumno
                }
            }
            return (suma / grades.Length); // media

        }

        public double MediaStudent(int indiceAlumno)
        {
            double suma = 0;
            for (int i = 0; i < grades.GetLength(1); i++)
            {
                suma += grades[indiceAlumno, i];
            }
            return (suma / grades.GetLength(1));
        }

        public double MediaSubject(int indiceAsignatura)
        {
            double suma = 0;
            for (int i = 0; i < grades.GetLength(0); i++)
            {
                suma += grades[i, indiceAsignatura];
            }
            return (suma / grades.GetLength(0));

        }
        
        //public void MostrarAsignatura(int indiceAsignatura)
        //{
        //    Console.WriteLine(new string('+', 1) + new string('-', 15) + "+" + new string('-', 15) + "+");
        //    Console.WriteLine($"|               |{(Asignaturas)indiceAsignatura,-15}|");
        //    Console.WriteLine(new string('+', 1) + new string('-', 15) + "+" + new string('-', 15) + "+");
        //    for (int i = 0; i < notas.GetLength(0); i++)
        //    {
        //        Console.Write($"|{nombreAlumnos[i],-15}|");
        //        Console.Write($"{notas[i, indiceAsignatura],-15}|\n");
        //        Console.WriteLine(new string('+', 1) + new string('-', 15) + "+" + new string('-', 15) + "+");


        //    }

        //}
        //public void MostrarTablaCompleta()
        //{
        //    Console.Write($"{" ",-15}");
        //    for (int i = 0; i < 64; i++)
        //    {
        //        Console.Write("-");
        //    }
        //    Console.WriteLine($"\n{" ",-15}|{((Asignaturas)0),-15}|{((Asignaturas)1),-15}|{((Asignaturas)2),-15}|{((Asignaturas)3),-15}|");
        //    for (int i = 0; i < 15; i++)
        //    {
        //        Console.Write("-");
        //    }
        //    for (int i = 0; i < nombreAlumnos.GetLength(0); i++)
        //    {
        //        Console.WriteLine($"\n|{nombreAlumnos[i],-15}");
        //        Console.Write("|");
        //        for (int j = 0; j < 79; j++)
        //        {

        //            Console.Write("-");
        //        }

        //    }

        //}

    }
}
