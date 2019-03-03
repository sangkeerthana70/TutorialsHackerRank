using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongPlaylist
{
    // class Playlist that is similar to a Linked list
    public class PlayList
    {
        public Song firstSong;

        public void AddSong(Song song)
        {
            if(this.firstSong == null)
            {
                firstSong = song;
            }
            else
            {
               var currentSong = firstSong; 
               
                while (currentSong.next != null)
                {
                    currentSong = currentSong.next;

                }
                currentSong.next = song;
               
 
            }
        }
       
    }
}
