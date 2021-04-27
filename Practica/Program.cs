using System;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            int op,edad;
            string rpta,nombre;
            Console.WriteLine("Ingrese sus datos ");
            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            do
            {
                Console.WriteLine("Ingrese su edad: ");
                edad = int.Parse(Console.ReadLine());
            } while (edad<18 || edad > 100);
            Console.WriteLine();
            menu();
            do
            {
                Console.WriteLine("Elija una opción: ");
                op = int.Parse(Console.ReadLine());
            } while (op <= 0 || op >= 4 );

            opciones(op, nombre, edad);
          

        }

        private static void menu()
        {
            Console.WriteLine("1. Ver su nombre");
            Console.WriteLine("2. Ver su edad");
            Console.WriteLine("3. Ver su direccion");

        }
        private static void opciones(int op, string nombre, int edad)
        {
            switch (op)
            {
                case 1: Console.WriteLine("Su nombre es: " + nombre); break;
                case 2: Console.WriteLine("Su edad es: " + edad); break;
                case 3: Console.WriteLine("Su dirrecion es: Huayna Capac"); break;
            }
        }
    }
}
