using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class CD
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public List <Song> SongList { get; set; }

        public CD (string t, string a, List<Song> sl)
        {
            Title = t;
            Artist = a;
            SongList = sl;
        }

    }
}
