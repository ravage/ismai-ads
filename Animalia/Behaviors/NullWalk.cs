using Animalia.Contracts;

namespace Animalia.Behaviors
{
    public class NullWalk : IWalkBehavior
    {
        public string Walk()
        {
            return null;
        }
    }
}