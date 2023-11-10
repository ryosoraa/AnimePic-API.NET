using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SFWAnimePic_API.NET.src.model;
using SFWAnimePic_API.NET.src.utils;
using System.IO;
using SFWAnimePic_API.NET.src.engine;

internal class Program
{
    static async Task Main(string[] args)
    {

        String url = "https://api.waifu.pics/many/nsfw/waifu";
        String path = @"D:\playground\C#\SFWAnimePic-API.NET\src\Results\URL\SFW\Waifu.json";
        Engine engine = new Engine(path, url, 5);
        await engine.producer();

    }
}

