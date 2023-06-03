using MusicAlbumDI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAlbum.Bll
{
    public abstract class Album : IYear, IName, IAuthor, IGenre, IRating, IForSale
    {
        public Album(int year, string name, string author, string typeOfAuthor, string genre, int price, int discount, int rating)
        {
            this.Year = year;
            this.Name = name;
            this.Author = author;
            this.TypeOfAuthor = typeOfAuthor;
            this.Genre = genre;
            this.Price = price;
            this.Discount = discount;
            this.Rating = rating;
        }

        public string Name { get ; set; }
        public string Author { get; set; }
        public string TypeOfAuthor { get; set; }
        public string Genre { get; set; }
     
        public int Price { get; set; }
        public int Discount { get; set; }
        public int Year { get ; set; }
        public int Rating { get; set; }

        abstract public bool IsValidName(string name);        
    }
}
