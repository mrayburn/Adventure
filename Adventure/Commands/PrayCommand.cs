using System;
using System.Collections.Generic;
using System.Linq;

namespace Adventure
{
    class PrayCommand : BaseSimpleCommand
    {
        public PrayCommand()
            : base("pray") { }

        public override void Execute(string cmd)
        {
            Console.WriteLine("You pray for God's guidance.");
        }
    }
}
