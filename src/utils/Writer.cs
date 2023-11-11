using Newtonsoft.Json;
using SFWAnimePic_API.NET.src.assets;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFWAnimePic_API.NET.src.utils
{
    internal class Writer
    {
        Paths paths = new Paths();
        
            public void write(String path,String json, int title)
            {

            File.WriteAllText($"{path}/{paths.path()[title]}", json);
            
            }

        public void handle(String path)
        {
            foreach (var one in paths.path())
            {
                try
                {
                    File.WriteAllText($"{path}/{one}", "[]");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

}

    }
}
