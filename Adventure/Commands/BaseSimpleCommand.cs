using System;
using System.Collections.Generic;
using System.Linq;

namespace Adventure
{
    public abstract class BaseSimpleCommand : ICommand
    {
        private readonly string _cmdName;
        public BaseSimpleCommand(string cmdName)
        {
            _cmdName = cmdName.ToLower();
        }
        public bool IsValid(string cmd)
        {
            return cmd.ToLower() == _cmdName;
        }

        public abstract void Execute(string cmd);

    }
}
