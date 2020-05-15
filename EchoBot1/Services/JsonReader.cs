using System;
using System.Collections.Generic;
using System.Linq;
using EchoBot1.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Data;

namespace EchoBot1.Services
{
    public class JsonReader
    {
        public List<JObject> GetFeedback()
        {
            //Start by getting the Json filepath
            var path = AppContext.BaseDirectory + $"/Data/Questions.json";
            var content = new List<JObject>();

            if (File.Exists(path))
            {
                content = JsonConvert.DeserializeObject<List<JObject>>(File.ReadAllText(path));
            }
            //Console.WriteLine( content);

            int index = 0;
            while (index < content.Count)
            {
                content.ElementAt(index);
                //Console.WriteLine(index);
                index += 1;
            }
            return content;
        }
    }
}

