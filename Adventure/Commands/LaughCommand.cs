using System;
using System.Collections.Generic;
using System.Linq;

namespace Adventure
{
    class LaughCommand : ICommand
    {

        public bool IsValid(string cmd)
        {
            return cmd == "lol";
        }

        public void Execute(string cmd)
        {
            Console.WriteLine("You laugh out loud!");
        }
    }
}
