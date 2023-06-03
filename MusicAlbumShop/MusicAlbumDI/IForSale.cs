using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAlbumDI
{
    public interface IForSale
    {
        int Price { get; set; }
        int Discount { get; set; }
        int getPrice()
        {
            return Math.Max(Price - Discount, 0);
        }
    }
}
