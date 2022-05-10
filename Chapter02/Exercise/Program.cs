using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            //List<Song> songs = new List<Song>();

            //var song1 = new Song("Let it be","The Beatles",243);
            //songs.Add(song1);

            //var song2 = new Song("Let it be", "The Beatles", 243);
            //songs.Add(song2);

            //var song3 = new Song("Let it be", "The Beatles", 243);
            //songs.Add(song3);

            var songs = new Song[]
            {
                new Song("Let it be","The Beatles",256),
                new Song("マカロニえんぴつ","生きるをする",243),
                new Song("マカロニえんぴつ","なんでもないよ",258),
                new Song("マカロニえんぴつ","恋人ごっこ",354),
                new Song("マカロニえんぴつ","遠心",654),

            };

            PrintSongs(songs);
        }

        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs)
            {
                Console.WriteLine("{0},{1},{2:mm\\:ss}",
                    song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));
            }

           
        }
    }
}