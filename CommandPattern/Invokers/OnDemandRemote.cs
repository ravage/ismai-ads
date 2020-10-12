using System;
using System.Collections.Generic;
using CommandPattern.Contracts;

namespace CommandPattern.Invokers
{
    public class OnDemandRemote
    {
        private Dictionary<Char, ICommand> buttons;

        public OnDemandRemote()
        {
            buttons = new Dictionary<char, ICommand>();
        }

        public void Press(char key, ICommand command)
        {
            command.Execute();
            buttons[key] = command;
        }
    }
}
