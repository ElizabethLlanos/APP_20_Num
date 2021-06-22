using System;

namespace App3Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia
            Numeros objNumero = new Numeros();
            //Arreglo
            int[] numero = new int[20];
            Console.WriteLine("►►►►► NÚMEROS ENTEROS◄◄◄◄◄");
            Console.WriteLine("♦Introduce 20 numeros: ");
            //Se reciben los números y se guardan en el arreglo
            for(int i = 0; i < 20; i++)
            {
                Console.Write("►");
                numero[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Los números introducidos son:");
            //se recorre el array
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"► {numero[i]}");
               
            }
            Console.WriteLine("►►► Números ordenados de menor a mayor ◄◄◄");
            //Llamada al método para ordenar los numeros
            numero = objNumero.Orden_Menor_mayor(numero);
            //Recorrer el array ya modificado
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"► {numero[i]}");

            }
        }
    }
}
