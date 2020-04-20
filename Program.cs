using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise22
    {
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 0;

            Console.WriteLine(" Write the number of element to the arragement:");
            cant = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[cant];

            for (int i = 0; i < cant; i++)
            {
                Console.Write(" Write the number:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(" ARRAY");
            for (int i = 0; i < cant; i++)
            {
                Console.Write(" {0}", array[i]);
            }

            Console.Write(" \n");

            int index = 1;
            int cont = 0;
            int[] sequency = new int[cant];
            int[] sequencyNext = new int[cant];

            for (int i = 0; i < cant - 1; i++)
            {
                sequencyNext[i] = array[i];
                for (int j = i + 1; j < cant; j++)
                {
                    if (array[j - 1] < array[j])
                    {
                        sequencyNext[index] = array[j];
                        index++;
                    }

                }
                if (cont < index)
                {
                    cont = index;
                    index = 1;
                    for (int j = 0; j < cont; j++)
                    {
                        sequency[j] = sequencyNext[j];
                    }
                }
                else
                {
                    index = 1;
                }
            }

            if (cont != 0 && cont >= index)
            {
                Console.WriteLine(" Maximal sequence of consecutive increasing elements:");
                for (int i = 0; i < cont; i++)
                {
                    Console.Write(" {0}", sequency[i]);

                }
            }
            else
            {
                Console.WriteLine(" Does not exist sequence of elements:");

            }

            Console.ReadKey();


        }
    }
}
