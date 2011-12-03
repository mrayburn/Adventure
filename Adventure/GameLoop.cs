using System;
using System.Collections.Generic;
using System.Linq;

namespace Adventure
{
    public interface IConsoleFacade
    {
        string ReadLine();
        void Write(string msg);
    }
    public class ConsoleFacade : IConsoleFacade
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
        public void Write(string msg)
        {
            Console.Write(msg);
        }
    }

    public class GameLoop
    {
        private IConsoleFacade _console;
        private IEnumerable<ICommand> _cmdList;
        public GameLoop(IConsoleFacade console, IEnumerable<ICommand> cmdList)
        {
            _cmdList = cmdList;
            _console = console;
        }
        public void RunLoop()
        {
            string currentLine;
            do
            {
                _console.Write(">");
                currentLine = _console.ReadLine();

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
