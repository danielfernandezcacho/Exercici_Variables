using System;
using System.Collections.Generic;
using System.Text;

namespace Exercici_Variables
{
    class milestone1
    {
        public static void nombre()
        {
            string nom = "daniel ";
            string cognom1 = "fernandez ";
            string cognom2 = "Cacho ";

            int dia = 20;
            int mes = 11;
            int any = 2001;

            int bis = 0;

            bool anyobis = true;

            string string_bis = "bisiesto";
            string string_nobis = "no bisiesto";

            const int año_bisiesto = 1948;

            string nombre_junto = nom + cognom1 + cognom2;
            string año_nacimiento = dia + "/" + mes + "/" + any;

            Console.WriteLine("1--------------");
            Console.WriteLine(cognom1 + cognom2 + nom);
            Console.WriteLine(dia + "/" + mes + "/" + any);

            Console.WriteLine("2--------------");
            bis = (any - año_bisiesto) / 4;
            Console.WriteLine("Hay {0} años bisiestos entre el año {1} y el año {2}", bis, año_bisiesto, any);

            Console.WriteLine("FASE 3--------------");
            for (int i = año_bisiesto; i <= any; i++)
            {
                if (i % 4 != 0)
                {
                    anyobis = false;
                }
                else
                {
                    anyobis = true;
                }

                Console.Write(i + " ");
                if (anyobis)
                {
                    Console.WriteLine(string_bis);
                }
                else
                {
                    Console.WriteLine(string_nobis);
                }
            }
            Console.WriteLine("FASE 4--------------");
            Console.WriteLine("El meu nom és " + nombre_junto);
            Console.WriteLine("Vaig néixer el " + año_nacimiento);
            if (any % 4 == 0) Console.WriteLine("El meu any de naixement és de traspàs");
            else Console.WriteLine("El meu any de naixement no és de traspàs");
        }
    }
}
