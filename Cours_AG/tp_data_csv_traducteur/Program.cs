using System.Transactions;

namespace tp_data_csv_traducteur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < 76; i++) 
            {
                string name = "Mat" + i.ToString();

                list.Add(name);
            }

            Random rand = new Random();
            int randomMaterial = rand.Next(0, 76);

            LanguageManager.CurrentLanguage = Language.French;

            Console.WriteLine($"Langue actuelle : {LanguageManager.CurrentLanguage}\nMatériel randomisé = {LanguageManager.GetString(list[randomMaterial])}");

            randomMaterial = rand.Next(0, 76);

            LanguageManager.CurrentLanguage = Language.English;

            Console.WriteLine($"Langue actuelle : {LanguageManager.CurrentLanguage}\nMatériel randomisé = {LanguageManager.GetString(list[randomMaterial])}");
        }
    }
}
