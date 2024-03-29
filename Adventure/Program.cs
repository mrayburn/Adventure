﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICommand> cmdList = new List<ICommand>();
            cmdList.Add(new DbEmoteCommand());

            //cmdList.Add(new LaughCommand());
            //cmdList.Add(new DanceCommand());
            //cmdList.Add(new PrayCommand());
            //cmdList.Add(new StretchCommand());
            //cmdList.Add(new FenceCommand());
            GameLoop game = new GameLoop(new ConsoleFacade(), cmdList);
            game.RunLoop();
        }
    }
}