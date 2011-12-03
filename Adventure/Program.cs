using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentLine;
            List<ICommand> cmdList = new List<ICommand>();
            cmdList.Add(new LaughCommand());
            cmdList.Add(new DanceCommand());
            cmdList.Add(new PrayCommand());
            cmdList.Add(new StretchCommand());
            do
            {
                Console.Write(">");
                currentLine = Console.ReadLine();

                //ICommand cmd = cmdList.FirstOrDefault(m => m.IsValid(currentLine));
                ICommand cmd = null;
                foreach (ICommand command in cmdList)
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