using System;
using System.Collections.Generic;
using System.Text;

namespace GymFactoryMethod
{
    public class ConcreteGym : Gym
    {
        public override IMaquinas GetMaquinas(string maquina)
        {
            switch (maquina)
            {
                case "dorsalera":
                    return new Dorsalera();
                case "remo":
                    return new Remo();
                default:
                    throw new Exception(string.Format("maquina '{0}' no puede ser utilizada", maquina));
            }
        }
    }
}
