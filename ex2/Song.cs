using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public TimeSpan Length { get; set; }

        public Song(string t, string a, TimeSpan l)
        {
            Title = t;
            Artist = a;
            Length = l;
        }
    }
}
