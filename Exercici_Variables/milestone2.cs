using System;
using System.Collections.Generic;
using System.Text;

namespace Exercici_Variables
{
    class milestone2
    {
        public class Milestone2
        {
            public static void numeros()
            {
                double double_var = 88.88;
                int int_var = (int)double_var;
                float float_var = (float)double_var;
                string string_var = double_var.ToString();

                Console.WriteLine("La variable double es " + double_var);
                Console.WriteLine("La variable int es " + int_var);
                Console.WriteLine("La variable float es " + float_var);
                Console.WriteLine("La variable string es " + string_var);


            }
        }
    }
}
