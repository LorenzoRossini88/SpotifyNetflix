using System;
using System.Collections.Generic;

namespace SpotifyNetflix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MediaPlay> musicList = new List<MediaPlay>
            {
                new Music("1- Hollywood", "Irama & Rkomi"),
                new Music("2- Lario","Lazza"),
                new Music("3- Tre parole","Fabri Fibra"),
                new Music("4- Stop trying to be god ","Travis Scott")
            };

            List<MediaPlay> filmList = new List<MediaPlay>
            {
                new Film("1- Film 1","author1"),
                new Film("2- Film 2","author2"),
                new Film("3- Film 3","author3"),
                new Film("4- Film 4","author4")
            };

            

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Inserire s per entrare in spotify");
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Inserire n per entrare in Netflix");
            Console.WriteLine("--------------------------------------------------");
            Console.ResetColor();

            string choice;
            

            do
            {
                choice = Console.ReadLine();

                if (choice == "s")
                {
                    Lettore musicPlayer = new Lettore(musicList);
                    foreach(var item in musicList)
                    {
                        var i = (Music)item;
                        Console.WriteLine("--------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($" - canzone: {i.titolo} || artista: {i.artist}");
                        Console.ResetColor();
                        Console.WriteLine("--------------------------------------------------");

                    }

                    while (!musicPlayer.Exit())
                    {
                        //Console.WriteLine($"Titolo corrente: {musicPlayer.GetCurrentMediaTitle()}");
                        Console.WriteLine("--------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Opzioni:");
                        Console.WriteLine("- 1 Play");
                        Console.WriteLine("- 2 Stop");
                        Console.WriteLine("- 3 Next");
                        Console.WriteLine("- 4 Previous");
                        Console.WriteLine("- 5 Exit");
                        Console.WriteLine("- 6 Scegli musica");
                        Console.ResetColor();
                        Console.WriteLine("--------------------------------------------------");

                        string option = Console.ReadLine();

                        switch (option)
                        {
                            case "1":
                                musicPlayer.Play();
                                break;
                            case "2":
                                musicPlayer.Stop();
                                break;
                            case "3":
                                musicPlayer.Next();
                                break;
                            case "4":
                                musicPlayer.Previous();
                                break;
                            case "5":
                                musicPlayer.Exit();
                                break;
                            case "6":
                                Console.WriteLine("--------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Scegli una canzone :");
                                Console.ResetColor();
                                Console.WriteLine("--------------------------------------------------");
                                string songChoice = Console.ReadLine();
                                if (int.TryParse(songChoice, out int songIndex) && songIndex >= 1 && songIndex <= 4)
                                {
                                    musicPlayer.JumpToMedia(songIndex - 1);
                                }
                                else
                                {
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Scelta non valida. Riprova.");
                                    Console.ResetColor();
                                    Console.WriteLine("--------------------------------------------------");
                                }
                                break;


                            default:
                                Console.WriteLine("--------------------------------------------------");
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("Opzione non valida. Riprova.");
                                Console.ResetColor();
                                Console.WriteLine("--------------------------------------------------");
                                break;
                        }
                    }
                }
                else if (choice == "n")
                {
                    Lettore filmPlayer = new Lettore(filmList);
                    foreach (var item in filmList)
                    {
                        var i = (Film)item;
                        Console.WriteLine("--------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($" - titolo: {i.titolo} || autore: {i.author}");
                        Console.ResetColor();
                        Console.WriteLine("--------------------------------------------------");
                    }

                    while (!filmPlayer.Exit())
                    {
                        //Console.WriteLine($"Titolo corrente: {filmPlayer.GetCurrentMediaTitle()}");
                        Console.WriteLine("--------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opzioni:");
                        Console.WriteLine("- 1 Play");
                        Console.WriteLine("- 2 Stop");
                        Console.WriteLine("- 3 Next");
                        Console.WriteLine("- 4 Previous");
                        Console.WriteLine("- 5 Exit");
                        Console.WriteLine("- 6 Scegli film");
                        Console.ResetColor();
                        Console.WriteLine("--------------------------------------------------");

                        string option = Console.ReadLine();

                        switch (option)
                        {
                            case "1":
                                filmPlayer.Play();
                                break;
                            case "2":
                                filmPlayer.Stop();
                                break;
                            case "3":
                                filmPlayer.Next();
                                break;
                            case "4":
                                filmPlayer.Previous();
                                break;
                            case "5":
                                filmPlayer.Exit();
                                break;
                            case "6":
                                Console.WriteLine("--------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Scegli un film:");
                                Console.ResetColor();
                                Console.WriteLine("--------------------------------------------------");
                                string filmChoice = Console.ReadLine();
                                if (int.TryParse(filmChoice, out int filmIndex) && filmIndex >= 1 && filmIndex <= 4)
                                {
                                    filmPlayer.JumpToMedia(filmIndex - 1);
                                }
                                else
                                {
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Scelta non valida. Riprova.");
                                    Console.ResetColor();
                                    Console.WriteLine("--------------------------------------------------");
                                }
                                break;
                            default:
                                Console.WriteLine("--------------------------------------------------");
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("Opzione non valida. Riprova.");
                                Console.ResetColor();
                                Console.WriteLine("--------------------------------------------------");
                                break;
                        }
                    }
                }
                else if (choice != "exit")
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Scelta non valida. Riprova.");
                    Console.ResetColor();
                    Console.WriteLine("--------------------------------------------------");
                }

            } while (choice != "exit");

            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Uscita in corso");
            Console.ResetColor();
            Console.WriteLine("--------------------------------------------------");
        }


    }
    
}
