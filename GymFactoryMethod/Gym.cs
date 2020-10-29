using System;
using System.Collections.Generic;
using System.Text;

namespace GymFactoryMethod
{
    public abstract class Gym
    {
        public abstract IMaquinas GetMaquinas(string maquina);
    }
}
