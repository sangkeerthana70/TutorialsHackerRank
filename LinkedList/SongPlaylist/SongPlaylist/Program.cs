using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongPlaylist
{
    class Program
    {
        static void Main(string[] args)
        {
            var playList = CreatePlayList();
            var currentSong = playList.firstSong;

            var action = string.Empty;
            
            Console.WriteLine("Enter action (Play/Pause/Next/Previous/Stop) : ");

            while (action != "Stop")
            {
                action = Console.ReadLine();
                if (action == "Play")
                {
                    currentSong.Play();
                }
                else if (action == "Pause")
                {
                    Console.WriteLine("Music paused");
                }

                else if (action == "Next")
                {
                    
                    currentSong = currentSong.next;
                    if (currentSong == null)
                    {
                        Console.WriteLine("End of Playlist");
                        break;
                    }
                    else
                    {
                        currentSong.Play();
                    }

                }
                else if (action == "Previous")
                {
                    Console.WriteLine("Playing previous song");
                }
                else
                {
                    Console.WriteLine("Music stopped");
                }

               
            }

            

        }
        // instantiate a new instance of PlayList to add songs
        public static PlayList CreatePlayList()
        {
            // creates an empty playlist
            PlayList playList = new PlayList();
            Song song = new Song("Roja ondru mutham ketkum neram", "Illayaraja", 1981);
            playList.AddSong(song);
            song = new Song("Rasathi en usuru", "Ar.Rehman", 1998);
            playList.AddSong(song);
            song = new Song("Rathiriyil poothirukkum thamarai than penno", "Illayaraja", 1984);
            playList.AddSong(song);
            song = new Song("Etho mogam etho thagam", "Illayaraja", 1985);
            playList.AddSong(song);
            song = new Song("Raja rajathi rajan entha raja", "Illayaraja", 1990);
            playList.AddSong(song);
            return playList;

        }
    }
}
