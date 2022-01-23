using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Module_4HW3.ServerSettings
{
    public class Path
    {
        public string ServerPath { get; set; }
        public void SerializePath(Path objects)
        {
            using (FileStream fs = new FileStream("Config.json", FileMode.OpenOrCreate))
            {

                System.Text.Json.JsonSerializer.SerializeAsync<Path>(fs, objects);
            }
        }
        public string GetPath(string path)
        {
            Path restoredPerson = new Path();

            restoredPerson = JsonConvert.DeserializeObject<Path>(File.ReadAllText(path));

            Console.WriteLine(restoredPerson.ServerPath);

            return restoredPerson.ServerPath.ToString();
            
        } 
        
    }
}
