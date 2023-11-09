using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFWAnimePic_API.NET.src.utils
{
    internal class Check
    {
        public bool IsValidJson(string json)
        {
            try
            {
                var obj = JsonConvert.DeserializeObject(json);
                return true;
            }
            catch (JsonReaderException)
            {
                return false;
            }

        }

        private String path = @"D:/playground/C#/SFWAnimePic-API.NET/src/Results/json/Results.json";
        public List<String> filter (List<String> req)
        {

            string jsonText = System.IO.File.ReadAllText(path);
            List<string> myData = JsonConvert.DeserializeObject<List<string>>(jsonText);
            List<String> results = new List<string>();

            foreach (String one in req)
            {
                if(myData.Contains(one) == false)
                {
                    results.Add(one);
                }
            }

            return results;
        }
    }
}
