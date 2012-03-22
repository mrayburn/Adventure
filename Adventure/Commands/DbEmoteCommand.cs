using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Extensions;

namespace Adventure
{
    //select Message from Emotes where Command = 'fence'
    public class DbEmoteCommand : ICommand
    {
        private Dictionary<string, List<string>> _Dictionary;
        public Dictionary<string, List<string>> Dictionary
        {
            get
            {
                if (_Dictionary.Count == 0)
                {
                    LoadEmotesFromDatabase();
                }
                return _Dictionary;
            }

        }
        public DbEmoteCommand()
        {
            _Dictionary = new Dictionary<string, List<string>>();
        }
        public bool IsValid(string cmd)
        {
            string firstWord = cmd.Split(' ')[0];
            return Dictionary.ContainsKey(firstWord.ToLower());
        }

        public void Execute(string cmd)
        {
            string[] words = cmd.Split(' ');
            Console.WriteLine(Dictionary[words[0].ToLower()].Random(), words);
        }
        private void LoadEmotesFromDatabase()
        {
            using (SqlConnection conn = new SqlConnection("Server=localhost;Database=Adventure;Integrated Security = true"))
            {
                conn.Open();
                var cmd = new SqlCommand("select e.Command, m.message from Emotes e join Msgs m on e.EmoteId = m.Emoteid", conn);
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string cmdName = rdr["Command"] as string;
                    if (!_Dictionary.Keys.Contains(cmdName))
                    {
                        _Dictionary.Add(cmdName, new List<string>());
                    }

                    _Dictionary[cmdName].Add(rdr["Message"] as string);
                }
            }
        }

    }
}
