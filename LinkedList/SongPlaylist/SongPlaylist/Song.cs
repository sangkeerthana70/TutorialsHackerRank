using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongPlaylist
{
    public class Song
    {
        public string title;
        public string author;
        public int year;
        public Song next;
        

        public Song(string t, string a, int y)
        {
            this.title = t;
            this.author = a;
            this.year = y;
        }

        public void Play()
        {
            Console.WriteLine("Playing song " + title + " by " + author + " from the year " + year);
        }
    }
}
