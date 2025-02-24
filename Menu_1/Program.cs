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
            Console.WriteLine("Elige un menu:");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("1 - Menu 1");
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("2 - Menu 2");
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("3 - Salir");

            Console.SetCursorPosition(5, 9);
            Console.Write("Cual es tu opcion? ");

            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Clear();
                    int option1 = 0;
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

                        option1 = int.Parse(Console.ReadLine());

                        switch (option1)
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

                                Console.SetCursorPosition(widthREC + 4, heightREC + 4);
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
                                break;
                        }
                    } while (option1 != 3);

                    break;
                case 2:
                    Console.Clear();
                    int menu2 = 0;
                    do
                    {
                        Console.SetCursorPosition(5, 2);
                        Console.WriteLine("Menu 2");

                        Console.SetCursorPosition(5, 3);
                        Console.WriteLine("Elige una opcion de las siguientes disponibles:");
                        Console.SetCursorPosition(5, 5);
                        Console.WriteLine("1 - Muestre la tabla de senos del 0 al 90");
                        Console.SetCursorPosition(5, 6);
                        Console.WriteLine("2 - Muestre la tabla de los cosenos del 0 al 90");
                        Console.SetCursorPosition(5, 7);
                        Console.WriteLine("3 - Calcular la hipotenusa de un triángulo rectángulo");
                        Console.SetCursorPosition(5, 8);
                        Console.WriteLine("4 - Calculos con 2 puntos de una recta ");
                        Console.SetCursorPosition(5, 9);
                        Console.WriteLine("5 - Trayectoria de un proyectil de acuerdo al lanzamiento parabólico de un proyectil.");
                        Console.SetCursorPosition(5, 10);
                        Console.WriteLine("6 - Menu Principal \n");
                        Console.SetCursorPosition(5, 12);
                        Console.Write("Cual es tu opcion? ");

                        menu2 = int.Parse(Console.ReadLine());

                        switch (menu2)
                        {
                            case 1:
                                //Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Clear();
                                Console.WriteLine("        Tabla de Senos \n");
                                Console.WriteLine("     A             Seno");
                                Console.WriteLine("  -------------------------");

                                for (int i = 0; i <= 90; i++)
                                {
                                    double angulo2 = i;
                                    double seno = Math.Sin(angulo2 * Math.PI / 180); // Convertir grados a radianes
                                    Console.WriteLine($"{angulo2,5}°           {seno,8:F4}");
                                }

                                Console.WriteLine("\n   Presione cualquier tecla para salir... ");
                                Console.ReadKey();  // Espera que el usuario presione una tecla

                                Console.Clear();  // Limpia la pantalla antes de salir
                                break;

                            case 2:
                                //Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Clear();
                                Console.WriteLine("        Tabla de Cosenos \n");
                                Console.WriteLine("     A             Coseno");
                                Console.WriteLine("  -------------------------");

                                for (int i = 0; i <= 90; i++)
                                {
                                    double angulo1 = i;
                                    double coseno = Math.Cos(angulo1 * Math.PI / 180); // Utiliza Math.Cos en lugar de Math.Sin
                                    Console.WriteLine($"{angulo1,5}°           {coseno,8:F4}");
                                }

                                Console.WriteLine("\n   Presione cualquier tecla para regresar al menú... ");
                                Console.ReadKey();
                                Console.ResetColor();
                                Console.Clear();
                                break;

                            case 3:
                                Console.Clear();
                                Console.SetCursorPosition(5, 2);
                                Console.WriteLine("Calcular la hipotenusa de un triángulo rectángulo");
                                Console.SetCursorPosition(5, 4);
                                Console.WriteLine("Ingrese la longitud del primer cateto:");
                                Console.SetCursorPosition(5, 5);
                                double cateto1 = Convert.ToDouble(Console.ReadLine());
                                Console.SetCursorPosition(5, 6);
                                Console.WriteLine("Ingrese la longitud del segundo cateto:");
                                Console.SetCursorPosition(5, 7);
                                double cateto2 = Convert.ToDouble(Console.ReadLine());

                                double hipotenusa = Math.Sqrt(cateto1 * cateto1 + cateto2 * cateto2);
                                double anguloA = Math.Asin(cateto1 / hipotenusa) * 180 / Math.PI;
                                double anguloB = Math.Asin(cateto2 / hipotenusa) * 180 / Math.PI;
                                double anguloC = 90; // Ángulo recto en un triángulo rectángulo

                                Console.WriteLine("\nResultados:");
                                Console.WriteLine($"Longitud de la hipotenusa: {hipotenusa:F4}");
                                Console.WriteLine($"Ángulo A: {anguloA:F2} grados");
                                Console.WriteLine($"Ángulo B: {anguloB:F2} grados");
                                Console.WriteLine($"Ángulo C: {anguloC:F2} grados");
                                Console.ReadKey();
                                Console.Clear();
                                break;

                            case 4:
                                Console.Clear();
                                Console.WriteLine("Calculos con 2 puntos de una recta \n");

                                Console.WriteLine("Ingrese las coordenadas del primer punto:");
                                Console.Write("x': ");
                                double x1 = Convert.ToDouble(Console.ReadLine());

                                Console.Write("x': ");
                                double y1 = Convert.ToDouble(Console.ReadLine());

                                // Solicitar las coordenadas del segundo punto
                                Console.WriteLine("\nIngrese las coordenadas del segundo punto:");
                                Console.Write("x'': ");
                                double x2 = Convert.ToDouble(Console.ReadLine());

                                Console.Write("y'': ");
                                double y2 = Convert.ToDouble(Console.ReadLine());

                                // Calcular la pendiente (m)
                                double pendiente = (y2 - y1) / (x2 - x1);

                                // Calcular el ángulo de inclinación (θ) en radianes
                                double angulo = Math.Atan(pendiente);

                                // Convertir el ángulo a grados
                                double anguloGrados = angulo * (180 / Math.PI);

                                // Calcular las coordenadas del punto medio
                                double xMedio = (x1 + x2) / 2;
                                double yMedio = (y1 + y2) / 2;

                                // Mostrar resultados
                                Console.WriteLine("\nPendiente: " + pendiente);
                                Console.WriteLine("Ángulo de inclinación (en grados): " + anguloGrados);
                                Console.WriteLine("Coordenadas del punto medio: (" + xMedio + ", " + yMedio + ")");
                                Console.ReadKey();
                                Console.Clear();
                                break;

                            case 5:
                                Console.Clear();
                                Console.WriteLine("Trayectoria de un proyectil");

                                Console.Write("Ingrese la velocidad inicial (m/s): ");
                                double velocidad;
                                while (!double.TryParse(Console.ReadLine(), out velocidad) || velocidad <= 0)
                                {
                                    Console.Write("Entrada invalida. Ingrese un valor positivo: ");
                                }

                                Console.Write("Ingrese el ángulo de lanzamiento (grados): ");
                                while (!double.TryParse(Console.ReadLine(), out angulo) || angulo < 0 || angulo > 90)
                                {
                                    Console.Write("Entrada invalida. Ingrese un ángulo entre 0 y 90 grados: ");
                                }

                                const double g = 9.81;
                                double anguloRad = angulo * Math.PI / 180.0;
                                double velocidadX = velocidad * Math.Cos(anguloRad);
                                double velocidadY = velocidad * Math.Sin(anguloRad);
                                double tiempoVuelo = (2 * velocidadY) / g;
                                double alturaMaxima = Math.Pow(velocidadY, 2) / (2 * g);
                                double distanciaMaxima = velocidadX * tiempoVuelo;

                                Console.WriteLine("\nTiempo (s) | X (m) | Y (m) | V (m/s)");
                                Console.WriteLine(new string('-', 35));

                                for (double t = 0; t <= tiempoVuelo; t += 0.1)
                                {
                                    double x = velocidadX * t;
                                    double y = velocidadY * t - 0.5 * g * t * t;
                                    double velocidadFinal = Math.Sqrt(velocidadX * velocidadX + Math.Pow(velocidadY - g * t, 2));

                                    if (y < 0) break;

                                    Console.WriteLine($"{t,8:F2} | {x,5:F2} | {y,5:F2} | {velocidadFinal,6:F2}");
                                }

                                Console.WriteLine($"\nAltura máxima: {alturaMaxima:F2} m");
                                Console.WriteLine($"Distancia máxima: {distanciaMaxima:F2} m");
                                Console.WriteLine($"Tiempo de vuelo: {tiempoVuelo:F2} s");

                                Console.WriteLine("\nPresione cualquier tecla para regresar al menu...");
                                Console.ReadKey();
                                Console.Clear();

                                break;

                            default:
                                Console.Clear();
                                break;
                        }
                    } while (menu2 != 6);

                    break;



                default:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }
        } while (option != 3);

    }
}