using MusicAlbumDI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAlbum.Bll
{
    public abstract class Shop : IAuthor, IName, IRating, IGenre
    {
        protected Shop(string author, string typeOfAuthor, string name, int rating, string genre)
        {
            Author = author;
            TypeOfAuthor = typeOfAuthor;
            Name = name;
            Rating = rating;
            Genre = genre;
        }

        public string Author { get; set; }
        public string TypeOfAuthor { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Genre { get; set; }

        public abstract bool IsValidName(string name);
    }
}
