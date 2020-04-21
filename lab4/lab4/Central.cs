using System;
namespace lab4
{
    public class Central : IControl
    {
        private Maquina[] Maquinas;


        public Central()
        {
            Recepcion recepcion = new Recepcion();
            Almacenamiento almacenamiento = new Almacenamiento();
            Ensamblaje ensamblaje = new Ensamblaje();
            Verificacion verificacion = new Verificacion();
            Empaque empaque = new Empaque();
            Maquina[] listaMaq = new Maquina[5] { recepcion, almacenamiento, ensamblaje, verificacion, empaque };

            Maquinas = listaMaq;
        }

        public void Off()
        {
            foreach (Maquina item in Maquinas)
            {
                item.Off();
            }
        }

        public void On()
        {
            foreach (Maquina item in Maquinas)
            {
                item.On();
            }
        }

        public void Restart(Maquina maquina)
        {
            maquina.Restart(maquina);

        }

        public Maquina[] GetMaquinas()
        {
            return Maquinas;
        }

        public Maquina Restart_Manual()
        {
            Console.WriteLine("Ingrese que maquina desea reiniciar:\n");
            Console.WriteLine($"Para reiniciar {Maquinas[0].Nombre} ingrese 1");
            Console.WriteLine($"Para reiniciar {Maquinas[1].Nombre} ingrese 2");
            Console.WriteLine($"Para reiniciar {Maquinas[2].Nombre} ingrese 3");
            Console.WriteLine($"Para reiniciar {Maquinas[3].Nombre} ingrese 4");
            Console.WriteLine($"Para reiniciar {Maquinas[4].Nombre} ingrese 5");
            string input = Console.ReadLine();
            int inp = 0;
            int a = 0;

            while (a == 0)
            {
                try
                {
                    inp = Convert.ToInt32(input) - 1;  //Asumiendo que el usuario solo va a ingresar uno de esos numeros
                    a = 1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Numero invalido");
                    input = Console.ReadLine();
                }
            }

            


            return Maquinas[inp];

        }
    }
}
