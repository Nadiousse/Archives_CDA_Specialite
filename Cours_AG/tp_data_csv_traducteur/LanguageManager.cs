using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_data_csv_traducteur
{
    internal static class LanguageManager
    {
        public static Language CurrentLanguage { get; set; }

        public static string GetString(string objectName)
        {
            string fileName = "LanguageMats.csv";
            string filePath = AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\" + fileName;

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,

                Delimiter = ";"
            };

            var reader = new StreamReader(filePath);
            var csv = new CsvHelper.CsvReader(reader, config);

            while (csv.Read())
            {
                // Conversion de la ligne en objet Person
                var record = csv.GetRecord<dynamic>();

                // Vérification des critères de recherche
                if (record.Language == objectName)
                {
                    switch (CurrentLanguage)
                    {
                        case Language.French:
                            return record.French;
                        case Language.English:
                            return record.English;
                    }
                }
            }

            return "Emplty entry";

        }
    }
}
