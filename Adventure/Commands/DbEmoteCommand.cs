using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace Adventure
{
    //select Message from Emotes where Command = 'fence'
    public class DbEmoteCommand : ICommand
    {
        private Dictionary<string, string> _Dictionary;
        public Dictionary<string, string> Dictionary
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
            _Dictionary = new Dictionary<string, string>();
        }
        public bool IsValid(string cmd)
        {
            string firstWord = cmd.Split(' ')[0];
            return Dictionary.ContainsKey(firstWord.ToLower());
        }

        public void Execute(string cmd)
        {
            string[] words = cmd.Split(' ');
            Console.WriteLine(Dictionary[words[0].ToLower()], words);
        }
        private void LoadEmotesFromDatabase()
        {
            using (SqlConnection conn = new SqlConnection("Server=localhost;Database=Adventure;Integrated Security = true"))
            {
                conn.Open();
                var cmd = new SqlCommand("select * from Emotes", conn);
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    _Dictionary.Add(rdr["Command"] as string, rdr["Message"] as string);
                }
            }
        }

    }
}
