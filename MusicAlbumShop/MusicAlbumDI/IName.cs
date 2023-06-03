using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAlbumDI
{
    public interface IName
    {
        string Name { get; set; }
        bool IsValidName(string name);
    }
}
