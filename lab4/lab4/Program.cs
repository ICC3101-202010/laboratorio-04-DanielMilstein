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
            Recepcion recepcion = new Recepcion();
            Almacenamiento almacenamiento = new Almacenamiento();
            Ensamblaje ensamblaje = new Ensamblaje();
            Verificacion verificacion = new Verificacion();
            Empaque empaque = new Empaque();

            Maquina[] listaMaq = new Maquina[5] { recepcion, almacenamiento, ensamblaje, verificacion, empaque };

            foreach (Maquina item in listaMaq)
            {
                central.On(item);
            }

            Console.WriteLine("Cuantos productos hoy?");

            // Input manual de cantidad de productos
            //            string sprod = Console.ReadLine();
            //            int prod = Int32.Parse(sprod); // Asumiendo que el input siempre es numero

            // Asumiendo una cantidad x de productos procesados al dia
            int x = 200;

            List<string> prods = new List<string>();

            for (int i = 0; i < x; i++)
            {
                prods.Add($"Producto x{ i }");
            }

            while (prods.Count() > 0)
            {

                foreach (Maquina item in listaMaq)
                {
                    bool conf = item.Work(prods[0]);

                    if (!conf)
                    {
                        central.Restart(item);
                        _ = item.Work(prods[0]);
                    }

                    
                }
                prods.RemoveAt(0);
            }









            foreach (Maquina item in listaMaq)
            {
                central.Off(item);

            }


        }
    }
}
