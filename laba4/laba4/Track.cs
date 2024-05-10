using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    public class Track //класс Трек
    {
        public string Title { get; set; }
        public string Album { get; set; }

        public Track(string title, string album) //Конструктор для трека
        {
            Title = title;
            Album = album;
        }
    }
}
