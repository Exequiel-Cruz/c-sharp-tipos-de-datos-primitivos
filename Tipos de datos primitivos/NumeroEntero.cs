using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_de_datos_primitivos
{
    class NumeroEntero
    {
        public static void IniciarPrueba()
        {
            Console.WriteLine("Pruebas con numeros enteros");
            try
            {
                int opcion = -1;
                do
                {
                    Console.WriteLine("1 - BYTE");
                    Console.WriteLine("2 - SBYTE");
                    Console.WriteLine("3 - SHORT");
                    Console.WriteLine("4 - USHORT");
                    Console.WriteLine("5 - INT");
                    Console.WriteLine("6 - USHORT");
                    Console.WriteLine("7 - LONG");
                    Console.WriteLine("8 - ULONG");
                    Console.WriteLine("9 - Operaciones tipicas con numeros enteros");
                    Console.WriteLine("10 - SALIR");
                    Console.WriteLine("Eliga una opcion: ");
                    opcion = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("BYTE entero de 8 bits con signo -128 a 127");
                            LimpiarCampos();
                            break;
                        case 2:
                            Console.WriteLine("SBYTE entero de 8 bits sin signo de 0 a 255");
                            LimpiarCampos();
                            break;
                        case 3:
                            Console.WriteLine("SHORT entero 16 bits con signo de -32768 a 32767");
                            break;
                        case 4:
                            Console.WriteLine("USHORT entero de 16 sin signo de 0 a 65.535");
                            LimpiarCampos();
                            break;
                        case 5:
                            Console.WriteLine("INT entero de 32 bits con signo de -2.147.483.648 a 2.147.483.647");
                            LimpiarCampos();
                            break;
                        case 6:
                            Console.WriteLine("UINT entero de 32 bits sin signo de 0 a 4.294.967.295");
                            LimpiarCampos();
                            break;
                        case 7:
                            Console.WriteLine("LONG entero 64 bits con signo de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807");
                            LimpiarCampos();
                            break;
                        case 8:
                            Console.WriteLine("ULONG entero 64 bits sin signo de 0 a 18.446.744.073.709.551.615");
                            LimpiarCampos();
                            break;
                        case 9:
                            Console.WriteLine("Ingresa el primer numero:");
                            int numero1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa el segundo numero");
                            int numero2 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
                            Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
                            Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2}");
                            Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2} resto {numero1 % numero2}");
                            LimpiarCampos();
                            break;
                        case 10:
                            Console.WriteLine("Saliendo ...");
                            break;
                        default:
                            Console.WriteLine("Opcion ingresada es incorrecta. Ingrese nuevamente");
                            LimpiarCampos();
                            break;
                    }
                } while (opcion!=10);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void LimpiarCampos()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
