using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Association association = new Association("KEK", "Jyväskylä");
            if (File.Exists("players.txt"))
                association.LoadPlayerInfo();
            else
            {
                List<Player> playerlist = new List<Player>();
                playerlist.Add(new Player("Henri", "Mäkelä", 69, 'R'));
                playerlist.Add(new Player("Juuso", "Mäkelä", 55, 'R'));
                playerlist.Add(new Player("Nikita", "Mämmelä", 4, 'L'));
                association.Roster = playerlist;
            }
            association.GetRoster();

            association.SavePlayerInfo();
            Console.ReadKey(true);
        }
    }
}
