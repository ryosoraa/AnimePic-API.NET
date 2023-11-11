using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFWAnimePic_API.NET.src.API
{
    internal class RestAPI
    {
        public List<String> rest()
        {
            List<String> url = new List<string>();

            url.Add("https://api.waifu.pics/many/sfw/waifu");
            url.Add("https://api.waifu.pics/many/sfw/neko");
            url.Add("https://api.waifu.pics/many/sfw/shinobu");
            url.Add("https://api.waifu.pics/many/sfw/megumin");
            url.Add("https://api.waifu.pics/many/sfw/bully");
            url.Add("https://api.waifu.pics/many/sfw/cuddle");

            url.Add("https://api.waifu.pics/many/nsfw/waifu");
            url.Add("https://api.waifu.pics/many/nsfw/trap");
            url.Add("https://api.waifu.pics/many/nsfw/neko");
            url.Add("https://api.waifu.pics/many/nsfw/blowjob");

            return url;
        }
    }
}
