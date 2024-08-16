using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AlefLauncher.Classes.Helpers;

namespace AlefLauncher.Classes
{
    internal class Services
    {
        public const string APP_NAME = "Alefmain.exe";
        public const string APP_FILENAME = "applist.json";
        public const string LOG_FILENAME = "alefLauncher.log";
        public static Boolean RunApp(Profile profile)
        {
            /// TODO add async
            var srcFolder = profile.PathToStandard;

            var destFolder = FSHelper.CreateDirectoryInUserFolder(profile.Name);
            var exeFile =  Path.Combine(destFolder, APP_NAME);

            var files = FSHelper.CopyNewOrUpdatedFiles(destFolder, srcFolder);
            /// TODO return file list to UI

            var result = FSHelper.RunExternalProcess(exeFile);
            /// TODO add command-line params 
            
            return result == exeFile;

        }

        public static void SaveLog(string text)
        {
            using (StreamWriter writer = new StreamWriter(LOG_FILENAME, true))
            {
                writer.WriteLineAsync(text);
            }
        }
    }
}
