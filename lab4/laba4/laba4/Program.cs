using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Track> tracks = new List<Track>() 
            {
                new Track("Survival", "Scorpion"),
                new Track("Nonstop", "Scorpion"),
                new Track("Elevate", "Scorpion"),
                new Track("Talk Up", "Scorpion"),
                new Track("Mob Ties", "Scorpion")
            };

            var sortedTracks = SortTracksByAlbum(tracks,"Scorpion"); //Вызов метода для сортировки треков по альбому

            foreach (var track in sortedTracks) //Вывод отсортированных треков
            {
                Console.WriteLine("Title:" + track.Title + ", Album:" + track.Album );
            }
        }
        static IEnumerable<Track>SortTracksByAlbum(List<Track> tracks, string album) //Метод для сортировки треков по альбому
        {
            var tracksInAlbum = tracks.Where(t => t.Album == album).OrderBy(t => t.Title).ToList() //проверяем есть ли трек и альбом в коллекции
                ?? throw new InvalidOperationException("No tracks found for the specified album");
            return tracksInAlbum;

        }
    }
}
