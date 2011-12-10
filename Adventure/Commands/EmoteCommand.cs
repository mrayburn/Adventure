using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace Adventure
{
    public class EmoteCommand : ICommand
    {
        private Dictionary<string, string> dict;
        public EmoteCommand()
        {
            dict = new Dictionary<string, string>();
            AddCommand("lol", "You laugh out loud!");
            AddCommand("fence", "You fence with {1}!");
            AddCommand("dance", "You get jiggy with it!");
            AddCommand("pray", "You pray for God's guidance");
            AddCommand("stretch", "You stretch and get ready for some killin'");
        }
        private void AddCommand(string cmd, string msg)
        {
            dict.Add(cmd.ToLower(), msg);
        }
        public bool IsValid(string cmd)
        {
            string firstWord = cmd.Split(' ')[0];
            return dict.ContainsKey(firstWord.ToLower());
        }

        public void Execute(string cmd)
        {
            string[] words = cmd.Split(' ');
            Console.WriteLine(dict[words[0].ToLower()], words);
        }
    }
}
