using System;
using System.Collections.Generic;
using System.Linq;

namespace Adventure
{
    class PrayCommand : ICommand
    {
        public bool IsValid(string cmd)
        {
            return cmd == "pray";
        }
        public void Execute(string cmd)
        {
            Console.WriteLine("You pray for God's guidance.");
        }
    }
}
