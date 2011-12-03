using System;
using System.Collections.Generic;
using System.Linq;

namespace Adventure
{
    class StretchCommand : ICommand
    {
        public bool IsValid(string cmd)
        {
            return cmd.ToLower() == "stretch".ToLower();
        }
        public void Execute(string cmd)
        {
            Console.WriteLine("You limber up and get ready for some killin'.");
        }
    }
}
