using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyNetflix
{
    internal class Music : MediaPlay
    {
        public string artist;
        
        public Music(string Titolo, string Artist) : base(Titolo)
        {
            artist = Artist;

        }
    }
}
