﻿namespace P03.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();
            for (int i = 0; i < numberOfSongs; i++)
            {
                List<string> input = Console.ReadLine()
                    .Split("_")
                    .ToList();

                string typeList = input[0];
                string name = input[1];
                string time = input[2];
                Song song = new Song(typeList, name, time);
                
                songs.Add(song);
            }

            string command = Console.ReadLine();
            if (command == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == command)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }

    public class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }


    }

}