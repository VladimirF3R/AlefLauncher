using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AlefLauncher.Classes
{
    internal class App
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<Profile> ProfileList { get; private set; }
        public App() {
            Name = "ИССО";
            Description = "Старое название. Новое - ИСПО";
            ProfileList = new List<Profile>();
            ProfileList.Add(new Profile("Прод", "7", "Продакшен", "report\\sql2008", "ReportProcessing", "\\\\fserv\\Shared\\БН_КИС\\Сбор_Отчетности\\Release\\"));
            ProfileList.Add(new Profile("Тест7", "7", "Тест", "report-test\\sql2008", "ReportProcessingTest", "\\\\fserv\\Shared\\БН_КИС\\Сбор_Отчетности\\Release_Test7\\"));
            ProfileList.Add(new Profile("Тест8", "8", "Тест", "report-test\\sql2008", "ReportProcessingTest8", "\\\\fserv\\Shared\\БН_КИС\\Сбор_Отчетности\\Release_Test8\\"));
            ProfileList.Add(new Profile("Тест9", "9", "Тест", "report-test\\sql2008", "ReportProcessingTest9", "\\\\fserv\\Shared\\БН_КИС\\Сбор_Отчетности\\Release_Test9\\"));
        }
        public App(string name, string description, List<Profile> profileList)
        {
            Name = name;
            Description = description;
            ProfileList = profileList ?? new List<Profile>();
        }
        public static List<App> LoadFromFile(string fileName)
        {
            List<App>? appList = null;
            try
            {
                var jsonString = File.ReadAllText("applist.json");
                appList = JsonSerializer.Deserialize<List<App>>(jsonString);
            }
            catch
            {
                // Error during loading/deserialization
            }
            return appList ?? new List<App>();
        }
        public static void SaveToFile(string fileName, List<App> appList)
        {
            var jsonString = JsonSerializer.Serialize(appList);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
