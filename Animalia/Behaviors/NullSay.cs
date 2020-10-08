using Animalia.Contracts;

namespace Animalia.Behaviors
{
    public class NullSay : ISayBehavior
    {
        public string Say()
        {
            return null;
        }
    }
}