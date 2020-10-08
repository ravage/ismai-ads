using System;
using Animalia;
using Animalia.Behaviors;

namespace AnimaliaRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Goose g1 = new Goose();
            Console.WriteLine(g1.Fly());
            g1.FlyBehavior = new NoFly();
            Console.WriteLine(g1.Fly());
        }
    }
}