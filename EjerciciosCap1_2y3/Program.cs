﻿using System;

namespace EjerciciosCap1_2y3
{
    class Tarea1
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
        }
        static void MenuPrincipal()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Hecho por: Jose Luis Burgos Hernandez - 2015-0565");
            Console.WriteLine("-------------------------------------------------\n");
            Console.WriteLine("========================");
            Console.WriteLine("     MENU PRINCIPAL");
            Console.WriteLine("========================");
            Console.WriteLine("\nEjercicios del Libro");
            Console.WriteLine("--------------------");
            Console.WriteLine("1) Capitulo 1");
            Console.WriteLine("2) Capitulo 2");
            Console.WriteLine("3) Capitulo 3");
            Console.WriteLine("\n4) Salir");
            Console.WriteLine("========================");
            Console.Write("\nDigite una opcion: ");
            int Capitulos;
            Capitulos = int.Parse(Console.ReadLine());
            Console.WriteLine("==========================");

            switch (Capitulos)
            {
                case 1:
                    Console.Clear();
                    Cap1();
                    Console.Write("\nPresione cualquier tecla para volver al menu principal... ");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Cap2();
                    Console.Write("\nPresione cualquier tecla para volver al menu principal... ");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Cap3();
                    Console.Write("\nPresione cualquier tecla para volver al menu principal... ");
                    Console.ReadKey();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Write("\n\n***Error*** Debes digitar una opcion del 1 al 4.");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal();
                break;
            }
            Console.Clear();
            MenuPrincipal();
        }
        static void Cap1()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Capitulo 1:");
            Console.WriteLine("---------------");
            Console.WriteLine("1) Ejercicio #1");
            Console.WriteLine("2) Ejercicio #5");
            Console.WriteLine("\n3) Volver al Menu Principal");
            Console.WriteLine("==============================");
            Console.Write("\nDigite una opcion: ");
            int EjerciciosCap1;
            EjerciciosCap1 = int.Parse(Console.ReadLine());
            Console.WriteLine("==============================");

            switch (EjerciciosCap1)
            {
                case 1:
                    //=================================[EJERCICIO #1]=================================
                    Console.Clear();
                    Console.WriteLine("_______________________[EJERCICIO #1]______________________");
                    Console.WriteLine("Programa que imprime mi nombre en la ventana de la consola.");
                    Console.WriteLine("-----------------------------------------------------------\n");
                    Console.WriteLine("Mi nombre es:\n");
                    Console.WriteLine("José Luis Burgos Hernández");
                    Console.WriteLine("-----------------------------------------------------------");
                break;
                case 2:
                    //=================================[EJERCICIO #5]=================================
                    Console.Clear();
                    Console.WriteLine("__________________[EJERCICIO #5]__________________");
                    Console.WriteLine("Agrega más mensajes a la aplicación que ha creado.");
                    Console.WriteLine("--------------------------------------------------\n");
                    Console.WriteLine("Hola,");
                    Console.WriteLine("Estoy añadiendo");
                    Console.WriteLine("Mas mensajes");
                    Console.WriteLine("xD");
                    Console.WriteLine("--------------------------------------------------");
               break;
               case 3:
               break;
                default:
                    Console.Write("\n\n***Error*** Debes digitar una opcion del 1 al 3.");
                    Console.ReadKey();
                    Console.Clear();
                    Cap1();
                    break;
            }
        }
        static void Cap2()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Capitulo 2:");
            Console.WriteLine("---------------");
            Console.WriteLine("1) Ejercicio #1");
            Console.WriteLine("2) Ejercicio #3");
            Console.WriteLine("3) Ejercicio #4");
            Console.WriteLine("4) Ejercicio #5");
            Console.WriteLine("\n5) Volver al Menu Principal");
            Console.WriteLine("==============================");
            Console.Write("\nDigite una opcion: ");
            int EjerciciosCap2;
            EjerciciosCap2 = int.Parse(Console.ReadLine());
            Console.WriteLine("==============================");

            switch (EjerciciosCap2)
            {
                case 1:
                    //=================================[EJERCICIO #1]=================================
                    Console.Clear();
                    Console.WriteLine("_________________________[EJERCICIO #1]_________________________");
                    Console.WriteLine("Programa que calcula el perímetro de cualquier polígono regular.");
                    Console.WriteLine("----------------------------------------------------------------\n");
                    int NumLados;
                    int LogLados;
                        Console.Write("Digite el Numero de Lados: ");
                    NumLados = int.Parse(Console.ReadLine());
                        Console.Write("\nDigite la Longitud de un Lado: ");
                    LogLados = int.Parse(Console.ReadLine());
                    int perimetro = NumLados * LogLados;
                        Console.WriteLine($"\nEl Perimetro del Poligono es: [{perimetro}]");
                        Console.WriteLine("----------------------------------------------------------------");
                break;
                case 2:
                    //=================================[EJERCICIO #3]=================================
                    Console.Clear();
                    Console.WriteLine("___________________[EJERCICIO #3]____________________");
                    Console.WriteLine("Programa que transforma de grados a radianes.");
                    Console.WriteLine("-----------------------------------------------------\n");
                    int Grados;
                        Console.Write("Digite los Grados: ");
                    Grados = int.Parse(Console.ReadLine());
                    double Radial = (Grados * Math.PI / 180);
                        Console.WriteLine($"\nLa convercion de [{Grados}] Grados a Raldial es: [{Math.Round(Radial, 4)}]");
                        Console.WriteLine("-----------------------------------------------------");
                    break;
                case 3:
                    //=================================[EJERCICIO #4]=================================
                    Console.Clear();
                    Console.WriteLine("__________________________[EJERCICIO #4]__________________________");
                    Console.WriteLine("Programa que transforma de grados Centígrados a grados Fahrenheit.");
                    Console.WriteLine("------------------------------------------------------------------\n");
                    double Centigrados;
                        Console.Write("***Si tiene decimales digite una Coma (,) No un punto (.)***\n\n");
                        Console.Write("Digite los Grados Celsios: ");
                    Centigrados = double.Parse(Console.ReadLine());
                    double Fahren = (Centigrados * 9 / 5) + 32;
                        Console.WriteLine($"\nLa convercion de [{Centigrados} *C] a Fahrenheit es: [{Fahren} *F]");
                        Console.WriteLine("------------------------------------------------------------------");
                    break;
                case 4:
                    //=================================[EJERCICIO #5]=================================
                    Console.Clear();
                    Console.WriteLine("______________________________[EJERCICIO #5]_______________________________");
                    Console.WriteLine("Programa que convierte de Dólares a Euros y pide el tipo de cambio del día.");
                    Console.WriteLine("---------------------------------------------------------------------------\n");
                    double Dolar;
                    double Cambio;
                        Console.Write("***Si tiene decimales digite una Coma (,) No un punto (.)***\n\n");
                        Console.Write("Digite la Cantidad de Dolares: ");
                    Dolar = double.Parse(Console.ReadLine());
                        Console.Write("\nDigite la Trasa de Cambio Actual de (Dolar a Euro): ");
                    Cambio = double.Parse(Console.ReadLine());
                    double Euro = Dolar * Cambio;
                        Console.WriteLine($"\nLa convercion de [{Dolar} US] a Euros es: [{Math.Round(Euro, 2)} EUR]");
                        Console.WriteLine("---------------------------------------------------------------------------");
                    break;
                case 5:
                    break;
                default:
                    Console.Write("\n\n***Error*** Debes digitar una opcion del 1 al 5.");
                    Console.ReadKey();
                    Console.Clear();
                    Cap2();
                    break;
            } 
        }
        static void Cap3()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Capitulo 3:");
            Console.WriteLine("---------------");
            Console.WriteLine("1) Ejercicio #1");
            Console.WriteLine("2) Ejercicio #4");
            Console.WriteLine("\n3) Volver al Menu Principal");
            Console.WriteLine("==============================");
            Console.Write("\nDigite una opcion: ");
            int EjerciciosCap3;
            EjerciciosCap3 = int.Parse(Console.ReadLine());
            Console.WriteLine("==============================");

            switch (EjerciciosCap3)
            {
                case 1:
                    //=================================[EJERCICIO #1]=================================
                    Console.Clear();
                    Console.WriteLine("____________________[EJERCICIO #1]___________________");
                    Console.WriteLine("Programa que pide un numero y dice si es Par o Impar.");
                    Console.WriteLine("-----------------------------------------------------\n");
                    int Num;
                        Console.Write("Digite un numero: ");
                    Num = int.Parse(Console.ReadLine());
                        if (Num % 2 == 0)
                            {
                                Console.Write($"\nEl numero [{Num}] es Par.");
                            }
                        else
                            {
                                Console.Write($"\nEl numero [{Num}] es Impar.");
                            }
                    Console.WriteLine("\n-----------------------------------------------------");
                break;
                case 2:
            //=================================[EJERCICIO #4]=================================
            Console.Clear();
            Console.WriteLine("___________________________________[EJERCICIO #4]___________________________________");
            Console.WriteLine("Programa que le pide un número del 1 al 7 y dice a que dia de la semana corresponde.");
            Console.WriteLine("------------------------------------------------------------------------------------\n");
            int Dia;
            Console.Write("Digite un numero del 1 al 7, Para saber que Dia es: ");
            Dia = int.Parse(Console.ReadLine());
            switch (Dia)
            {
                case 1:
                    Console.WriteLine("\nEl Primer dia de la semana es [Domingo]");
                    break;

                case 2:
                    Console.WriteLine("\nEl Segundo dia de la semana es [Lunes]");
                    break;

                case 3:
                    Console.WriteLine("\nEl Tercer dia de la semana es [Martes]");
                    break;

                case 4:
                    Console.WriteLine("\nEl Cuarto dia de la semana es [Miercoles]");
                    break;

                case 5:
                    Console.WriteLine("\nEl Quinto dia de la semana es [Jueves]");
                    break;

                case 6:
                    Console.WriteLine("\nEl Sexto dia de la semana es [Viernes]");
                    break;

                case 7:
                    Console.WriteLine("\nEl Septimo dia de la semana es [Sabado]");
                    break;

                default:
                    Console.WriteLine("\n***Error*** Debes digitar un numero del 1 al 7.");
                    break;
                    }
            Console.WriteLine("------------------------------------------------------------------------------------");
                    break;
                case 3:
                    break;
                default:
                    Console.Write("\n\n***Error*** Debes digitar una opcion del 1 al 3.");
                    Console.ReadKey();
                    Console.Clear();
                    Cap3();
                    break;
             }       
        }
    }
}