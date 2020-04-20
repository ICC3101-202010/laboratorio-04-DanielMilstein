using System;
namespace lab4
{
    public class Empaque : Maquina, IControl
    {
        public Empaque()
        {
            string name = "Empaque";
            Nombre = name;
        }
    }
}
