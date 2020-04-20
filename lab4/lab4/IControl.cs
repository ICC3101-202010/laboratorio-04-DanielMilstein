using System;
namespace lab4
{
    public interface IControl
    {
        void On(Maquina maquina);
        void Off(Maquina maquina);
        void Restart(Maquina maquina);
    }
}
