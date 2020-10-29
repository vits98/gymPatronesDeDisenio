using System;
using System.Collections.Generic;
using System.Text;

namespace GymFactoryMethod
{
    public class Dorsalera : IMaquinas
    {
        public void utilizarMaquina(int repeticiones)
        {
            Console.WriteLine("Repeticiones en dorsalera:" + repeticiones.ToString());
        }
    }
}
