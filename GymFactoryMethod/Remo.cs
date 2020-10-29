using System;
using System.Collections.Generic;
using System.Text;

namespace GymFactoryMethod
{
    public class Remo : IMaquinas
    {
        public void utilizarMaquina(int repeticiones)
        {
            Console.WriteLine("Repeticiones en Remo:" + repeticiones.ToString());
        }
    }
}
