using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SpotifyNetflix
{
    public abstract class MediaPlay
    {
        public string titolo;

        //public string Titolo { get => _titolo; set => _titolo = value; }



        public MediaPlay(string Titolo)
        {

            titolo = Titolo;
            
        }

        public void Print() 
        {

        }
    }
}
