using System;
using System.Collections.Generic;
using CommandPattern.Contracts;

namespace CommandPattern.Invokers
{
    public class RemoteWithSlider
    {
        // A, L, O, X
        private Dictionary<Char, IFloatParamCommand> buttons;

        public RemoteWithSlider()
        {
            buttons = new Dictionary<char, IFloatParamCommand>();
        }

        public void SetCommand(char key, IFloatParamCommand cmd)
        {
            buttons.Add(key, cmd);
        }

        public void Press(char key, float sliderValue)
        {
            buttons[key].Execute(sliderValue);
        }
    }
}
