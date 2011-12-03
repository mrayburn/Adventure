using System;
using System.Collections.Generic;
using System.Linq;

namespace Adventure
{
    class DanceCommand : ICommand
    {
        public bool IsValid(string cmd)
        {
            return cmd.ToLower() == "dance".ToLower();
        }
        public void Execute(string cmd)
        {
            Console.WriteLine("You get jiggy with it!");
        }

    }
}
