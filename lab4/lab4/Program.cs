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
                        Console.WriteLine("Ingrese que maquina desea reiniciar:\n");
                        Console.WriteLine($"Para reiniciar {listaMaq[0].Nombre} ingrese 1");
                        Console.WriteLine($"Para reiniciar {listaMaq[1].Nombre} ingrese 2");
                        Console.WriteLine($"Para reiniciar {listaMaq[2].Nombre} ingrese 3");
                        Console.WriteLine($"Para reiniciar {listaMaq[3].Nombre} ingrese 4");
                        Console.WriteLine($"Para reiniciar {listaMaq[4].Nombre} ingrese 5");
                        string input = Console.ReadLine();

                        int inp = Convert.ToInt32(input) - 1;  //Asumiendo que el usuario solo va a ingresar uno de esos numeros

                        string maq_sel = listaMaq[inp].Nombre;

                        central.Restart(listaMaq[inp]);

                        conf = item.Work(prods[0]);

                        //if (maq_sel == item.Nombre)
                        //{
                        //   
                        //}




                        
                        
                    }

                    
                }
                prods.RemoveAt(0);
            }

            central.Off();
        }
    }
}
