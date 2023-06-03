using MusicAlbumDI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAlbum.Bll
{
    public abstract class Song : IDuration, IAuthor, IName
    {
        protected Song(int duration, string name, string author, string typeOfAuthor)
        {
            this.Duration = duration;
            this.Name = name;
            this.Author = author;
            this.TypeOfAuthor = typeOfAuthor;
        }

        public int Duration { get ; set; }
        public string Author { get; set; }
        public string TypeOfAuthor { get; set; }
        public string Name { get; set; }

        abstract public bool IsValidName(string name);   
    }
}
