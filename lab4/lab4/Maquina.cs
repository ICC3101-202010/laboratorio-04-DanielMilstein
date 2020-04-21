using System;
using System.Collections.Generic;
using System.Linq;

namespace lab4
{
    public abstract class Maquina : IControl
    {
        protected List<String> Memoria;
        protected bool Encendida;
        protected int Memoria_Max;
        public string Nombre;

        public Maquina()
        {
            List<string> memoria = new List<string>();
            Memoria = memoria;

            Random random = new Random();
            int mem_max = random.Next(10, 50);
            Memoria_Max = mem_max;


        }

        public void Off()
        {
            Console.WriteLine($"Maquina {Nombre} apagada.");
            Encendida = false;
        }

        public void On()
        {
            Console.WriteLine($"Maquina {Nombre} encendida con memoria {Memoria_Max} .");
            Encendida = true;
        }

        public void Restart(Maquina maquina)
        {
            Memoria.Clear();
            Console.WriteLine($"Maquina {Nombre} reiniciada.\n");
        }

        public bool Work(string producto)
        {
            int mem = Memoria.Count();
            int mem_max = Memoria_Max;


            if (mem < mem_max)
            {
                Memoria.Add(producto);
                Console.WriteLine($"{producto} esta siendo procesado por {Nombre}.");
                return true;
            }

            else
            {
                Console.WriteLine($"Memoria de maquina {Nombre} llena.");
                return false;
            }
        }
    }
}
