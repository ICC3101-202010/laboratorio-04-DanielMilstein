using System;
namespace lab4
{
    public interface IControl
    {
        void On();
        void Off();
        void Restart(Maquina maquina);
    }
}
