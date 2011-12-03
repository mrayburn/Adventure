using System;
using System.Collections.Generic;
using System.Linq;

namespace Adventure
{
    class DanceCommand : BaseSimpleCommand
    {
        public DanceCommand()
            : base("dance") { }

        public override void Execute(string cmd)
        {
            Console.WriteLine("You get jiggy with it!");
        }

    }
}
