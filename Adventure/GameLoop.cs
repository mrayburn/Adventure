using System;
using System.Collections.Generic;
using System.Linq;

namespace Adventure
{
    public class GameLoop
    {
        private IEnumerable<ICommand> _cmdList;
        public GameLoop(IEnumerable<ICommand> cmdList)
        {
            _cmdList = cmdList;
        }
        public void RunLoop()
        {
            string currentLine;
            do
            {
                Console.Write(">");
                currentLine = Console.ReadLine();

                //ICommand cmd = cmdList.FirstOrDefault(m => m.IsValid(currentLine));
                ICommand cmd = null;
                foreach (ICommand command in _cmdList)
                {
                    bool isValid = command.IsValid(currentLine);
                    if (isValid)
                    {
                        cmd = command;
                        break;
                    }
                }


                if (cmd != null) cmd.Execute(currentLine);
            } while (currentLine.ToLower() != "exit".ToLower());
        }
    }
}
