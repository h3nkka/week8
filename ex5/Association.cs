using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex5
{
    class Association
    {
        public string Name { get; set; }
        public string City { get; set; }
        public List<Player> Roster { get; set; }

        public Association(string n, string c)
        {
            Name = n;
            City = c;
            Roster = new List<Player>();
        }

        public void GetRoster()
        {
            Console.WriteLine("Roster:");
            foreach (Player p in Roster)
            {
                Console.WriteLine("{0} {1}",p.FirstName,p.LastName);
                Console.WriteLine("Number: {0}",p.Number);
                Console.WriteLine("Handedness: {0}\n", p.Handedness);
            }
        }

        public void SavePlayerInfo()
        {
            try
            {
                StreamWriter sw = new StreamWriter("players.txt");
                foreach (Player p in Roster)
                {
                    sw.WriteLine(p.FirstName);
                    sw.WriteLine(p.LastName);
                    sw.WriteLine(p.Number);
                    sw.WriteLine(p.Handedness);
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void LoadPlayerInfo()
        {
            try
            {
                List<string> parsedFile = new List<string>();
                StreamReader sr = new StreamReader("players.txt");
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    parsedFile.Add(line);
                }
                sr.Close();

                for (int i = 0; i < parsedFile.Count/4; i++)
                {
                    Roster.Add(new Player(parsedFile[0 + (i * 4)], parsedFile[1 + (i * 4)], Int32.Parse(parsedFile[2 + (i * 4)]), Char.Parse(parsedFile[3 + (i * 4)])));
                }
                Console.WriteLine("Loaded player info from file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
