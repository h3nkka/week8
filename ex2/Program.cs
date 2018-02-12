using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Tornado of Souls", "Megadeth", new TimeSpan(0, 5, 22));
            Song song2 = new Song("Master of Puppets", "Metallica", new TimeSpan(0, 8, 35));
            Song song3 = new Song("Caught in a Mosh", "Anthrax", new TimeSpan(0,5,0));
            List<Song> songList1 = new List<Song>() { song1, song2, song3 };
            CD album1 = new CD("Thrash Metal Compilation Album", "Various Artists", songList1);

            Console.WriteLine("Song list of {0} - {1}:",album1.Artist,album1.Title);
            foreach (Song s in album1.SongList)
            {
                Console.WriteLine("{1} - {0} ({2}:{3})", s.Title, s.Artist, s.Length.Minutes, string.Format("{0:00}", s.Length.Seconds));
            }

            Console.ReadKey(true);
        }
    }
}
