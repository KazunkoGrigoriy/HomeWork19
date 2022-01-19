using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HomeWork19
{
    class DataFile
    {
        string path = "DataFile.json";
        string json = ""; 

        public void WriteToFile(RepositoryAnimal repositoryAnimal)
        {
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            json = JsonConvert.SerializeObject(repositoryAnimal.bd, settings);
            File.WriteAllText(path, json);
        }
        public BindingList<IAnimal> ReadFromFile()
        {
            if (File.Exists(path))
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<BindingList<IAnimal>>(json, settings);
            }
            File.CreateText(path).Dispose();
            return new BindingList<IAnimal>();
        }
    }
}
