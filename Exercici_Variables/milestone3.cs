using System;
using System.Collections.Generic;
using System.Text;

namespace Exercici_Variables
{
    class milestone3
    {
        public void Principal()
        {
            int[] num_array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int aux_var = 0;
            int j = num_array.Length - 1;

            for (int i = 0; i < j; i++)
            {
                aux_var = num_array[i];
                num_array[i] = num_array[j];
                num_array[j] = aux_var;
                j--;
            }

            for (int i = 0; i < num_array.Length; i++)
            {
                if (i == num_array.Length - 1)
                {
                    Console.WriteLine(num_array[i]);
                }

                else
                {
                    Console.Write(num_array[i] + ", ");
                }
            }
    }
}
