using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRUAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayInicio = new int[]{1,2,3,4,1,2,5,1,2,3,4,5};
            int[] ArrayFinal = new int[4];

            LRU(ArrayInicio, ArrayFinal);
        }
        static void LRU(int[] ArrayInicio, int[] ArrayFinal)
        {
            int contarEspacios = 0;
            int contador1 = 0, contador2 = 0, contador3 = 0, contador4 = 0;
            foreach (int numero in ArrayInicio)
            {
                int max = new int[] { contador1, contador2, contador3, contador4 }.Max();
                for (int i = 0; i <= ArrayFinal.Length; i++)
                {
                    if (i == 0 && max == contador1 || ArrayFinal[0] == numero)
                    {
                        contador1 = 0;
                        contador2++;
                        contador3++;
                        contador4++;
                        ArrayFinal[0] = numero;
                        break;
                    }
                    else if (i == 1 && max == contador2 || ArrayFinal[1] == numero)
                    {
                        contador2 = 0;
                        contador1++;
                        contador3++;
                        contador4++;
                        ArrayFinal[1] = numero;
                        break;
                    }
                    else if (i == 2 && max == contador3 || ArrayFinal[2] == numero)
                    {
                        contador3 = 0;
                        contador2++;
                        contador1++;
                        contador4++;
                        ArrayFinal[2] = numero;
                        break;
                    }
                    else if (i == 3 && max == contador4 || ArrayFinal[3] == numero)
                    {
                        contador4 = 0;
                        contador3++;
                        contador2++;
                        contador1++;
                        ArrayFinal[3] = numero;
                        break;
                    }
                }
                Console.Write(" ");
                foreach (var item in ArrayFinal)
                {
                    Console.Write(item);
                }
                if (contarEspacios == 1)
                {
                    Console.Write(" ");
                    contarEspacios = 0;
                }
                contarEspacios++;
            }

            Console.ReadLine();
        }
    }
}
