using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlefLauncher.Classes
{
    internal class Profile
    {
        public string Name { get; set; } 
        public string Version { get; private set; }
        public string Description { get; set; }
        public string Server { get; private set; }
        public string DB { get; private set; }
        public string PathToStandard { get; private set; }
        public Profile()
        {
            Name = "Тест 7";
            Version = "7.0";
            Description = "ИССО";
            Server = "report-test\\sql2008";
            DB = "ReportProcessingTest";
            PathToStandard = "D:\\My_progr\\_Consyst\\Alef\\AlefStandard";
        } 

        public Profile(string name, string version, string description, string server, string db, string path)
        {
            Name = name;
            Version = version;
            Description = description;  
            Server = server;    
            DB = db;
            PathToStandard = path;
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void EditSettings()
        {
            throw new NotImplementedException(); 
        }
    }
}
