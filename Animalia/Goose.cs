using System;
using Animalia.Behaviors;

namespace Animalia
{
    public class Goose : IBird
    {
        // comportamento para voar
        // private IFlyBehavior flyBehavior;
        // comportamento para falar
        // private ISayBehavior sayBehavior;
        // comportamento para andar
        //private IWalkBehavior walkBehavior;

        // public Goose(IFlyBehavior flyBehavior, IWalkBehavior walkBehavior, ISayBehavior sayBehavior)
        // {
        //     FlyBehavior = flyBehavior;
        //     WalkBehavior = walkBehavior;
        //     SayBehavior = sayBehavior;
        // }

        public Goose() 
        {
            FlyBehavior = new NullFly();
            SayBehavior = new NullSay();
            WalkBehavior = new NullWalk();
        }
        
        public IFlyBehavior FlyBehavior { get; set; }
        public ISayBehavior SayBehavior { get; set; }
        public IWalkBehavior WalkBehavior { get; set; }

        public string Fly()
        {
            return FlyBehavior.Fly();
        }

        public string Say()
        {
            return SayBehavior.Say();
        }

        public string Walk()
        {
            return WalkBehavior.Walk();
        }
    }
}