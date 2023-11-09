using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFWAnimePic_API.NET.src.utils
{
    internal class Writer
    {
            private String path = @"D:/playground/C#/SFWAnimePic-API.NET/src/Results/json/Results.json";
            public void write(String json)
            {
                File.WriteAllText(path, json);
/*                writer.WriteLine(json);
                writer.Close();*/
            }

        public void handle()
        {
            File.WriteAllText(path, "[]");
        }

    }
}
