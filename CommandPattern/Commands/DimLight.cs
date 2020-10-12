using CommandPattern.Contracts;
using CommandPattern.Receivers;

namespace CommandPattern.Commands
{
    public class DimLight : IFloatParamCommand, ICommand
    {
        public DimmingLight light;
        private float power;

        public DimLight(DimmingLight light)
        {
            this.light = light;
        }

        public DimLight(DimmingLight light, float power) : this(light)
        {
            this.power = power;
            
        }

        public void Execute(float dim)
        {
            light.Power = dim;
        }

        public void Execute()
        {
            light.Power = power;
        }
    }
}
