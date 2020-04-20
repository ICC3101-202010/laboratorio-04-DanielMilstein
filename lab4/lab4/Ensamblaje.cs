using System;
namespace lab4
{
    public class Ensamblaje : Maquina, IControl
    {
        public Ensamblaje()
        {
            string name = "Ensamblaje";
            Nombre = name;
        }
    }
}
