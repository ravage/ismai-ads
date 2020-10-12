using System;
using System.Collections.Generic;
using CommandPattern.Contracts;

namespace CommandPattern.Invokers
{
    public class Remote
    {
        // A, L, O, X
        private Dictionary<Char, ICommand> buttons;

        public Remote()
        {
            buttons = new Dictionary<char, ICommand>();
        }

        public void SetCommand(char key, ICommand cmd)
        {
            buttons.Add(key, cmd);
        }

        public void Press(char key)
        {
            buttons[key].Execute();
        }
    }
}
