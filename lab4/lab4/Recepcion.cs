using System;
namespace lab4
{
    public class Recepcion : Maquina, IControl
    {
        public Recepcion()
        {
            String name = "Recepcion";
            Nombre = name;
        }
    }
}
