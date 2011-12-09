using System;
using System.Collections.Generic;
using System.Linq;

namespace Adventure
{
    class FenceCommand : ICommand
    {

        //public FenceCommand(string fence, string partner)
        //{
        //    _fence = fence.Substring(0, 4);
        //    _partner = fence.Substring(5);
        //}
        public bool IsValid(string cmd)
        {
            return cmd.ToLower().StartsWith("fence");
        }

        public void Execute(string cmd)
        {
            string partner = cmd.Split(' ')[1];
            Console.WriteLine("You fence with {0}!", partner);
        }
    }
}
