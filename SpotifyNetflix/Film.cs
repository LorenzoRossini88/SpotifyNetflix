using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyNetflix
{
    internal class Film : MediaPlay
    {
        public string author;
        
        public Film(string Titolo, string Author) : base(Titolo)
        {
            author = Author;
        }


    }
}
