using CommandPattern.Contracts;
using CommandPattern.Receivers;

namespace CommandPattern.Commands
{
    public class LightOff : ICommand
    {
        private Light light;

        public LightOff(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.State = false;
        }
    }
}
