using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        int option = 0;
        do
        {
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Menu Principal");
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("Elige una de las Opciones:");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("1 - Rectangulos");
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("2 - Espiral");
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("3 - Salir");

            Console.SetCursorPosition(5, 9);
            Console.Write("Cual es tu opcion? ");

            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Clear();
                    Console.SetCursorPosition(5, 2);
                    Console.WriteLine("Rectangulos");

                    Console.CursorVisible = false;

                    int startXREC = 40; // Coordenada X inicial del primer rectángulo
                    int startYREC = 15;  // Coordenada Y inicial del primer rectángulo

                    int widthREC = 3; // Ancho inicial
                    int heightREC = 1; // Altura inicial

                    ConsoleColor[] colors = { ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.White };

                    int colorIndex = 0;

                    while (widthREC <= 50 && heightREC <= 52) // Ajusta los límites según sea necesario
                    {
                        int iREC = startXREC - widthREC / 2;
                        int jREC = startYREC - heightREC / 2;

                        Console.ForegroundColor = colors[colorIndex % colors.Length];

                        for (int x = 0; x < widthREC; x++)
                        {
                            System.Threading.Thread.Sleep(25);
                            Console.SetCursorPosition(iREC + x, jREC);
                            Console.WriteLine("*");
                        }

                        for (int y = 0; y < heightREC; y++)
                        {
                            System.Threading.Thread.Sleep(25);
                            Console.SetCursorPosition(iREC + widthREC - 1, jREC + y);
                            Console.WriteLine("*");
                        }

                        for (int x = widthREC - 1; x >= 0; x--)
                        {
                            System.Threading.Thread.Sleep(25);
                            Console.SetCursorPosition(iREC + x, jREC + heightREC - 1);
                            Console.WriteLine("*");
                        }

                        for (int y = heightREC - 1; y >= 0; y--)
                        {
                            System.Threading.Thread.Sleep(25);
                            Console.SetCursorPosition(iREC, jREC + y);
                            Console.WriteLine("*");
                        }

                        widthREC += 10; // Incremento mayor para separación
                        heightREC += 4; // Incremento mayor para separación

                        colorIndex++;
                    }

                    Console.SetCursorPosition(widthREC+4, heightREC+4);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n   Presione cuaquier tecla para regresar al menu... ");
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;

                case 2:
                    Console.Clear();
                    Console.SetCursorPosition(5, 2);
                    Console.WriteLine("Espiral");

                    Console.CursorVisible = false;

                    int i = 50;
                    int j = 15;

                    int width = 5; // Ancho inicial
                    int height = 2; // Altura inicial

                    do
                    {
                        int x = 0;
                        while (x < width)
                        {
                            System.Threading.Thread.Sleep(25);
                            Console.ForegroundColor = (ConsoleColor)(new[] { 10, 14, 9, 12, 15 }[x % 5]);
                            Console.SetCursorPosition(i, j);
                            Console.WriteLine("*");
                            i--;
                            x++;
                        }

                        width += 5;

                        int y = 0;
                        while (y < height)
                        {
                            System.Threading.Thread.Sleep(25);
                            Console.ForegroundColor = (ConsoleColor)(new[] { 15, 10, 14, 9, 12 }[y % 5]);
                            Console.SetCursorPosition(i, j);
                            Console.WriteLine("*");
                            j--;
                            y++;
                        }

                        height += 2;

                        x = 0;
                        while (x < width)
                        {
                            System.Threading.Thread.Sleep(25);
                            Console.ForegroundColor = (ConsoleColor)(new[] { 10, 14, 9, 12, 15 }[x % 5]);
                            Console.SetCursorPosition(i, j);
                            Console.WriteLine("*");
                            i++;
                            x++;
                        }

                        width += 5;

                        y = 0;
                        while (y < height)
                        {
                            System.Threading.Thread.Sleep(25);
                            Console.ForegroundColor = (ConsoleColor)(new[] { 15, 10, 14, 9, 12 }[y % 5]);
                            Console.SetCursorPosition(i, j);
                            Console.WriteLine("*");
                            j++;
                            y++;
                        }

                        height += 2;

                    } while (width <= 50 && height <= 52); // Ajusta los límites según sea necesario


                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n   Presione cuaquier tecla para regresar al menu... ");
                    Console.ReadKey();
                    Console.Clear();
                    break;

           

                default:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }
        } while (option != 3);

    }
}