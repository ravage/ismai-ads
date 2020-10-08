using Animalia.Contracts;

namespace Animalia.Behaviors
{
    public class NullFly : IFlyBehavior
    {
        public string Fly()
        {
            return null;
        }
    }
}