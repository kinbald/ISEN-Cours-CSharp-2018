using System;

namespace Isen.Cs.Library.Lessons
{
    public class B_Enumerations
    {
        public void RunEnumerations()
        {
            // Afficheg du lzbrl 
            Console.WriteLine($"JoursSemaine.Lundi = {JoursSemaine.Lundi}");
            // Afficher l'entier spis-jacent
            Console.WriteLine($"JoursSemaine.Lundi = {(int) JoursSemaine.Lundi}");
            // int > vers valeur d'enum
            int day4 = 4;
            JoursSemaine whoIsday4 = (JoursSemaine) day4;
            Console.WriteLine($"day = {whoIsday4}");
            // String > valeur d'enum
            string mardi = "Mardi";
            JoursSemaine parsed = (JoursSemaine) Enum.Parse(
                typeof(JoursSemaine),
                mardi);
            Console.WriteLine($"parsed = {parsed}");
            // .Net Core / .Net > 4
            // JoursSemaine parsed2;
            // bool didItWork = Enum.TryParse("Mercredi", out parsed2);
            // C # 7
            bool didItWork = Enum.TryParse(mardi, out JoursSemaine parsed2);
            Console.WriteLine($"parsed2 = {parsed2} / worked ? {didItWork}");
            // Enumérer les labels
            var enumNames = Enum.GetNames((typeof(JoursSemaine))); // string []
            var enumValues = Enum.GetValues(typeof(JoursSemaine)); // JoursSemaine[] sous-typé
            foreach (var enumName in enumNames) Console.WriteLine(enumName);
            foreach (JoursSemaine enumValue in enumValues) Console.WriteLine((int) enumValue);
            
            var jour = (JoursSemaine) (new Random().Next(0, 7));
            DayOfWeek foundDayOfWeek;
            switch (jour)
            {
                case JoursSemaine.Lundi:
                    foundDayOfWeek = DayOfWeek.Monday;
                    break;
                case JoursSemaine.Mardi:
                    foundDayOfWeek = DayOfWeek.Tuesday;
                    break;
                case JoursSemaine.Mercredi:
                    foundDayOfWeek = DayOfWeek.Wednesday;
                    break;
                case JoursSemaine.Jeudi:
                    foundDayOfWeek = DayOfWeek.Thursday;
                    break;
                case JoursSemaine.Vendredi:
                    foundDayOfWeek = DayOfWeek.Friday;
                    break;
                case JoursSemaine.Samedi:
                    foundDayOfWeek = DayOfWeek.Saturday;
                    break;
                case JoursSemaine.Dimanche:
                    foundDayOfWeek = DayOfWeek.Sunday;
                    break;
                default:
                    foundDayOfWeek = DayOfWeek.Sunday;
                    break;
            }
            // Console.WriteLine($"Random day was {foundDayOfWeek}");
            // C#7 : nameof() => nom de la variable, en string
            Console.WriteLine($"{nameof(foundDayOfWeek)} = {foundDayOfWeek}");
        }
    }

    public enum JoursSemaine
    {
        Lundi = 1,
        Mardi = 2,
        Mercredi = 3,
        Jeudi = 4,
        Vendredi = 5,
        Samedi = 6,
        Dimanche = 7
    }

    public enum Result
    {
        Success,
        Fail
    }
}