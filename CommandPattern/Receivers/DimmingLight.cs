namespace CommandPattern.Receivers
{
    public class DimmingLight
    {
        private float power;
        private bool state;

        public float Power
        {
            get { return power; }
            set
            {
                if (value > 0)
                {
                    power = value;
                    state = true;
                }
                else
                {
                    power = 0;
                    state = false;
                }
            }
        }

        public override string ToString()
        {
            return $"Power: {power} | State: {state}";
        }
        
    }
}
