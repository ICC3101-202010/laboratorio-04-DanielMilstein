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
    }
}
