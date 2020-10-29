using System;

namespace GymFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Gym recinto = new ConcreteGym();
            IMaquinas dorsalera = recinto.GetMaquinas("dorsalera");
            dorsalera.utilizarMaquina(40);
            IMaquinas remo = recinto.GetMaquinas("remo");
            remo.utilizarMaquina(50);
            Console.ReadKey();
        }
    }
}
