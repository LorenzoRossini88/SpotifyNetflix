using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyNetflix
{
    internal class Lettore
    {
        //public bool status;
        public int currentIndex;
        

        public List<MediaPlay> playlist;
       


        public Lettore(List<MediaPlay> mediaList)
        {
            playlist = mediaList;
            currentIndex = 0;
            
            
        }

        public void Stop() 
        {
            if (currentIndex >= 0 && currentIndex < playlist.Count)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Stop di: {playlist[currentIndex].titolo}");
                Console.ResetColor();
            }



        }

        public void Play()
        {
            if (currentIndex >= 0 && currentIndex < playlist.Count)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Riproduzione di: {playlist[currentIndex].titolo}");
                Console.ResetColor();
            }
        }
        public void Next()
        {
            if (currentIndex < playlist.Count - 1)
            {
                currentIndex++;
                
            }

            else
            {
                currentIndex = 0; 
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Passato a: {playlist[currentIndex].titolo}");
            Console.ResetColor();



        }

        public void Previous()
        {
            if (currentIndex > 0)
            {
                currentIndex--;
            }
            else
            {
                currentIndex = playlist.Count - 1; 
            }
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Passato a: {playlist[currentIndex].titolo}");
            Console.ResetColor();
        }

        public bool Exit()
        {
            return currentIndex >= playlist.Count;
        }

        public string GetCurrentMediaTitle()
        {
            if (currentIndex >= 0 && currentIndex < playlist.Count)
            {
                return playlist[currentIndex].titolo;
            }
            return "Nessun media in riproduzione";
        }


        public void JumpToMedia(int index)
        {
            if (index >= 0 && index < playlist.Count)
            {
                currentIndex = index;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Riprduzione di: {playlist[currentIndex].titolo}");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Indice non valido.");
                Console.ResetColor();
            }
        }

            //public string GetCurrentMediaTitle()
            //{
            //    if (currentIndex >= 0 && currentIndex < playlist.Count)
            //    {
            //        return playlist[currentIndex].titolo;
            //    }
            //    return "Nessun media in riproduzione";
            //}
        }

}
