using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFWAnimePic_API.NET.src.assets
{
    internal class Paths
    {
        List<String> paths = new List<String>();
        public List<String> path()
        {
            paths.Add("SFW_Waifu.json");
            paths.Add("SFW_Neko.json");
            paths.Add("SFW_Shinobu.json");
            paths.Add("SFW_Megumin.json");
            paths.Add("SFW_Bully.json");
            paths.Add("SFW_Cuddle.json");
            paths.Add("NSFW_Waifu.json");
            paths.Add("NSFW_Trap.json");
            paths.Add("NSFW_Neko.json");
            paths.Add("NSFW_Blowjob.json");
            return paths;
        }
    }
}
