using System;
using System.Collections.Generic;
using System.Linq;

namespace Adventure
{
    class StretchCommand : BaseSimpleCommand
    {
        public StretchCommand()
            : base("stretch") { }
            
        public override void Execute(string cmd)
        {
            Console.WriteLine("You limber up and get ready for some killin'.");
        }
    }
}
