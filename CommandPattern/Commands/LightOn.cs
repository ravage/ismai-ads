using CommandPattern.Contracts;
using CommandPattern.Receivers;

namespace CommandPattern.Commands
{
    public class LightOn : ICommand
    {
        private Light light;

        public LightOn(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.State = true;
        }
    }
}
