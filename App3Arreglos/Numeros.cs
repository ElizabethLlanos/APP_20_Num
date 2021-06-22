using System;
using System.Collections.Generic;
using System.Text;

namespace App3Arreglos
{
    class Numeros
    {
        //Método para ordenar números
        public int[] Orden_Menor_mayor(int[] num)
        {
            int[] numeros = new int[20];
            numeros = num;
            //Se ordenan los números de menor a mayor
            Array.Sort(numeros);
            return numeros;
        }
    }
}
