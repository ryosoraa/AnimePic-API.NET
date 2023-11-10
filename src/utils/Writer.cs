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
            public void write(String path,String json)
            {
                File.WriteAllText(path, json);
/*                writer.WriteLine(json);
                writer.Close();*/
            }

        public void handle(String path)
        {
            try
            {
                File.WriteAllText(path, "[]");
            } catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
