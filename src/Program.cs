using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SFWAnimePic_API.NET.src.model;
using SFWAnimePic_API.NET.src.utils;
using System.IO;
using SFWAnimePic_API.NET.src.engine;
using SFWAnimePic_API.NET.src.assets;

internal class Program
{
    static async Task Main(string[] args)
    {

        bool visualStudio = false;

        String path = @"D:\playground\C#\SFWAnimePic-API.NET\src\Results\URL\SFW";
        Intermediary intermediary;

        if (visualStudio)
        {
            //path.Add(@"D:\playground\C#\SFWAnimePic-API.NET\src\Results\URL\SFW\SFW_Waifu.json");      // SFW_Waifu
            //path.Add(@"D:\playground\C#\SFWAnimePic-API.NET\src\Results\URL\SFW\SFW_Neko.json");       // SFW_Neko
            //path.Add(@"D:\playground\C#\SFWAnimePic-API.NET\src\Results\URL\SFW\SFW_Shinobu.json");    // SFW_Shinobu
            //path.Add(@"D:\playground\C#\SFWAnimePic-API.NET\src\Results\URL\SFW\SFW_Megumin.json");    // SFW_Megumin
            //path.Add(@"D:\playground\C#\SFWAnimePic-API.NET\src\Results\URL\SFW\SFW_Bully.json");      // SFW_Bully
            //path.Add(@"D:\playground\C#\SFWAnimePic-API.NET\src\Results\URL\SFW\SFW_Cuddle.json");     // SFW_Cuddle

            //path.Add(@"D:\playground\C#\SFWAnimePic-API.NET\src\Results\URL\NSFW\NSFW_Waifu.json");    // NSFW_Waifu
            //path.Add(@"D:\playground\C#\SFWAnimePic-API.NET\src\Results\URL\NSFW\NSFW_Trap.json");     // NSFW_Trap
            //path.Add(@"D:\playground\C#\SFWAnimePic-API.NET\src\Results\URL\NSFW\NSFW_Neko.json");     // NSFW_Neko
            //path.Add(@"D:\playground\C#\SFWAnimePic-API.NET\src\Results\URL\NSFW\NSFW_Blowjob.json");  // NSFW_Blowjob
        }
        else
        {
            Menu.interfaces();
            intermediary = new Intermediary(Console.ReadLine());
            Console.WriteLine();
            intermediary.mediator();

        }

        intermediary = new Intermediary(path);
        intermediary.middleman();

    }
}

