using System;
namespace lab4
{
    public class Central : IControl
    {
        public Central()
        {
        }

        public void Off(Maquina maquina)
        {
            maquina.Off(maquina);
        }

        public void On(Maquina maquina)
        {
            maquina.On(maquina);
        }

        public void Restart(Maquina maquina)
        {
            maquina.Restart(maquina);

        }

    }
}
