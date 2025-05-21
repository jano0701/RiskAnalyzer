using System;
using System.Collections.Generic;
using System.Linq;

namespace RiskAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🔍 Willkommen beim RiskAnalyzer");
            Console.WriteLine("Analysiere kritische Risiken nach Kategorie, Level und Status\n");

            // Beispielhafte Risikodatenliste
            List<Risk> risiken = new List<Risk>
            {
                new Risk("Datenleck", 9, "IT", "Offen"),
                new Risk("Zahlungsverzug", 6, "Finanzen", "In Bearbeitung"),
                new Risk("Reputationsschaden", 8, "Kommunikation", "Offen"),
                new Risk("Systemausfall", 4, "IT", "Geschlossen"),
                new Risk("Lieferkettenproblem", 7, "Einkauf", "Offen")
            };

            // Risiken mit Level >= 8 filtern
            var kritischeRisiken = risiken.Where(r => r.IstKritisch()).ToList();

            if (kritischeRisiken.Count > 0)
            {
                Console.WriteLine("⚠️  Kritische Risiken (Level ≥ 8):\n");

                foreach (var r in kritischeRisiken)
                {
                    Console.WriteLine($"- {r.Name} ({r.Kategorie}) → Level: {r.Level}, Status: {r.Status}");
                }
            }
            else
            {
                Console.WriteLine("✅ Keine kritischen Risiken gefunden.");
            }

            Console.WriteLine("\nAnalyse abgeschlossen. Drücke eine Taste zum Beenden.");
            Console.ReadKey();
        }
    }
}
