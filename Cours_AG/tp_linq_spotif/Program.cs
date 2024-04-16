namespace tp_linq_spotif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database.MusicList.Add(new Music("give that wolf a banana", "subwoolfer", Genre.electro, 3));
            Database.MusicList.Add(new Music("melodies of hope", "patty gurdy", Genre.pop, 4));
            Database.MusicList.Add(new Music("cobra king", "powerwolf", Genre.metal, 4));
            Database.MusicList.Add(new Music("auslander", "rammstein", Genre.metal, 5, 100));
            Database.MusicList.Add(new Music("shum", "go_a", Genre.electro, 3));
            Database.MusicList.Add(new Music("zitti e buoni", "maneskin", Genre.rock, 3, 200));


            List<Music> searchMetalMusic = Database.Search(Genre.metal);

            Console.WriteLine($"Voici les résultats de votre recherche pour le genre {Genre.metal} : ");

            foreach (Music music in searchMetalMusic)
            {
                Console.WriteLine(music);
            }

            Console.WriteLine("-----------------------------------------------------------------------------");

            List<Music> searchStringMusic = Database.Search("n");

            Console.WriteLine($"Voici les résultats de votre recherche de \"n\" : ");

            foreach (Music music in searchStringMusic)
            {
                Console.WriteLine(music);
            }
        }
    }
}
