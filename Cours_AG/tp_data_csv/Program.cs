using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace tp_data_csv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> SuccessRates = new List<int>();
            List<int> Scores = new List<int>();


            //-------------

            string fileName = "ScoresGOT.csv";
            string filePath = AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\" + fileName;

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,

                Delimiter = ";"
            };

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, config))
            {
                // Lecture des enregistrements CSV en tant qu'objets dynamiques
                var records = csv.GetRecords<dynamic>();

                // Parcourir chaque enregistrement et accéder à ses valeurs
                foreach (var record in records)
                {
                    int successRate = int.Parse(record.successRate);
                    int score = int.Parse(record.score);

                    if (successRate <= 0) 
                    {
                        continue;
                    }

                    Console.Write($"SucessRate = {successRate} - ");
                    SuccessRates.Add(successRate);
                    Console.WriteLine($"Score = {score} ");
                    Scores.Add(score);
                }
            }

            Console.WriteLine("\n--------------------------------------------\n\n");

            double averageSuccessRate = SuccessRates.Average();
            double averageScore = SuccessRates.Average();

            Console.WriteLine($"La moyenne du pourcentage de succès : {averageSuccessRate}");
            Console.WriteLine($"La moyenne des score : {averageScore}");
        }
    }
}
