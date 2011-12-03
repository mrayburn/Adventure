using System;
using System.Collections.Generic;
using System.Linq;

namespace Adventure
{
    public interface ICommand
    {

        bool IsValid(string cmd);
        void Execute(string cmd);
    }
}
