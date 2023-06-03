using MusicAlbumDI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAlbum.Bll
{
    abstract public class Catalog : ISearch<Album>
    {
        public abstract Album Find(Func<Album, bool> predicate);
        public abstract Album[] SearchAll();
    }
}
