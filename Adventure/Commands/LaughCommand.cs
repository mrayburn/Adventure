using System;
using System.Collections.Generic;
using System.Linq;

namespace Adventure
{
    class LaughCommand : BaseSimpleCommand
    {
        public LaughCommand()
            : base("lol") { }

        public override void Execute(string cmd)
        {
            Console.WriteLine("You laugh out loud!");
        }
    }
}
