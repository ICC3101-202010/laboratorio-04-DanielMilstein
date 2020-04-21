using System;
using System.Collections.Generic;
using System.Linq;

namespace lab4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Central central = new Central();


            Maquina[] listaMaq = central.GetMaquinas();

            central.On();

            Console.WriteLine("Cuantos productos hoy?");

            // Input manual de cantidad de productos
            //            string sprod = Console.ReadLine();
            //            int prod = Int32.Parse(sprod); // Asumiendo que el input siempre es numero

            // Asumiendo una cantidad x de productos procesados al dia
            int x = 200;

            List<string> prods = new List<string>();

            for (int i = 0; i < x; i++)
            {
                prods.Add($"Producto { i +1}");
            }

            while (prods.Count() > 0)
            {

                foreach (Maquina item in listaMaq)
                {
                    bool conf = item.Work(prods[0]);

                    while (!conf)
                    {
                        central.Restart(central.Restart_Manual());
                        
                        conf = item.Work(prods[0]);

                    }

                    
                }
                prods.RemoveAt(0);
            }

            central.Off();
        }
    }
}
